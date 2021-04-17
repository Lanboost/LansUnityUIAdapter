#region Assembly UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll
#endregion

using System;

namespace UnityEngine
{
	public sealed class Canvas : Behaviour
	{
		public Canvas() {
			
		}

		//
		// Summary:
		//     The render order in which the canvas is being emitted to the Scene. (Read Only)
		public int renderOrder { get; }
		//
		// Summary:
		//     Returns the Canvas closest to root, by checking through each parent and returning
		//     the last canvas found. If no other canvas is found then the canvas will return
		//     itself.
		public Canvas rootCanvas { get; }
		//
		// Summary:
		//     Name of the Canvas' sorting layer.
		public string sortingLayerName { get; set; }
		//
		// Summary:
		//     Get or set the mask of additional shader channels to be used when creating the
		//     Canvas mesh.
		//public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
		//
		// Summary:
		//     Cached calculated value based upon SortingLayerID.
		public int cachedSortingLayerValue { get; }
		//
		// Summary:
		//     Unique ID of the Canvas' sorting layer.
		public int sortingLayerID { get; set; }
		//
		// Summary:
		//     For Overlay mode, display index on which the UI canvas will appear.
		public int targetDisplay { get; set; }
		//
		// Summary:
		//     Canvas' order within a sorting layer.
		public int sortingOrder { get; set; }
		//
		// Summary:
		//     Override the sorting of canvas.
		public bool overrideSorting { get; set; }
		//
		// Summary:
		//     How far away from the camera is the Canvas generated.
		public float planeDistance { get; set; }
		//
		// Summary:
		//     Force elements in the canvas to be aligned with pixels. Only applies with renderMode
		//     is Screen Space.
		public bool pixelPerfect { get; set; }
		//
		// Summary:
		//     Allows for nested canvases to override pixelPerfect settings inherited from parent
		//     canvases.
		public bool overridePixelPerfect { get; set; }
		//
		// Summary:
		//     The number of pixels per unit that is considered the default.
		public float referencePixelsPerUnit { get; set; }
		//
		// Summary:
		//     Used to scale the entire canvas, while still making it fit the screen. Only applies
		//     with renderMode is Screen Space.
		public float scaleFactor { get; set; }
		//
		// Summary:
		//     Get the render rect for the Canvas.
		public Rect pixelRect { get; }
		//
		// Summary:
		//     Is this the root Canvas?
		public bool isRootCanvas { get; }
		//
		// Summary:
		//     Is the Canvas in World or Overlay mode?
		public RenderMode renderMode { get; set; }
		//
		// Summary:
		//     The normalized grid size that the canvas will split the renderable area into.
		//[NativeProperty("SortingBucketNormalizedSize", false, TargetType.Function)]
		[Obsolete("Setting normalizedSize via a int is not supported. Please use normalizedSortingGridSize", false)]
		public int sortingGridNormalizedSize { get; set; }
		//
		// Summary:
		//     Camera used for sizing the Canvas when in Screen Space - Camera. Also used as
		//     the Camera that events will be sent through for a World Space [[Canvas].
		//[NativeProperty("Camera", false, TargetType.Function)]
		public Camera worldCamera { get; set; }
		//
		// Summary:
		//     The normalized grid size that the canvas will split the renderable area into.
		//[NativeProperty("SortingBucketNormalizedSize", false, TargetType.Function)]
		public float normalizedSortingGridSize { get; set; }

		public static event WillRenderCanvases willRenderCanvases;

		//
		// Summary:
		//     Force all canvases to update their content.
		public static void ForceUpdateCanvases() {
			//throw new System.NotImplementedException();
		}
		//
		// Summary:
		//     Returns the default material that can be used for rendering normal elements on
		//     the Canvas.
		//[FreeFunction("UI::GetDefaultUIMaterial")]
		public static Material GetDefaultCanvasMaterial() {
			return new Material("Nothing");
		}
		//
		// Summary:
		//     Returns the default material that can be used for rendering text elements on
		//     the Canvas.
		//[FreeFunction("UI::GetDefaultUIMaterial")]
		[Obsolete("Shared default material now used for text and general UI elements, call Canvas.GetDefaultCanvasMaterial()", false)]
		public static Material GetDefaultCanvasTextMaterial() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Gets or generates the ETC1 Material.
		//
		// Returns:
		//     The generated ETC1 Material from the Canvas.
		//[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
		public static Material GetETC1SupportedCanvasMaterial() { throw new System.NotImplementedException(); }

		public delegate void WillRenderCanvases();

		internal static void InvokeRender()
		{
			Canvas.willRenderCanvases?.Invoke();
		}
	}
}