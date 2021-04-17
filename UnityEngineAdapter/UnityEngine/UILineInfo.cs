#region Assembly UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextRenderingModule.dll
#endregion

namespace UnityEngine
{
	public struct UILineInfo
	{
		//
		// Summary:
		//     Index of the first character in the line.
		public int startCharIdx;
		//
		// Summary:
		//     Height of the line.
		public int height;
		//
		// Summary:
		//     The upper Y position of the line in pixels. This is used for text annotation
		//     such as the caret and selection box in the InputField.
		public float topY;
		//
		// Summary:
		//     Space in pixels between this line and the next line.
		public float leading;
	}
}