
namespace UnityEngine
{
	public static class UISystemProfilerApi
	{
		public static void AddMarker(string name, Object obj) { }
		public static void BeginSample(SampleType type) { }
		public static void EndSample(SampleType type) { }

		public enum SampleType
		{
			Layout = 0,
			Render = 1
		}
	}
}