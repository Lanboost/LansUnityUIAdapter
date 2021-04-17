#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion


namespace UnityEngine
{
	public struct SortingLayer
	{
		//
		// Summary:
		//     Returns all the layers defined in this project.
		public static SortingLayer[] layers { get; }
		//
		// Summary:
		//     This is the unique id assigned to the layer. It is not an ordered running value
		//     and it should not be used to compare with other layers to determine the sorting
		//     order.
		public int id { get; }
		//
		// Summary:
		//     Returns the name of the layer as defined in the TagManager.
		public string name { get; }
		//
		// Summary:
		//     This is the relative value that indicates the sort order of this layer relative
		//     to the other layers.
		public int value { get; }

		//
		// Summary:
		//     Returns the final sorting layer value. To determine the sorting order between
		//     the various sorting layers, use this method to retrieve the final sorting value
		//     and use CompareTo to determine the order.
		//
		// Parameters:
		//   id:
		//     The unique value of the sorting layer as returned by any renderer's sortingLayerID
		//     property.
		//
		// Returns:
		//     The final sorting value of the layer relative to other layers.
		[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
		public static int GetLayerValueFromID(int id) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the final sorting layer value. See Also: GetLayerValueFromID.
		//
		// Parameters:
		//   name:
		//     The unique value of the sorting layer as returned by any renderer's sortingLayerID
		//     property.
		//
		// Returns:
		//     The final sorting value of the layer relative to other layers.
		[FreeFunction("GetTagManager().GetSortingLayerValueFromName")]
		public static int GetLayerValueFromName(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the unique id of the layer. Will return "<unknown layer>" if an invalid
		//     id is given.
		//
		// Parameters:
		//   id:
		//     The unique id of the layer.
		//
		// Returns:
		//     The name of the layer with id or "<unknown layer>" for invalid id.
		[FreeFunction("GetTagManager().GetSortingLayerNameFromUniqueID")]
		public static string IDToName(int id) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true if the id provided is a valid layer id.
		//
		// Parameters:
		//   id:
		//     The unique id of a layer.
		//
		// Returns:
		//     True if the id provided is valid and assigned to a layer.
		[FreeFunction("GetTagManager().IsSortingLayerUniqueIDValid")]
		public static bool IsValid(int id) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the id given the name. Will return 0 if an invalid name was given.
		//
		// Parameters:
		//   name:
		//     The name of the layer.
		//
		// Returns:
		//     The unique id of the layer with name.
		[FreeFunction("GetTagManager().GetSortingLayerUniqueIDFromName")]
		public static int NameToID(string name) { throw new System.NotImplementedException(); }
	}
}