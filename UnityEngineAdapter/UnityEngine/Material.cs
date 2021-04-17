using System.Collections.Generic;

namespace UnityEngine
{
	public class Material: Object
	{
		//
		// Summary:
		//     Create a temporary Material.
		//
		// Parameters:
		//   shader:
		//     Create a material with a given Shader.
		//
		//   source:
		//     Create a material by copying all properties from another material.
		//public Material(Shader shader) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Create a temporary Material.
		//
		// Parameters:
		//   shader:
		//     Create a material with a given Shader.
		//
		//   source:
		//     Create a material by copying all properties from another material.
		//[RequiredByNativeCode]
		public Material(Material source) { throw new System.NotImplementedException(); }
		//
		// Parameters:
		//   contents:
		//[EditorBrowsable(EditorBrowsableState.Never)]
		//[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", false)]
		public Material(string contents) {
			//throw new System.NotImplementedException();
		}

		//
		// Summary:
		//     Additional shader keywords set by this material.
		public string[] shaderKeywords { get; set; }
		//
		// Summary:
		//     Gets and sets whether GPU instancing is enabled for this material.
		//[NativeProperty("EnableInstancingVariants")]
		public bool enableInstancing { get; set; }
		//
		// Summary:
		//     Gets and sets whether the Double Sided Global Illumination setting is enabled
		//     for this material.
		public bool doubleSidedGI { get; set; }
		//
		// Summary:
		//     Defines how the material should interact with lightmaps and lightprobes.
		//public MaterialGlobalIlluminationFlags globalIlluminationFlags { get; set; }
		//
		// Summary:
		//     Render queue of this material.
		public int renderQueue { get; set; }
		//
		// Summary:
		//     The texture scale of the main texture.
		public Vector2 mainTextureScale { get; set; }
		//
		// Summary:
		//     The texture offset of the main texture.
		public Vector2 mainTextureOffset { get; set; }
		//
		// Summary:
		//     The material's texture.
		public Texture mainTexture { get; set; }
		//
		// Summary:
		//     The main material's color.
		public Color color { get; set; }
		//
		// Summary:
		//     The shader used by the material.
		//public Shader shader { get; set; }
		//
		// Summary:
		//     How many passes are in this material (Read Only).
		public int passCount { get; }

		public static Material Create(string scriptContents) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Computes a CRC hash value from the content of the material.
		public int ComputeCRC() { throw new System.NotImplementedException(); }

		public void CopyPropertiesFromMaterial(Material mat) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Unset a shader keyword.
		//
		// Parameters:
		//   keyword:
		public void DisableKeyword(string keyword) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a shader keyword that is enabled by this material.
		//
		// Parameters:
		//   keyword:
		public void EnableKeyword(string keyword) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the index of the pass passName.
		//
		// Parameters:
		//   passName:
		public int FindPass(string passName) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named color value.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Color GetColor(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named color value.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Color GetColor(int nameID) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named color array.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Color[] GetColorArray(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named color array.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Color[] GetColorArray(int nameID) { throw new System.NotImplementedException(); }
		public void GetColorArray(int nameID, List<Color> values) { throw new System.NotImplementedException(); }
		public void GetColorArray(string name, List<Color> values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named float value.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public float GetFloat(int nameID) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named float value.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public float GetFloat(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named float array.
		//
		// Parameters:
		//   name:
		//     The name of the property.
		//
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		public float[] GetFloatArray(int nameID) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named float array.
		//
		// Parameters:
		//   name:
		//     The name of the property.
		//
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		public float[] GetFloatArray(string name) { throw new System.NotImplementedException(); }
		public void GetFloatArray(int nameID, List<float> values) { throw new System.NotImplementedException(); }
		public void GetFloatArray(string name, List<float> values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named integer value.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public int GetInt(int nameID) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named integer value.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public int GetInt(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named matrix value from the shader.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Matrix4x4 GetMatrix(int nameID) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named matrix value from the shader.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Matrix4x4 GetMatrix(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named matrix array.
		//
		// Parameters:
		//   name:
		//     The name of the property.
		//
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		public Matrix4x4[] GetMatrixArray(int nameID) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named matrix array.
		//
		// Parameters:
		//   name:
		//     The name of the property.
		//
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		public Matrix4x4[] GetMatrixArray(string name) { throw new System.NotImplementedException(); }
		public void GetMatrixArray(string name, List<Matrix4x4> values) { throw new System.NotImplementedException(); }
		public void GetMatrixArray(int nameID, List<Matrix4x4> values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the name of the shader pass at index pass.
		//
		// Parameters:
		//   pass:
		public string GetPassName(int pass) { throw new System.NotImplementedException(); }

		public bool GetShaderPassEnabled(string passName) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get the value of material's shader tag.
		//
		// Parameters:
		//   tag:
		//
		//   searchFallbacks:
		//
		//   defaultValue:
		public string GetTag(string tag, bool searchFallbacks, string defaultValue) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get the value of material's shader tag.
		//
		// Parameters:
		//   tag:
		//
		//   searchFallbacks:
		//
		//   defaultValue:
		public string GetTag(string tag, bool searchFallbacks) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named texture.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Texture GetTexture(int nameID) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a named texture.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Texture GetTexture(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Gets the placement offset of texture propertyName.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Vector2 GetTextureOffset(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Gets the placement offset of texture propertyName.
		//
		// Parameters:
		//   nameID:
		//     The name ID of the property retrieved by Shader.PropertyToID.
		//
		//   name:
		//     The name of the property.
		public Vector2 GetTextureOffset(int nameID) { throw new System.NotImplementedException(); }
		public void GetTexturePropertyNameIDs(List<int> outNames) { throw new System.NotImplementedException(); }

		public int[] GetTexturePropertyNameIDs() { throw new System.NotImplementedException(); }
		
		public string[] GetTexturePropertyNames() { throw new System.NotImplementedException(); }
		public void GetTexturePropertyNames(List<string> outNames) { throw new System.NotImplementedException(); }
		
		public Vector2 GetTextureScale(int nameID) { throw new System.NotImplementedException(); }
		
		public Vector2 GetTextureScale(string name) { throw new System.NotImplementedException(); }
		
		public Vector4 GetVector(int nameID) { throw new System.NotImplementedException(); }
		
		public Vector4 GetVector(string name) { throw new System.NotImplementedException(); }
		
		public Vector4[] GetVectorArray(string name) { throw new System.NotImplementedException(); }
		public void GetVectorArray(string name, List<Vector4> values) { throw new System.NotImplementedException(); }
		public void GetVectorArray(int nameID, List<Vector4> values) { throw new System.NotImplementedException(); }
		
		public Vector4[] GetVectorArray(int nameID) { throw new System.NotImplementedException(); }
		
		public bool HasProperty(string name) {
			return false;
			//throw new System.NotImplementedException();
		}
		
		public bool HasProperty(int nameID) {
			return false;
			}
		
		public bool IsKeywordEnabled(string keyword) { throw new System.NotImplementedException(); }
		
		public void Lerp(Material start, Material end, float t) { throw new System.NotImplementedException(); }
		
		//public void SetBuffer(int nameID, ComputeBuffer value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named ComputeBuffer value.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name.
		//
		//   value:
		//     The ComputeBuffer value to set.
		//public void SetBuffer(string name, ComputeBuffer value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named color value.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_Color".
		//
		//   value:
		//     Color value to set.
		public void SetColor(string name, Color value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named color value.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_Color".
		//
		//   value:
		//     Color value to set.
		public void SetColor(int nameID, Color value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a color array property.
		//
		// Parameters:
		//   name:
		//     Property name.
		//
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   values:
		//     Array of values to set.
		public void SetColorArray(int nameID, Color[] values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a color array property.
		//
		// Parameters:
		//   name:
		//     Property name.
		//
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   values:
		//     Array of values to set.
		public void SetColorArray(string name, Color[] values) { throw new System.NotImplementedException(); }
		public void SetColorArray(int nameID, List<Color> values) { throw new System.NotImplementedException(); }
		public void SetColorArray(string name, List<Color> values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a ComputeBuffer as a named constant buffer for the material.
		//
		// Parameters:
		//   name:
		//     The name of the constant buffer to override.
		//
		//   value:
		//     The ComputeBuffer to override the constant buffer values with, or null to remove
		//     binding.
		//
		//   offset:
		//     Offset in bytes from the beginning of the ComputeBuffer to bind. Must be a multiple
		//     of SystemInfo.MinConstantBufferAlignment, or 0 if that value is 0.
		//
		//   size:
		//     The number of bytes to bind.
		//
		//   nameID:
		//     The shader property ID of the constant buffer to override.
		//public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a ComputeBuffer as a named constant buffer for the material.
		//
		// Parameters:
		//   name:
		//     The name of the constant buffer to override.
		//
		//   value:
		//     The ComputeBuffer to override the constant buffer values with, or null to remove
		//     binding.
		//
		//   offset:
		//     Offset in bytes from the beginning of the ComputeBuffer to bind. Must be a multiple
		//     of SystemInfo.MinConstantBufferAlignment, or 0 if that value is 0.
		//
		//   size:
		//     The number of bytes to bind.
		//
		//   nameID:
		//     The shader property ID of the constant buffer to override.
		//public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named float value.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   value:
		//     Float value to set.
		//
		//   name:
		//     Property name, e.g. "_Glossiness".
		public void SetFloat(string name, float value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named float value.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   value:
		//     Float value to set.
		//
		//   name:
		//     Property name, e.g. "_Glossiness".
		public void SetFloat(int nameID, float value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a float array property.
		//
		// Parameters:
		//   name:
		//     Property name.
		//
		//   nameID:
		//     Property name ID. Use Shader.PropertyToID to get this ID.
		//
		//   values:
		//     Array of values to set.
		public void SetFloatArray(string name, float[] values) { throw new System.NotImplementedException(); }
		public void SetFloatArray(int nameID, List<float> values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a float array property.
		//
		// Parameters:
		//   name:
		//     Property name.
		//
		//   nameID:
		//     Property name ID. Use Shader.PropertyToID to get this ID.
		//
		//   values:
		//     Array of values to set.
		public void SetFloatArray(int nameID, float[] values) { throw new System.NotImplementedException(); }
		public void SetFloatArray(string name, List<float> values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named integer value.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   value:
		//     Integer value to set.
		//
		//   name:
		//     Property name, e.g. "_SrcBlend".
		public void SetInt(int nameID, int value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named integer value.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   value:
		//     Integer value to set.
		//
		//   name:
		//     Property name, e.g. "_SrcBlend".
		public void SetInt(string name, int value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named matrix for the shader.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_CubemapRotation".
		//
		//   value:
		//     Matrix value to set.
		public void SetMatrix(string name, Matrix4x4 value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named matrix for the shader.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_CubemapRotation".
		//
		//   value:
		//     Matrix value to set.
		public void SetMatrix(int nameID, Matrix4x4 value) { throw new System.NotImplementedException(); }
		public void SetMatrixArray(string name, List<Matrix4x4> values) { throw new System.NotImplementedException(); }
		public void SetMatrixArray(int nameID, List<Matrix4x4> values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a matrix array property.
		//
		// Parameters:
		//   name:
		//     Property name.
		//
		//   values:
		//     Array of values to set.
		//
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		public void SetMatrixArray(string name, Matrix4x4[] values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a matrix array property.
		//
		// Parameters:
		//   name:
		//     Property name.
		//
		//   values:
		//     Array of values to set.
		//
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		public void SetMatrixArray(int nameID, Matrix4x4[] values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets an override tag/value on the material.
		//
		// Parameters:
		//   tag:
		//     Name of the tag to set.
		//
		//   val:
		//     Name of the value to set. Empty string to clear the override flag.
		public void SetOverrideTag(string tag, string val) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Activate the given pass for rendering.
		//
		// Parameters:
		//   pass:
		//     Shader pass number to setup.
		//
		// Returns:
		//     If false is returned, no rendering should be done.
		//[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = true)]
		public bool SetPass(int pass) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Enables or disables a Shader pass on a per-Material level.
		//
		// Parameters:
		//   passName:
		//     Shader pass name (case insensitive).
		//
		//   enabled:
		//     Flag indicating whether this Shader pass should be enabled.
		//[FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = true)]
		public void SetShaderPassEnabled(string passName, bool enabled) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named texture.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_MainTex".
		//
		//   value:
		//     Texture to set.
		//
		//   element:
		//     Optional parameter that specifies the type of data from the render texture to
		//     set.
		//public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named texture.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_MainTex".
		//
		//   value:
		//     Texture to set.
		//
		//   element:
		//     Optional parameter that specifies the type of data from the render texture to
		//     set.
		//public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named texture.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_MainTex".
		//
		//   value:
		//     Texture to set.
		//
		//   element:
		//     Optional parameter that specifies the type of data from the render texture to
		//     set.
		public void SetTexture(int nameID, Texture value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named texture.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_MainTex".
		//
		//   value:
		//     Texture to set.
		//
		//   element:
		//     Optional parameter that specifies the type of data from the render texture to
		//     set.
		public void SetTexture(string name, Texture value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the placement offset of texture propertyName.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, for example: "_MainTex".
		//
		//   value:
		//     Texture placement offset.
		public void SetTextureOffset(int nameID, Vector2 value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the placement offset of texture propertyName.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, for example: "_MainTex".
		//
		//   value:
		//     Texture placement offset.
		public void SetTextureOffset(string name, Vector2 value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the placement scale of texture propertyName.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_MainTex".
		//
		//   value:
		//     Texture placement scale.
		public void SetTextureScale(int nameID, Vector2 value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the placement scale of texture propertyName.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_MainTex".
		//
		//   value:
		//     Texture placement scale.
		public void SetTextureScale(string name, Vector2 value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named vector value.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_WaveAndDistance".
		//
		//   value:
		//     Vector value to set.
		public void SetVector(int nameID, Vector4 value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a named vector value.
		//
		// Parameters:
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		//
		//   name:
		//     Property name, e.g. "_WaveAndDistance".
		//
		//   value:
		//     Vector value to set.
		public void SetVector(string name, Vector4 value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a vector array property.
		//
		// Parameters:
		//   name:
		//     Property name.
		//
		//   values:
		//     Array of values to set.
		//
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		public void SetVectorArray(int nameID, Vector4[] values) { throw new System.NotImplementedException(); }
		public void SetVectorArray(int nameID, List<Vector4> values) { throw new System.NotImplementedException(); }
		public void SetVectorArray(string name, List<Vector4> values) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a vector array property.
		//
		// Parameters:
		//   name:
		//     Property name.
		//
		//   values:
		//     Array of values to set.
		//
		//   nameID:
		//     Property name ID, use Shader.PropertyToID to get it.
		public void SetVectorArray(string name, Vector4[] values) { throw new System.NotImplementedException(); }
	}
}