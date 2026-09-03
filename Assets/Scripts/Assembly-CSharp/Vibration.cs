using UnityEngine;

public static class Vibration
{
	public static AndroidJavaClass unityPlayer;

	public static AndroidJavaObject currentActivity;

	public static AndroidJavaObject vibManager;

	public static AndroidJavaObject vibrator;

	public static AndroidJavaObject context;

	public static AndroidJavaClass vibrationEffectClass;

	public static AndroidJavaClass combineVibrationClass;

	private static bool initialized;

	private static AndroidJavaObject _combineVibration;

	private static int _androidVersion;

	public static int AndroidVersion => 0;

	public static void Init()
	{
	}

	public static void VibratePop()
	{
	}

	public static void VibratePeek()
	{
	}

	public static void VibrateNope()
	{
	}

	public static void Vibrate(long milliseconds)
	{
	}

	public static void Vibrate2(long milliseconds)
	{
	}

	public static void Vibrate(long[] pattern, int repeat)
	{
	}

	public static void Cancel()
	{
	}

	public static bool HasVibrator()
	{
		return false;
	}

	public static void Vibrate()
	{
	}
}
