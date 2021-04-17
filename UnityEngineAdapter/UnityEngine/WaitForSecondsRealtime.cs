#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
	//
	// Summary:
	//     Suspends the coroutine execution for the given amount of seconds using unscaled
	//     time.
	public class WaitForSecondsRealtime : CustomYieldInstruction
	{
		//
		// Summary:
		//     Creates a yield instruction to wait for a given number of seconds using unscaled
		//     time.
		//
		// Parameters:
		//   time:
		public WaitForSecondsRealtime(float time) { }

		//
		// Summary:
		//     The given amount of seconds that the yield instruction will wait for.
		public float waitTime { get; set; }
		public override bool keepWaiting { get; }
	}
}