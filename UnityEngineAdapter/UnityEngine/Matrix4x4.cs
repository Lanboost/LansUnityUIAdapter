#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;

namespace UnityEngine
{

	public struct Matrix4x4 : IEquatable<Matrix4x4>
	{
		
		public float m00;

		public float m33;

		public float m23;

		public float m13;

		public float m03;

		public float m32;

		public float m22;

		public float m02;

		public float m12;

		public float m21;

		public float m11;

		public float m01;

		public float m30;

		public float m20;

		public float m10;

		public float m31;

		public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) {
			m00 = column0.x;
			m10 = column0.y;
			m20 = column0.z;
			m30 = column0.w;
			m01 = column1.x;
			m11 = column1.y;
			m21 = column1.z;
			m31 = column1.w;
			m02 = column2.x;
			m12 = column2.y;
			m22 = column2.z;
			m32 = column2.w;
			m03 = column3.x;
			m13 = column3.y;
			m23 = column3.z;
			m33 = column3.w;
			rotation = new Quaternion();
			isIdentity = false;
			determinant = 0;
			lossyScale = new Vector3(0,0,0);
			

		}

		public float this[int index] { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public float this[int row, int column] {
			get {
				if(row == 0)
				{
					if(column == 0)
					{
						return m00;
					}
					else if (column == 1)
					{
						return m01;
					}
					else if (column == 2)
					{
						return m02;
					}
					else if (column == 3)
					{
						return m03;
					}
				}
				else if (row == 1)
				{
					if (column == 0)
					{
						return m10;
					}
					else if (column == 1)
					{
						return m11;
					}
					else if (column == 2)
					{
						return m12;
					}
					else if (column == 3)
					{
						return m13;
					}
				}
				else if (row == 2)
				{
					if (column == 0)
					{
						return m20;
					}
					else if (column == 1)
					{
						return m21;
					}
					else if (column == 2)
					{
						return m22;
					}
					else if (column == 3)
					{
						return m23;
					}
				}
				else if (row == 3)
				{
					if (column == 0)
					{
						return m30;
					}
					else if (column == 1)
					{
						return m31;
					}
					else if (column == 2)
					{
						return m32;
					}
					else if (column == 3)
					{
						return m33;
					}
				}
				return 0;
			} set { throw new System.NotImplementedException(); } }

		//
		// Summary:
		//     Returns a matrix with all elements set to zero (Read Only).
		public static Matrix4x4 zero { get; }
		//
		// Summary:
		//     Returns the identity matrix (Read Only).
		public static Matrix4x4 identity { get; }
		//
		// Summary:
		//     Returns the transpose of this matrix (Read Only).
		public Matrix4x4 transpose { get { throw new System.NotImplementedException(); } }
		//
		// Summary:
		//     Attempts to get a rotation quaternion from this matrix.
		public Quaternion rotation { get; }
		//
		// Summary:
		//     Attempts to get a scale value from the matrix. (Read Only)
		public Vector3 lossyScale { get; }
		//
		// Summary:
		//     Checks whether this is an identity matrix. (Read Only)
		public bool isIdentity { get; }
		//
		// Summary:
		//     The determinant of the matrix. (Read Only)
		public float determinant { get; }
		//
		// Summary:
		//     This property takes a projection matrix and returns the six plane coordinates
		//     that define a projection frustum.
		//public FrustumPlanes decomposeProjection { get { throw new System.NotImplementedException(); } }
		//
		// Summary:
		//     The inverse of this matrix. (Read Only)
		public Matrix4x4 inverse { get { throw new System.NotImplementedException(); } }

		public static float Determinant(Matrix4x4 m) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     This function returns a projection matrix with viewing frustum that has a near
		//     plane defined by the coordinates that were passed in.
		//
		// Parameters:
		//   left:
		//     The X coordinate of the left side of the near projection plane in view space.
		//
		//   right:
		//     The X coordinate of the right side of the near projection plane in view space.
		//
		//   bottom:
		//     The Y coordinate of the bottom side of the near projection plane in view space.
		//
		//   top:
		//     The Y coordinate of the top side of the near projection plane in view space.
		//
		//   zNear:
		//     Z distance to the near plane from the origin in view space.
		//
		//   zFar:
		//     Z distance to the far plane from the origin in view space.
		//
		//   frustumPlanes:
		//     Frustum planes struct that contains the view space coordinates of that define
		//     a viewing frustum.
		//
		//   fp:
		//
		// Returns:
		//     A projection matrix with a viewing frustum defined by the plane coordinates passed
		//     in.
		//[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = true)]
		public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     This function returns a projection matrix with viewing frustum that has a near
		//     plane defined by the coordinates that were passed in.
		//
		// Parameters:
		//   left:
		//     The X coordinate of the left side of the near projection plane in view space.
		//
		//   right:
		//     The X coordinate of the right side of the near projection plane in view space.
		//
		//   bottom:
		//     The Y coordinate of the bottom side of the near projection plane in view space.
		//
		//   top:
		//     The Y coordinate of the top side of the near projection plane in view space.
		//
		//   zNear:
		//     Z distance to the near plane from the origin in view space.
		//
		//   zFar:
		//     Z distance to the far plane from the origin in view space.
		//
		//   frustumPlanes:
		//     Frustum planes struct that contains the view space coordinates of that define
		//     a viewing frustum.
		//
		//   fp:
		//
		// Returns:
		//     A projection matrix with a viewing frustum defined by the plane coordinates passed
		//     in.
		//public static Matrix4x4 Frustum(FrustumPlanes fp);
		//[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = true)]
		public static Matrix4x4 Inverse(Matrix4x4 m) { throw new System.NotImplementedException(); }
		//[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = true)]
		public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Create a "look at" matrix.
		//
		// Parameters:
		//   from:
		//     The source point.
		//
		//   to:
		//     The target point.
		//
		//   up:
		//     The vector describing the up direction (typically Vector3.up).
		//
		// Returns:
		//     The resulting transformation matrix.
		public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Create an orthogonal projection matrix.
		//
		// Parameters:
		//   left:
		//     Left-side x-coordinate.
		//
		//   right:
		//     Right-side x-coordinate.
		//
		//   bottom:
		//     Bottom y-coordinate.
		//
		//   top:
		//     Top y-coordinate.
		//
		//   zNear:
		//     Near depth clipping plane value.
		//
		//   zFar:
		//     Far depth clipping plane value.
		//
		// Returns:
		//     The projection matrix.

		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Create a perspective projection matrix.
		//
		// Parameters:
		//   fov:
		//     Vertical field-of-view in degrees.
		//
		//   aspect:
		//     Aspect ratio (width divided by height).
		//
		//   zNear:
		//     Near depth clipping plane value.
		//
		//   zFar:
		//     Far depth clipping plane value.
		//
		// Returns:
		//     The projection matrix.

		public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a rotation matrix.
		//
		// Parameters:
		//   q:
		public static Matrix4x4 Rotate(Quaternion q) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a scaling matrix.
		//
		// Parameters:
		//   vector:
		public static Matrix4x4 Scale(Vector3 vector) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a translation matrix.
		//
		// Parameters:
		//   vector:
		public static Matrix4x4 Translate(Vector3 vector) { throw new System.NotImplementedException(); }

		public static Matrix4x4 Transpose(Matrix4x4 m) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a translation, rotation and scaling matrix.
		//
		// Parameters:
		//   pos:
		//
		//   q:
		//
		//   s:

		public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { throw new System.NotImplementedException(); }
		public override bool Equals(object other) { throw new System.NotImplementedException(); }
		public bool Equals(Matrix4x4 other) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a column of the matrix.
		//
		// Parameters:
		//   index:
		public Vector4 GetColumn(int index) { throw new System.NotImplementedException(); }
		public override int GetHashCode() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a row of the matrix.
		//
		// Parameters:
		//   index:
		public Vector4 GetRow(int index) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms a position by this matrix (generic).
		//
		// Parameters:
		//   point:
		public Vector3 MultiplyPoint(Vector3 point) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms a position by this matrix (fast).
		//
		// Parameters:
		//   point:



		public Vector3 MultiplyPoint3x4(Vector3 point1) {
			//https://www.c-sharpcorner.com/article/matrix-multiplication-in-c-sharp-applying-transformations-to-images/

			// cahing matrix lengths for better performance  
			var matrix1Rows = 1;
			var matrix1Cols = 4;
			var matrix2Rows = 4;
			var matrix2Cols = 4;
			var point = new Vector4(point1.x, point1.y, point1.z, 1);
			// checking if product is defined  
			if (matrix1Cols != matrix2Rows)
				throw new InvalidOperationException
				  ("Product is undefined. n columns of first matrix must equal to n rows of second matrix");

			// creating the final product matrix  
			Vector4 product = new Vector4();

			// looping through matrix 1 rows  
			for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++)
			{
				// for each matrix 1 row, loop through matrix 2 columns  
				for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++)
				{
					// loop through matrix 1 columns to calculate the dot product  
					for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++)
					{
						product[matrix2_col] +=
						  point[matrix1_col] *
						  this[matrix2_col, matrix1_col];
					}
				}
			}
			var v = new Vector3(product.x, product.y, product.z);
			return v;
		}
		//
		// Summary:
		//     Transforms a direction by this matrix.
		//
		// Parameters:
		//   vector:
		public Vector3 MultiplyVector(Vector3 vector) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a column of the matrix.
		//
		// Parameters:
		//   index:
		//
		//   column:
		public void SetColumn(int index, Vector4 column) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a row of the matrix.
		//
		// Parameters:
		//   index:
		//
		//   row:
		public void SetRow(int index, Vector4 row) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets this matrix to a translation, rotation and scaling matrix.
		//
		// Parameters:
		//   pos:
		//
		//   q:
		//
		//   s:
		public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string for this matrix.
		//
		// Parameters:
		//   format:
		public override string ToString() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string for this matrix.
		//
		// Parameters:
		//   format:
		public string ToString(string format) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a plane that is transformed in space.
		//
		// Parameters:
		//   plane:
		public Plane TransformPlane(Plane plane) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Checks if this matrix is a valid transform matrix.

		public bool ValidTRS() { throw new System.NotImplementedException(); }

		public static Vector4 operator *(Matrix4x4 lhs, Vector4 vector) { throw new System.NotImplementedException(); }
		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs) { throw new System.NotImplementedException(); }
		public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs) { throw new System.NotImplementedException(); }
		public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs) { throw new System.NotImplementedException(); }
	}
}