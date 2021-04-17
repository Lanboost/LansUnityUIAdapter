#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
	//
	// Summary:
	//     Specifies which color components will get written into the target framebuffer.
	[Flags]
	public enum ColorWriteMask
	{
		//
		// Summary:
		//     Write alpha component.
		Alpha = 1,
		//
		// Summary:
		//     Write blue component.
		Blue = 2,
		//
		// Summary:
		//     Write green component.
		Green = 4,
		//
		// Summary:
		//     Write red component.
		Red = 8,
		//
		// Summary:
		//     Write all components (R, G, B and Alpha).
		All = 15
	}
}