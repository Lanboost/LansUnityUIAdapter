#region Assembly UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.InputLegacyModule.dll
#endregion

namespace UnityEngine
{
	//
	// Summary:
	//     Describes phase of a finger touch.
	public enum TouchPhase
	{
		//
		// Summary:
		//     A finger touched the screen.
		Began = 0,
		//
		// Summary:
		//     A finger moved on the screen.
		Moved = 1,
		//
		// Summary:
		//     A finger is touching the screen but hasn't moved.
		Stationary = 2,
		//
		// Summary:
		//     A finger was lifted from the screen. This is the final phase of a touch.
		Ended = 3,
		//
		// Summary:
		//     The system cancelled tracking for the touch.
		Canceled = 4
	}
}