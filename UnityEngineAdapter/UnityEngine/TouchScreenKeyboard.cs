#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{

	public class TouchScreenKeyboard
	{
		public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { throw new System.NotImplementedException(); }

		~TouchScreenKeyboard() { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Returns portion of the screen which is covered by the keyboard.

		public static Rect area { get; }
		//
		// Summary:
		//     Returns true whenever any keyboard is completely visible on the screen.
		public static bool visible { get; }
		//
		// Summary:
		//     Checks if the text within an input field can be selected and modified while TouchScreenKeyboard
		//     is open.
		//
		// Returns:
		//     Returns true when you are able to select and modify the input field, returns
		//     false otherwise.
		public static bool isInPlaceEditingAllowed { get; }
		//
		// Summary:
		//     Is touch screen keyboard supported.
		public static bool isSupported { get; }
		//
		// Summary:
		//     Will text input field above the keyboard be hidden when the keyboard is on screen?
		public static bool hideInput { get; set; }
		//
		// Summary:
		//     Specifies if input process was canceled. (Read Only)
		[Obsolete("Property wasCanceled is deprecated, use status instead.")]
		public bool wasCanceled { get; }
		//
		// Summary:
		//     Specified on which display the on-screen keyboard will appear.
		public int targetDisplay { get; set; }
		//
		// Summary:
		//     Returns the TouchScreenKeyboardType of the keyboard.
		public TouchScreenKeyboardType type { get; }
		//
		// Summary:
		//     Gets or sets the character range of the selected text within the string currently
		//     being edited.
		public RangeInt selection { get; set; }
		//
		// Summary:
		//     Returns the text displayed by the input field of the keyboard.
		public string text { get; set; }
		//
		// Summary:
		//     Specifies whether the TouchScreenKeyboard supports the selection property. (Read
		//     Only)
		public bool canSetSelection { get; }
		//
		// Summary:
		//     Is the keyboard visible or sliding into the position on the screen?
		public bool active { get; set; }
		//
		// Summary:
		//     Specifies if input process was finished. (Read Only)
		[Obsolete("Property done is deprecated, use status instead")]
		public bool done { get; }
		//
		// Summary:
		//     Specifies whether the TouchScreenKeyboard supports the selection property. (Read
		//     Only)
		public bool canGetSelection { get; }
		//
		// Summary:
		//     Returns the status of the on-screen keyboard. (Read Only)
		public Status status { get; }
		//
		// Summary:
		//     How many characters the keyboard input field is limited to. 0 = infinite.
		public int characterLimit { get; set; }

		//
		// Summary:
		//     Opens the native keyboard provided by OS on the screen.
		//
		// Parameters:
		//   text:
		//     Text to edit.
		//
		//   keyboardType:
		//     Type of keyboard (eg, any text, numbers only, etc).
		//
		//   autocorrection:
		//     Is autocorrection applied?
		//
		//   multiline:
		//     Can more than one line of text be entered?
		//
		//   secure:
		//     Is the text masked (for passwords, etc)?
		//
		//   alert:
		//     Is the keyboard opened in alert mode?
		//
		//   textPlaceholder:
		//     Text to be used if no other text is present.
		//
		//   characterLimit:
		//     How many characters the keyboard input field is limited to. 0 = infinite. (Android
		//     and iOS only)
		public static TouchScreenKeyboard Open(string text, [DefaultValue("TouchScreenKeyboardType.Default")] TouchScreenKeyboardType keyboardType, [DefaultValue("true")] bool autocorrection, [DefaultValue("false")] bool multiline, [DefaultValue("false")] bool secure, [DefaultValue("false")] bool alert, [DefaultValue("\"\"")] string textPlaceholder, [DefaultValue("0")] int characterLimit) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Opens the native keyboard provided by OS on the screen.
		//
		// Parameters:
		//   text:
		//     Text to edit.
		//
		//   keyboardType:
		//     Type of keyboard (eg, any text, numbers only, etc).
		//
		//   autocorrection:
		//     Is autocorrection applied?
		//
		//   multiline:
		//     Can more than one line of text be entered?
		//
		//   secure:
		//     Is the text masked (for passwords, etc)?
		//
		//   alert:
		//     Is the keyboard opened in alert mode?
		//
		//   textPlaceholder:
		//     Text to be used if no other text is present.
		//
		//   characterLimit:
		//     How many characters the keyboard input field is limited to. 0 = infinite. (Android
		//     and iOS only)
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Opens the native keyboard provided by OS on the screen.
		//
		// Parameters:
		//   text:
		//     Text to edit.
		//
		//   keyboardType:
		//     Type of keyboard (eg, any text, numbers only, etc).
		//
		//   autocorrection:
		//     Is autocorrection applied?
		//
		//   multiline:
		//     Can more than one line of text be entered?
		//
		//   secure:
		//     Is the text masked (for passwords, etc)?
		//
		//   alert:
		//     Is the keyboard opened in alert mode?
		//
		//   textPlaceholder:
		//     Text to be used if no other text is present.
		//
		//   characterLimit:
		//     How many characters the keyboard input field is limited to. 0 = infinite. (Android
		//     and iOS only)
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Opens the native keyboard provided by OS on the screen.
		//
		// Parameters:
		//   text:
		//     Text to edit.
		//
		//   keyboardType:
		//     Type of keyboard (eg, any text, numbers only, etc).
		//
		//   autocorrection:
		//     Is autocorrection applied?
		//
		//   multiline:
		//     Can more than one line of text be entered?
		//
		//   secure:
		//     Is the text masked (for passwords, etc)?
		//
		//   alert:
		//     Is the keyboard opened in alert mode?
		//
		//   textPlaceholder:
		//     Text to be used if no other text is present.
		//
		//   characterLimit:
		//     How many characters the keyboard input field is limited to. 0 = infinite. (Android
		//     and iOS only)
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Opens the native keyboard provided by OS on the screen.
		//
		// Parameters:
		//   text:
		//     Text to edit.
		//
		//   keyboardType:
		//     Type of keyboard (eg, any text, numbers only, etc).
		//
		//   autocorrection:
		//     Is autocorrection applied?
		//
		//   multiline:
		//     Can more than one line of text be entered?
		//
		//   secure:
		//     Is the text masked (for passwords, etc)?
		//
		//   alert:
		//     Is the keyboard opened in alert mode?
		//
		//   textPlaceholder:
		//     Text to be used if no other text is present.
		//
		//   characterLimit:
		//     How many characters the keyboard input field is limited to. 0 = infinite. (Android
		//     and iOS only)
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Opens the native keyboard provided by OS on the screen.
		//
		// Parameters:
		//   text:
		//     Text to edit.
		//
		//   keyboardType:
		//     Type of keyboard (eg, any text, numbers only, etc).
		//
		//   autocorrection:
		//     Is autocorrection applied?
		//
		//   multiline:
		//     Can more than one line of text be entered?
		//
		//   secure:
		//     Is the text masked (for passwords, etc)?
		//
		//   alert:
		//     Is the keyboard opened in alert mode?
		//
		//   textPlaceholder:
		//     Text to be used if no other text is present.
		//
		//   characterLimit:
		//     How many characters the keyboard input field is limited to. 0 = infinite. (Android
		//     and iOS only)
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Opens the native keyboard provided by OS on the screen.
		//
		// Parameters:
		//   text:
		//     Text to edit.
		//
		//   keyboardType:
		//     Type of keyboard (eg, any text, numbers only, etc).
		//
		//   autocorrection:
		//     Is autocorrection applied?
		//
		//   multiline:
		//     Can more than one line of text be entered?
		//
		//   secure:
		//     Is the text masked (for passwords, etc)?
		//
		//   alert:
		//     Is the keyboard opened in alert mode?
		//
		//   textPlaceholder:
		//     Text to be used if no other text is present.
		//
		//   characterLimit:
		//     How many characters the keyboard input field is limited to. 0 = infinite. (Android
		//     and iOS only)
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Opens the native keyboard provided by OS on the screen.
		//
		// Parameters:
		//   text:
		//     Text to edit.
		//
		//   keyboardType:
		//     Type of keyboard (eg, any text, numbers only, etc).
		//
		//   autocorrection:
		//     Is autocorrection applied?
		//
		//   multiline:
		//     Can more than one line of text be entered?
		//
		//   secure:
		//     Is the text masked (for passwords, etc)?
		//
		//   alert:
		//     Is the keyboard opened in alert mode?
		//
		//   textPlaceholder:
		//     Text to be used if no other text is present.
		//
		//   characterLimit:
		//     How many characters the keyboard input field is limited to. 0 = infinite. (Android
		//     and iOS only)
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline) { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     The status of the on-screen keyboard.
		public enum Status
		{
			//
			// Summary:
			//     The on-screen keyboard is visible.
			Visible = 0,
			//
			// Summary:
			//     The user has finished providing input.
			Done = 1,
			//
			// Summary:
			//     The on-screen keyboard was canceled.
			Canceled = 2,
			//
			// Summary:
			//     The on-screen keyboard has lost focus.
			LostFocus = 3
		}
	}
}