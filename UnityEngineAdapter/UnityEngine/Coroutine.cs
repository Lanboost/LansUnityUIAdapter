
namespace UnityEngine
{
	
	public sealed class Coroutine : YieldInstruction
	{
		internal System.Collections.IEnumerator value;
		internal Coroutine(System.Collections.IEnumerator value)
		{
			this.value = value;
		}

		~Coroutine() { //throw new System.NotImplementedException(); 
		}
	}
}