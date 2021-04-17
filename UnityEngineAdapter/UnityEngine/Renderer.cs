#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace UnityEngine
{
	public class Renderer : Component
	{
		/*public Renderer();

		//
		// Summary:
		//     The light probe interpolation type.
		public LightProbeUsage lightProbeUsage { get; set; }
		//
		// Summary:
		//     This value sorts renderers by priority. Lower values are rendered first and higher
		//     values are rendered last.
		public int rendererPriority { get; set; }
		//
		// Summary:
		//     Describes how this renderer is updated for ray tracing.
		public RayTracingMode rayTracingMode { get; set; }
		//
		// Summary:
		//     Name of the Renderer's sorting layer.
		public string sortingLayerName { get; set; }
		//
		// Summary:
		//     Unique ID of the Renderer's sorting layer.
		*/
		public int sortingLayerID { get; set; }
		
		//
		// Summary:
		//     Renderer's order within a sorting layer.
		public int sortingOrder { get; set; }
		/*
		//
		// Summary:
		//     Controls if dynamic occlusion culling should be performed for this renderer.
		[NativeProperty("IsDynamicOccludee")]
		public bool allowOcclusionWhenDynamic { get; set; }
		//
		// Summary:
		//     Has this renderer been statically batched with any other renderers?
		public bool isPartOfStaticBatch { get; }
		//
		// Summary:
		//     Matrix that transforms a point from world space into local space (Read Only).
		public Matrix4x4 worldToLocalMatrix { get; }
		//
		// Summary:
		//     Matrix that transforms a point from local space into world space (Read Only).
		public Matrix4x4 localToWorldMatrix { get; }
		//
		// Summary:
		//     If set, the Renderer will use the Light Probe Proxy Volume component attached
		//     to the source GameObject.
		public GameObject lightProbeProxyVolumeOverride { get; set; }
		//
		// Summary:
		//     If set, Renderer will use this Transform's position to find the light or reflection
		//     probe.
		public Transform probeAnchor { get; set; }
		//
		// Summary:
		//     The index of the baked lightmap applied to this renderer.
		public int lightmapIndex { get; set; }
		//
		// Summary:
		//     The index of the realtime lightmap applied to this renderer.
		public int realtimeLightmapIndex { get; set; }
		//
		// Summary:
		//     The UV scale & offset used for a lightmap.
		public Vector4 lightmapScaleOffset { get; set; }
		//
		// Summary:
		//     The UV scale & offset used for a realtime lightmap.
		public Vector4 realtimeLightmapScaleOffset { get; set; }
		//
		// Summary:
		//     Returns all the instantiated materials of this object.
		public Material[] materials { get; set; }
		//
		// Summary:
		//     Returns the first instantiated Material assigned to the renderer.
		public Material material { get; set; }
		//
		// Summary:
		//     Determines which rendering layer this renderer lives on.
		public uint renderingLayerMask { get; set; }
		//
		// Summary:
		//     Should reflection probes be used for this Renderer?
		public ReflectionProbeUsage reflectionProbeUsage { get; set; }
		//
		// Summary:
		//     All the shared materials of this object.
		public Material[] sharedMaterials { get; set; }
		//
		// Summary:
		//     Specifies the mode for motion vector rendering.
		public MotionVectorGenerationMode motionVectorGenerationMode { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property lightmapTilingOffset has been deprecated. Use lightmapScaleOffset (UnityUpgradable) -> lightmapScaleOffset", true)]
		public Vector4 lightmapTilingOffset { get; set; }
		//
		// Summary:
		//     The shared material of this object.
		public Material sharedMaterial { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use shadowCastingMode instead.", false)]
		public bool castShadows { get; set; }
		//
		// Summary:
		//     Specifies whether this renderer has a per-object motion vector pass.
		[Obsolete("Use motionVectorGenerationMode instead.", false)]
		public bool motionVectors { get; set; }
		//
		// Summary:
		//     Should light probes be used for this Renderer?
		[Obsolete("Use lightProbeUsage instead.", false)]
		public bool useLightProbes { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use probeAnchor instead (UnityUpgradable) -> probeAnchor", true)]
		public Transform lightProbeAnchor { get; set; }
		//
		// Summary:
		//     Makes the rendered 3D object visible if enabled.
		public bool enabled { get; set; }
		//
		// Summary:
		//     Is this renderer visible in any camera? (Read Only)
		public bool isVisible { get; }
		//
		// Summary:
		//     Does this object cast shadows?
		public ShadowCastingMode shadowCastingMode { get; set; }
		//
		// Summary:
		//     Does this object receive shadows?
		public bool receiveShadows { get; set; }
		//
		// Summary:
		//     Allows turning off rendering for a specific component.
		public bool forceRenderingOff { get; set; }
		//
		// Summary:
		//     The bounding volume of the renderer (Read Only).
		public Bounds bounds { get; }

		public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result);
		public void GetMaterials(List<Material> m);
		//
		// Summary:
		//     Get per-Renderer or per-Material property block.
		//
		// Parameters:
		//   properties:
		//     Material parameters to retrieve.
		//
		//   materialIndex:
		//     The index of the Material you want to get overridden parameters from. The index
		//     ranges from 0 to Renderer.sharedMaterials.Length-1.
		public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex);
		//
		// Summary:
		//     Get per-Renderer or per-Material property block.
		//
		// Parameters:
		//   properties:
		//     Material parameters to retrieve.
		//
		//   materialIndex:
		//     The index of the Material you want to get overridden parameters from. The index
		//     ranges from 0 to Renderer.sharedMaterials.Length-1.
		public void GetPropertyBlock(MaterialPropertyBlock properties);
		public void GetSharedMaterials(List<Material> m);
		//
		// Summary:
		//     Returns true if the Renderer has a material property block attached via SetPropertyBlock.
		[FreeFunction(Name = "RendererScripting::HasPropertyBlock", HasExplicitThis = true)]
		public bool HasPropertyBlock();
		//
		// Summary:
		//     Lets you set or clear per-renderer or per-material parameter overrides.
		//
		// Parameters:
		//   properties:
		//     Property block with values you want to override.
		//
		//   materialIndex:
		//     The index of the Material you want to override the parameters of. The index ranges
		//     from 0 to Renderer.sharedMaterial.Length-1.
		public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex);
		//
		// Summary:
		//     Lets you set or clear per-renderer or per-material parameter overrides.
		//
		// Parameters:
		//   properties:
		//     Property block with values you want to override.
		//
		//   materialIndex:
		//     The index of the Material you want to override the parameters of. The index ranges
		//     from 0 to Renderer.sharedMaterial.Length-1.
		public void SetPropertyBlock(MaterialPropertyBlock properties);
		*/
	}
}