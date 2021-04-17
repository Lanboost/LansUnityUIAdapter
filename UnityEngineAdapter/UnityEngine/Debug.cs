#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using System.Diagnostics;

namespace UnityEngine
{
	public class Debug
	{
		public Debug() { throw new System.NotImplementedException(); }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Debug.logger is obsolete. Please use Debug.unityLogger instead (UnityUpgradable) -> unityLogger")]
		//public static ILogger logger { get; }
		//
		// Summary:
		//     Reports whether the development console is visible. The development console cannot
		//     be made to appear using:
		public static bool developerConsoleVisible { get; set; }
		//
		// Summary:
		//     Get default debug logger.
		//public static ILogger unityLogger { get; }
		//
		// Summary:
		//     In the Build Settings dialog there is a check box called "Development Build".
		//[NativeProperty(TargetType = TargetType.Field)]
		//[StaticAccessor("GetBuildSettings()", StaticAccessorType.Dot)]
		//public static bool isDebugBuild { get; }

		[Conditional("UNITY_ASSERTIONS")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Assert(bool, string, params object[]) is obsolete. Use AssertFormat(bool, string, params object[]) (UnityUpgradable) -> AssertFormat(*)", true)]
		public static void Assert(bool condition, string format, params object[] args) { throw new System.NotImplementedException(); }
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message, Object context) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Assert a condition and logs an error message to the Unity console on failure.
		//
		// Parameters:
		//   condition:
		//     Condition you expect to be true.
		//
		//   context:
		//     Object to which the message applies.
		//
		//   message:
		//     String or object to be converted to string representation for display.
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Assert a condition and logs an error message to the Unity console on failure.
		//
		// Parameters:
		//   condition:
		//     Condition you expect to be true.
		//
		//   context:
		//     Object to which the message applies.
		//
		//   message:
		//     String or object to be converted to string representation for display.
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message, Object context) { throw new System.NotImplementedException(); }
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Assert a condition and logs an error message to the Unity console on failure.
		//
		// Parameters:
		//   condition:
		//     Condition you expect to be true.
		//
		//   context:
		//     Object to which the message applies.
		//
		//   message:
		//     String or object to be converted to string representation for display.
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Assert a condition and logs an error message to the Unity console on failure.
		//
		// Parameters:
		//   condition:
		//     Condition you expect to be true.
		//
		//   context:
		//     Object to which the message applies.
		//
		//   message:
		//     String or object to be converted to string representation for display.
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, Object context) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Assert a condition and logs a formatted error message to the Unity console on
		//     failure.
		//
		// Parameters:
		//   condition:
		//     Condition you expect to be true.
		//
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, Object context, string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Assert a condition and logs a formatted error message to the Unity console on
		//     failure.
		//
		// Parameters:
		//   condition:
		//     Condition you expect to be true.
		//
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Pauses the editor.
		[FreeFunction("PauseEditor")]
		public static void Break() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Clears errors from the developer console.
		public static void ClearDeveloperConsole() { throw new System.NotImplementedException(); }
		public static void DebugBreak() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Draws a line between specified start and end points.
		//
		// Parameters:
		//   start:
		//     Point in world space where the line should start.
		//
		//   end:
		//     Point in world space where the line should end.
		//
		//   color:
		//     Color of the line.
		//
		//   duration:
		//     How long the line should be visible for.
		//
		//   depthTest:
		//     Should the line be obscured by objects closer to the camera?
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Draws a line between specified start and end points.
		//
		// Parameters:
		//   start:
		//     Point in world space where the line should start.
		//
		//   end:
		//     Point in world space where the line should end.
		//
		//   color:
		//     Color of the line.
		//
		//   duration:
		//     How long the line should be visible for.
		//
		//   depthTest:
		//     Should the line be obscured by objects closer to the camera?
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Draws a line between specified start and end points.
		//
		// Parameters:
		//   start:
		//     Point in world space where the line should start.
		//
		//   end:
		//     Point in world space where the line should end.
		//
		//   color:
		//     Color of the line.
		//
		//   duration:
		//     How long the line should be visible for.
		//
		//   depthTest:
		//     Should the line be obscured by objects closer to the camera?
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Draws a line between specified start and end points.
		//
		// Parameters:
		//   start:
		//     Point in world space where the line should start.
		//
		//   end:
		//     Point in world space where the line should end.
		//
		//   color:
		//     Color of the line.
		//
		//   duration:
		//     How long the line should be visible for.
		//
		//   depthTest:
		//     Should the line be obscured by objects closer to the camera?
		//[FreeFunction("DebugDrawLine")]
		//public static void DrawLine(Vector3 start, Vector3 end, [Internal.DefaultValue("Color.white")] Color color, [Internal.DefaultValue("0.0f")] float duration, [Internal.DefaultValue("true")] bool depthTest) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Draws a line from start to start + dir in world coordinates.
		//
		// Parameters:
		//   start:
		//     Point in world space where the ray should start.
		//
		//   dir:
		//     Direction and length of the ray.
		//
		//   color:
		//     Color of the drawn line.
		//
		//   duration:
		//     How long the line will be visible for (in seconds).
		//
		//   depthTest:
		//     Should the line be obscured by other objects closer to the camera?
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Draws a line from start to start + dir in world coordinates.
		//
		// Parameters:
		//   start:
		//     Point in world space where the ray should start.
		//
		//   dir:
		//     Direction and length of the ray.
		//
		//   color:
		//     Color of the drawn line.
		//
		//   duration:
		//     How long the line will be visible for (in seconds).
		//
		//   depthTest:
		//     Should the line be obscured by other objects closer to the camera?
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Draws a line from start to start + dir in world coordinates.
		//
		// Parameters:
		//   start:
		//     Point in world space where the ray should start.
		//
		//   dir:
		//     Direction and length of the ray.
		//
		//   color:
		//     Color of the drawn line.
		//
		//   duration:
		//     How long the line will be visible for (in seconds).
		//
		//   depthTest:
		//     Should the line be obscured by other objects closer to the camera?
		//public static void DrawRay(Vector3 start, Vector3 dir, [Internal.DefaultValue("Color.white")] Color color, [Internal.DefaultValue("0.0f")] float duration, [Internal.DefaultValue("true")] bool depthTest) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Draws a line from start to start + dir in world coordinates.
		//
		// Parameters:
		//   start:
		//     Point in world space where the ray should start.
		//
		//   dir:
		//     Direction and length of the ray.
		//
		//   color:
		//     Color of the drawn line.
		//
		//   duration:
		//     How long the line will be visible for (in seconds).
		//
		//   depthTest:
		//     Should the line be obscured by other objects closer to the camera?
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a message to the Unity Console.
		//
		// Parameters:
		//   message:
		//     String or object to be converted to string representation for display.
		//
		//   context:
		//     Object to which the message applies.
		public static void Log(object message) {
			//Logger.Info("This is an informational log"); // at log-level INFO
			UnityEngineAdapter.Logger.Log(message);
		}
		//
		// Summary:
		//     Logs a message to the Unity Console.
		//
		// Parameters:
		//   message:
		//     String or object to be converted to string representation for display.
		//
		//   context:
		//     Object to which the message applies.
		public static void Log(object message, Object context) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     A variant of Debug.Log that logs an assertion message to the console.
		//
		// Parameters:
		//   message:
		//     String or object to be converted to string representation for display.
		//
		//   context:
		//     Object to which the message applies.
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message, Object context) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     A variant of Debug.Log that logs an assertion message to the console.
		//
		// Parameters:
		//   message:
		//     String or object to be converted to string representation for display.
		//
		//   context:
		//     Object to which the message applies.
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a formatted assertion message to the Unity console.
		//
		// Parameters:
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(Object context, string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a formatted assertion message to the Unity console.
		//
		// Parameters:
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     A variant of Debug.Log that logs an error message to the console.
		//
		// Parameters:
		//   message:
		//     String or object to be converted to string representation for display.
		//
		//   context:
		//     Object to which the message applies.
		public static void LogError(object message, Object context) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     A variant of Debug.Log that logs an error message to the console.
		//
		// Parameters:
		//   message:
		//     String or object to be converted to string representation for display.
		//
		//   context:
		//     Object to which the message applies.
		public static void LogError(object message) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a formatted error message to the Unity console.
		//
		// Parameters:
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		public static void LogErrorFormat(Object context, string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a formatted error message to the Unity console.
		//
		// Parameters:
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		public static void LogErrorFormat(string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     A variant of Debug.Log that logs an error message to the console.
		//
		// Parameters:
		//   context:
		//     Object to which the message applies.
		//
		//   exception:
		//     Runtime Exception.
		public static void LogException(Exception exception) {


			//throw new System.NotImplementedException();
			Debug.Log("EXCEPTION: " + exception.ToString());
		}
		//
		// Summary:
		//     A variant of Debug.Log that logs an error message to the console.
		//
		// Parameters:
		//   context:
		//     Object to which the message applies.
		//
		//   exception:
		//     Runtime Exception.
		public static void LogException(Exception exception, Object context) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a formatted message to the Unity Console.
		//
		// Parameters:
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		//
		//   logType:
		//     Type of message e.g. warn or error etc.
		//
		//   logOptions:
		//     Option flags to treat the log message special.
		public static void LogFormat(string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a formatted message to the Unity Console.
		//
		// Parameters:
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		//
		//   logType:
		//     Type of message e.g. warn or error etc.
		//
		//   logOptions:
		//     Option flags to treat the log message special.
		public static void LogFormat(Object context, string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a formatted message to the Unity Console.
		//
		// Parameters:
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		//
		//   logType:
		//     Type of message e.g. warn or error etc.
		//
		//   logOptions:
		//     Option flags to treat the log message special.
		//public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     A variant of Debug.Log that logs a warning message to the console.
		//
		// Parameters:
		//   message:
		//     String or object to be converted to string representation for display.
		//
		//   context:
		//     Object to which the message applies.
		public static void LogWarning(object message, Object context) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     A variant of Debug.Log that logs a warning message to the console.
		//
		// Parameters:
		//   message:
		//     String or object to be converted to string representation for display.
		//
		//   context:
		//     Object to which the message applies.
		public static void LogWarning(object message) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a formatted warning message to the Unity Console.
		//
		// Parameters:
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		public static void LogWarningFormat(Object context, string format, params object[] args) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Logs a formatted warning message to the Unity Console.
		//
		// Parameters:
		//   format:
		//     A composite format string.
		//
		//   args:
		//     Format arguments.
		//
		//   context:
		//     Object to which the message applies.
		public static void LogWarningFormat(string format, params object[] args) { throw new System.NotImplementedException(); }
	}
}