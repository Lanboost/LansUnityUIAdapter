namespace UnityEngine
{
	public struct UIVertex
	{
		//
		// Summary:
		//     Simple UIVertex with sensible settings for use in the UI system.
		public static UIVertex simpleVert;
		//
		// Summary:
		//     Vertex position.
		public Vector3 position;
		//
		// Summary:
		//     Normal.
		public Vector3 normal;
		//
		// Summary:
		//     Tangent.
		public Vector4 tangent;
		//
		// Summary:
		//     Vertex color.
		public Color32 color;
		//
		// Summary:
		//     The first texture coordinate set of the mesh. Used by UI elements by default.
		public Vector2 uv0;
		//
		// Summary:
		//     The second texture coordinate set of the mesh, if present.
		public Vector2 uv1;
		//
		// Summary:
		//     The Third texture coordinate set of the mesh, if present.
		public Vector2 uv2;
		//
		// Summary:
		//     The forth texture coordinate set of the mesh, if present.
		public Vector2 uv3;
	}
}