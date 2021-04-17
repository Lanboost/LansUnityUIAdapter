using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public struct Mathf
{
	//
	// Summary:
	//     The well-known 3.14159265358979... value (Read Only).
	public const float PI = 3.14159274F;
	//
	// Summary:
	//     A representation of positive infinity (Read Only).
	public const float Infinity = float.PositiveInfinity;
	//
	// Summary:
	//     A representation of negative infinity (Read Only).
	public const float NegativeInfinity = float.NegativeInfinity;
	//
	// Summary:
	//     Degrees-to-radians conversion constant (Read Only).
	public const float Deg2Rad = 0.0174532924F;
	//
	// Summary:
	//     Radians-to-degrees conversion constant (Read Only).
	public const float Rad2Deg = 57.29578F;
	//
	// Summary:
	//     A tiny floating point value (Read Only).
	public static readonly float Epsilon;

	//
	// Summary:
	//     Returns the absolute value of f.
	//
	// Parameters:
	//   f:
	public static float Abs(float f)
	{
		return Math.Abs(f);
	}
	//
	// Summary:
	//     Returns the absolute value of value.
	//
	// Parameters:
	//   value:
	public static int Abs(int value)
	{
		return Math.Abs(value);
	}
	//
	// Summary:
	//     Returns the arc-cosine of f - the angle in radians whose cosine is f.
	//
	// Parameters:
	//   f:
	public static float Acos(float f)
	{
		return (float)Math.Acos(f);
	}
	
	public static bool Approximately(float a, float b)
	{
		return Abs(a - b) < 0.00001f;
	}
	
	public static float Asin(float f)
	{
		return (float)Math.Asin(f);
	}

	public static float Atan(float f)
	{
		return (float)Math.Atan(f);
	}

	public static float Atan2(float y, float x)
	{
		return (float)Math.Atan2(y, x);
	}

	public static float Ceil(float f)
	{
		return (float)Math.Ceiling(f);
	}

	public static int CeilToInt(float f)
	{
		return (int)Ceil(f);
	}
	
	public static int Clamp(int value, int min, int max)
	{
		return Math.Max(min, Math.Min(max, value));
	}
	
	public static float Clamp(float value, float min, float max)
	{
		return Math.Max(min, Math.Min(max, value));
	}

	public static float Clamp01(float value)
	{
		return Clamp(value, 0, 1);
	}
	/*
	public static int ClosestPowerOfTwo(int value);
	
	public static Color CorrelatedColorTemperatureToRGB(float kelvin);
	*/
	public static float Cos(float f)
	{
		return (float)Math.Cos(f);
	}
	/*
	public static float DeltaAngle(float current, float target);
	
	public static ushort FloatToHalf(float val);
	
	public static float Floor(float f);
	*/
	public static int FloorToInt(float f)
	{
		if(f < 0)
		{
			return (int)(f - 1);
		}
		return (int)f;
	}
	/*
	public static float Gamma(float value, float absmax, float gamma);
	
	public static float GammaToLinearSpace(float value);
	
	public static float HalfToFloat(ushort val);
	*/
	public static float InverseLerp(float a, float b, float value)
	{
		return (value - a) / (b - a);
	}
	
	//public static bool IsPowerOfTwo(int value);
	
	public static float Lerp(float a, float b, float t)
	{
		return a * (1 - t) + b * t;
	}
	/*
	public static float LerpAngle(float a, float b, float t);
	
	public static float LerpUnclamped(float a, float b, float t);
	
	public static float LinearToGammaSpace(float value);
	*/
	public static float Log(float f, float p)
	{
		return (float) Math.Log(f, p);
	}
	
	public static float Log(float f)
	{
		return (float)Math.Log(f);
	}

	public static float Log10(float f)
	{
		return (float)Math.Log(f, 10);
	}

	public static int Max(int a, int b)
	{
		return Math.Max(a, b);
	}
	
	//public static float Max(params float[] values);
	
	public static float Max(float a, float b)
	{
		return Math.Max(a, b);
	}

	//public static int Max(params int[] values);
	
	//public static int Min(params int[] values);
	
	public static int Min(int a, int b)
	{
		return Math.Min(a, b);
	}

	//public static float Min(params float[] values);
	
	public static float Min(float a, float b)
	{
		return Math.Min(a, b);
	}
	/*
	public static float MoveTowards(float current, float target, float maxDelta);
	
	public static float MoveTowardsAngle(float current, float target, float maxDelta);
	
	public static int NextPowerOfTwo(int value);
	
	public static float PerlinNoise(float x, float y);
	
	public static float PingPong(float t, float length);
	*/
	public static float Pow(float f, float p)
	{
		return (float) Math.Pow(f, p);
	}
	public static float Repeat(float t, float length)
	{
		if(t <0)
		{
			return length - t;
		}
		else
		{
			return t % length;
		}
	}

	public static float Round(float f)
	{
		return (float)RoundToInt(f);
	}
	public static int RoundToInt(float f)
	{
		return (int)(f + 0.5f);
	}
	public static float Sign(float f)
	{
		if(f<0)
		{
			return -1;
		}
		return 1;
	}
	
	public static float Sin(float f)
	{
		return (float)Math.Sin(f);
	}
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
	{
		if(Math.Abs(current-target) < 0.3f)
		{
			currentVelocity = 0;
			return 0;
		}
		return Mathf.Lerp(current, target, 0.1f);
	}
	
	//public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime);
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed,float deltaTime) {
		return SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed);
	}
	/*
	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed);

	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime);
	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime);
	public static float SmoothStep(float from, float to, float t);
	public static float Sqrt(float f);
	public static float Tan(float f);*/
	public static float Sqrt(float f)
	{
		return (float)Math.Sqrt(f);
	}
}
