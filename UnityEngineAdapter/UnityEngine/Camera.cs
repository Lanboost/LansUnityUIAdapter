
using System;
using System.ComponentModel;
namespace UnityEngine
{
	
	public sealed class Camera : Behaviour
	{
		//
		// Summary:
		//     Event that is fired before any camera starts culling.
		public static CameraCallback onPreCull;
		//
		// Summary:
		//     Event that is fired before any camera starts rendering.
		public static CameraCallback onPreRender;
		//
		// Summary:
		//     Event that is fired after any camera finishes rendering.
		public static CameraCallback onPostRender;

		public Camera() { }

		//
		// Summary:
		//     The first enabled camera tagged "MainCamera" (Read Only).
		public static Camera main { get; }
		//
		// Summary:
		//     The camera we are currently rendering with, for low-level render control only
		//     (Read Only).
		public static Camera current { get; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property mainCamera has been deprecated. Use Camera.main instead (UnityUpgradable) -> main", true)]
		public static Camera mainCamera { get; }
		//
		// Summary:
		//     Returns all enabled cameras in the Scene.
		public static Camera[] allCameras { get; }
		//
		// Summary:
		//     The number of cameras in the current Scene.
		public static int allCamerasCount { get; }
		//
		// Summary:
		//     This is used to render parts of the Scene selectively.
		public int cullingMask { get; set; }
		//
		// Summary:
		//     Mask to select which layers can trigger events on the camera.
		public int eventMask { get; set; }
		//
		// Summary:
		//     How to perform per-layer culling for a Camera.
		public bool layerCullSpherical { get; set; }
		//
		// Summary:
		//     Identifies what kind of camera this is.
		//public CameraType cameraType { get; set; }
		//
		// Summary:
		//     Sets the culling maks used to determine which objects from which Scenes to draw.
		//     See EditorSceneManager.SetSceneCullingMask.
		//[NativeConditional("UNITY_EDITOR")]
		public ulong overrideSceneCullingMask { get; set; }
		//
		// Summary:
		//     Whether or not the Camera will use occlusion culling during rendering.
		public bool useOcclusionCulling { get; set; }
		//
		// Summary:
		//     Get the world-space speed of the camera (Read Only).
		public Vector3 velocity { get; }
		//
		// Summary:
		//     Sets a custom matrix for the camera to use for all culling queries.
		public Matrix4x4 cullingMatrix { get; set; }
		//
		// Summary:
		//     The color with which the screen will be cleared.
		public Color backgroundColor { get; set; }
		//
		// Summary:
		//     How the camera clears the background.
		//public CameraClearFlags clearFlags { get; set; }
		//
		// Summary:
		//     How and if camera generates a depth texture.
		//public DepthTextureMode depthTextureMode { get; set; }
		//
		// Summary:
		//     Should the camera clear the stencil buffer after the deferred light pass?
		public bool clearStencilAfterLightingPass { get; set; }
		//
		// Summary:
		//     Per-layer culling distances.
		public float[] layerCullDistances { get; set; }
		//
		// Summary:
		//     The aspect ratio (width divided by height).
		public float aspect { get; set; }
		//
		// Summary:
		//     High dynamic range rendering.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property hdr has been deprecated. Use Camera.allowHDR instead (UnityUpgradable) -> UnityEngine.Camera.allowHDR", false)]
		public bool hdr { get; set; }
		//
		// Summary:
		//     Enable [UsePhysicalProperties] to use physical camera properties to compute the
		//     field of view and the frustum.
		public bool usePhysicalProperties { get; set; }
		//
		// Summary:
		//     An axis that describes the direction along which the distances of objects are
		//     measured for the purpose of sorting.
		public Vector3 transparencySortAxis { get; set; }
		//
		// Summary:
		//     Transparent object sorting mode.
		//public TransparencySortMode transparencySortMode { get; set; }
		//
		// Summary:
		//     Opaque object sorting mode.
		//public OpaqueSortMode opaqueSortMode { get; set; }
		//
		// Summary:
		//     Is the camera orthographic (true) or perspective (false)?
		public bool orthographic { get; set; }
		//
		// Summary:
		//     Camera's half-size when in orthographic mode.
		public float orthographicSize { get; set; }
		//
		// Summary:
		//     Should camera rendering be forced into a RenderTexture.
		//[NativeProperty("ForceIntoRT")]
		public bool forceIntoRenderTexture { get; set; }
		//
		// Summary:
		//     Dynamic Resolution Scaling.
		public bool allowDynamicResolution { get; set; }
		//
		// Summary:
		//     MSAA rendering.
		public bool allowMSAA { get; set; }
		//
		// Summary:
		//     High dynamic range rendering.
		public bool allowHDR { get; set; }
		//
		// Summary:
		//     The rendering path that is currently being used (Read Only).
		//public RenderingPath actualRenderingPath { get; }
		//
		// Summary:
		//     The rendering path that should be used, if possible.
		//public RenderingPath renderingPath { get; set; }
		//
		// Summary:
		//     The field of view of the camera in degrees.
		//[NativeProperty("VerticalFieldOfView")]
		public float fieldOfView { get; set; }
		//
		// Summary:
		//     Camera's depth in the camera rendering order.
		public float depth { get; set; }
		//
		// Summary:
		//     The size of the camera sensor, expressed in millimeters.
		public Vector2 sensorSize { get; set; }
		//
		// Summary:
		//     There are two gates for a camera, the sensor gate and the resolution gate. The
		//     physical camera sensor gate is defined by the sensorSize property, the resolution
		//     gate is defined by the render target area.
		//public GateFitMode gateFit { get; set; }
		//
		// Summary:
		//     The camera focal length, expressed in millimeters. To use this property, enable
		//     UsePhysicalProperties.
		public float focalLength { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property fov has been deprecated. Use Camera.fieldOfView instead (UnityUpgradable) -> UnityEngine.Camera.fieldOfView", false)]
		public float fov { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property far has been deprecated. Use Camera.farClipPlane instead (UnityUpgradable) -> UnityEngine.Camera.farClipPlane", false)]
		public float far { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property near has been deprecated. Use Camera.nearClipPlane instead (UnityUpgradable) -> UnityEngine.Camera.nearClipPlane", false)]
		public float near { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property isOrthoGraphic has been deprecated. Use orthographic (UnityUpgradable) -> orthographic", true)]
		public bool isOrthoGraphic { get; set; }
		//
		// Summary:
		//     Number of command buffers set up on this camera (Read Only).
		public int commandBufferCount { get; }
		//
		// Summary:
		//     Returns the eye that is currently rendering. If called when stereo is not enabled
		//     it will return Camera.MonoOrStereoscopicEye.Mono. If called during a camera rendering
		//     callback such as OnRenderImage it will return the currently rendering eye. If
		//     called outside of a rendering callback and stereo is enabled, it will return
		//     the default eye which is Camera.MonoOrStereoscopicEye.Left.
		//public MonoOrStereoscopicEye stereoActiveEye { get; }
		//
		// Summary:
		//     Defines which eye of a VR display the Camera renders into.
		/*
		public StereoTargetEyeMask stereoTargetEye { get; set; }
		//
		// Summary:
		//     Determines whether the stereo view matrices are suitable to allow for a single
		//     pass cull.
		public bool areVRStereoViewMatricesWithinSingleCullTolerance { get; }
		//
		// Summary:
		//     Distance to a point where virtual eyes converge.
		public float stereoConvergence { get; set; }
		//
		// Summary:
		//     The distance between the virtual eyes. Use this to query or set the current eye
		//     separation. Note that most VR devices provide this value, in which case setting
		//     the value will have no effect.
		public float stereoSeparation { get; set; }
		//
		// Summary:
		//     Stereoscopic rendering.
		public bool stereoEnabled { get; }
		//
		// Summary:
		//     If not null, the camera will only render the contents of the specified Scene.
		public Scene scene { get; set; }
		//
		// Summary:
		//     Get the view projection matrix used on the last frame.
		public Matrix4x4 previousViewProjectionMatrix { get; }
		//
		// Summary:
		//     The lens offset of the camera. The lens shift is relative to the sensor size.
		//     For example, a lens shift of 0.5 offsets the sensor by half its horizontal size.
		public Vector2 lensShift { get; set; }
		//
		// Summary:
		//     Should the jittered matrix be used for transparency rendering?
		[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
		public bool useJitteredProjectionMatrixForTransparentRendering { get; set; }
		//
		// Summary:
		//     Set a custom projection matrix.
		public Matrix4x4 projectionMatrix { get; set; }
		//
		// Summary:
		//     Matrix that transforms from world to camera space.
		public Matrix4x4 worldToCameraMatrix { get; set; }
		//
		// Summary:
		//     Matrix that transforms from camera space to world space (Read Only).
		public Matrix4x4 cameraToWorldMatrix { get; }
		*/
		//
		// Summary:
		//     Set the target display for this Camera.
		public int targetDisplay { get; set; }
		
		//
		// Summary:
		//     Gets the temporary RenderTexture target for this Camera.
		//public RenderTexture activeTexture { get; }
		//
		// Summary:
		//     Destination render texture.
		//public RenderTexture targetTexture { get; set; }
		//
		// Summary:
		//     How tall is the camera in pixels (accounting for dynamic resolution scaling)
		//     (Read Only).
		public int scaledPixelHeight { get; }
		//
		// Summary:
		//     How wide is the camera in pixels (accounting for dynamic resolution scaling)
		//     (Read Only).
		public int scaledPixelWidth { get; }
		//
		// Summary:
		//     How tall is the camera in pixels (not accounting for dynamic resolution scaling)
		//     (Read Only).
		public int pixelHeight { get; }
		//
		// Summary:
		//     How wide is the camera in pixels (not accounting for dynamic resolution scaling)
		//     (Read Only).
		public int pixelWidth { get; }
		//
		// Summary:
		//     The far clipping plane distance.
		[NativeProperty("Far")]
		public float farClipPlane { get; set; }
		//
		// Summary:
		//     Where on the screen is the camera rendered in normalized coordinates.
		[NativeProperty("NormalizedViewportRect")]
		public Rect rect { get; set; }
		//
		// Summary:
		//     Render only once and use resulting image for both eyes.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property stereoMirrorMode is no longer supported. Please use single pass stereo rendering instead.", true)]
		public bool stereoMirrorMode { get; set; }
		//
		// Summary:
		//     Get or set the raw projection matrix with no camera offset (no jittering).
		public Matrix4x4 nonJitteredProjectionMatrix { get; set; }
		//
		// Summary:
		//     Where on the screen is the camera rendered in pixel coordinates.
		[NativeProperty("ScreenViewportRect")]
		public Rect pixelRect { get; set; }
		//
		// Summary:
		//     The near clipping plane distance.
		[NativeProperty("Near")]
		public float nearClipPlane { get; set; }

		//public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters = default);
		//
		// Summary:
		//     Converts field of view to focal length. Use either sensor height and vertical
		//     field of view or sensor width and horizontal field of view.
		//
		// Parameters:
		//   fieldOfView:
		//     field of view in degrees.
		//
		//   sensorSize:
		//     Sensor size in millimeters.
		//
		// Returns:
		//     Focal length in millimeters.
		[NativeName("FieldOfViewToFocalLength_Safe")]
		public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Converts focal length to field of view.
		//
		// Parameters:
		//   focalLength:
		//     Focal length in millimeters.
		//
		//   sensorSize:
		//     Sensor size in millimeters. Use the sensor height to get the vertical field of
		//     view. Use the sensor width to get the horizontal field of view.
		//
		// Returns:
		//     field of view in degrees.
		[NativeName("FocalLengthToFieldOfView_Safe")]
		public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Fills an array of Camera with the current cameras in the Scene, without allocating
		//     a new array.
		//
		// Parameters:
		//   cameras:
		//     An array to be filled up with cameras currently in the Scene.
		public static int GetAllCameras(Camera[] cameras) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Converts the horizontal field of view (FOV) to the vertical FOV, based on the
		//     value of the aspect ratio parameter.
		//
		// Parameters:
		//   horizontalFOV:
		//     The horizontal FOV value in degrees.
		//
		//   aspectRatio:
		//     The aspect ratio value used for the conversion
		//
		//   horizontalFieldOfView:
		[NativeName("HorizontalToVerticalFieldOfView_Safe")]
		public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { throw new System.NotImplementedException(); }
		[FreeFunction("CameraScripting::SetupCurrent")]
		public static void SetupCurrent(Camera cur) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Converts the vertical field of view (FOV) to the horizontal FOV, based on the
		//     value of the aspect ratio parameter.
		//
		// Parameters:
		//   verticalFieldOfView:
		//     The vertical FOV value in degrees.
		//
		//   aspectRatio:
		//     The aspect ratio value used for the conversion
		public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Add a command buffer to be executed at a specified place.
		//
		// Parameters:
		//   evt:
		//     When to execute the command buffer during rendering.
		//
		//   buffer:
		//     The buffer to execute.
		//public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Adds a command buffer to the GPU's async compute queues and executes that command
		//     buffer when graphics processing reaches a given point.
		//
		// Parameters:
		//   evt:
		//     The point during the graphics processing at which this command buffer should
		//     commence on the GPU.
		//
		//   buffer:
		//     The buffer to execute.
		//
		//   queueType:
		//     The desired async compute queue type to execute the buffer on.
		//public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { throw new System.NotImplementedException(); }
		//public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calculates and returns oblique near-plane projection matrix.
		//
		// Parameters:
		//   clipPlane:
		//     Vector4 that describes a clip plane.
		//
		// Returns:
		//     Oblique near-plane projection matrix.
		[FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = true)]
		public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Makes this camera's settings match other camera.
		//
		// Parameters:
		//   other:
		//     Copy camera settings to the other camera.
		[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = true)]
		public void CopyFrom(Camera other) { throw new System.NotImplementedException(); }
		public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { throw new System.NotImplementedException(); }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Camera.DoClear has been deprecated (UnityUpgradable).", true)]
		public void DoClear() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get command buffers to be executed at a specified place.
		//
		// Parameters:
		//   evt:
		//     When to execute the command buffer during rendering.
		//
		// Returns:
		//     Array of command buffers.
		//[FreeFunction("CameraScripting::GetCommandBuffers", HasExplicitThis = true)]
		//public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Retrieves the effective vertical field of view of the camera, including GateFit.
		//     Fitting the sensor gate and the resolution gate has an impact on the final field
		//     of view. If the sensor gate aspect ratio is the same as the resolution gate aspect
		//     ratio or if the camera is not in physical mode, then this method returns the
		//     same value as the fieldofview property.
		//
		// Returns:
		//     Returns the effective vertical field of view.
		public float GetGateFittedFieldOfView() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Retrieves the effective lens offset of the camera, including GateFit. Fitting
		//     the sensor gate and the resolution gate has an impact on the final obliqueness
		//     of the projection. If the sensor gate aspect ratio is the same as the resolution
		//     gate aspect ratio, then this method returns the same value as the lenshift property.
		//     If the camera is not in physical mode, then this methods returns Vector2.zero.
		//
		// Returns:
		//     Returns the effective lens shift value.
		public Vector2 GetGateFittedLensShift() { throw new System.NotImplementedException(); }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Camera.GetScreenHeight has been deprecated. Use Screen.height instead (UnityUpgradable) -> Screen.height", true)]
		public float GetScreenHeight() { throw new System.NotImplementedException(); }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Camera.GetScreenWidth has been deprecated. Use Screen.width instead (UnityUpgradable) -> Screen.width", true)]
		public float GetScreenWidth() { throw new System.NotImplementedException(); }
		public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { throw new System.NotImplementedException(); }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Camera.GetStereoProjectionMatrices has been deprecated. Use GetStereoProjectionMatrix(StereoscopicEye eye) instead.", false)]
		public Matrix4x4[] GetStereoProjectionMatrices() { throw new System.NotImplementedException(); }
		[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = true)]
		public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { throw new System.NotImplementedException(); }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Camera.GetStereoViewMatrices has been deprecated. Use GetStereoViewMatrix(StereoscopicEye eye) instead.", false)]
		public Matrix4x4[] GetStereoViewMatrices() { throw new System.NotImplementedException(); }
		[FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = true)]
		public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Remove all command buffers set on this camera.
		public void RemoveAllCommandBuffers() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Remove command buffer from execution at a specified place.
		//
		// Parameters:
		//   evt:
		//     When to execute the command buffer during rendering.
		//
		//   buffer:
		//     The buffer to execute.
		//public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Remove command buffers from execution at a specified place.
		//
		// Parameters:
		//   evt:
		//     When to execute the command buffer during rendering.
		//public void RemoveCommandBuffers(CameraEvent evt) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Render the camera manually.
		[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
		public void Render() { throw new System.NotImplementedException(); }
		[FreeFunction("CameraScripting::RenderDontRestore", HasExplicitThis = true)]
		public void RenderDontRestore() { throw new System.NotImplementedException(); }
		//public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Render into a static cubemap from this camera.
		//
		// Parameters:
		//   cubemap:
		//     The cube map to render to.
		//
		//   faceMask:
		//     A bitmask which determines which of the six faces are rendered to.
		//
		// Returns:
		//     False if rendering fails, else true.
		//public bool RenderToCubemap(Cubemap cubemap, int faceMask) { throw new System.NotImplementedException(); }
		//public bool RenderToCubemap(Cubemap cubemap) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Render into a cubemap from this camera.
		//
		// Parameters:
		//   faceMask:
		//     A bitfield indicating which cubemap faces should be rendered into.
		//
		//   cubemap:
		//     The texture to render to.
		//
		// Returns:
		//     False if rendering fails, else true.
		//public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { throw new System.NotImplementedException(); }
		//public bool RenderToCubemap(RenderTexture cubemap) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Render the camera with shader replacement.
		//
		// Parameters:
		//   shader:
		//
		//   replacementTag:
		//[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = true)]
		//public void RenderWithShader(Shader shader, string replacementTag) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Revert all camera parameters to default.
		public void Reset() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Revert the aspect ratio to the screen's aspect ratio.
		public void ResetAspect() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Make culling queries reflect the camera's built in parameters.
		public void ResetCullingMatrix() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Reset to the default field of view.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Camera.ResetFieldOfView has been deprecated in Unity 5.6 and will be removed in the future. Please replace it by explicitly setting the camera's FOV to 60 degrees.", false)]
		public void ResetFieldOfView() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Make the projection reflect normal camera's parameters.
		public void ResetProjectionMatrix() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Remove shader replacement from camera.
		public void ResetReplacementShader() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Reset the camera to using the Unity computed projection matrices for all stereoscopic
		//     eyes.
		public void ResetStereoProjectionMatrices() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Reset the camera to using the Unity computed view matrices for all stereoscopic
		//     eyes.
		public void ResetStereoViewMatrices() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Resets this Camera's transparency sort settings to the default. Default transparency
		//     settings are taken from GraphicsSettings instead of directly from this Camera.
		public void ResetTransparencySortSettings() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Make the rendering position reflect the camera's position in the Scene.
		public void ResetWorldToCameraMatrix() { throw new System.NotImplementedException(); }
		public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a ray going from camera through a screen point.
		//
		// Parameters:
		//   eye:
		//     Optional argument that can be used to specify which eye transform to use. Default
		//     is Mono.
		//
		//   pos:
		public Ray ScreenPointToRay(Vector3 pos) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms position from screen space into viewport space.
		//
		// Parameters:
		//   position:
		public Vector3 ScreenToViewportPoint(Vector3 position) { throw new System.NotImplementedException(); }
		public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms a point from screen space into world space, where world space is defined
		//     as the coordinate system at the very top of your game's hierarchy.
		//
		// Parameters:
		//   position:
		//     A screen space position (often mouse x, y), plus a z position for depth (for
		//     example, a camera clipping plane).
		//
		//   eye:
		//     By default, Camera.MonoOrStereoscopicEye.Mono. Can be set to Camera.MonoOrStereoscopicEye.Left
		//     or Camera.MonoOrStereoscopicEye.Right for use in stereoscopic rendering (e.g.,
		//     for VR).
		//
		// Returns:
		//     The worldspace point created by converting the screen space point at the provided
		//     distance z from the camera plane.
		public Vector3 ScreenToWorldPoint(Vector3 position) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Make the camera render with shader replacement.
		//
		// Parameters:
		//   shader:
		//
		//   replacementTag:
		//public void SetReplacementShader(Shader shader, string replacementTag) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets custom projection matrices for both the left and right stereoscopic eyes.
		//
		// Parameters:
		//   leftMatrix:
		//     Projection matrix for the stereoscopic left eye.
		//
		//   rightMatrix:
		//     Projection matrix for the stereoscopic right eye.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Camera.SetStereoProjectionMatrices has been deprecated. Use SetStereoProjectionMatrix(StereoscopicEye eye) instead.", false)]
		public void SetStereoProjectionMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix) { throw new System.NotImplementedException(); }
		public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Set custom view matrices for both eyes.
		//
		// Parameters:
		//   leftMatrix:
		//     View matrix for the stereo left eye.
		//
		//   rightMatrix:
		//     View matrix for the stereo right eye.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Camera.SetStereoViewMatrices has been deprecated. Use SetStereoViewMatrix(StereoscopicEye eye) instead.", false)]
		public void SetStereoViewMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix) { throw new System.NotImplementedException(); }
		public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the Camera to render to the chosen buffers of one or more RenderTextures.
		//
		// Parameters:
		//   colorBuffer:
		//     The RenderBuffer(s) to which color information will be rendered.
		//
		//   depthBuffer:
		//     The RenderBuffer to which depth information will be rendered.
		//public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the Camera to render to the chosen buffers of one or more RenderTextures.
		//
		// Parameters:
		//   colorBuffer:
		//     The RenderBuffer(s) to which color information will be rendered.
		//
		//   depthBuffer:
		//     The RenderBuffer to which depth information will be rendered.
		//public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { throw new System.NotImplementedException(); }
		//public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { throw new System.NotImplementedException(); }
		//public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { throw new System.NotImplementedException(); }
		public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a ray going from camera through a viewport point.
		//
		// Parameters:
		//   eye:
		//     Optional argument that can be used to specify which eye transform to use. Default
		//     is Mono.
		//
		//   pos:
		public Ray ViewportPointToRay(Vector3 pos) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms position from viewport space into screen space.
		//
		// Parameters:
		//   position:
		public Vector3 ViewportToScreenPoint(Vector3 position) { throw new System.NotImplementedException(); }
		public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms position from viewport space into world space.
		//
		// Parameters:
		//   position:
		//     The 3d vector in Viewport space.
		//
		// Returns:
		//     The 3d vector in World space.
		public Vector3 ViewportToWorldPoint(Vector3 position) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms position from world space into screen space.
		//
		// Parameters:
		//   eye:
		//     Optional argument that can be used to specify which eye transform to use. Default
		//     is Mono.
		//
		//   position:
		public Vector3 WorldToScreenPoint(Vector3 position) { throw new System.NotImplementedException(); }
		public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { throw new System.NotImplementedException(); }
		public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms position from world space into viewport space.
		//
		// Parameters:
		//   eye:
		//     Optional argument that can be used to specify which eye transform to use. Default
		//     is Mono.
		//
		//   position:
		public Vector3 WorldToViewportPoint(Vector3 position) { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Enum used to specify either the left or the right eye of a stereoscopic camera.
		public enum StereoscopicEye
		{
			//
			// Summary:
			//     Specifies the target to be the left eye.
			Left = 0,
			//
			// Summary:
			//     Specifies the target to be the right eye.
			Right = 1
		}
		//
		// Summary:
		//     A Camera eye corresponding to the left or right human eye for stereoscopic rendering,
		//     or neither for non-stereoscopic rendering. A single Camera can render both left
		//     and right views in a single frame. Therefore, this enum describes which eye the
		//     Camera is currently rendering when returned by Camera.stereoActiveEye during
		//     a rendering callback (such as Camera.OnRenderImage), or which eye to act on when
		//     passed into a function. The default value is Camera.MonoOrStereoscopicEye.Left,
		//     so Camera.MonoOrStereoscopicEye.Left may be returned by some methods or properties
		//     when called outside of rendering if stereoscopic rendering is enabled.
		public enum MonoOrStereoscopicEye
		{
			//
			// Summary:
			//     Camera eye corresponding to stereoscopic rendering of the left eye.
			Left = 0,
			//
			// Summary:
			//     Camera eye corresponding to stereoscopic rendering of the right eye.
			Right = 1,
			//
			// Summary:
			//     Camera eye corresponding to non-stereoscopic rendering.
			Mono = 2
		}
		//
		// Summary:
		//     Enum used to specify how the sensor gate (sensor frame) defined by Camera.sensorSize
		//     fits into the resolution gate (render frame).
		public enum GateFitMode
		{
			//
			// Summary:
			//     Stretch the sensor gate to fit exactly into the resolution gate.
			None = 0,
			//
			// Summary:
			//     Fit the resolution gate vertically within the sensor gate.
			Vertical = 1,
			//
			// Summary:
			//     Fit the resolution gate horizontally within the sensor gate.
			Horizontal = 2,
			//
			// Summary:
			//     Automatically selects a horizontal or vertical fit so that the sensor gate fits
			//     completely inside the resolution gate.
			Fill = 3,
			//
			// Summary:
			//     Automatically selects a horizontal or vertical fit so that the render frame fits
			//     completely inside the resolution gate.
			Overscan = 4
		}
		//
		// Summary:
		//     Enumerates which axis to use when expressing the value for the field of view.
		//     The default value is Camera.FieldOfViewAxis.Vertical.
		public enum FieldOfViewAxis
		{
			//
			// Summary:
			//     Specifies the field of view as vertical.
			Vertical = 0,
			//
			// Summary:
			//     Specifies the field of view as horizontal.
			Horizontal = 1
		}

		//
		// Summary:
		//     Wrapper for gate fit parameters
		public struct GateFitParameters
		{
			public GateFitParameters(GateFitMode mode, float aspect) { throw new System.NotImplementedException(); }

			//
			// Summary:
			//     GateFitMode to use. See Camera.GateFitMode.
			public GateFitMode mode { get; set; }
			//
			// Summary:
			//     Aspect ratio of the resolution gate.
			public float aspect { get; set; }
		}
		
		//
		// Summary:
		//     Delegate type for camera callbacks.
		//
		// Parameters:
		//   cam:
		public delegate void CameraCallback(Camera cam);
	}
	
}