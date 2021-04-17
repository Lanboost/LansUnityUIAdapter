using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Example_MonoGame.MonoGameAdapter
{
	class MonoGameRenderer
	{
		
		DepthStencilState stencilMask;
		DepthStencilState stencilMaskCheck;

		SpriteFont font;
		Microsoft.Xna.Framework.Graphics.Texture2D panelMask;
		Microsoft.Xna.Framework.Graphics.Texture2D panel;

		int CORNER_SIZE = 12;
		int BAR_SIZE = 4;
		Game1 game;

		public MonoGameRenderer(Game1 game, GraphicsDeviceManager graphicsDeviceManager, ContentManager content)
		{
			this.game = game;

			font = content.Load<SpriteFont>("DefaultFont");
			panelMask = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("panelMask");
			panel = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("panel");

			
			stencilMask = new DepthStencilState
			{
				StencilEnable = true,
				StencilFunction = CompareFunction.Always,
				StencilPass = StencilOperation.Replace,
				ReferenceStencil = 1,
				DepthBufferEnable = false,
			};
			stencilMaskCheck = new DepthStencilState
			{
				StencilEnable = true,
				StencilFunction = CompareFunction.LessEqual,
				StencilPass = StencilOperation.Keep,
				ReferenceStencil = 1,
				DepthBufferEnable = false,
			};
		}

		public void Draw(SpriteBatch spriteBatch, GameObject o)
		{
			//Ref.Logger.Warn("GameObject: "+ o.name);

			foreach (var c in o.GetComponents<Component>())
			{
				//Ref.Logger.Warn("Component: " + c.name);
			}

			//var color = BorderColor;
			bool closeMask = false;

			var canvasRenderer = o.GetComponent<CanvasRenderer>();
			if (canvasRenderer != null)
			{
				var rectTransform = o.GetComponent<RectTransform>();
				if (rectTransform != null)
				{
					var mask = o.GetComponent<UnityEngine.UI.Mask>();
					if (mask != null)
					{

						var m = Matrix.CreateOrthographicOffCenter(0,
							game.GraphicsDevice.PresentationParameters.BackBufferWidth,
							game.GraphicsDevice.PresentationParameters.BackBufferHeight,
							0, 0, 1
						);

						var alphaEffect = new AlphaTestEffect(game.GraphicsDevice)
						{
							Projection = m
						};

						spriteBatch.End();
						spriteBatch.Begin(SpriteSortMode.Immediate, null, null, stencilMask, null, alphaEffect);

						UnityEngine.Vector3[] corners = new UnityEngine.Vector3[4];
						rectTransform.GetWorldCorners(corners);
						var oMin = rectTransform.offsetMin;
						var oMax = rectTransform.offsetMax;
						Point point1 = new Point((int)corners[0].x, (int)corners[0].y);
						Point point22 = new Point((int)corners[2].x, (int)corners[2].y);
						Color32 color = canvasRenderer._mesh._color * canvasRenderer.GetColor();

						drawSliced(spriteBatch, point1, point22, panelMask, Microsoft.Xna.Framework.Color.Blue);

						spriteBatch.End();
						closeMask = true;

						spriteBatch.Begin(SpriteSortMode.Immediate, null, null, stencilMaskCheck, null, null);



					}
					else
					{
						var text = o.GetComponent<UnityEngine.UI.Text>();
						if (text == null)
						{
							UnityEngine.Vector3[] corners = new UnityEngine.Vector3[4];
							rectTransform.GetWorldCorners(corners);
							var oMin = rectTransform.offsetMin;
							var oMax = rectTransform.offsetMax;
							Point point = new Point((int)corners[0].x, (int)corners[0].y);
							Point point2 = new Point((int)corners[2].x, (int)corners[2].y);
							Color32 color = canvasRenderer._mesh._color * canvasRenderer.GetColor();


							drawPanel(spriteBatch, point, point2, new Microsoft.Xna.Framework.Color(
								color.r,
								color.g,
								color.b,
								color.a
								)
							);
						}
						else
						{
							UnityEngine.Vector3[] corners = new UnityEngine.Vector3[4];
							rectTransform.GetWorldCorners(corners);

							var bounds = font.MeasureString(text.text);


							Point point1 = new Point((int)(corners[0].x + (corners[2].x - corners[0].x) / 2 - bounds.X / 2), (int)(corners[0].y + (corners[2].y - corners[0].y) / 2 + bounds.Y / 2));

							Point point = new Point(point1.X, game.Window.ClientBounds.Height - point1.Y);

							spriteBatch.DrawString(font, text.text,
								new Microsoft.Xna.Framework.Vector2(point.X, point.Y),
								 Microsoft.Xna.Framework.Color.Yellow);
						}
					}
				}
			}

			foreach (var g in o.GetActiveChildren())
			{
				Draw(spriteBatch, g);
			}

			if (closeMask)
			{
				spriteBatch.End();
				spriteBatch.Begin();
			}
		}

		public void drawPanel(SpriteBatch spriteBatch, Point point1, Point point22, Microsoft.Xna.Framework.Color color)
		{
			if (color.A != 0)
			{
				drawSliced(spriteBatch, point1, point22, panel, color);
			}
		}

		public void drawSliced(SpriteBatch spriteBatch, Point point1, Point point22, Microsoft.Xna.Framework.Graphics.Texture2D texture, Microsoft.Xna.Framework.Color color)
		{

			Point point = new Point(point1.X, game.Window.ClientBounds.Height - point22.Y);
			Point point2 = new Point(point22.X, game.Window.ClientBounds.Height - point1.Y);

			int width = point2.X - point.X;
			int height = point2.Y - point.Y;

			int[] sizeX = new int[3];
			int[] sizeY = new int[3];
			sizeX[0] = CORNER_SIZE;
			sizeX[1] = width - CORNER_SIZE * 2;
			sizeX[2] = CORNER_SIZE;

			sizeY[0] = CORNER_SIZE;
			sizeY[1] = height - CORNER_SIZE * 2;
			sizeY[2] = CORNER_SIZE;

			if (width < 2 * CORNER_SIZE)
			{
				sizeX[0] = width / 2;
				sizeX[1] = 0;
				sizeX[2] = width - sizeX[0];
			}
			if (height < 2 * CORNER_SIZE)
			{
				sizeY[0] = height / 2;
				sizeY[1] = 0;
				sizeY[2] = height - sizeY[0];
			}

			int[] sizeOffsetX = new int[] {
				point.X,
				point.X+sizeX[0],
				point.X+sizeX[0]+sizeX[1],
			};

			int[] sizeOffsetY = new int[] {
				point.Y,
				point.Y+sizeY[0],
				point.Y+sizeY[0]+sizeY[1],
			};

			int[] offsets = new int[] { 0, CORNER_SIZE, CORNER_SIZE + BAR_SIZE };
			int[] size = new int[] { CORNER_SIZE, BAR_SIZE, CORNER_SIZE };

			for (int i = 0; i < 9; i++)
			{
				int x = i % 3;
				int y = i / 3;

				if (sizeX[x] > 0 && sizeY[y] > 0)
				{
					spriteBatch.Draw(texture,
						new Rectangle(sizeOffsetX[x], sizeOffsetY[y], sizeX[x], sizeY[y]),
						new Rectangle?(new Rectangle(offsets[x], offsets[y], size[x], size[y])),
						color);
				}

			}
		}
	}
}
