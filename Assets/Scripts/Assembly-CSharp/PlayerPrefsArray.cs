using UnityEngine;

public static class PlayerPrefsArray
{
	public static bool SetVector3(string key, Vector3 vector)
	{
		return false;
	}

	public static Vector3 GetVector3(string key)
	{
		return default;
	}

	public static bool SetBoolArray(string key, params bool[] boolArray)
	{
		return false;
	}

	public static bool[] GetBoolArray(string key)
	{
		return null;
	}

	public static bool[] GetBoolArray(string key, bool defaultValue, int defaultSize)
	{
		return null;
	}

	public static bool SetIntArray(string key, params int[] intArray)
	{
		return false;
	}

	public static int[] GetIntArray(string key)
	{
		return null;
	}

	public static int[] GetIntArray(string key, int defaultValue, int defaultSize)
	{
		return null;
	}

	public static bool SetFloatArray(string key, params float[] floatArray)
	{
		return false;
	}

	public static float[] GetFloatArray(string key)
	{
		return null;
	}

	public static float[] GetFloatArray(string key, float defaultValue, int defaultSize)
	{
		return null;
	}

	public static bool SetStringArray(string key, char separator, params string[] stringArray)
	{
		return false;
	}

	public static bool SetStringArray(string key, params string[] stringArray)
	{
		return false;
	}

	public static string[] GetStringArray(string key, char separator)
	{
		return null;
	}

	public static string[] GetStringArray(string key)
	{
		return null;
	}

	public static string[] GetStringArray(string key, char separator, string defaultValue, int defaultSize)
	{
		return null;
	}

	public static string[] GetStringArray(string key, string defaultValue, int defaultSize)
	{
		return null;
	}
}
