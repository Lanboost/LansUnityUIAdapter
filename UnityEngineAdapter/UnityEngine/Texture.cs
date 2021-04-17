#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{

	public class Texture : Object
	{
		//
		// Summary:
		//     Can be used with texture constructors that take a mip count to indicate that
		//     all mips should be generated. The value of this field is -1.
		public static readonly int GenerateAllMips;

		internal Texture() { }

		//
		// Summary:
		//     Force streaming textures to load all mipmap levels.
		public static bool streamingTextureForceLoadAll { get; set; }
		//
		// Summary:
		//     Number of streaming textures with mipmaps currently loading.
		public static ulong streamingTextureLoadingCount { get; }
		//
		// Summary:
		//     Number of streaming textures with outstanding mipmaps to be loaded.
		public static ulong streamingTexturePendingLoadCount { get; }
		//
		// Summary:
		//     Number of non-streaming textures.
		public static ulong nonStreamingTextureCount { get; }
		//
		// Summary:
		//     Number of streaming textures.
		public static ulong streamingTextureCount { get; }
		//
		// Summary:
		//     Number of renderers registered with the texture streaming system.
		public static ulong streamingRendererCount { get; }
		//
		// Summary:
		//     How many times has a texture been uploaded due to texture mipmap streaming.
		public static ulong streamingMipmapUploadCount { get; }
		//
		// Summary:
		//     Total amount of memory being used by non-streaming textures.
		public static ulong nonStreamingTextureMemory { get; }
		//
		// Summary:
		//     The amount of memory currently being used by textures.
		public static ulong currentTextureMemory { get; }
		//
		// Summary:
		//     The amount of memory used by textures after the mipmap streaming and budget are
		//     applied and loading is complete.
		public static ulong targetTextureMemory { get; }
		//
		// Summary:
		//     This amount of texture memory would be used before the texture streaming budget
		//     is applied.
		public static ulong desiredTextureMemory { get; }
		//
		// Summary:
		//     The total amount of memory that would be used by all textures at mipmap level
		//     0.
		public static ulong totalTextureMemory { get; }
		//
		// Summary:
		//     Force the streaming texture system to discard all unused mipmaps immediately,
		//     rather than caching them until the texture memory budget is exceeded.
		public static bool streamingTextureDiscardUnusedMips { get; set; }
		//
		// Summary:
		//     Allow texture creation to occur on any thread (rather than the dedicated render
		//     thread).
		public static bool allowThreadedTextureCreation { get; set; }
		public static int masterTextureLimit { get; set; }
		[NativeProperty("AnisoLimit")]
		//public static AnisotropicFiltering anisotropicFiltering { get; set; }
		//
		// Summary:
		//     Texture U coordinate wrapping mode.
		public TextureWrapMode wrapModeU { get; set; }
		//
		// Summary:
		//     How many mipmap levels are in this texture (Read Only).
		public int mipmapCount { get; }
		//
		// Summary:
		//     Returns the GraphicsFormat format or color format of a texture object.
		//public virtual GraphicsFormat graphicsFormat { get; }
		//
		// Summary:
		//     Texture coordinate wrapping mode.
		public TextureWrapMode wrapMode { get; set; }
		//
		// Summary:
		//     Height of the texture in pixels. (Read Only)
		public virtual int height { get; set; }
		//
		// Summary:
		//     Dimensionality (type) of the texture (Read Only).
		//public virtual TextureDimension dimension { get; set; }
		//
		// Summary:
		//     Width of the texture in pixels. (Read Only)
		public virtual int width { get; set; }
		//
		// Summary:
		//     This counter is incremented when the texture is updated.
		public uint updateCount { get; }
		public Vector2 texelSize { get; }
		//
		// Summary:
		//     Mip map bias of the texture.
		public float mipMapBias { get; set; }
		//
		// Summary:
		//     Anisotropic filtering level of the texture.
		public int anisoLevel { get; set; }
		//
		// Summary:
		//     Returns true if the Read/Write Enabled checkbox was checked when the texture
		//     was imported; otherwise returns false. For a dynamic Texture created from script,
		//     always returns true. For additional information, see TextureImporter.isReadable.
		public virtual bool isReadable { get; }
		//
		// Summary:
		//     Texture W coordinate wrapping mode for Texture3D.
		public TextureWrapMode wrapModeW { get; set; }
		//
		// Summary:
		//     Texture V coordinate wrapping mode.
		public TextureWrapMode wrapModeV { get; set; }
		//
		// Summary:
		//     The hash value of the Texture.
		//public Hash128 imageContentsHash { get; set; }
		//
		// Summary:
		//     Filtering mode of the texture.
		//public FilterMode filterMode { get; set; }

		//
		// Summary:
		//     Sets Anisotropic limits.
		//
		// Parameters:
		//   forcedMin:
		//
		//   globalMax:
		[NativeName("SetGlobalAnisoLimits")]
		public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Uploads additional debug information to materials using textures set to stream
		//     mip maps.
		[FreeFunction("GetTextureStreamingManager().SetStreamingTextureMaterialDebugProperties")]
		public static void SetStreamingTextureMaterialDebugProperties() { throw new System.NotImplementedException(); }
		[Obsolete("Use GetNativeTexturePtr instead.", false)]
		public int GetNativeTextureID() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Retrieve a native (underlying graphics API) pointer to the texture resource.
		//
		// Returns:
		//     Pointer to an underlying graphics API texture resource.
		public IntPtr GetNativeTexturePtr() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Increment the update counter.
		public void IncrementUpdateCount() { throw new System.NotImplementedException(); }
	}
}