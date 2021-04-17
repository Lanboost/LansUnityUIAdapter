#region Assembly UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextRenderingModule.dll
#endregion

using System;

namespace UnityEngine {

	public sealed class Font : Object
	{
		//
		// Summary:
		//     Create a new Font.
		//
		// Parameters:
		//   name:
		//     The name of the created Font object.
		public Font() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Create a new Font.
		//
		// Parameters:
		//   name:
		//     The name of the created Font object.
		public Font(string name) { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     The ascent of the font.
		public int ascent { get; }
		//
		// Summary:
		//     Is the font a dynamic font.
		public bool dynamic { get; }
		public string[] fontNames { get; set; }
		//
		// Summary:
		//     The material used for the font display.
		public Material material { get; set; }
		//
		// Summary:
		//     The line height of the font.

		public int lineHeight { get; }
		[Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
		public FontTextureRebuildCallback textureRebuildCallback { get; set; }
		//
		// Summary:
		//     The default size of the font.
		public int fontSize { get; }
		//
		// Summary:
		//     Access an array of all characters contained in the font texture.
		//public CharacterInfo[] characterInfo { get; set; }

		public static event Action<Font> textureRebuilt;

		//
		// Summary:
		//     Creates a Font object which lets you render a font installed on the user machine.
		//
		// Parameters:
		//   fontname:
		//     The name of the OS font to use for this font object.
		//
		//   size:
		//     The default character size of the generated font.
		//
		//   fontnames:
		//     Am array of names of OS fonts to use for this font object. When rendering characters
		//     using this font object, the first font which is installed on the machine, which
		//     contains the requested character will be used.
		//
		// Returns:
		//     The generate Font object.
		public static Font CreateDynamicFontFromOSFont(string[] fontnames, int size) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a Font object which lets you render a font installed on the user machine.
		//
		// Parameters:
		//   fontname:
		//     The name of the OS font to use for this font object.
		//
		//   size:
		//     The default character size of the generated font.
		//
		//   fontnames:
		//     Am array of names of OS fonts to use for this font object. When rendering characters
		//     using this font object, the first font which is installed on the machine, which
		//     contains the requested character will be used.
		//
		// Returns:
		//     The generate Font object.
		public static Font CreateDynamicFontFromOSFont(string fontname, int size) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the maximum number of verts that the text generator may return for a
		//     given string.
		//
		// Parameters:
		//   str:
		//     Input string.
		public static int GetMaxVertsForString(string str) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get names of fonts installed on the machine.
		//
		// Returns:
		//     An array of the names of all fonts installed on the machine.
		public static string[] GetOSInstalledFontNames() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Gets the file paths of the fonts that are installed on the operating system.
		//
		// Returns:
		//     An array of the file paths of all fonts installed on the machine.
		public static string[] GetPathsToOSFonts() { throw new System.NotImplementedException(); }
		//[ExcludeFromDocs]
		//public bool GetCharacterInfo(char ch, out CharacterInfo info) { throw new System.NotImplementedException(); }

		//public bool GetCharacterInfo(char ch, out CharacterInfo info, [DefaultValue("0")] int size, [DefaultValue("FontStyle.Normal")] FontStyle style);
		//[ExcludeFromDocs]
		//public bool GetCharacterInfo(char ch, out CharacterInfo info, int size);
		//
		// Summary:
		//     Does this font have a specific character?
		//
		// Parameters:
		//   c:
		//     The character to check for.
		//
		// Returns:
		//     Whether or not the font has the character specified.
		public bool HasCharacter(char c) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Request characters to be added to the font texture (dynamic fonts only).
		//
		// Parameters:
		//   characters:
		//     The characters which are needed to be in the font texture.
		//
		//   size:
		//     The size of the requested characters (the default value of zero will use the
		//     font's default size).
		//
		//   style:
		//     The style of the requested characters.
		//public void RequestCharactersInTexture(string characters, [DefaultValue("0")] int size, [DefaultValue("FontStyle.Normal")] FontStyle style);
		//[ExcludeFromDocs]
		//public void RequestCharactersInTexture(string characters, int size);
		//[ExcludeFromDocs]
		//public void RequestCharactersInTexture(string characters);

		public delegate void FontTextureRebuildCallback();
	}
}