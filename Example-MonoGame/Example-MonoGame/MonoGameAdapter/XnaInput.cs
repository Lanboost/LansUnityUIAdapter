using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Example_MonoGame.MonoGameAdapter
{

	public class XnaInput : BaseInput
	{
		Game1 game;

		public void Init(Game1 game)
		{
			this.game = game;
		}

		MouseState last;
		MouseState now;
		public void Tick()
		{
			last = now;
			if (last == null)
			{
				last = Mouse.GetState();
			}
			now = Mouse.GetState();
		}
		/// <summary>
		/// Interface to Input.compositionString. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override string compositionString
		{
			get { return Input.compositionString; }
		}

		/// <summary>
		/// Interface to Input.imeCompositionMode. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override IMECompositionMode imeCompositionMode
		{
			get { return Input.imeCompositionMode; }
			set { Input.imeCompositionMode = value; }
		}

		/// <summary>
		/// Interface to Input.compositionCursorPos. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override UnityEngine.Vector2 compositionCursorPos
		{
			get { return Input.compositionCursorPos; }
			set { Input.compositionCursorPos = value; }
		}

		/// <summary>
		/// Interface to Input.mousePresent. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override bool mousePresent
		{
			get { return true; }
		}

		/// <summary>
		/// Interface to Input.GetMouseButtonDown. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		/// <param name="button"></param>
		/// <returns></returns>
		public override bool GetMouseButtonDown(int button)
		{
			ButtonState laststate = ButtonState.Released;
			ButtonState state = ButtonState.Released;
			if (button == 0)
			{
				laststate = last.LeftButton;
				state = now.LeftButton;
			}
			else if (button == 1)
			{
				laststate = last.RightButton;
				state = now.RightButton;
			}
			else if (button == 2)
			{
				laststate = last.MiddleButton;
				state = now.MiddleButton;
			}
			return laststate == ButtonState.Released && state == ButtonState.Pressed;
		}

		/// <summary>
		/// Interface to Input.GetMouseButtonUp. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override bool GetMouseButtonUp(int button)
		{
			ButtonState laststate = ButtonState.Released;
			ButtonState state = ButtonState.Released;
			if (button == 0)
			{
				laststate = last.LeftButton;
				state = now.LeftButton;
			}
			else if (button == 1)
			{
				laststate = last.RightButton;
				state = now.RightButton;
			}
			else if (button == 2)
			{
				laststate = last.MiddleButton;
				state = now.MiddleButton;
			}
			return laststate == ButtonState.Pressed && state == ButtonState.Released;
		}

		/// <summary>
		/// Interface to Input.GetMouseButton. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override bool GetMouseButton(int button)
		{
			ButtonState state = ButtonState.Released;
			if (button == 0)
			{
				state = now.LeftButton;
			}
			else if (button == 1)
			{
				state = now.RightButton;
			}
			else if (button == 2)
			{
				state = now.MiddleButton;
			}
			return state == ButtonState.Pressed;
		}

		/// <summary>
		/// Interface to Input.mousePosition. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override UnityEngine.Vector2 mousePosition
		{
			get
			{
				var v = new UnityEngine.Vector2(now.X, game.Window.ClientBounds.Height - now.Y);
				return v;

			}
		}

		/// <summary>
		/// Interface to Input.mouseScrollDelta. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override UnityEngine.Vector2 mouseScrollDelta
		{
			get { return Input.mouseScrollDelta; }
		}

		/// <summary>
		/// Interface to Input.touchSupported. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override bool touchSupported
		{
			get { return false; }
		}

		/// <summary>
		/// Interface to Input.touchCount. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		public override int touchCount
		{
			get { return 0; }
		}

		/// <summary>
		/// Interface to Input.GetTouch. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		/// <param name="index">Touch index to get</param>
		public override Touch GetTouch(int index)
		{
			return Input.GetTouch(index);
		}

		/// <summary>
		/// Interface to Input.GetAxisRaw. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		/// <param name="axisName">Axis name to check</param>
		public override float GetAxisRaw(string axisName)
		{
			/*if(axisName == "Horizontal")
			{
				return now.X - last.X;
			}
			else if(axisName == "Vertical")
			{
				return now.Y - last.Y;
			}*/
			return 0;
		}

		/// <summary>
		/// Interface to Input.GetButtonDown. Can be overridden to provide custom input instead of using the Input class.
		/// </summary>
		/// <param name="buttonName">Button name to get</param>
		public override bool GetButtonDown(string buttonName)
		{
			return false;

			return Input.GetButtonDown(buttonName);
		}
	}
}
