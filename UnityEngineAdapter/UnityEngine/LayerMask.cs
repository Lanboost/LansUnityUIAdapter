#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion


namespace UnityEngine
{
	

	public struct LayerMask
	{
		static LayerMask basic = new LayerMask();

		//
		// Summary:
		//     Converts a layer mask value to an integer value.
		public int value { get; set; }

		//
		// Summary:
		//     Given a set of layer names as defined by either a Builtin or a User Layer in
		//     the, returns the equivalent layer mask for all of them.
		//
		// Parameters:
		//   layerNames:
		//     List of layer names to convert to a layer mask.
		//
		// Returns:
		//     The layer mask created from the layerNames.
		public static int GetMask(params string[] layerNames) { throw new System.NotImplementedException(); }

		public static string LayerToName(int layer) { throw new System.NotImplementedException(); }

		public static int NameToLayer(string layerName) { throw new System.NotImplementedException(); }

		public static implicit operator int(LayerMask mask) { throw new System.NotImplementedException(); }
		public static implicit operator LayerMask(int intVal) {
			return basic;
		}
	}
}