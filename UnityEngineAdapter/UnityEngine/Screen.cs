#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
	//
	// Summary:
	//     Access to display information.
	public sealed class Screen
	{
		public Screen() { }

		//
		// Summary:
		//     Set this property to one of the values in FullScreenMode to change the display
		//     mode of your application.
		//public static FullScreenMode fullScreenMode { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property GetResolution has been deprecated. Use resolutions instead (UnityUpgradable) -> resolutions", true)]
		public static Resolution[] GetResolution { get; }
		//
		// Summary:
		//     The current brightness of the screen.
		public static float brightness { get; set; }
		//
		// Summary:
		//     A power saving setting, allowing the screen to dim some time after the last active
		//     user interaction.
		public static int sleepTimeout { get; set; }
		//
		// Summary:
		//     Specifies logical orientation of the screen.
		//public static ScreenOrientation orientation { get; set; }
		//
		// Summary:
		//     Allow auto-rotation to landscape right?
		public static bool autorotateToLandscapeRight { get; set; }
		//
		// Summary:
		//     Allow auto-rotation to landscape left?
		public static bool autorotateToLandscapeLeft { get; set; }
		//
		// Summary:
		//     Allow auto-rotation to portrait, upside down?
		public static bool autorotateToPortraitUpsideDown { get; set; }
		//
		// Summary:
		//     Allow auto-rotation to portrait?
		public static bool autorotateToPortrait { get; set; }
		//
		// Summary:
		//     Returns a list of screen areas that are not functional for displaying content
		//     (Read Only).
		public static Rect[] cutouts { get; }
		//
		// Summary:
		//     Returns the safe area of the screen in pixels (Read Only).
		public static Rect safeArea { get; }
		//
		// Summary:
		//     Should the cursor be locked?
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Cursor.lockState and Cursor.visible instead.", false)]
		public static bool lockCursor { get; set; }
		//
		// Summary:
		//     Is the game running full-screen?
		public static bool fullScreen { get; set; }
		//
		// Summary:
		//     All full-screen resolutions supported by the monitor (Read Only).
		public static Resolution[] resolutions { get; }
		//
		// Summary:
		//     The current screen resolution (Read Only).
		public static Resolution currentResolution { get; }
		//
		// Summary:
		//     The current DPI of the screen / device (Read Only).
		public static float dpi { get; }
		//
		// Summary:
		//     The current height of the screen window in pixels (Read Only).
		public static int height { get; set; }
		//
		// Summary:
		//     The current width of the screen window in pixels (Read Only).
		public static int width { get; set; }
		//
		// Summary:
		//     Should the cursor be visible?
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property showCursor has been deprecated. Use Cursor.visible instead (UnityUpgradable) -> UnityEngine.Cursor.visible", true)]
		public static bool showCursor { get; set; }

		//
		// Summary:
		//     Switches the screen resolution.
		//
		// Parameters:
		//   width:
		//
		//   height:
		//
		//   fullscreen:
		//
		//   preferredRefreshRate:
		//
		//   fullscreenMode:
		//public static void SetResolution(int width, int height, bool fullscreen);
		//
		// Summary:
		//     Switches the screen resolution.
		//
		// Parameters:
		//   width:
		//
		//   height:
		//
		//   fullscreen:
		//
		//   preferredRefreshRate:
		//
		//   fullscreenMode:
		//public static void SetResolution(int width, int height, bool fullscreen, [Internal.DefaultValue("0")] int preferredRefreshRate);
		//public static void SetResolution(int width, int height, FullScreenMode fullscreenMode);
		//
		// Summary:
		//     Switches the screen resolution.
		//
		// Parameters:
		//   width:
		//
		//   height:
		//
		//   fullscreen:
		//
		//   preferredRefreshRate:
		//
		//   fullscreenMode:
		//public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, [Internal.DefaultValue("0")] int preferredRefreshRate);
	}
}