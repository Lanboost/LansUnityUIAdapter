using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UnityEngine.UI
{


	public class Debug
	{
		public static void Log(object message) { }
		public static void Log(object message, Object context) { }
		public static void LogAssertion(object message, Object context) { }
		public static void LogAssertion(object message) { }
		public static void LogAssertionFormat(Object context, string format, params object[] args) { }
		public static void LogAssertionFormat(string format, params object[] args) { }
		public static void LogError(object message, Object context) { }
		public static void LogError(object message) { }
		public static void LogErrorFormat(Object context, string format, params object[] args) { }
		public static void LogErrorFormat(string format, params object[] args) { }
		public static void LogException(Exception exception) { }
		public static void LogException(Exception exception, Object context) { }
		public static void LogFormat(string format, params object[] args) { }
		public static void LogFormat(Object context, string format, params object[] args) { }
		public static void LogWarning(object message, Object context) { }
		public static void LogWarning(object message) { }
		public static void LogWarningFormat(Object context, string format, params object[] args) { }
		public static void LogWarningFormat(string format, params object[] args) { }
	}

}

namespace UnityEngine
{
	class Helper
	{
		public static void Call(MonoBehaviour m, String name)
		{
			var method = m.GetType().GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
			if (method != null)
			{
				method.Invoke(m, null);
			}
		}
	}



	public sealed class SerializeField : Attribute
	{
	}

	public sealed class Tooltip : Attribute
	{
		public Tooltip(string data) { }
	}

	public sealed class Range : Attribute
	{
		public Range(int i1, int i2) { }
		public Range(float i1, float i2) { }
	}

	public sealed class ExecuteAlways : Attribute { }
	public sealed class DisallowMultipleComponent : Attribute { }



	public sealed class AddComponentMenu : Attribute
	{
		public AddComponentMenu(string str1, int i1 = 0) { }
	}

	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public sealed class RequireComponent : Attribute
	{
		public RequireComponent(Type t) { }
	}
	public sealed class SelectionBase : Attribute { }

	public enum VerticalWrapMode
	{
		Truncate = 0,
		Overflow = 1
	}

	public class UnityException : SystemException
	{
		public UnityException() { }
		public UnityException(string message) : base(message) { }
		public UnityException(string message, Exception innerException) : base(message) { }
	}

	public enum TextAnchor
	{
		UpperLeft = 0,
		UpperCenter = 1,
		UpperRight = 2,
		MiddleLeft = 3,
		MiddleCenter = 4,
		MiddleRight = 5,
		LowerLeft = 6,
		LowerCenter = 7,
		LowerRight = 8
	}





	public sealed class ExcludeFromDocs : Attribute { }
	public sealed class NativeThrows : Attribute { }
	public sealed class NotNull : Attribute { }
	public sealed class ExecuteInEditMode : Attribute
	{
	}
	public sealed class NativeName : Attribute
	{
		public NativeName(string str) { }
	}
	public sealed class NativeMethod : Attribute
	{
		public NativeMethod(string str = "") { }

		public string Name { get; set; }
		public bool HasExplicitThis { get; set; }
		public bool ThrowsException { get; set; }
		public bool IsFreeFunction { get; set; }
	}
	public sealed class NativeProperty : Attribute
	{
		public NativeProperty(string str) { }
	}

	public sealed class DefaultValue : Attribute
	{
		public DefaultValue(string str) { }
	}

	public sealed class StaticAccessor : Attribute
	{
		public StaticAccessor(string str, StaticAccessorType t) { }
	}

	public enum StaticAccessorType
	{
		DoubleColon,
	}

	public sealed class FreeFunction : Attribute
	{
		public FreeFunction(string str1 = "") { }

		public string Name { get; set; }
		public bool HasExplicitThis { get; set; }
		public bool ThrowsException { get; set; }
		public bool IsThreadSafe { get; set; }
	}

	public sealed class Space : Attribute
	{
		public Space(int i = 0) { }
	}

	public sealed class TextArea : Attribute
	{
		public TextArea(int i1, int i2) { }
	}
}

namespace UnityEngine.Events
{

	public class UnityEventBase { }


	public class UnityEvent : UnityEventBase
	{
		List<UnityAction> list = new List<UnityAction>();
		public UnityEvent() { }
		public void AddListener(UnityAction call)
		{
			list.Add(call);
		}
		public void Invoke()
		{
			foreach (var v in list)
			{
				v.Invoke();
			}
		}
		public void RemoveListener(UnityAction call)
		{
			list.Remove(call);
		}
		//protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	}

	public abstract class UnityEvent<T0> : UnityEventBase
	{
		List<UnityAction<T0>> list = new List<UnityAction<T0>>();
		public UnityEvent() { }
		public void AddListener(UnityAction<T0> call)
		{
			list.Add(call);
		}
		public void Invoke(T0 arg0)
		{
			foreach (var v in list)
			{
				v.Invoke(arg0);
			}
		}
		public void RemoveListener(UnityAction<T0> call)
		{
			list.Remove(call);
		}
	}
}