
using System;
using System.Collections.Generic;

namespace UnityEngine
{

	public sealed class CanvasRenderer : Component
	{

		internal Color _color = Color.white;
		internal  float _alpha = 0.8f;
		internal  Material[] _material;
		internal  Material[] _popMaterial;
		public Mesh _mesh;
		internal  Texture _texture;
		internal  Texture _alphaTexture;

		int _materialCount = 0;
		int _popMaterialCount = 0;

		public CanvasRenderer() { }
		
		//
		// Summary:
		//     Depth of the renderer relative to the root canvas.
		public int absoluteDepth { get; set; }
		//
		// Summary:
		//     The number of materials usable by this renderer.
		public int materialCount
		{
			get => _materialCount;
			set
			{
				_materialCount = value;
				Array.Resize(ref _material, value);
			}
		}
		//
		// Summary:
		//     Enable 'render stack' pop draw call.
		public bool hasPopInstruction { get; set; }
		//
		// Summary:
		//     The clipping softness to apply to the renderer.
		public Vector2 clippingSoftness { get; set; }
		//
		// Summary:
		//     True if any change has occured that would invalidate the positions of generated
		//     geometry.

		public bool hasMoved { get; }
		
		//
		// Summary:
		//     Is the UIRenderer a mask component.
		[Obsolete("isMask is no longer supported.See EnableClipping for vertex clipping configuration", false)]
		public bool isMask { get; set; }
		//
		// Summary:
		//     Indicates whether geometry emitted by this renderer can be ignored when the vertex
		//     color alpha is close to zero for every vertex of the mesh.
		public bool cullTransparentMesh { get; set; }
		//
		// Summary:
		//     Indicates whether geometry emitted by this renderer is ignored.
		public bool cull { get; set; }
		//
		// Summary:
		//     Depth of the renderer realative to the parent canvas.
		public int relativeDepth { get; }
		//
		// Summary:
		//     The number of materials usable by this renderer. Used internally for masking.
		public int popMaterialCount { get => _popMaterialCount;
			set
			{
				_popMaterialCount = value;
				Array.Resize(ref _popMaterial, value);
			}
		}
		//
		// Summary:
		//     True if rect clipping has been enabled on this renderer. See Also: CanvasRenderer.EnableRectClipping,
		//     CanvasRenderer.DisableRectClipping.
		public bool hasRectClipping { get; }
		/*
		public static event OnRequestRebuild onRequestRebuild;
		*/
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) {throw new NotImplementedException();}
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents) { throw new NotImplementedException(); }
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { throw new NotImplementedException(); }
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { throw new NotImplementedException(); }
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { throw new NotImplementedException(); }
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { throw new NotImplementedException(); }
		
		//
		// Summary:
		//     Remove all cached vertices.
		public void Clear(){ //throw new System.NotImplementedException();
		}
		
		//
		// Summary:
		//     Disables rectangle clipping for this CanvasRenderer.
		public void DisableRectClipping() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Enables rect clipping on the CanvasRendered. Geometry outside of the specified
		//     rect will be clipped (not rendered).
		//
		// Parameters:
		//   rect:
		public void EnableRectClipping(Rect rect) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get the current alpha of the renderer.
		public float GetAlpha() { return _alpha; }
		//
		// Summary:
		//     Get the current color of the renderer.
		public Color GetColor() { return _color; }
		//
		// Summary:
		//     Get the final inherited alpha calculated by including all the parent alphas from
		//     included parent CanvasGroups.
		//
		// Returns:
		//     The calculated inherited alpha.
		public float GetInheritedAlpha() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Gets the current Material assigned to the CanvasRenderer.
		//
		// Parameters:
		//   index:
		//     The material index to retrieve (0 if this parameter is omitted).
		//
		// Returns:
		//     Result.
		public Material GetMaterial(int index) { return _material[0]; }
		//
		// Summary:
		//     Gets the current Material assigned to the CanvasRenderer.
		//
		// Parameters:
		//   index:
		//     The material index to retrieve (0 if this parameter is omitted).
		//
		// Returns:
		//     Result.
		public Material GetMaterial() { return GetMaterial(0); }
		//
		// Summary:
		//     Gets the current Material assigned to the CanvasRenderer. Used internally for
		//     masking.
		//
		// Parameters:
		//   index:
		public Material GetPopMaterial(int index) { return _popMaterial[index]; }
		//
		// Summary:
		//     Set the alpha of the renderer. Will be multiplied with the UIVertex alpha and
		//     the Canvas alpha.
		//
		// Parameters:
		//   alpha:
		//     Alpha.
		public void SetAlpha(float alpha) { this._alpha = alpha; }
		//
		// Summary:
		//     The Alpha Texture that will be passed to the Shader under the _AlphaTex property.
		//
		// Parameters:
		//   texture:
		//     The Texture to be passed.
		public void SetAlphaTexture(Texture texture) { _alphaTexture = texture; }
		//
		// Summary:
		//     Set the color of the renderer. Will be multiplied with the UIVertex color and
		//     the Canvas color.
		//
		// Parameters:
		//   color:
		//     Renderer multiply color.
		public void SetColor(Color color) {
			this._color = color;
		}
		//
		// Summary:
		//     Set the material for the canvas renderer. If a texture is specified then it will
		//     be used as the 'MainTex' instead of the material's 'MainTex'. See Also: CanvasRenderer.SetMaterialCount,
		//     CanvasRenderer.SetTexture.
		//
		// Parameters:
		//   material:
		//     Material for rendering.
		//
		//   texture:
		//     Material texture overide.
		//
		//   index:
		//     Material index.
		public void SetMaterial(Material material, Texture texture) {
			this._material = new Material[] { material };
			this._texture = texture;
		}
		//
		// Summary:
		//     Set the material for the canvas renderer. If a texture is specified then it will
		//     be used as the 'MainTex' instead of the material's 'MainTex'. See Also: CanvasRenderer.SetMaterialCount,
		//     CanvasRenderer.SetTexture.
		//
		// Parameters:
		//   material:
		//     Material for rendering.
		//
		//   texture:
		//     Material texture overide.
		//
		//   index:
		//     Material index.
		public void SetMaterial(Material material, int index)
		{
			if(_material == null)
			{
				_material = new Material[materialCount];
			}
			_material[index] = material;
		}
		//
		// Summary:
		//     Sets the Mesh used by this renderer. Note the Mesh must be read/write enabled.
		//
		// Parameters:
		//   mesh:
		public void SetMesh(Mesh mesh) {
			this._mesh = new Mesh(mesh);
		}
		//
		// Summary:
		//     Set the material for the canvas renderer. Used internally for masking.
		//
		// Parameters:
		//   material:
		//
		//   index:
		
		public void SetPopMaterial(Material material, int index) {
			if (_popMaterial == null)
			{
				_popMaterial = new Material[popMaterialCount];
			}
			_popMaterial[index] = material;
		}
		
		//
		// Summary:
		//     Sets the texture used by this renderer's material.
		//
		// Parameters:
		//   texture:
		public void SetTexture(Texture texture) { this._texture = texture; }
		[Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", false)]
		public void SetVertices(List<UIVertex> vertices) { //throw new System.NotImplementedException(); 
		}
		//
		// Summary:
		//     Set the vertices for the UIRenderer.
		//
		// Parameters:
		//   vertices:
		//     Array of vertices to set.
		//
		//   size:
		//     Number of vertices to set.
		[Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", false)]
		public void SetVertices(UIVertex[] vertices, int size) { //throw new System.NotImplementedException();
		}

		public delegate void OnRequestRebuild();
		
	}
}