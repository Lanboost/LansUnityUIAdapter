#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.U2D
{
	public class SpriteAtlasManager
	{
		public SpriteAtlasManager() { throw new System.NotImplementedException(); }

		public static event Action<string, Action<SpriteAtlas>> atlasRequested;
		public static event Action<SpriteAtlas> atlasRegistered;
	}
}