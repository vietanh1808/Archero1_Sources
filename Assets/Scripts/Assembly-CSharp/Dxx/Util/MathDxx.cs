using UnityEngine;

namespace Dxx.Util
{
	public class MathDxx
	{
		private const float InfinityValue = 99999f;

		private const float NaNValue = 0f;

		public static float TrimmedDeltaPercent(float deltaPercent, float cumulatedPercent, float maxPercent)
		{
			return 0f;
		}

		public static int CeilToInt(float value)
		{
			return 0;
		}

		public static long CeilToLong(float value)
		{
			return 0L;
		}

		public static int FloorToInt(float value)
		{
			return 0;
		}

		public static int CeilBig(float value)
		{
			return 0;
		}

		public static long CeilLongBig(float value)
		{
			return 0L;
		}

		public static int GetSymbol(float value)
		{
			return 0;
		}

		public static int GetSymbol(int value)
		{
			return 0;
		}

		public static int GetSymbol(long value)
		{
			return 0;
		}

		public static string GetSymbolString(long value)
		{
			return null;
		}

		public static string GetSymbolString(int value)
		{
			return null;
		}

		public static string GetSymbolString(float value)
		{
			return null;
		}

		public static float Sin(float angle)
		{
			return 0f;
		}

		public static float Cos(float angle)
		{
			return 0f;
		}

		public static float Tan(float angle)
		{
			return 0f;
		}

		public static int Abs(int value)
		{
			return 0;
		}

		public static float Abs(float value)
		{
			return 0f;
		}

		public static long Abs(long value)
		{
			return 0L;
		}

		public static float MoveTowardsAngle(float current, float target, float maxDelta)
		{
			return 0f;
		}

		public static float Clamp(float value, float min, float max)
		{
			return 0f;
		}

		public static int Clamp(int value, int min, int max)
		{
			return 0;
		}

		public static long Clamp(long value, long min, long max)
		{
			return 0L;
		}

		public static bool Approximately(float value_1, float value_2)
		{
			return false;
		}

		public static Vector3 Clamp(Vector3 value, float min, float max)
		{
			return default;
		}

		public static float Clamp01(float value)
		{
			return 0f;
		}

		public static float Pow(float f, float p)
		{
			return 0f;
		}

		public static int RandomSymbol()
		{
			return 0;
		}

		public static bool RandomBool()
		{
			return false;
		}

		public static int RoundToInt(float value)
		{
			return 0;
		}

		public static double RoundToInt(float value, int decimals)
		{
			return 0.0;
		}

		public static float Min(float a, float b)
		{
			return 0f;
		}

		public static long Min(long a, long b)
		{
			return 0L;
		}

		public static int Min(int a, int b)
		{
			return 0;
		}

		public static float Max(float a, float b)
		{
			return 0f;
		}

		public static long Max(long a, long b)
		{
			return 0L;
		}

		public static int Max(int a, int b)
		{
			return 0;
		}

		public static Color RandomColor()
		{
			return default;
		}

		private static float check(float value, float infinityvalue, float nanvalue)
		{
			return 0f;
		}

		private static Vector3 check(Vector3 value, float infinityvalue, float nanvalue)
		{
			return default;
		}

		public static Vector3 CheckValid(Vector3 value)
		{
			return default;
		}

		public static bool IsValid(float value)
		{
			return false;
		}

		public static bool IsValid(Vector3 pos)
		{
			return false;
		}

		public static float DistanceWithoutY(Vector3 p1, Vector3 p2)
		{
			return 0f;
		}

		public static float DistanceSqrdWithOutY(Vector3 p1, Vector3 p2)
		{
			return 0f;
		}
	}
}
