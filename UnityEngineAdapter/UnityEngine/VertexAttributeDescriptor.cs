
using System;

namespace UnityEngine.Rendering
{
	public struct VertexAttributeDescriptor //: IEquatable<VertexAttributeDescriptor>
	{
		//
		// Summary:
		//     Create a VertexAttributeDescriptor structure.
		//
		// Parameters:
		//   attribute:
		//     The VertexAttribute.
		//
		//   format:
		//     Format of the vertex attribute. Default is VertexAttributeFormat.Float32.
		//
		//   dimension:
		//     Dimensionality of the vertex attribute (1 to 4). Default is 3.
		//
		//   stream:
		//     Vertex buffer stream that the attribute should be placed in. Default is 0.
		//public VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0);

		//
		// Summary:
		//     The vertex attribute.
		public VertexAttribute attribute { get; set; }
		//
		// Summary:
		//     Format of the vertex attribute.
		public VertexAttributeFormat format { get; set; }
		//
		// Summary:
		//     Dimensionality of the vertex attribute.
		public int dimension { get; set; }
		//
		// Summary:
		//     Which vertex buffer stream the attribute should be in.
		public int stream { get; set; }

		//public override bool Equals(object other);
		//public bool Equals(VertexAttributeDescriptor other);
		//public override int GetHashCode();
		//public override string ToString();

		//public static bool operator ==(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs);
		//public static bool operator !=(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs);
	}
}