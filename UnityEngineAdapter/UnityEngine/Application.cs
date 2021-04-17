#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using System.Security;

using UnityEngine.Events;

namespace UnityEngine
{

	public class Application
	{
		public Application() { }

		//
		// Summary:
		//     Returns application version number (Read Only).
		public static string version { get; }
		//
		// Summary:
		//     The version of the Unity runtime used to play the content.
		public static string unityVersion { get; }
		//
		// Summary:
		//     The URL of the document. For WebGL, this a web URL. For Android, iOS, or Universal
		//     Windows Platform (UWP) this is a deep link URL. (Read Only)
		public static string absoluteURL { get; }
		//
		// Summary:
		//     Contains the path to a temporary data / cache directory (Read Only).
		public static string temporaryCachePath { get; }
		
		public static string persistentDataPath { get; }
		//
		// Summary:
		//     The path to the StreamingAssets folder (Read Only).
		public static string streamingAssetsPath { get; }
		//
		// Summary:
		//     Returns the name of the store or package that installed the application (Read
		//     Only).
		public static string installerName { get; }
		//
		// Summary:
		//     Contains the path to the game data folder on the target device (Read Only).
		public static string dataPath { get; }
		//
		// Summary:
		//     Note: This is now obsolete. Use SceneManager.GetActiveScene instead. (Read Only).
		[Obsolete("Use SceneManager to determine what scenes have been loaded")]
		public static int loadedLevel { get; }
		//
		// Summary:
		//     Returns a GUID for this build (Read Only).
		public static string buildGUID { get; }
		//
		// Summary:
		//     Whether the player currently has focus. Read-only.
		public static bool isFocused { get; }
		//
		// Summary:
		//     Returns true when called in any kind of built Player, or when called in the Editor
		//     in Play Mode (Read Only).
		public static bool isPlaying { get => true; }
		//
		// Summary:
		//     Indicates whether Unity's webplayer security model is enabled.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Application.webSecurityEnabled is no longer supported, since the Unity Web Player is no longer supported by Unity", true)]
		public static bool webSecurityEnabled { get; }
		//
		// Summary:
		//     How many bytes have we downloaded from the main unity web stream (Read Only).
		[Obsolete("Streaming was a Unity Web Player feature, and is removed. This property is deprecated and always returns 0.")]
		public static int streamedBytes { get; }
		//
		// Summary:
		//     Returns true when Unity is launched with the -batchmode flag from the command
		//     line (Read Only).
		public static bool isBatchMode { get; }
		//
		// Summary:
		//     Returns application identifier at runtime. On Apple platforms this is the 'bundleIdentifier'
		//     saved in the info.plist file, on Android it's the 'package' from the AndroidManifest.xml.
		public static string identifier { get; }
		//
		// Summary:
		//     Is the current Runtime platform a known console platform.
		public static bool isConsolePlatform { get; }
		//
		// Summary:
		//     Is the current Runtime platform a known mobile platform.
		public static bool isMobilePlatform { get; }
		//
		// Summary:
		//     Returns the platform the game is running on (Read Only).
		public static RuntimePlatform platform { get; }
		//
		// Summary:
		//     Checks whether splash screen is being shown.
		[Obsolete("This property is deprecated, please use SplashScreen.isFinished instead")]
		public static bool isShowingSplashScreen { get; }
		//
		// Summary:
		//     Returns true if application integrity can be confirmed.
		public static bool genuineCheckAvailable { get; }
		//
		// Summary:
		//     Returns false if application is altered in any way after it was built.
		public static bool genuine { get; }
		//
		// Summary:
		//     Returns the path to the console log file, or an empty string if the current platform
		//     does not support log files.
		public static string consoleLogPath { get; }
		//
		// Summary:
		//     Instructs the game to try to render at a specified frame rate.
		public static int targetFrameRate { get; set; }
		//
		// Summary:
		//     A unique cloud project identifier. It is unique for every project (Read Only).
		public static string cloudProjectId { get; }
		//
		// Summary:
		//     Return application company name (Read Only).
		public static string companyName { get; }
		//
		// Summary:
		//     Returns application product name (Read Only).
		public static string productName { get; }
		//
		// Summary:
		//     Is some level being loaded? (Read Only) (Obsolete).
		[Obsolete("This property is deprecated, please use LoadLevelAsync to detect if a specific scene is currently loading.")]
		public static bool isLoadingLevel { get; }
		[Obsolete("use Application.isEditor instead")]
		public static bool isPlayer { get; }
		//
		// Summary:
		//     Should the player be running when the application is in the background?
		public static bool runInBackground { get; set; }
		//
		// Summary:
		//     Are we running inside the Unity editor? (Read Only)
		public static bool isEditor { get; }
		//
		// Summary:
		//     The name of the level that was last loaded (Read Only).
		[Obsolete("Use SceneManager to determine what scenes have been loaded")]
		public static string loadedLevelName { get; }
		//
		// Summary:
		//     The total number of levels available (Read Only).
		[Obsolete("Use SceneManager.sceneCountInBuildSettings")]
		public static int levelCount { get; }

		public static event UnityAction onBeforeRender;
		public static event Action quitting;
		public static event Func<bool> wantsToQuit;
		public static event LowMemoryCallback lowMemory;
		public static event Action<string> deepLinkActivated;
		public static event Action<bool> focusChanged;
		
		

		public static bool IsPlaying(Object obj)
		{
			return true;
		}
		public delegate void AdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled, string errorMsg);
		//
		// Summary:
		//     This is the delegate function when a mobile device notifies of low memory.
		public delegate void LowMemoryCallback();
		
	}
}