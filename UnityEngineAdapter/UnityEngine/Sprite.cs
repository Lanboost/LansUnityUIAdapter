
using System.Collections.Generic;
namespace UnityEngine
{

	public sealed class Sprite : Object
	{
		//
		// Summary:
		//     Returns the border sizes of the sprite.
		public Vector4 border { get; }
		//
		// Summary:
		//     Returns a copy of the array containing sprite mesh vertex positions.
		public Vector2[] vertices { get; }
		//
		// Summary:
		//     Gets the offset of the rectangle this sprite uses on its texture to the original
		//     sprite bounds. If sprite mesh type is FullRect, offset is zero.
		public Vector2 textureRectOffset { get; }
		//
		// Summary:
		//     Get the rectangle this sprite uses on its texture. Raises an exception if this
		//     sprite is tightly packed in an atlas.
		public Rect textureRect { get; }
		//
		// Summary:
		//     If Sprite is packed (see Sprite.packed), returns its SpritePackingRotation.
		public SpritePackingRotation packingRotation { get; }
		//
		// Summary:
		//     If Sprite is packed (see Sprite.packed), returns its SpritePackingMode.
		public SpritePackingMode packingMode { get; }
		//
		// Summary:
		//     Returns true if this Sprite is packed in an atlas.
		public bool packed { get; }
		//
		// Summary:
		//     Location of the Sprite's center point in the Rect on the original Texture, specified
		//     in pixels.
		public Vector2 pivot { get; }
		//
		// Summary:
		//     Returns the texture that contains the alpha channel from the source texture.
		//     Unity generates this texture under the hood for sprites that have alpha in the
		//     source, and need to be compressed using techniques like ETC1. Returns NULL if
		//     there is no associated alpha texture for the source sprite. This is the case
		//     if the sprite has not been setup to use ETC1 compression.
		public Texture2D associatedAlphaSplitTexture { get; }
		//
		// Summary:
		//     The Variant scale of texture used by the Sprite. This is useful to check when
		//     a Variant SpriteAtlas is being used by Sprites.
		public float spriteAtlasTextureScale { get; }
		//
		// Summary:
		//     The number of pixels in the sprite that correspond to one unit in world space.
		//     (Read Only)
		public float pixelsPerUnit { get; }
		//
		// Summary:
		//     Get the reference to the used texture. If packed this will point to the atlas,
		//     if not packed will point to the source sprite.
		public Texture2D texture { get; }
		//
		// Summary:
		//     Returns a copy of the array containing sprite mesh triangles.
		public ushort[] triangles { get; }
		//
		// Summary:
		//     The base texture coordinates of the sprite mesh.
		public Vector2[] uv { get; }
		//
		// Summary:
		//     Bounds of the Sprite, specified by its center and extents in world space units.
		public Bounds bounds { get; }
		//
		// Summary:
		//     Location of the Sprite on the original Texture, specified in pixels.
		public Rect rect { get; }

		//
		// Summary:
		//     Create a new Sprite object.
		//
		// Parameters:
		//   texture:
		//     Texture from which to obtain the sprite graphic.
		//
		//   rect:
		//     Rectangular section of the texture to use for the sprite.
		//
		//   pivot:
		//     Sprite's pivot point relative to its graphic rectangle.
		//
		//   pixelsPerUnit:
		//     The number of pixels in the sprite that correspond to one unit in world space.
		//
		//   extrude:
		//     Amount by which the sprite mesh should be expanded outwards.
		//
		//   meshType:
		//     Controls the type of mesh generated for the sprite.
		//
		//   border:
		//     The border sizes of the sprite (X=left, Y=bottom, Z=right, W=top).
		//
		//   generateFallbackPhysicsShape:
		//     Generates a default physics shape for the sprite.
		//public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot);
		//
		// Summary:
		//     Create a new Sprite object.
		//
		// Parameters:
		//   texture:
		//     Texture from which to obtain the sprite graphic.
		//
		//   rect:
		//     Rectangular section of the texture to use for the sprite.
		//
		//   pivot:
		//     Sprite's pivot point relative to its graphic rectangle.
		//
		//   pixelsPerUnit:
		//     The number of pixels in the sprite that correspond to one unit in world space.
		//
		//   extrude:
		//     Amount by which the sprite mesh should be expanded outwards.
		//
		//   meshType:
		//     Controls the type of mesh generated for the sprite.
		//
		//   border:
		//     The border sizes of the sprite (X=left, Y=bottom, Z=right, W=top).
		//
		//   generateFallbackPhysicsShape:
		//     Generates a default physics shape for the sprite.
		//public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit);
		//
		// Summary:
		//     Create a new Sprite object.
		//
		// Parameters:
		//   texture:
		//     Texture from which to obtain the sprite graphic.
		//
		//   rect:
		//     Rectangular section of the texture to use for the sprite.
		//
		//   pivot:
		//     Sprite's pivot point relative to its graphic rectangle.
		//
		//   pixelsPerUnit:
		//     The number of pixels in the sprite that correspond to one unit in world space.
		//
		//   extrude:
		//     Amount by which the sprite mesh should be expanded outwards.
		//
		//   meshType:
		//     Controls the type of mesh generated for the sprite.
		//
		//   border:
		//     The border sizes of the sprite (X=left, Y=bottom, Z=right, W=top).
		//
		//   generateFallbackPhysicsShape:
		//     Generates a default physics shape for the sprite.
		//public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude);
		//
		// Summary:
		//     Create a new Sprite object.
		//
		// Parameters:
		//   texture:
		//     Texture from which to obtain the sprite graphic.
		//
		//   rect:
		//     Rectangular section of the texture to use for the sprite.
		//
		//   pivot:
		//     Sprite's pivot point relative to its graphic rectangle.
		//
		//   pixelsPerUnit:
		//     The number of pixels in the sprite that correspond to one unit in world space.
		//
		//   extrude:
		//     Amount by which the sprite mesh should be expanded outwards.
		//
		//   meshType:
		//     Controls the type of mesh generated for the sprite.
		//
		//   border:
		//     The border sizes of the sprite (X=left, Y=bottom, Z=right, W=top).
		//
		//   generateFallbackPhysicsShape:
		//     Generates a default physics shape for the sprite.
		//public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType);
		//
		// Summary:
		//     Create a new Sprite object.
		//
		// Parameters:
		//   texture:
		//     Texture from which to obtain the sprite graphic.
		//
		//   rect:
		//     Rectangular section of the texture to use for the sprite.
		//
		//   pivot:
		//     Sprite's pivot point relative to its graphic rectangle.
		//
		//   pixelsPerUnit:
		//     The number of pixels in the sprite that correspond to one unit in world space.
		//
		//   extrude:
		//     Amount by which the sprite mesh should be expanded outwards.
		//
		//   meshType:
		//     Controls the type of mesh generated for the sprite.
		//
		//   border:
		//     The border sizes of the sprite (X=left, Y=bottom, Z=right, W=top).
		//
		//   generateFallbackPhysicsShape:
		//     Generates a default physics shape for the sprite.
		//public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border);
		//
		// Summary:
		//     Create a new Sprite object.
		//
		// Parameters:
		//   texture:
		//     Texture from which to obtain the sprite graphic.
		//
		//   rect:
		//     Rectangular section of the texture to use for the sprite.
		//
		//   pivot:
		//     Sprite's pivot point relative to its graphic rectangle.
		//
		//   pixelsPerUnit:
		//     The number of pixels in the sprite that correspond to one unit in world space.
		//
		//   extrude:
		//     Amount by which the sprite mesh should be expanded outwards.
		//
		//   meshType:
		//     Controls the type of mesh generated for the sprite.
		//
		//   border:
		//     The border sizes of the sprite (X=left, Y=bottom, Z=right, W=top).
		//
		//   generateFallbackPhysicsShape:
		//     Generates a default physics shape for the sprite.
		//public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape);
		//public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape);
		//
		// Summary:
		//     The number of physics shapes for the Sprite.
		//
		// Returns:
		//     The number of physics shapes for the Sprite.
		//public int GetPhysicsShapeCount();
		//
		// Summary:
		//     The number of points in the selected physics shape for the Sprite.
		//
		// Parameters:
		//   shapeIdx:
		//     The index of the physics shape to retrieve the number of points from.
		//
		// Returns:
		//     The number of points in the selected physics shape for the Sprite.
		//public int GetPhysicsShapePointCount(int shapeIdx);
		//
		// Summary:
		//     Sets up new Sprite geometry.
		//
		// Parameters:
		//   vertices:
		//     Array of vertex positions in Sprite Rect space.
		//
		//   triangles:
		//     Array of sprite mesh triangle indices.
		//[FreeFunction("SpritesBindings::OverrideGeometry", HasExplicitThis = true)]
		//public void OverrideGeometry(Vector2[] vertices, ushort[] triangles);
		//public void OverridePhysicsShape(IList<Vector2[]> physicsShapes);
	}
}