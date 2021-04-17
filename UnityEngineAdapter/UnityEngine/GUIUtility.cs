#region Assembly UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;

namespace UnityEngine
{

	public class GUIUtility
	{
		public GUIUtility() { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     The controlID of the control that has keyboard focus.
		public static int keyboardControl { get; set; }
		//
		// Summary:
		//     Get access to the system-wide clipboard.
		public static string systemCopyBuffer { get; set; }
		//
		// Summary:
		//     A global property, which is true if a ModalWindow is being displayed, false otherwise.
		public static bool hasModalWindow { get; }
		//
		// Summary:
		//     The controlID of the current hot control.
		public static int hotControl { get; set; }

		public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Align a local space rectangle to the pixel grid.
		//
		// Parameters:
		//   local:
		//     The local space rectangle that needs to be processed.
		//
		//   widthInPixels:
		//     Width, in pixel units, of the axis-aligned bounding box that encompasses the
		//     aligned points.
		//
		//   heightInPixels:
		//     Height, in pixel units, of the axis-aligned bounding box that encompasses the
		//     aligned points.
		//
		//   rect:
		//
		// Returns:
		//     The aligned rectangle in local space.
		public static Rect AlignRectToDevice(Rect rect) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Puts the GUI in a state that will prevent all subsequent immediate mode GUI functions
		//     from evaluating for the remainder of the GUI loop by throwing an ExitGUIException.
		public static void ExitGUI() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a unique ID for a control, using an integer as a hint to help ensure correct
		//     matching of IDs to controls.
		//
		// Parameters:
		//   hint:
		//
		//   focus:
		//
		//   focusType:
		//
		//   rect:

		//public static int GetControlID(int hint, FocusType focusType, Rect rect) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a unique ID for a control, using an integer as a hint to help ensure correct
		//     matching of IDs to controls.
		//
		// Parameters:
		//   hint:
		//
		//   focus:
		//
		//   focusType:
		//
		//   rect:
		//public static int GetControlID(int hint, FocusType focus) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a unique ID for a control, using a the label content as a hint to help ensure
		//     correct matching of IDs to controls.
		//
		// Parameters:
		//   contents:
		//
		//   focus:
		//
		//   position:
		//public static int GetControlID(GUIContent contents, FocusType focus, Rect position) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a unique ID for a control.
		//
		// Parameters:
		//   focus:
		//
		//   position:
		//public static int GetControlID(FocusType focus, Rect position) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a unique ID for a control, using a the label content as a hint to help ensure
		//     correct matching of IDs to controls.
		//
		// Parameters:
		//   contents:
		//
		//   focus:
		//
		//   position:
		//public static int GetControlID(GUIContent contents, FocusType focus) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a unique ID for a control.
		//
		// Parameters:
		//   focus:
		//
		//   position:
		//public static int GetControlID(FocusType focus) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a state object from a controlID.
		//
		// Parameters:
		//   t:
		//
		//   controlID:
		public static object GetStateObject(Type t, int controlID) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Convert a point from GUI position to screen space.
		//
		// Parameters:
		//   guiPoint:
		public static Vector2 GUIToScreenPoint(Vector2 guiPoint) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Convert a rect from GUI position to screen space.
		//
		// Parameters:
		//   guiRect:
		public static Rect GUIToScreenRect(Rect guiRect) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get an existing state object from a controlID.
		//
		// Parameters:
		//   t:
		//
		//   controlID:
		public static object QueryStateObject(Type t, int controlID) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Helper function to rotate the GUI around a point.
		//
		// Parameters:
		//   angle:
		//
		//   pivotPoint:
		public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Helper function to scale the GUI around a point.
		//
		// Parameters:
		//   scale:
		//
		//   pivotPoint:
		public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Convert a point from screen space to GUI position.
		//
		// Parameters:
		//   screenPoint:
		public static Vector2 ScreenToGUIPoint(Vector2 screenPoint) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Convert a rect from screen space to GUI position.
		//
		// Parameters:
		//   screenRect:
		public static Rect ScreenToGUIRect(Rect screenRect) { throw new System.NotImplementedException(); }
	}
}