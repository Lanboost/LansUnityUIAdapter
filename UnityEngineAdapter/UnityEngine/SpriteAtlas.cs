#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.U2D
{
	public class SpriteAtlas : Object
	{
		public SpriteAtlas() { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Return true if this SpriteAtlas is a variant.
		public bool isVariant { get; }
		//
		// Summary:
		//     Get the tag of this SpriteAtlas.
		public string tag { get; }
		//
		// Summary:
		//     Get the total number of Sprite packed into this atlas.
		public int spriteCount { get; }

		//
		// Summary:
		//     Return true if Sprite is packed into this SpriteAtlas.
		//
		// Parameters:
		//   sprite:
		public bool CanBindTo([NotNull] Sprite sprite) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Clone the first Sprite in this atlas that matches the name packed in this atlas
		//     and return it.
		//
		// Parameters:
		//   name:
		//     The name of the Sprite.
		public Sprite GetSprite(string name) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Clone all the Sprite in this atlas and fill them into the supplied array.
		//
		// Parameters:
		//   sprites:
		//     Array of Sprite that will be filled.
		//
		// Returns:
		//     The size of the returned array.
		public int GetSprites(Sprite[] sprites) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Clone all the Sprite matching the name in this atlas and fill them into the supplied
		//     array.
		//
		// Parameters:
		//   sprites:
		//     Array of Sprite that will be filled.
		//
		//   name:
		//     The name of the Sprite.
		public int GetSprites(Sprite[] sprites, string name) { throw new System.NotImplementedException(); }
	}
}