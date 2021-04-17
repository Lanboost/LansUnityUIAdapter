using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
	//
	// Summary:
	//     Determines whether the mouse cursor is rendered using software rendering or,
	//     on supported platforms, hardware rendering.
	public enum CursorMode
	{
		//
		// Summary:
		//     Use hardware cursors on supported platforms.
		Auto = 0,
		//
		// Summary:
		//     Force the use of software cursors.
		ForceSoftware = 1
	}
}