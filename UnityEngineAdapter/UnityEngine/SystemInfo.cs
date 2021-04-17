#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Rendering;

namespace UnityEngine
{
	//
	// Summary:
	//     Access system and hardware information.
	public sealed class SystemInfo
	{
		//
		// Summary:
		//     Value returned by SystemInfo string properties which are not supported on the
		//     current platform.
		public const string unsupportedIdentifier = "n/a";

		public SystemInfo() { }

		//
		// Summary:
		//     Determines how many compute buffers Unity supports simultaneously in a vertex
		//     shader for reading. (Read Only)
		public static int maxComputeBufferInputsVertex { get; }
		//
		// Summary:
		//     Maximum Cubemap texture size (Read Only).
		public static int maxCubemapSize { get; }
		//
		// Summary:
		//     Maximum texture size (Read Only).
		public static int maxTextureSize { get; }
		//
		// Summary:
		//     What NPOT (non-power of two size) texture support does the GPU provide? (Read
		//     Only)
		//public static NPOTSupport npotSupport { get; }
		//
		// Summary:
		//     This property is true if the current platform uses a reversed depth buffer (where
		//     values range from 1 at the near plane and 0 at far plane), and false if the depth
		//     buffer is normal (0 is near, 1 is far). (Read Only)
		public static bool usesReversedZBuffer { get; }
		//
		// Summary:
		//     Returns true if the 'Mirror Once' texture wrap mode is supported. (Read Only)
		public static int supportsTextureWrapMirrorOnce { get; }
		//
		// Summary:
		//     Returns true if multisampled textures are resolved automatically
		public static bool supportsMultisampleAutoResolve { get; }
		//
		// Summary:
		//     Are multisampled textures supported? (Read Only)
		public static int supportsMultisampledTextures { get; }
		//
		// Summary:
		//     The maximum number of random write targets (UAV) that Unity supports simultaneously.
		//     (Read Only)
		public static int supportedRandomWriteTargetCount { get; }
		//
		// Summary:
		//     Returns true when the platform supports different blend modes when rendering
		//     to multiple render targets, or false otherwise.
		public static bool supportsSeparatedRenderTargetsBlend { get; }
		//
		// Summary:
		//     How many simultaneous render targets (MRTs) are supported? (Read Only)
		public static int supportedRenderTargetCount { get; }
		//
		// Summary:
		//     Are sparse textures supported? (Read Only)
		public static bool supportsSparseTextures { get; }
		//
		// Summary:
		//     Are 32-bit index buffers supported? (Read Only)
		public static bool supports32bitsIndexBuffer { get; }
		//
		// Summary:
		//     Does the hardware support quad topology? (Read Only)
		public static bool supportsHardwareQuadTopology { get; }
		//
		// Summary:
		//     Is GPU draw call instancing supported? (Read Only)
		public static bool supportsInstancing { get; }
		//
		// Summary:
		//     Are tessellation shaders supported? (Read Only)
		public static bool supportsTessellationShaders { get; }
		//
		// Summary:
		//     Are geometry shaders supported? (Read Only)
		public static bool supportsGeometryShaders { get; }
		//
		// Summary:
		//     Are compute shaders supported? (Read Only)
		public static bool supportsComputeShaders { get; }
		//
		// Summary:
		//     Determines how many compute buffers Unity supports simultaneously in a fragment
		//     shader for reading. (Read Only)
		public static int maxComputeBufferInputsFragment { get; }
		//
		// Summary:
		//     Determines how many compute buffers Unity supports simultaneously in a geometry
		//     shader for reading. (Read Only)
		public static int maxComputeBufferInputsGeometry { get; }
		//
		// Summary:
		//     Determines how many compute buffers Unity supports simultaneously in a domain
		//     shader for reading. (Read Only)
		public static int maxComputeBufferInputsDomain { get; }
		//
		// Summary:
		//     Determines how many compute buffers Unity supports simultaneously in a hull shader
		//     for reading. (Read Only)
		public static int maxComputeBufferInputsHull { get; }
		[Obsolete("graphicsPixelFillrate is no longer supported in Unity 5.0+.")]
		public static int graphicsPixelFillrate { get; }
		//
		// Summary:
		//     Is the stencil buffer supported? (Read Only)
		[Obsolete("supportsStencil always returns true, no need to call it")]
		public static int supportsStencil { get; }
		//
		// Summary:
		//     Are image effects supported? (Read Only)
		[Obsolete("supportsImageEffects always returns true, no need to call it")]
		public static bool supportsImageEffects { get; }
		//
		// Summary:
		//     Are cubemap render textures supported? (Read Only)
		[Obsolete("supportsRenderToCubemap always returns true, no need to call it")]
		public static bool supportsRenderToCubemap { get; }
		//
		// Summary:
		//     Are render textures supported? (Read Only)
		[Obsolete("supportsRenderTextures always returns true, no need to call it")]
		public static bool supportsRenderTextures { get; }
		//
		// Summary:
		//     True if the Graphics API takes RenderBufferLoadAction and RenderBufferStoreAction
		//     into account, false if otherwise.
		public static bool usesLoadStoreActions { get; }
		//
		// Summary:
		//     Is streaming of texture mip maps supported? (Read Only)
		public static bool supportsMipStreaming { get; }
		//
		// Summary:
		//     Returns true if the GPU supports partial mipmap chains (Read Only).
		public static bool hasMipMaxLevel { get; }
		//
		// Summary:
		//     Minimum buffer offset (in bytes) when binding a constant buffer using Shader.SetConstantBuffer
		//     or Material.SetConstantBuffer.
		public static bool minConstantBufferOffsetAlignment { get; }
		//
		// Summary:
		//     Does the current renderer support binding constant buffers directly? (Read Only)
		public static bool supportsSetConstantBuffer { get; }
		//
		// Summary:
		//     Checks if ray tracing is supported by the current configuration.
		public static bool supportsRayTracing { get; }
		//
		// Summary:
		//     Returns true if asynchronous readback of GPU data is available for this device
		//     and false otherwise.
		public static bool supportsAsyncGPUReadback { get; }
		//
		// Summary:
		//     Returns true when the platform supports GraphicsFences, and false if otherwise.
		public static bool supportsGraphicsFence { get; }
		//
		// Summary:
		//     Returns true when the platform supports asynchronous compute queues and false
		//     if otherwise.
		public static bool supportsAsyncCompute { get; }
		//
		// Summary:
		//     The maximum number of work groups that a compute shader can use in Z dimension
		//     (Read Only).
		public static int maxComputeWorkGroupSizeZ { get; }
		//
		// Summary:
		//     The maximum number of work groups that a compute shader can use in Y dimension
		//     (Read Only).
		public static int maxComputeWorkGroupSizeY { get; }
		//
		// Summary:
		//     The maximum number of work groups that a compute shader can use in X dimension
		//     (Read Only).
		public static int maxComputeWorkGroupSizeX { get; }
		//
		// Summary:
		//     The largest total number of invocations in a single local work group that can
		//     be dispatched to a compute shader (Read Only).
		public static int maxComputeWorkGroupSize { get; }
		//
		// Summary:
		//     Determines how many compute buffers Unity supports simultaneously in a compute
		//     shader for reading. (Read Only)
		public static int maxComputeBufferInputsCompute { get; }
		//
		// Summary:
		//     Support for various Graphics.CopyTexture cases (Read Only).
		//public static CopyTextureSupport copyTextureSupport { get; }
		//
		// Summary:
		//     Are Cubemap Array textures supported? (Read Only)
		public static bool supportsCubemapArrayTextures { get; }
		//
		// Summary:
		//     Are 3D (volume) RenderTextures supported? (Read Only)
		public static bool supports3DRenderTextures { get; }
		//
		// Summary:
		//     Are 2D Array textures supported? (Read Only)
		public static bool supports2DArrayTextures { get; }
		//
		// Summary:
		//     Is the device capable of providing the user haptic feedback by vibration?
		public static bool supportsVibration { get; }
		[Obsolete("Vertex program support is required in Unity 5.0+")]
		public static bool supportsVertexPrograms { get; }
		//
		// Summary:
		//     Is a gyroscope available on the device?
		public static bool supportsGyroscope { get; }
		//
		// Summary:
		//     Is an accelerometer available on the device?
		public static bool supportsAccelerometer { get; }
		//
		// Summary:
		//     The model of the device (Read Only).
		public static string deviceModel { get; }
		//
		// Summary:
		//     The user defined name of the device (Read Only).
		public static string deviceName { get; }
		//
		// Summary:
		//     A unique device identifier. It is guaranteed to be unique for every device (Read
		//     Only).
		public static string deviceUniqueIdentifier { get; }
		//
		// Summary:
		//     Amount of system memory present (Read Only).
		public static int systemMemorySize { get; }
		//
		// Summary:
		//     Number of processors present (Read Only).
		public static int processorCount { get; }
		//
		// Summary:
		//     Processor frequency in MHz (Read Only).
		public static int processorFrequency { get; }
		//
		// Summary:
		//     Processor name (Read Only).
		public static string processorType { get; }
		//
		// Summary:
		//     Returns the operating system family the game is running on (Read Only).
		public static OperatingSystemFamily operatingSystemFamily { get; }
		//
		// Summary:
		//     Operating system name with version (Read Only).
		public static string operatingSystem { get; }
		//
		// Summary:
		//     Returns the current status of the device's battery (Read Only).
		//public static BatteryStatus batteryStatus { get; }
		//
		// Summary:
		//     The current battery level (Read Only).
		public static float batteryLevel { get; }
		//
		// Summary:
		//     Is there an Audio device available for playback? (Read Only)
		public static bool supportsAudio { get; }
		//
		// Summary:
		//     Returns the kind of device the application is running on (Read Only).
		//public static DeviceType deviceType { get; }
		//
		// Summary:
		//     Is the device capable of reporting its location?
		public static bool supportsLocationService { get; }
		//
		// Summary:
		//     The name of the graphics device (Read Only).
		public static string graphicsDeviceName { get; }
		//
		// Summary:
		//     Are 3D (volume) textures supported? (Read Only)
		public static bool supports3DTextures { get; }
		//
		// Summary:
		//     Whether motion vectors are supported on this platform.
		public static bool supportsMotionVectors { get; }
		//
		// Summary:
		//     Is sampling raw depth from shadowmaps supported? (Read Only)
		public static bool supportsRawShadowDepthSampling { get; }
		//
		// Summary:
		//     Amount of video memory present (Read Only).
		public static int graphicsMemorySize { get; }
		//
		// Summary:
		//     Returns true when the GPU has native support for indexing uniform arrays in fragment
		//     shaders without restrictions.
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders { get; }
		//
		// Summary:
		//     True if the GPU supports hidden surface removal.
		public static bool hasHiddenSurfaceRemovalOnGPU { get; }
		//
		// Summary:
		//     Application's actual rendering threading mode (Read Only).
		//public static RenderingThreadingMode renderingThreadingMode { get; }
		//
		// Summary:
		//     Are built-in shadows supported? (Read Only)
		public static bool supportsShadows { get; }
		//
		// Summary:
		//     Graphics device shader capability level (Read Only).
		public static int graphicsShaderLevel { get; }
		//
		// Summary:
		//     The graphics API type and driver version used by the graphics device (Read Only).
		public static string graphicsDeviceVersion { get; }
		//
		// Summary:
		//     Returns true if the texture UV coordinate convention for this platform has Y
		//     starting at the top of the image.
		public static bool graphicsUVStartsAtTop { get; }
		//
		// Summary:
		//     The graphics API type used by the graphics device (Read Only).
		//public static GraphicsDeviceType graphicsDeviceType { get; }
		//
		// Summary:
		//     The identifier code of the graphics device vendor (Read Only).
		public static int graphicsDeviceVendorID { get; }
		//
		// Summary:
		//     The identifier code of the graphics device (Read Only).
		public static int graphicsDeviceID { get; }
		//
		// Summary:
		//     The vendor of the graphics device (Read Only).
		public static string graphicsDeviceVendor { get; }
		//
		// Summary:
		//     Is graphics device using multi-threaded rendering (Read Only)?
		public static bool graphicsMultiThreaded { get; }
		//
		// Summary:
		//     This functionality is deprecated, and should no longer be used. Please use SystemInfo.supportsGraphicsFence.
		[Obsolete("SystemInfo.supportsGPUFence has been deprecated, use SystemInfo.supportsGraphicsFence instead (UnityUpgradable) ->  supportsGraphicsFence", true)]
		public static bool supportsGPUFence { get; }

		//public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage);
		//
		// Summary:
		//     Returns the platform-specific GraphicsFormat that is associated with the DefaultFormat.
		//
		// Parameters:
		//   format:
		//     The DefaultFormat format to look up.
		//public static GraphicsFormat GetGraphicsFormat(DefaultFormat format);
		//public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage);
		//
		// Summary:
		//     Is blending supported on render texture format?
		//
		// Parameters:
		//   format:
		//     The format to look up.
		//
		// Returns:
		//     True if blending is supported on the given format.
		//public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format);
		//
		// Summary:
		//     Is render texture format supported?
		//
		// Parameters:
		//   format:
		//     The format to look up.
		//
		// Returns:
		//     True if the format is supported.
		//public static bool SupportsRenderTextureFormat(RenderTextureFormat format);
		//
		// Summary:
		//     Is texture format supported on this device?
		//
		// Parameters:
		//   format:
		//     The TextureFormat format to look up.
		//
		// Returns:
		//     True if the format is supported.
		//public static bool SupportsTextureFormat(TextureFormat format);
		//
		// Summary:
		//     Indicates whether the given combination of a vertex attribute format and dimension
		//     is supported on this device.
		//
		// Parameters:
		//   format:
		//     The VertexAttributeFormat format to look up.
		//
		//   dimension:
		//     The dimension of vertex data to check for.
		//
		// Returns:
		//     True if the format with the given dimension is supported.
		//public static bool SupportsVertexAttributeFormat(VertexAttributeFormat format, int dimension);
	}
}