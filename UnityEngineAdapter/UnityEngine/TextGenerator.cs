
using System;
using System.Collections.Generic;

namespace UnityEngine
{
	public sealed class TextGenerator : IDisposable
	{

		bool _invalidated = true;
		//
		// Summary:
		//     Create a TextGenerator.
		//
		// Parameters:
		//   initialCapacity:
		public TextGenerator() { }
		//
		// Summary:
		//     Create a TextGenerator.
		//
		// Parameters:
		//   initialCapacity:
		public TextGenerator(int initialCapacity) { 
			//TODO
		}

		~TextGenerator() { }

		//
		// Summary:
		//     The number of characters that have been generated.
		public int characterCount { get; }
		//
		// Summary:
		//     Number of vertices generated.
		public int vertexCount { get; }
		//
		// Summary:
		//     Extents of the generated text in rect format.
		public Rect rectExtents { get; }
		//
		// Summary:
		//     Information about each generated text line.
		public IList<UILineInfo> lines { get; }
		//
		// Summary:
		//     Array of generated characters.
		public IList<UICharInfo> characters { get; }
		//
		// Summary:
		//     Array of generated vertices.
		public IList<UIVertex> verts { get; }
		//
		// Summary:
		//     The number of characters that have been generated and are included in the visible
		//     lines.
		public int characterCountVisible { get; }
		//
		// Summary:
		//     Number of text lines generated.
		public int lineCount { get; }
		//
		// Summary:
		//     The size of the font that was found if using best fit mode.
		//[NativeProperty("FontSizeFoundForBestFit", false, TargetType.Function)]
		public int fontSizeUsedForBestFit { get; }

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void GetCharacters(List<UICharInfo> characters) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the current UICharInfo.
		//
		// Returns:
		//     Character information.
		public UICharInfo[] GetCharactersArray() { throw new System.NotImplementedException(); }
		//public void GetLines(List<UILineInfo> lines) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the current UILineInfo.
		//
		// Returns:
		//     Line information.
		//public UILineInfo[] GetLinesArray() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Given a string and settings, returns the preferred height for a container that
		//     would hold this text.
		//
		// Parameters:
		//   str:
		//     Generation text.
		//
		//   settings:
		//     Settings for generation.
		//
		// Returns:
		//     Preferred height.
		public float GetPreferredHeight(string str, TextGenerationSettings settings) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Given a string and settings, returns the preferred width for a container that
		//     would hold this text.
		//
		// Parameters:
		//   str:
		//     Generation text.
		//
		//   settings:
		//     Settings for generation.
		//
		// Returns:
		//     Preferred width.
		public float GetPreferredWidth(string str, TextGenerationSettings settings) { throw new System.NotImplementedException(); }
		public void GetVertices(List<UIVertex> vertices) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the current UIVertex array.
		//
		// Returns:
		//     Vertices.
		public UIVertex[] GetVerticesArray() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Mark the text generator as invalid. This will force a full text generation the
		//     next time Populate is called.
		public void Invalidate() {
			_invalidated = true;
		}
		//
		// Summary:
		//     Will generate the vertices and other data for the given string with the given
		//     settings.
		//
		// Parameters:
		//   str:
		//     String to generate.
		//
		//   settings:
		//     Settings.
		public bool Populate(string str, TextGenerationSettings settings) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Will generate the vertices and other data for the given string with the given
		//     settings.
		//
		// Parameters:
		//   str:
		//     String to generate.
		//
		//   settings:
		//     Generation settings.
		//
		//   context:
		//     The object used as context of the error log message, if necessary.
		//
		// Returns:
		//     True if the generation is a success, false otherwise.
		public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { throw new System.NotImplementedException(); }
	}
}