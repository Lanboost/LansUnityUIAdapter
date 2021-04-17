#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine
{

	public sealed class Texture2D : Texture
	{
		//
		// Summary:
		//     Create a new empty texture.
		//
		// Parameters:
		//   width:
		//
		//   height:
		public Texture2D(int width, int height) { }
		//
		// Summary:
		//     Create a new empty texture.
		//
		// Parameters:
		//   width:
		//
		//   height:
		//
		//   textureFormat:
		//
		//   mipChain:
		//public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { throw new System.NotImplementedException(); }
		//public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { throw new System.NotImplementedException(); }
		//public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags) { throw new System.NotImplementedException(); }
		//public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Create a new empty texture.
		//
		// Parameters:
		//   width:
		//
		//   height:
		//
		//   textureFormat:
		//
		//   mipChain:
		//
		//   linear:
		//public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("true")] bool mipChain, [DefaultValue("false")] bool linear) { throw new System.NotImplementedException(); }
		//public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("-1")] int mipCount, [DefaultValue("false")] bool linear) { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Gets a small Texture with all gray pixels.
		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D grayTexture { get; }
		//
		// Summary:
		//     Gets a small Texture with all gray pixels.
		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D linearGrayTexture { get; }
		//
		// Summary:
		//     Gets a small Texture with all red pixels.
		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D redTexture { get; }
		//
		// Summary:
		//     Gets a small Texture with all white pixels.
		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D whiteTexture { get; }
		//
		// Summary:
		//     Gets a small Texture with pixels that represent surface normal vectors at a neutral
		//     position.
		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D normalTexture { get; }
		//
		// Summary:
		//     Gets a small Texture with all black pixels.
		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D blackTexture { get; }
		//
		// Summary:
		//     Restricts the mipmap streaming system to a minimum mip level for this Texture.
		public int minimumMipmapLevel { get; set; }
		//
		// Summary:
		//     The mipmap level calculated by the streaming system, which takes into account
		//     the streaming Cameras and the location of the objects containing this Texture.
		//     This is unaffected by requestedMipmapLevel or minimumMipmapLevel.
		public int calculatedMipmapLevel { get; }
		//
		// Summary:
		//     The mipmap level that the streaming system would load before memory budgets are
		//     applied.
		public int desiredMipmapLevel { get; }
		//
		// Summary:
		//     The mipmap level that the mipmap streaming system is in the process of loading.
		public int loadingMipmapLevel { get; }
		//
		// Summary:
		//     Returns true if the Read/Write Enabled checkbox was checked when the texture
		//     was imported; otherwise returns false. For a dynamic Texture created from script,
		//     always returns true. For additional information, see TextureImporter.isReadable.
		public override bool isReadable { get; }
		//
		// Summary:
		//     The mipmap level to load.
		public int requestedMipmapLevel { get; set; }
		//
		// Summary:
		//     The format of the pixel data in the texture (Read Only).
		//public TextureFormat format { get; }
		//
		// Summary:
		//     Sets the relative priority for this Texture when reducing memory size to fit
		//     within the memory budget.
		public int streamingMipmapsPriority { get; }
		//
		// Summary:
		//     Determines whether mipmap streaming is enabled for this Texture.
		public bool streamingMipmaps { get; }
		//
		// Summary:
		//     The mipmap level that is currently loaded by the streaming system.
		public int loadedMipmapLevel { get; }
		//
		// Summary:
		//     Indicates whether this texture was imported with TextureImporter.alphaIsTransparency
		//     enabled. This setting is available only in the Editor scripts. Note that changing
		//     this setting will have no effect; it must be enabled in TextureImporter instead.
		public bool alphaIsTransparency { get; set; }

		//
		// Summary:
		//     Creates Unity Texture out of externally created native texture object.
		//
		// Parameters:
		//   nativeTex:
		//     Native 2D texture object.
		//
		//   width:
		//     Width of texture in pixels.
		//
		//   height:
		//     Height of texture in pixels.
		//
		//   format:
		//     Format of underlying texture object.
		//
		//   mipmap:
		//     Does the texture have mipmaps?
		//
		//   linear:
		//     Is texture using linear color space?
		//
		//   mipChain:
		//public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) { throw new System.NotImplementedException(); }
		public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results) { throw new System.NotImplementedException(); }
		public void Apply() { throw new System.NotImplementedException(); }
		public void Apply(bool updateMipmaps) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Actually apply all previous SetPixel and SetPixels changes.
		//
		// Parameters:
		//   updateMipmaps:
		//     When set to true, mipmap levels are recalculated.
		//
		//   makeNoLongerReadable:
		//     When set to true, system memory copy of a texture is released.
		public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Resets the minimumMipmapLevel field.
		[FreeFunction(Name = "GetTextureStreamingManager().ClearMinimumMipmapLevel", HasExplicitThis = true)]
		public void ClearMinimumMipmapLevel() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Resets the requestedMipmapLevel field.
		[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = true)]
		public void ClearRequestedMipmapLevel() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Compress texture into DXT format.
		//
		// Parameters:
		//   highQuality:
		public void Compress(bool highQuality) { throw new System.NotImplementedException(); }
		public Color GetPixel(int x, int y, int mipLevel) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns pixel color at coordinates (x, y).
		//
		// Parameters:
		//   x:
		//
		//   y:
		public Color GetPixel(int x, int y) { throw new System.NotImplementedException(); }
		public Color GetPixelBilinear(float u, float v, int mipLevel) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns filtered pixel color at normalized coordinates (u, v).
		//
		// Parameters:
		//   u:
		//
		//   v:
		public Color GetPixelBilinear(float u, float v) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a block of pixel colors.
		//
		// Parameters:
		//   x:
		//     The x position of the pixel array to fetch.
		//
		//   y:
		//     The y position of the pixel array to fetch.
		//
		//   blockWidth:
		//     The width length of the pixel array to fetch.
		//
		//   blockHeight:
		//     The height length of the pixel array to fetch.
		//
		//   miplevel:
		//     The mipmap level to fetch the pixels. Defaults to zero, and is optional.
		//
		// Returns:
		//     The array of pixels in the texture that have been selected.
		[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = true, ThrowsException = true)]
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { throw new System.NotImplementedException(); }
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { throw new System.NotImplementedException(); }
		public Color[] GetPixels() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get the pixel colors from the texture.
		//
		// Parameters:
		//   miplevel:
		//     The mipmap level to fetch the pixels from. Defaults to zero.
		//
		// Returns:
		//     The array of all pixels in the mipmap level of the texture.
		public Color[] GetPixels(int miplevel) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a block of pixel colors in Color32 format.
		//
		// Parameters:
		//   miplevel:
		[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = true, ThrowsException = true)]
		public Color32[] GetPixels32(int miplevel) { throw new System.NotImplementedException(); }
		public Color32[] GetPixels32() { throw new System.NotImplementedException(); }
		//public NativeArray<T> GetRawTextureData<T>() where T : struct;
		//
		// Summary:
		//     Get raw data from a texture.
		//
		// Returns:
		//     Raw texture data as a byte array.
		[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = true)]
		public byte[] GetRawTextureData() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Checks to see whether the mipmap level set by requestedMipmapLevel has finished
		//     loading.
		//
		// Returns:
		//     True if the mipmap level requested by requestedMipmapLevel has finished loading.
		[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = true)]
		public bool IsRequestedMipmapLevelLoaded() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Fills texture pixels with raw preformatted data.
		//
		// Parameters:
		//   data:
		//     Raw data array to initialize texture pixels with.
		//
		//   size:
		//     Size of data in bytes.
		public void LoadRawTextureData(byte[] data) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Fills texture pixels with raw preformatted data.
		//
		// Parameters:
		//   data:
		//     Raw data array to initialize texture pixels with.
		//
		//   size:
		//     Size of data in bytes.
		public void LoadRawTextureData(IntPtr data, int size) { throw new System.NotImplementedException(); }
		//public void LoadRawTextureData<T>(NativeArray<T> data) where T : struct;
		//
		// Summary:
		//     Packs multiple Textures into a texture atlas.
		//
		// Parameters:
		//   textures:
		//     Array of textures to pack into the atlas.
		//
		//   padding:
		//     Padding in pixels between the packed textures.
		//
		//   maximumAtlasSize:
		//     Maximum size of the resulting texture.
		//
		//   makeNoLongerReadable:
		//     Should the texture be marked as no longer readable?
		//
		// Returns:
		//     An array of rectangles containing the UV coordinates in the atlas for each input
		//     texture, or null if packing fails.
		[FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = true)]
		public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { throw new System.NotImplementedException(); }
		public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { throw new System.NotImplementedException(); }
		public Rect[] PackTextures(Texture2D[] textures, int padding) { throw new System.NotImplementedException(); }
		[ExcludeFromDocs]
		public void ReadPixels(Rect source, int destX, int destY) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Read pixels from screen into the saved texture data.
		//
		// Parameters:
		//   source:
		//     Rectangular region of the view to read from. Pixels are read from current render
		//     target.
		//
		//   destX:
		//     Horizontal pixel position in the texture to place the pixels that are read.
		//
		//   destY:
		//     Vertical pixel position in the texture to place the pixels that are read.
		//
		//   recalculateMipMaps:
		//     Should the texture's mipmaps be recalculated after reading?
		public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Resizes the texture.
		//
		// Parameters:
		//   width:
		//
		//   height:
		//
		//   format:
		//
		//   hasMipMap:
		//public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Resizes the texture.
		//
		// Parameters:
		//   width:
		//
		//   height:
		public bool Resize(int width, int height) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets pixel color at coordinates (x,y).
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   color:
		public void SetPixel(int x, int y, Color color) { throw new System.NotImplementedException(); }
		public void SetPixel(int x, int y, Color color, int mipLevel) { throw new System.NotImplementedException(); }
		public void SetPixelData<T>(T[] data, int mipLevel, int sourceDataStartIndex = 0) { throw new System.NotImplementedException(); }
		//public void SetPixelData<T>(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) where T : struct;
		public void SetPixels(Color[] colors) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Set a block of pixel colors.
		//
		// Parameters:
		//   colors:
		//     The array of pixel colours to assign (a 2D image flattened to a 1D array).
		//
		//   miplevel:
		//     The mip level of the texture to write to.
		public void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel) { throw new System.NotImplementedException(); }
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Set a block of pixel colors.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   blockWidth:
		//
		//   blockHeight:
		//
		//   colors:
		//
		//   miplevel:
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Set a block of pixel colors.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   blockWidth:
		//
		//   blockHeight:
		//
		//   colors:
		//
		//   miplevel:
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { throw new System.NotImplementedException(); }
		public void SetPixels32(Color32[] colors) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Set a block of pixel colors.
		//
		// Parameters:
		//   colors:
		//
		//   miplevel:
		public void SetPixels32(Color32[] colors, int miplevel) { throw new System.NotImplementedException(); }
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Updates Unity texture to use different native texture object.
		//
		// Parameters:
		//   nativeTex:
		//     Native 2D texture object.
		[FreeFunction("Texture2DScripting::UpdateExternalTexture", HasExplicitThis = true)]
		public void UpdateExternalTexture(IntPtr nativeTex) { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Flags used to control the encoding to an EXR file.
		[Flags]
		public enum EXRFlags
		{
			//
			// Summary:
			//     No flag. This will result in an uncompressed 16-bit float EXR file.
			None = 0,
			//
			// Summary:
			//     The texture will be exported as a 32-bit float EXR file (default is 16-bit).
			OutputAsFloat = 1,
			//
			// Summary:
			//     The texture will use the EXR ZIP compression format.
			CompressZIP = 2,
			//
			// Summary:
			//     The texture will use RLE (Run Length Encoding) EXR compression format (similar
			//     to Targa RLE compression).
			CompressRLE = 4,
			//
			// Summary:
			//     This texture will use Wavelet compression. This is best used for grainy images.
			CompressPIZ = 8
		}
	}
}