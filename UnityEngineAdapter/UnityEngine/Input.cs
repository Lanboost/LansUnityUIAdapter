#region Assembly UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.InputLegacyModule.dll
#endregion

using System;

namespace UnityEngine
{

	public class Input
	{
		public Input() { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Returns the keyboard input entered this frame. (Read Only)

		public static string inputString { get; }
		//
		// Summary:
		//     Controls enabling and disabling of IME input composition.
		public static IMECompositionMode imeCompositionMode { get; set; }
		//
		// Summary:
		//     The current IME composition string being typed by the user.
		public static string compositionString { get; }
		//
		// Summary:
		//     Does the user have an IME keyboard input source selected?
		public static bool imeIsSelected { get; }
		//
		// Summary:
		//     The current text input position used by IMEs to open windows.
		public static Vector2 compositionCursorPos { get; set; }
		//
		// Summary:
		//     Property indicating whether keypresses are eaten by a textinput if it has focus
		//     (default true).
		[Obsolete("eatKeyPressOnTextFieldFocus property is deprecated, and only provided to support legacy behavior.")]
		public static bool eatKeyPressOnTextFieldFocus { get; set; }
		//
		// Summary:
		//     Indicates if a mouse device is detected.
		public static bool mousePresent {
			get => true;
		}
		//
		// Summary:
		//     Number of touches. Guaranteed not to change throughout the frame. (Read Only)
		public static int touchCount { get; }
		//
		// Summary:
		//     Bool value which let's users check if touch pressure is supported.
		public static bool touchPressureSupported { get; }
		//
		// Summary:
		//     Returns true when Stylus Touch is supported by a device or platform.
		public static bool stylusTouchSupported { get; }
		//
		// Summary:
		//     Returns whether the device on which application is currently running supports
		//     touch input.
		public static bool touchSupported { get; }
		//
		// Summary:
		//     Property indicating whether the system handles multiple touches.
		public static bool multiTouchEnabled { get; set; }
		[Obsolete("isGyroAvailable property is deprecated. Please use SystemInfo.supportsGyroscope instead.")]
		public static bool isGyroAvailable { get; }
		//
		// Summary:
		//     Device physical orientation as reported by OS. (Read Only)
		//public static DeviceOrientation deviceOrientation { get; }
		//
		// Summary:
		//     Last measured linear acceleration of a device in three-dimensional space. (Read
		//     Only)
		public static Vector3 acceleration { get; }
		//
		// Summary:
		//     This property controls if input sensors should be compensated for screen orientation.
		public static bool compensateSensors { get; set; }
		//
		// Summary:
		//     Number of acceleration measurements which occurred during last frame.
		public static int accelerationEventCount { get; }
		//
		// Summary:
		//     Should Back button quit the application? Only usable on Android, Windows Phone
		//     or Windows Tablets.
		public static bool backButtonLeavesApp { get; set; }
		//
		// Summary:
		//     Property for accessing device location (handheld devices only). (Read Only)
		//public static LocationService location { get; }
		//
		// Summary:
		//     Property for accessing compass (handheld devices only). (Read Only)
		//public static Compass compass { get; }
		//
		// Summary:
		//     Returns default gyroscope.
		//public static Gyroscope gyro { get; }
		//
		// Summary:
		//     The current mouse scroll delta. (Read Only)

		public static Vector2 mouseScrollDelta { get; }
		//
		// Summary:
		//     The current mouse position in pixel coordinates. (Read Only)

		public static Vector3 mousePosition { get; }
		//
		// Summary:
		//     Returns list of acceleration measurements which occurred during the last frame.
		//     (Read Only) (Allocates temporary variables).
		//public static AccelerationEvent[] accelerationEvents { get; }
		//
		// Summary:
		//     Returns true the first frame the user hits any key or mouse button. (Read Only)

		public static bool anyKeyDown { get; }
		//
		// Summary:
		//     Is any key or mouse button currently held down? (Read Only)

		public static bool anyKey { get; }
		//
		// Summary:
		//     Enables/Disables mouse simulation with touches. By default this option is enabled.
		public static bool simulateMouseWithTouches { get; set; }
		//
		// Summary:
		//     Returns list of objects representing status of all touches during last frame.
		//     (Read Only) (Allocates temporary variables).
		public static Touch[] touches { get; }

		//
		// Summary:
		//     Returns specific acceleration measurement which occurred during last frame. (Does
		//     not allocate temporary variables).
		//
		// Parameters:
		//   index:

		//public static AccelerationEvent GetAccelerationEvent(int index) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the value of the virtual axis identified by axisName.
		//
		// Parameters:
		//   axisName:

		public static float GetAxis(string axisName) {
			return 0;
			throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the value of the virtual axis identified by axisName with no smoothing
		//     filtering applied.
		//
		// Parameters:
		//   axisName:

		public static float GetAxisRaw(string axisName) {
			//s.X
			//throw new System.NotImplementedException();
			return 0;
		}
		//
		// Summary:
		//     Returns true while the virtual button identified by buttonName is held down.
		//
		// Parameters:
		//   buttonName:
		//     The name of the button such as Jump.
		//
		// Returns:
		//     True when an axis has been pressed and not released.

		public static bool GetButton(string buttonName) {
			return false;
			throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true during the frame the user pressed down the virtual button identified
		//     by buttonName.
		//
		// Parameters:
		//   buttonName:

		public static bool GetButtonDown(string buttonName) {
			return false;
			throw new System.NotImplementedException();
		}
		//
		// Summary:
		//     Returns true the first frame the user releases the virtual button identified
		//     by buttonName.
		//
		// Parameters:
		//   buttonName:

		public static bool GetButtonUp(string buttonName) {
			return false;
			throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns an array of strings describing the connected joysticks.

		public static string[] GetJoystickNames() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true while the user holds down the key identified by name.
		//
		// Parameters:
		//   name:
		public static bool GetKey(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true while the user holds down the key identified by the key KeyCode
		//     enum parameter.
		//
		// Parameters:
		//   key:
		public static bool GetKey(KeyCode key) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true during the frame the user starts pressing down the key identified
		//     by the key KeyCode enum parameter.
		//
		// Parameters:
		//   key:
		public static bool GetKeyDown(KeyCode key) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true during the frame the user starts pressing down the key identified
		//     by name.
		//
		// Parameters:
		//   name:
		public static bool GetKeyDown(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true during the frame the user releases the key identified by the key
		//     KeyCode enum parameter.
		//
		// Parameters:
		//   key:
		public static bool GetKeyUp(KeyCode key) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true during the frame the user releases the key identified by name.
		//
		// Parameters:
		//   name:
		public static bool GetKeyUp(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns whether the given mouse button is held down.
		//
		// Parameters:
		//   button:

		public static bool GetMouseButton(int button) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true during the frame the user pressed the given mouse button.
		//
		// Parameters:
		//   button:

		public static bool GetMouseButtonDown(int button) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true during the frame the user releases the given mouse button.
		//
		// Parameters:
		//   button:

		public static bool GetMouseButtonUp(int button) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Call Input.GetTouch to obtain a Touch struct.
		//
		// Parameters:
		//   index:
		//     The touch input on the device screen.
		//
		// Returns:
		//     Touch details in the struct.

		public static Touch GetTouch(int index) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Determine whether a particular joystick model has been preconfigured by Unity.
		//     (Linux-only).
		//
		// Parameters:
		//   joystickName:
		//     The name of the joystick to check (returned by Input.GetJoystickNames).
		//
		// Returns:
		//     True if the joystick layout has been preconfigured; false otherwise.
		public static bool IsJoystickPreconfigured(string joystickName) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Resets all input. After ResetInputAxes all axes return to 0 and all buttons return
		//     to 0 for one frame.

		public static void ResetInputAxes() { throw new System.NotImplementedException(); }
	}
}