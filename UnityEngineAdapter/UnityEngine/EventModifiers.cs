#region Assembly UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;

namespace UnityEngine
{
	//
	// Summary:
	//     Types of modifier key that can be active during a keystroke event.
	[Flags]
	public enum EventModifiers
	{
		//
		// Summary:
		//     No modifier key pressed during a keystroke event.
		None = 0,
		//
		// Summary:
		//     Shift key.
		Shift = 1,
		//
		// Summary:
		//     Control key.
		Control = 2,
		//
		// Summary:
		//     Alt key.
		Alt = 4,
		//
		// Summary:
		//     Command key (Mac).
		Command = 8,
		//
		// Summary:
		//     Num lock key.
		Numeric = 16,
		//
		// Summary:
		//     Caps lock key.
		CapsLock = 32,
		//
		// Summary:
		//     Function key.
		FunctionKey = 64
	}
}