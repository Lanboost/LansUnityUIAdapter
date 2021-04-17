
namespace UnityEngine
{

	public class Time
	{
		public Time() { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Slows game playback time to allow screenshots to be saved between frames.
		public static float captureDeltaTime { get; set; }
		//
		// Summary:
		//     The real time in seconds since the game started (Read Only).
		[NativeProperty("Realtime")]
		public static float realtimeSinceStartup { get; }
		[NativeProperty("RenderFrameCount")]
		public static int renderedFrameCount { get; }
		//
		// Summary:
		//     The total number of frames that have passed (Read Only).
		public static int frameCount { get; }
		//
		// Summary:
		//     The scale at which time passes. This can be used for slow motion effects.
		public static float timeScale { get; set; }
		//
		// Summary:
		//     The maximum time a frame can spend on particle updates. If the frame takes longer
		//     than this, then updates are split into multiple smaller updates.
		public static float maximumParticleDeltaTime { get; set; }
		//
		// Summary:
		//     A smoothed out Time.deltaTime (Read Only).
		public static float smoothDeltaTime { get; }
		//
		// Summary:
		//     The maximum time a frame can take. Physics and other fixed frame rate updates
		//     (like MonoBehaviour's MonoBehaviour.FixedUpdate) will be performed only for this
		//     duration of time per frame.
		public static float maximumDeltaTime { get; set; }
		//
		// Summary:
		//     The interval in seconds at which physics and other fixed frame rate updates (like
		//     MonoBehaviour's MonoBehaviour.FixedUpdate) are performed.
		public static float fixedDeltaTime { get; set; }
		//
		// Summary:
		//     The timeScale-independent interval in seconds from the last fixed frame to the
		//     current one (Read Only).
		public static float fixedUnscaledDeltaTime { get; set; }
		//
		// Summary:
		//     The timeScale-independent interval in seconds from the last frame to the current
		//     one (Read Only).
		public static float unscaledDeltaTime { get; set; }
		//
		// Summary:
		//     The TimeScale-independant time the latest MonoBehaviour.FixedUpdate has started
		//     (Read Only). This is the time in seconds since the start of the game.
		public static float fixedUnscaledTime { get; set; }
		//
		// Summary:
		//     The timeScale-independant time for this frame (Read Only). This is the time in
		//     seconds since the start of the game.
		public static float unscaledTime { get; set; }
		//
		// Summary:
		//     The time the latest MonoBehaviour.FixedUpdate has started (Read Only). This is
		//     the time in seconds since the start of the game.
		public static float fixedTime { get; set; }
		//
		// Summary:
		//     The completion time in seconds since the last frame (Read Only).
		public static float deltaTime { get; set; }
		//
		// Summary:
		//     The time this frame has started (Read Only). This is the time in seconds since
		//     the last level has been loaded.
		[NativeProperty("TimeSinceSceneLoad")]
		public static float timeSinceLevelLoad { get; }
		//
		// Summary:
		//     The time at the beginning of this frame (Read Only). This is the time in seconds
		//     since the start of the game.
		[NativeProperty("CurTime")]
		public static float time { get; set; }
		//
		// Summary:
		//     The reciprocal of Time.captureDeltaTime.
		public static int captureFramerate { get; set; }
		//
		// Summary:
		//     Returns true if called inside a fixed time step callback (like MonoBehaviour's
		//     MonoBehaviour.FixedUpdate), otherwise returns false.
		public static bool inFixedTimeStep { get; }
	}
}