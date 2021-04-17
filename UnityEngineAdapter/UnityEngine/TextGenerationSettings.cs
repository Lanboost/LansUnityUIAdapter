namespace UnityEngine
{
	//
	// Summary:
	//     A struct that stores the settings for TextGeneration.
	public struct TextGenerationSettings
	{
		//
		// Summary:
		//     Font to use for generation.
		public Font font;
		//
		// Summary:
		//     Generated vertices are offset by the pivot.
		public Vector2 pivot;
		//
		// Summary:
		//     Extents that the generator will attempt to fit the text in.
		public Vector2 generationExtents;
		//
		// Summary:
		//     What happens to text when it reaches the horizontal generation bounds.
		public HorizontalWrapMode horizontalOverflow;
		//
		// Summary:
		//     What happens to text when it reaches the bottom generation bounds.
		public VerticalWrapMode verticalOverflow;
		//
		// Summary:
		//     Should the text generator update the bounds from the generated text.
		public bool updateBounds;
		//
		// Summary:
		//     Maximum size for resized text.
		public int resizeTextMaxSize;
		//
		// Summary:
		//     Minimum size for resized text.
		public int resizeTextMinSize;
		//
		// Summary:
		//     Continue to generate characters even if the text runs out of bounds.
		public bool generateOutOfBounds;
		//
		// Summary:
		//     Should the text be resized to fit the configured bounds?
		public bool resizeTextForBestFit;
		//
		// Summary:
		//     How is the generated text anchored.
		public TextAnchor textAnchor;
		//
		// Summary:
		//     Font style.
		public FontStyle fontStyle;
		//
		// Summary:
		//     A scale factor for the text. This is useful if the Text is on a Canvas and the
		//     canvas is scaled.
		public float scaleFactor;
		//
		// Summary:
		//     Allow rich text markup in generation.
		public bool richText;
		//
		// Summary:
		//     The line spacing multiplier.
		public float lineSpacing;
		//
		// Summary:
		//     Font size.
		public int fontSize;
		//
		// Summary:
		//     The base color for the text generation.
		public Color color;
		//
		// Summary:
		//     Use the extents of glyph geometry to perform horizontal alignment rather than
		//     glyph metrics.
		public bool alignByGeometry;

		public bool Equals(TextGenerationSettings other) { throw new System.NotImplementedException(); }
	}
}