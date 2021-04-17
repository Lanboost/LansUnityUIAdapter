using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.Serialization
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public sealed class FormerlySerializedAs : Attribute
	{
		public FormerlySerializedAs(string str1) { }
	}
}
