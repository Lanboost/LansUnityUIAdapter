using System;
using System.Collections.Generic;
using System.Text;

namespace UnityEngineAdapter
{
	class CoroutineHandler
	{

		List<System.Collections.IEnumerator> enumerators = new List<System.Collections.IEnumerator>();

		static CoroutineHandler _instance;

		public static CoroutineHandler Instance()
		{
			if (_instance == null)
			{
				_instance = new CoroutineHandler();
			}
			return _instance;
		}

		public UnityEngine.Coroutine Add(System.Collections.IEnumerator value)
		{
			enumerators.Add(value);
			return new UnityEngine.Coroutine(value);
		}

		public void Remove(System.Collections.IEnumerator value)
		{
			enumerators.Remove(value);
		}

		public void Tick()
		{

			for (int i = enumerators.Count - 1; i >= 0; i--)
			{
				var e = enumerators[i];
				if (!e.MoveNext())
				{
					enumerators.Remove(e);
				}
			}
		}


	}
}
