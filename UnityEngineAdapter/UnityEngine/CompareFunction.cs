#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Rendering
{
	//
	// Summary:
	//     Depth or stencil comparison function.
	public enum CompareFunction
	{
		//
		// Summary:
		//     Depth or stencil test is disabled.
		Disabled = 0,
		//
		// Summary:
		//     Never pass depth or stencil test.
		Never = 1,
		//
		// Summary:
		//     Pass depth or stencil test when new value is less than old one.
		Less = 2,
		//
		// Summary:
		//     Pass depth or stencil test when values are equal.
		Equal = 3,
		//
		// Summary:
		//     Pass depth or stencil test when new value is less or equal than old one.
		LessEqual = 4,
		//
		// Summary:
		//     Pass depth or stencil test when new value is greater than old one.
		Greater = 5,
		//
		// Summary:
		//     Pass depth or stencil test when values are different.
		NotEqual = 6,
		//
		// Summary:
		//     Pass depth or stencil test when new value is greater or equal than old one.
		GreaterEqual = 7,
		//
		// Summary:
		//     Always pass depth or stencil test.
		Always = 8
	}
}