#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Rendering;

namespace UnityEngine
{
	public sealed class Mesh : Object
	{
		public Color _color = new Color(1,1,1,1);
		public Mesh() {
			var v = 0;
		}

		internal Mesh(Mesh m)
		{
			this._color = m._color;
		}

		//
		// Summary:
		//     Format of the mesh index buffer data.
		//public IndexFormat indexFormat { get; set; }
		//
		// Summary:
		//     Gets the number of vertex buffers present in the Mesh. (Read Only)
		public int vertexBufferCount { get; }
		//
		// Summary:
		//     Returns BlendShape count on this mesh.
		public int blendShapeCount { get; }
		//
		// Summary:
		//     The bind poses. The bind pose at each index refers to the bone with the same
		//     index.
		[NativeName("BindPosesFromScript")]
		public Matrix4x4[] bindposes { get; set; }
		//
		// Summary:
		//     Returns true if the Mesh is read/write enabled, or false if it is not.
		public bool isReadable { get; }
		//
		// Summary:
		//     Returns the number of vertices in the Mesh (Read Only).
		public int vertexCount { get; }
		//
		// Summary:
		//     The number of sub-meshes inside the Mesh object.
		public int subMeshCount { get; set; }
		//
		// Summary:
		//     The bounding volume of the Mesh.
		public Bounds bounds { get; set; }
		//
		// Summary:
		//     Returns a copy of the vertex positions or assigns a new vertex positions array.
		public Vector3[] vertices { get; set; }
		//
		// Summary:
		//     The normals of the Mesh.
		public Vector3[] normals { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property Mesh.uv1 has been deprecated. Use Mesh.uv2 instead (UnityUpgradable) -> uv2", true)]
		public Vector2[] uv1 { get; set; }
		//
		// Summary:
		//     The tangents of the Mesh.
		public Vector4[] tangents { get; set; }
		//
		// Summary:
		//     The second texture coordinate set of the mesh, if present.
		public Vector2[] uv2 { get; set; }
		//
		// Summary:
		//     The third texture coordinate set of the mesh, if present.
		public Vector2[] uv3 { get; set; }
		//
		// Summary:
		//     The fourth texture coordinate set of the mesh, if present.
		public Vector2[] uv4 { get; set; }
		//
		// Summary:
		//     The fifth texture coordinate set of the mesh, if present.
		public Vector2[] uv5 { get; set; }
		//
		// Summary:
		//     The sixth texture coordinate set of the mesh, if present.
		public Vector2[] uv6 { get; set; }
		//
		// Summary:
		//     The seventh texture coordinate set of the mesh, if present.
		public Vector2[] uv7 { get; set; }
		//
		// Summary:
		//     The eighth texture coordinate set of the mesh, if present.
		public Vector2[] uv8 { get; set; }
		//
		// Summary:
		//     Vertex colors of the Mesh.
		public Color[] colors { get; set; }
		//
		// Summary:
		//     Vertex colors of the Mesh.
		public Color32[] colors32 { get; set; }
		//
		// Summary:
		//     Returns the number of vertex attributes that the mesh has. (Read Only)
		public int vertexAttributeCount { get; }
		//
		// Summary:
		//     The base texture coordinates of the Mesh.
		public Vector2[] uv { get; set; }
		//
		// Summary:
		//     An array containing all triangles in the Mesh.
		public int[] triangles { get; set; }
		//
		// Summary:
		//     The bone weights of each vertex.
		//public BoneWeight[] boneWeights { get; set; }

		public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) {
			
		}
		
		//public void Clear([Internal.DefaultValue("true")] bool keepVertexLayout) { throw new System.NotImplementedException(); }

		public void Clear() {

		}
		public void ClearBlendShapes() {
			
		}
		//
		// Summary:
		//     Combines several Meshes into this Mesh.
		//
		// Parameters:
		//   combine:
		//     Descriptions of the Meshes to combine.
		//
		//   mergeSubMeshes:
		//     Defines whether Meshes should be combined into a single sub-mesh.
		//
		//   useMatrices:
		//     Defines whether the transforms supplied in the CombineInstance array should be
		//     used or ignored.
		//
		//   hasLightmapData:
		//public void CombineMeshes(CombineInstance[] combine, [Internal.DefaultValue("true")] bool mergeSubMeshes, [Internal.DefaultValue("true")] bool useMatrices, [Internal.DefaultValue("false")] bool hasLightmapData) { throw new System.NotImplementedException(); }
		
		//public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Combines several Meshes into this Mesh.
		//
		// Parameters:
		//   combine:
		//     Descriptions of the Meshes to combine.
		//
		//   mergeSubMeshes:
		//     Defines whether Meshes should be combined into a single sub-mesh.
		//
		//   useMatrices:
		//     Defines whether the transforms supplied in the CombineInstance array should be
		//     used or ignored.
		//
		//   hasLightmapData:
		//[ExcludeFromDocs]
		//public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Combines several Meshes into this Mesh.
		//
		// Parameters:
		//   combine:
		//     Descriptions of the Meshes to combine.
		//
		//   mergeSubMeshes:
		//     Defines whether Meshes should be combined into a single sub-mesh.
		//
		//   useMatrices:
		//     Defines whether the transforms supplied in the CombineInstance array should be
		//     used or ignored.
		//
		//   hasLightmapData:
		//[ExcludeFromDocs]
		//public void CombineMeshes(CombineInstance[] combine) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     The bone weights of all vertices.
		//public NativeArray<BoneWeight1> GetAllBoneWeights() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Gets the base vertex index of the given sub-mesh.
		//
		// Parameters:
		//   submesh:
		//     The sub-mesh index. See subMeshCount.
		//
		// Returns:
		//     The offset applied to all vertex indices of this sub-mesh.
		public uint GetBaseVertex(int submesh) { throw new System.NotImplementedException(); }
		public void GetBindposes(List<Matrix4x4> bindposes) { throw new System.NotImplementedException(); }

		public int GetBlendShapeFrameCount(int shapeIndex) { throw new System.NotImplementedException(); }


		public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { throw new System.NotImplementedException(); }

		public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) { throw new System.NotImplementedException(); }

		public int GetBlendShapeIndex(string blendShapeName) { throw new System.NotImplementedException(); }

		public string GetBlendShapeName(int shapeIndex) { throw new System.NotImplementedException(); }

		//public NativeArray<byte> GetBonesPerVertex() { throw new System.NotImplementedException(); }
		//public void GetBoneWeights(List<BoneWeight> boneWeights) { throw new System.NotImplementedException(); }
		public void GetColors(List<Color32> colors) { throw new System.NotImplementedException(); }
		public void GetColors(List<Color> colors) { throw new System.NotImplementedException(); }

		public uint GetIndexCount(int submesh) { throw new System.NotImplementedException(); }

		public uint GetIndexStart(int submesh) { throw new System.NotImplementedException(); }
		public void GetIndices(List<ushort> indices, int submesh, bool applyBaseVertex = true) { throw new System.NotImplementedException(); }
		//public void GetIndices(List<int> indices, int submesh, [Internal.DefaultValue("true")] bool applyBaseVertex) { throw new System.NotImplementedException(); }

		public void GetIndices(List<int> indices, int submesh) { throw new System.NotImplementedException(); }

		//public int[] GetIndices(int submesh, [Internal.DefaultValue("true")] bool applyBaseVertex) { throw new System.NotImplementedException(); }

		public int[] GetIndices(int submesh) { throw new System.NotImplementedException(); }

		public IntPtr GetNativeIndexBufferPtr() { throw new System.NotImplementedException(); }
		
		public IntPtr GetNativeVertexBufferPtr(int index) { throw new System.NotImplementedException(); }
		public void GetNormals(List<Vector3> normals) { throw new System.NotImplementedException(); }
		
		//public SubMeshDescriptor GetSubMesh(int index) { throw new System.NotImplementedException(); }
		public void GetTangents(List<Vector4> tangents) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Gets the topology of a sub-mesh.
		//
		// Parameters:
		//   submesh:
		public MeshTopology GetTopology(int submesh) { throw new System.NotImplementedException(); }
		public void GetTriangles(List<int> triangles, int submesh) { throw new System.NotImplementedException(); }
		public void GetTriangles(List<ushort> triangles, int submesh, bool applyBaseVertex = true) { throw new System.NotImplementedException(); }
		//public void GetTriangles(List<int> triangles, int submesh, [Internal.DefaultValue("true")] bool applyBaseVertex) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Fetches the triangle list for the specified sub-mesh on this object.
		//
		// Parameters:
		//   triangles:
		//     A list of vertex indices to populate.
		//
		//   submesh:
		//     The sub-mesh index. See subMeshCount.
		//
		//   applyBaseVertex:
		//     True (default value) will apply base vertex offset to returned indices.
		public int[] GetTriangles(int submesh) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Fetches the triangle list for the specified sub-mesh on this object.
		//
		// Parameters:
		//   triangles:
		//     A list of vertex indices to populate.
		//
		//   submesh:
		//     The sub-mesh index. See subMeshCount.
		//
		//   applyBaseVertex:
		//     True (default value) will apply base vertex offset to returned indices.
		public int[] GetTriangles(int submesh, bool applyBaseVertex) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     The UV distribution metric can be used to calculate the desired mipmap level
		//     based on the position of the camera.
		//
		// Parameters:
		//   uvSetIndex:
		//     UV set index to return the UV distibution metric for. 0 for first.
		//
		// Returns:
		//     Average of triangle area / uv area.
		[NativeMethod("GetMeshMetric")]
		public float GetUVDistributionMetric(int uvSetIndex) { throw new System.NotImplementedException(); }
		public void GetUVs(int channel, List<Vector2> uvs) { throw new System.NotImplementedException(); }
		public void GetUVs(int channel, List<Vector3> uvs) { throw new System.NotImplementedException(); }
		public void GetUVs(int channel, List<Vector4> uvs) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns information about a vertex attribute based on its index.
		//
		// Parameters:
		//   index:
		//     The vertex attribute index (0 to vertexAttributeCount-1).
		//
		// Returns:
		//     Information about the vertex attribute.
		[FreeFunction(Name = "MeshScripting::GetVertexAttributeByIndex", HasExplicitThis = true)]
		public VertexAttributeDescriptor GetVertexAttribute(int index) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get dimension of a specific vertex data attribute on this Mesh.
		//
		// Parameters:
		//   attr:
		//     Vertex data attribute to check for.
		//
		// Returns:
		//     Dimensionality of the data attribute, or zero if it is not present.
		[FreeFunction(Name = "MeshScripting::GetChannelDimension", HasExplicitThis = true)]
		public int GetVertexAttributeDimension(VertexAttribute attr) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get format of a specific vertex data attribute on this Mesh.
		//
		// Parameters:
		//   attr:
		//     Vertex data attribute to check for.
		//
		// Returns:
		//     Format of the data attribute.
		[FreeFunction(Name = "MeshScripting::GetChannelFormat", HasExplicitThis = true)]
		public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr) { throw new System.NotImplementedException(); }
		public int GetVertexAttributes(List<VertexAttributeDescriptor> attributes) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get information about vertex attributes of a Mesh, without memory allocations.
		//
		// Parameters:
		//   attributes:
		//     Collection of vertex attributes to receive the results.
		//
		// Returns:
		//     The number of vertex attributes returned in the attributes container.
		public int GetVertexAttributes(VertexAttributeDescriptor[] attributes) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get information about vertex attributes of a Mesh.
		//
		// Returns:
		//     Array of vertex attribute information.
		public VertexAttributeDescriptor[] GetVertexAttributes() { throw new System.NotImplementedException(); }
		public void GetVertices(List<Vector3> vertices) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Checks if a specific vertex data attribute exists on this Mesh.
		//
		// Parameters:
		//   attr:
		//     Vertex data attribute to check for.
		//
		// Returns:
		//     Returns true if the data attribute is present in the mesh.
		[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = true)]
		public bool HasVertexAttribute(VertexAttribute attr) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Optimize mesh for frequent updates.
		public void MarkDynamic() { }
		//
		// Summary:
		//     Notify Renderer components of mesh geometry change.
		[NativeMethod("MarkModified")]
		public void MarkModified() { }
		//
		// Summary:
		//     Optimizes the Mesh data to improve rendering performance.
		public void Optimize() { }
		//
		// Summary:
		//     Optimizes the geometry of the Mesh to improve rendering performance.
		public void OptimizeIndexBuffers() { }
		//
		// Summary:
		//     Optimizes the vertices of the Mesh to improve rendering performance.
		public void OptimizeReorderVertexBuffer() { }
		//
		// Summary:
		//     Recalculate the bounding volume of the Mesh from the vertices.
		public void RecalculateBounds() { }
		//
		// Summary:
		//     Recalculates the normals of the Mesh from the triangles and vertices.
		public void RecalculateNormals() { }
		//
		// Summary:
		//     Recalculates the tangents of the Mesh from the normals and texture coordinates.
		public void RecalculateTangents() {}
		//public void SetBoneWeights(NativeArray<byte> bonesPerVertex, NativeArray<BoneWeight1> weights) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the per-vertex colors of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   inColors:
		//     Per-vertex colors.
		//
		//   start:
		//     Index of the first element to take from the input array.
		//
		//   length:
		//     Number of elements to take from the input array.
		public void SetColors(Color32[] inColors, int start, int length) {
			_color = inColors[0];
		}
		//public void SetColors<T>(NativeArray<T> inColors) where T : struct;
		public void SetColors(List<Color32> inColors, int start, int length) {
			_color = inColors[0];
		}
		public void SetColors(List<Color> inColors, int start, int length) {
			_color = inColors[0];
		}
		public void SetColors(List<Color32> inColors) {
			_color = inColors[0];
		}
		public void SetColors(List<Color> inColors) {
			_color = inColors[0];
		}
		//
		// Summary:
		//     Set the per-vertex colors of the Mesh.
		//
		// Parameters:
		//   inColors:
		//     Per-vertex colors.
		public void SetColors(Color[] inColors) {
			_color = inColors[0];
		}
		//
		// Summary:
		//     Sets the per-vertex colors of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   inColors:
		//     Per-vertex colors.
		//
		//   start:
		//     Index of the first element to take from the input array.
		//
		//   length:
		//     Number of elements to take from the input array.
		public void SetColors(Color[] inColors, int start, int length) {
			_color = inColors[0];
		}
		//public void SetColors<T>(NativeArray<T> inColors, int start, int length) where T : struct;
		//
		// Summary:
		//     Set the per-vertex colors of the Mesh.
		//
		// Parameters:
		//   inColors:
		//     Per-vertex colors.
		public void SetColors(Color32[] inColors) {
			_color = inColors[0];
		}
		//public void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
		//public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
		//public void SetIndexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
		//
		// Summary:
		//     Sets the index buffer size and format.
		//
		// Parameters:
		//   indexCount:
		//     Size of index buffer.
		//
		//   format:
		//     Format of the indices.
		//[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = true)]
		//public void SetIndexBufferParams(int indexCount, IndexFormat format) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the index buffer of a sub-mesh, using a part of the input array.
		//
		// Parameters:
		//   indices:
		//     The array of indices that define the mesh faces.
		//
		//   indicesStart:
		//     Index of the first element to take from the input array.
		//
		//   indicesLength:
		//     Number of elements to take from the input array.
		//
		//   topology:
		//     The topology of the Mesh, e.g: Triangles, Lines, Quads, Points, etc. See MeshTopology.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the indices. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the indices.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all vertex indices.
		public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//
		// Summary:
		//     Sets the index buffer for the sub-mesh.
		//
		// Parameters:
		//   indices:
		//     The array of indices that define the mesh faces.
		//
		//   topology:
		//     The topology of the Mesh, e.g: Triangles, Lines, Quads, Points, etc. See MeshTopology.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the indices. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the indices.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all vertex indices.
		public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//public void SetIndices<T>(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : struct;
		//public void SetIndices<T>(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : struct;
		public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//
		// Summary:
		//     Sets the index buffer for the sub-mesh.
		//
		// Parameters:
		//   indices:
		//     The array of indices that define the mesh faces.
		//
		//   topology:
		//     The topology of the Mesh, e.g: Triangles, Lines, Quads, Points, etc. See MeshTopology.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the indices. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the indices.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all vertex indices.
		[ExcludeFromDocs]
		public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }
		//
		// Summary:
		//     Sets the index buffer for the sub-mesh.
		//
		// Parameters:
		//   indices:
		//     The array of indices that define the mesh faces.
		//
		//   topology:
		//     The topology of the Mesh, e.g: Triangles, Lines, Quads, Points, etc. See MeshTopology.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the indices. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the indices.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all vertex indices.
		//public void SetIndices(int[] indices, MeshTopology topology, int submesh, [Internal.DefaultValue("true")] bool calculateBounds, [Internal.DefaultValue("0")] int baseVertex) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the index buffer of a sub-mesh, using a part of the input array.
		//
		// Parameters:
		//   indices:
		//     The array of indices that define the mesh faces.
		//
		//   indicesStart:
		//     Index of the first element to take from the input array.
		//
		//   indicesLength:
		//     Number of elements to take from the input array.
		//
		//   topology:
		//     The topology of the Mesh, e.g: Triangles, Lines, Quads, Points, etc. See MeshTopology.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the indices. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the indices.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all vertex indices.
		public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		public void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//
		// Summary:
		//     Sets the index buffer for the sub-mesh.
		//
		// Parameters:
		//   indices:
		//     The array of indices that define the mesh faces.
		//
		//   topology:
		//     The topology of the Mesh, e.g: Triangles, Lines, Quads, Points, etc. See MeshTopology.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the indices. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the indices.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all vertex indices.
		[ExcludeFromDocs]
		public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }
		public void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//public void SetNormals<T>(NativeArray<T> inNormals, int start, int length) where T : struct;
		//public void SetNormals<T>(NativeArray<T> inNormals) where T : struct;
		//
		// Summary:
		//     Sets the vertex normals of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   inNormals:
		//     Per-vertex normals.
		//
		//   start:
		//     Index of the first element to take from the input array.
		//
		//   length:
		//     Number of elements to take from the input array.
		public void SetNormals(Vector3[] inNormals, int start, int length) { }
		//
		// Summary:
		//     Set the normals of the Mesh.
		//
		// Parameters:
		//   inNormals:
		//     Per-vertex normals.
		public void SetNormals(Vector3[] inNormals) { }
		public void SetNormals(List<Vector3> inNormals, int start, int length) { }
		public void SetNormals(List<Vector3> inNormals) { }
		//
		// Summary:
		//     Sets the information about a sub-mesh of the Mesh.
		//
		// Parameters:
		//   index:
		//     Sub-mesh index. See subMeshCount. Out of range indices throw an exception.
		//
		//   desc:
		//     Sub-mesh data.
		//
		//   flags:
		//     Flags controlling the function behavior, see MeshUpdateFlags.
		//[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = true, ThrowsException = true)]
		//public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default) { throw new System.NotImplementedException(); }
		//public void SetTangents<T>(NativeArray<T> inTangents, int start, int length) where T : struct;
		//
		// Summary:
		//     Sets the tangents of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   inTangents:
		//     Per-vertex tangents.
		//
		//   start:
		//     Index of the first element to take from the input array.
		//
		//   length:
		//     Number of elements to take from the input array.
		public void SetTangents(Vector4[] inTangents, int start, int length) { }
		//public void SetTangents<T>(NativeArray<T> inTangents) where T : struct;
		//
		// Summary:
		//     Set the tangents of the Mesh.
		//
		// Parameters:
		//   inTangents:
		//     Per-vertex tangents.
		public void SetTangents(Vector4[] inTangents) { }
		public void SetTangents(List<Vector4> inTangents, int start, int length) { }
		public void SetTangents(List<Vector4> inTangents) { }
		public void SetTriangles(List<ushort> triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//public void SetTriangles(List<int> triangles, int submesh, [Internal.DefaultValue("true")] bool calculateBounds, [Internal.DefaultValue("0")] int baseVertex) { throw new System.NotImplementedException(); }
		[ExcludeFromDocs]
		public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds) { }
		[ExcludeFromDocs]
		public void SetTriangles(List<int> triangles, int submesh) { }
		//
		// Summary:
		//     Sets the triangle list of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   triangles:
		//     The list of indices that define the triangles.
		//
		//   trianglesStart:
		//     Index of the first element to take from the input array.
		//
		//   trianglesLength:
		//     Number of elements to take from the input array.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the triangles. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the triangles.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all triangle vertex indices.
		public void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//
		// Summary:
		//     Sets the triangle list of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   triangles:
		//     The list of indices that define the triangles.
		//
		//   trianglesStart:
		//     Index of the first element to take from the input array.
		//
		//   trianglesLength:
		//     Number of elements to take from the input array.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the triangles. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the triangles.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all triangle vertex indices.
		public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//
		// Summary:
		//     Sets the triangle list for the sub-mesh.
		//
		// Parameters:
		//   triangles:
		//     The list of indices that define the triangles.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the triangles. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the triangles.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all triangle vertex indices.
		//public void SetTriangles(int[] triangles, int submesh, [Internal.DefaultValue("true")] bool calculateBounds, [Internal.DefaultValue("0")] int baseVertex) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the triangle list for the sub-mesh.
		//
		// Parameters:
		//   triangles:
		//     The list of indices that define the triangles.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the triangles. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the triangles.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all triangle vertex indices.
		[ExcludeFromDocs]
		public void SetTriangles(int[] triangles, int submesh, bool calculateBounds) { }
		//
		// Summary:
		//     Sets the triangle list for the sub-mesh.
		//
		// Parameters:
		//   triangles:
		//     The list of indices that define the triangles.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the triangles. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the triangles.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all triangle vertex indices.
		[ExcludeFromDocs]
		public void SetTriangles(int[] triangles, int submesh) { }
		public void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//
		// Summary:
		//     Sets the triangle list for the sub-mesh.
		//
		// Parameters:
		//   triangles:
		//     The list of indices that define the triangles.
		//
		//   submesh:
		//     The sub-mesh to modify.
		//
		//   calculateBounds:
		//     Calculate the bounding box of the Mesh after setting the triangles. This is done
		//     by default. Use false when you want to use the existing bounding box and reduce
		//     the CPU cost of setting the triangles.
		//
		//   baseVertex:
		//     Optional vertex offset that is added to all triangle vertex indices.
		public void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }
		//
		// Summary:
		//     Sets the UVs of the Mesh.
		//
		// Parameters:
		//   channel:
		//     The UV channel, in [0..7] range. Indices start at 0, which corresponds to uv.
		//     Note that 1 corresponds to uv2.
		//
		//   uvs:
		//     UVs to set for the given index.
		public void SetUVs(int channel, Vector4[] uvs) { }
		//
		// Summary:
		//     Sets the UVs of the Mesh.
		//
		// Parameters:
		//   channel:
		//     The UV channel, in [0..7] range. Indices start at 0, which corresponds to uv.
		//     Note that 1 corresponds to uv2.
		//
		//   uvs:
		//     UVs to set for the given index.
		public void SetUVs(int channel, Vector3[] uvs) { }
		//
		// Summary:
		//     Sets the UVs of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   channel:
		//     The UV channel, in [0..7] range.
		//
		//   uvs:
		//     UVs to set for the given index.
		//
		//   start:
		//     Index of the first element to take from the input array.
		//
		//   length:
		//     Number of elements to take from the input array.
		public void SetUVs(int channel, Vector2[] uvs, int start, int length) { }
		public void SetUVs(int channel, List<Vector2> uvs) { }
		public void SetUVs(int channel, List<Vector3> uvs) { }
		public void SetUVs(int channel, List<Vector4> uvs) { }
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }
		public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }
		//
		// Summary:
		//     Sets the UVs of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   channel:
		//     The UV channel, in [0..7] range.
		//
		//   uvs:
		//     UVs to set for the given index.
		//
		//   start:
		//     Index of the first element to take from the input array.
		//
		//   length:
		//     Number of elements to take from the input array.
		public void SetUVs(int channel, Vector3[] uvs, int start, int length) { }
		//
		// Summary:
		//     Sets the UVs of the Mesh.
		//
		// Parameters:
		//   channel:
		//     The UV channel, in [0..7] range. Indices start at 0, which corresponds to uv.
		//     Note that 1 corresponds to uv2.
		//
		//   uvs:
		//     UVs to set for the given index.
		public void SetUVs(int channel, Vector2[] uvs) { }
		//
		// Summary:
		//     Sets the UVs of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   channel:
		//     The UV channel, in [0..7] range.
		//
		//   uvs:
		//     UVs to set for the given index.
		//
		//   start:
		//     Index of the first element to take from the input array.
		//
		//   length:
		//     Number of elements to take from the input array.
		public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }
		//public void SetUVs<T>(int channel, NativeArray<T> uvs) where T : struct;
		//public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length) where T : struct;
		//public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
		//public void SetVertexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
		//public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
		//
		// Summary:
		//     Sets the vertex buffer size and layout.
		//
		// Parameters:
		//   vertexCount:
		//     The number of vertices in the Mesh.
		//
		//   attributes:
		//     Layout of the vertex data -- which attributes are present, their data types and
		//     so on.
		[FreeFunction(Name = "MeshScripting::SetVertexBufferParams", HasExplicitThis = true, ThrowsException = true)]
		public void SetVertexBufferParams(int vertexCount, params VertexAttributeDescriptor[] attributes) { }
		//public void SetVertices<T>(NativeArray<T> inVertices) where T : struct;
		//
		// Summary:
		//     Sets the vertex positions of the Mesh, using a part of the input array.
		//
		// Parameters:
		//   inVertices:
		//     Per-vertex positions.
		//
		//   start:
		//     Index of the first element to take from the input array.
		//
		//   length:
		//     Number of elements to take from the input array.
		public void SetVertices(Vector3[] inVertices, int start, int length) {}
		public void SetVertices(List<Vector3> inVertices) {}
		public void SetVertices(List<Vector3> inVertices, int start, int length) {}
		//public void SetVertices<T>(NativeArray<T> inVertices, int start, int length) where T : struct;
		//
		// Summary:
		//     Assigns a new vertex positions array.
		//
		// Parameters:
		//   inVertices:
		//     Per-vertex positions.
		public void SetVertices(Vector3[] inVertices) {}
		//
		// Summary:
		//     Upload previously done Mesh modifications to the graphics API.
		//
		// Parameters:
		//   markNoLongerReadable:
		//     Frees up system memory copy of mesh data when set to true.
		public void UploadMeshData(bool markNoLongerReadable) {}
	}
}