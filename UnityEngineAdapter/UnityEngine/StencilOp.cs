#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Rendering
{
	//
	// Summary:
	//     Specifies the operation that's performed on the stencil buffer when rendering.
	public enum StencilOp
	{
		//
		// Summary:
		//     Keeps the current stencil value.
		Keep = 0,
		//
		// Summary:
		//     Sets the stencil buffer value to zero.
		Zero = 1,
		//
		// Summary:
		//     Replace the stencil buffer value with reference value (specified in the shader).
		Replace = 2,
		//
		// Summary:
		//     Increments the current stencil buffer value. Clamps to the maximum representable
		//     unsigned value.
		IncrementSaturate = 3,
		//
		// Summary:
		//     Decrements the current stencil buffer value. Clamps to 0.
		DecrementSaturate = 4,
		//
		// Summary:
		//     Bitwise inverts the current stencil buffer value.
		Invert = 5,
		//
		// Summary:
		//     Increments the current stencil buffer value. Wraps stencil buffer value to zero
		//     when incrementing the maximum representable unsigned value.
		IncrementWrap = 6,
		//
		// Summary:
		//     Decrements the current stencil buffer value. Wraps stencil buffer value to the
		//     maximum representable unsigned value when decrementing a stencil buffer value
		//     of zero.
		DecrementWrap = 7
	}
}