namespace UnityEngine
{
	//
	// Summary:
	//     Enumeration of the different types of supported touchscreen keyboards.
	public enum TouchScreenKeyboardType
	{
		//
		// Summary:
		//     The default keyboard layout of the target platform.
		Default = 0,
		//
		// Summary:
		//     Keyboard with standard ASCII keys.
		ASCIICapable = 1,
		//
		// Summary:
		//     Keyboard with numbers and punctuation mark keys.
		NumbersAndPunctuation = 2,
		//
		// Summary:
		//     Keyboard with keys for URL entry.
		URL = 3,
		//
		// Summary:
		//     Keyboard with standard numeric keys.
		NumberPad = 4,
		//
		// Summary:
		//     Keyboard with a layout suitable for typing telephone numbers.
		PhonePad = 5,
		//
		// Summary:
		//     Keyboard with alphanumeric keys.
		NamePhonePad = 6,
		//
		// Summary:
		//     Keyboard with additional keys suitable for typing email addresses.
		EmailAddress = 7,
		//
		// Summary:
		//     Keyboard for the Nintendo Network (Deprecated).
		NintendoNetworkAccount = 8,
		//
		// Summary:
		//     Keyboard with symbol keys often used on social media, such as Twitter.
		Social = 9,
		//
		// Summary:
		//     Keyboard with the "." key beside the space key, suitable for typing search terms.
		Search = 10,
		//
		// Summary:
		//     Keyboard with numbers and a decimal point.
		DecimalPad = 11
	}
}