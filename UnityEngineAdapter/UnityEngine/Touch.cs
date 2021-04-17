namespace UnityEngine
{
	public enum TouchType
	{
		//
		// Summary:
		//     A direct touch on a device.
		Direct = 0,
		//
		// Summary:
		//     An Indirect, or remote, touch on a device.
		Indirect = 1,
		//
		// Summary:
		//     A touch from a stylus on a device.
		Stylus = 2
	}

	public struct Touch
	{
		public TouchPhase phase { get; set; }
		//
		// Summary:
		//     The unique index for the touch.
		public int fingerId { get; set; }
		//
		// Summary:
		//     The position of the touch in pixel coordinates.
		public Vector2 position { get; set; }
		//
		// Summary:
		//     The raw position used for the touch.
		public Vector2 rawPosition { get; set; }
		//
		// Summary:
		//     The position delta since last change.
		public Vector2 deltaPosition { get; set; }
		//
		// Summary:
		//     Amount of time that has passed since the last recorded change in Touch values.
		public float deltaTime { get; set; }
		//
		// Summary:
		//     Number of taps.
		public int tapCount { get; set; }
		//
		// Summary:
		//     The current amount of pressure being applied to a touch. 1.0f is considered to
		//     be the pressure of an average touch. If Input.touchPressureSupported returns
		//     false, the value of this property will always be 1.0f.
		public float pressure { get; set; }
		//
		// Summary:
		//     The maximum possible pressure value for a platform. If Input.touchPressureSupported
		//     returns false, the value of this property will always be 1.0f.
		public float maximumPossiblePressure { get; set; }
		//
		// Summary:
		//     A value that indicates whether a touch was of Direct, Indirect (or remote), or
		//     Stylus type.
		public TouchType type { get; set; }
		//
		// Summary:
		//     Value of 0 radians indicates that the stylus is parallel to the surface, pi/2
		//     indicates that it is perpendicular.
		public float altitudeAngle { get; set; }
		//
		// Summary:
		//     Value of 0 radians indicates that the stylus is pointed along the x-axis of the
		//     device.
		public float azimuthAngle { get; set; }
		//
		// Summary:
		//     An estimated value of the radius of a touch. Add radiusVariance to get the maximum
		//     touch size, subtract it to get the minimum touch size.
		public float radius { get; set; }
		//
		// Summary:
		//     This value determines the accuracy of the touch radius. Add this value to the
		//     radius to get the maximum touch size, subtract it to get the minimum touch size.
		public float radiusVariance { get; set; }
	}
}