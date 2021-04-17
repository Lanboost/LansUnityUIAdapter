#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
	public sealed class SpriteRenderer : Renderer
	{
		public SpriteRenderer() { }

		//
		// Summary:
		//     The Sprite to render.
		public Sprite sprite { get; set; }
		//
		// Summary:
		//     The current draw mode of the Sprite Renderer.
		//public SpriteDrawMode drawMode { get; set; }
		//
		// Summary:
		//     Property to set/get the size to render when the SpriteRenderer.drawMode is set
		//     to SpriteDrawMode.Sliced.
		public Vector2 size { get; set; }
		//
		// Summary:
		//     The current threshold for Sprite Renderer tiling.
		public float adaptiveModeThreshold { get; set; }
		//
		// Summary:
		//     The current tile mode of the Sprite Renderer.
		//public SpriteTileMode tileMode { get; set; }
		//
		// Summary:
		//     Rendering color for the Sprite graphic.
		public Color color { get; set; }
		//
		// Summary:
		//     Specifies how the sprite interacts with the masks.
		//public SpriteMaskInteraction maskInteraction { get; set; }
		//
		// Summary:
		//     Flips the sprite on the X axis.
		public bool flipX { get; set; }
		//
		// Summary:
		//     Flips the sprite on the Y axis.
		public bool flipY { get; set; }
		//
		// Summary:
		//     Determines the position of the Sprite used for sorting the SpriteRenderer.
		//public SpriteSortPoint spriteSortPoint { get; set; }
	}
}