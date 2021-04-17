#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
	//
	// Summary:
	//     Wrap mode for textures.
	public enum TextureWrapMode
	{
		//
		// Summary:
		//     Tiles the texture, creating a repeating pattern.
		Repeat = 0,
		//
		// Summary:
		//     Clamps the texture to the last pixel at the edge.
		Clamp = 1,
		//
		// Summary:
		//     Tiles the texture, creating a repeating pattern by mirroring it at every integer
		//     boundary.
		Mirror = 2,
		//
		// Summary:
		//     Mirrors the texture once, then clamps to edge pixels.
		MirrorOnce = 3
	}
}