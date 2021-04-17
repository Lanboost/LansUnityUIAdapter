#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections;

namespace UnityEngine
{
	//
	// Summary:
	//     Base class for custom yield instructions to suspend coroutines.
	public abstract class CustomYieldInstruction : IEnumerator
	{
		protected CustomYieldInstruction() { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Indicates if coroutine should be kept suspended.
		public abstract bool keepWaiting { get; }
		public object Current { get; }

		public bool MoveNext() { throw new System.NotImplementedException(); }
		public void Reset() { throw new System.NotImplementedException(); }
	}
}