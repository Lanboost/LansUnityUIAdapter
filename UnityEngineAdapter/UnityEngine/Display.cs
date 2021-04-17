
using System;
namespace UnityEngine
{
	public class Display
	{
		//
		// Summary:
		//     The list of currently connected Displays. Contains at least one (main) display.
		public static Display[] displays;

		//
		// Summary:
		//     Main Display.
		public static Display main { get; }
		//
		// Summary:
		//     True when doing a blit to the back buffer requires manual color space conversion.
		public bool requiresSrgbBlitToBackbuffer { get; }
		//
		// Summary:
		//     True when the back buffer requires an intermediate texture to render.
		public bool requiresBlitToBackbuffer { get; }
		//
		// Summary:
		//     Gets the state of the display and returns true if the display is active and false
		//     if otherwise.
		public bool active { get; }
		//
		// Summary:
		//     Depth RenderBuffer.
		//public RenderBuffer depthBuffer { get; }
		//
		// Summary:
		//     Color RenderBuffer.
		//public RenderBuffer colorBuffer { get; }
		//
		// Summary:
		//     Vertical native display resolution.
		public int systemHeight { get; }
		//
		// Summary:
		//     Horizontal native display resolution.
		public int systemWidth { get; }
		//
		// Summary:
		//     Horizontal resolution that the display is rendering at.
		public int renderingWidth { get; }
		//
		// Summary:
		//     Vertical resolution that the display is rendering at.
		public int renderingHeight { get; }

		public static event DisplaysUpdatedDelegate onDisplaysUpdated;

		//[Obsolete("MultiDisplayLicense has been deprecated.", false)]
		//public static bool MultiDisplayLicense();
		//
		// Summary:
		//     Query relative mouse coordinates.
		//
		// Parameters:
		//   inputMouseCoordinates:
		//     Mouse Input Position as Coordinates.
		
		public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) {
			return Vector3.zero;
		}
		//
		// Summary:
		//     This overloaded function available for Windows allows specifying desired Window
		//     Width, Height and Refresh Rate.
		//
		// Parameters:
		//   width:
		//     Desired Width of the Window (for Windows only. On Linux and Mac uses Screen Width).
		//
		//   height:
		//     Desired Height of the Window (for Windows only. On Linux and Mac uses Screen
		//     Height).
		//
		//   refreshRate:
		//     Desired Refresh Rate.
		//public void Activate(int width, int height, int refreshRate);
		//
		// Summary:
		//     Activate an external display. Eg. Secondary Monitors connected to the System.
		//public void Activate();
		//
		// Summary:
		//     Set rendering size and position on screen (Windows only).
		//
		// Parameters:
		//   width:
		//     Change Window Width (Windows Only).
		//
		//   height:
		//     Change Window Height (Windows Only).
		//
		//   x:
		//     Change Window Position X (Windows Only).
		//
		//   y:
		//     Change Window Position Y (Windows Only).
		//public void SetParams(int width, int height, int x, int y);
		//
		// Summary:
		//     Sets rendering resolution for the display.
		//
		// Parameters:
		//   w:
		//     Rendering width in pixels.
		//
		//   h:
		//     Rendering height in pixels.
		//public void SetRenderingResolution(int w, int h);

		public delegate void DisplaysUpdatedDelegate();
	}
}