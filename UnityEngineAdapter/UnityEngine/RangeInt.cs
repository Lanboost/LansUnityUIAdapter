#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
	//
	// Summary:
	//     Describes an integer range.
	public struct RangeInt
	{
		//
		// Summary:
		//     The starting index of the range, where 0 is the first position, 1 is the second,
		//     2 is the third, and so on.
		public int start;
		//
		// Summary:
		//     The length of the range.
		public int length;

		//
		// Summary:
		//     Constructs a new RangeInt with given start, length values.
		//
		// Parameters:
		//   start:
		//     The starting index of the range.
		//
		//   length:
		//     The length of the range.
		public RangeInt(int start, int length)
		{
			this.start = start;
			this.length = length;
			this.end = length - 1;
		}

		//
		// Summary:
		//     The end index of the range (not inclusive).
		public int end { get; }
	}
}