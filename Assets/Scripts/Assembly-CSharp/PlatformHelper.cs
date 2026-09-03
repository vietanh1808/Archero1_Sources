using UnityEngine;

public class PlatformHelper
{
	public const string IOS_APPID = "1453651052";

	private static AndroidJavaClass _activityClass;

	private static AndroidJavaObject _currentActivity;

	private const float FringeHeight = -55f;

	private const float FringeHeightWithDynamicIsland = -75f;

	private const float BottomHeight = 30f;

	private static int _is_iphone;

	private static AndroidJavaObject _unityPlayer;

	private static float lastGetTick;

	public static AndroidJavaClass activityClass => null;

	public static AndroidJavaObject currentActivity => null;

	public static AndroidJavaObject unityPlayer => null;

	public static int KeyBoardHeight { get; private set; }

	public static string GetAppVersionName()
	{
		return null;
	}

	public static bool IsSupportGPUAnimation()
	{
		return false;
	}

	public static int GetAppVersionCode()
	{
		return 0;
	}

	private static AndroidJavaObject GetAndroidJO()
	{
		return null;
	}

	public static bool CheckRoot()
	{
		return false;
	}

	public static string GetDeviceModel()
	{
		return null;
	}

	public static int GetSystemMemorySize()
	{
		return 0;
	}

	public static string GetOperationSystem()
	{
		return null;
	}

	public static string GetGraphicsDeviceName()
	{
		return null;
	}

	public static string GetPlatformID()
	{
		return null;
	}

	public static bool IsFringe()
	{
		return false;
	}

	public static float GetFringeHeight()
	{
		return 0f;
	}

	public static float GetBottomHeight()
	{
		return 0f;
	}

	public static bool IsSupportDynamicIsland()
	{
		return false;
	}

	public static bool GetFlagShip()
	{
		return false;
	}

	public static bool GetLowPhone()
	{
		return false;
	}

	public static bool GetQualityLow()
	{
		return false;
	}

	public static string GetUUID()
	{
		return null;
	}

	public static bool IsPhone()
	{
		return false;
	}

	public static bool IsEditor()
	{
		return false;
	}

	public static bool IsAndroid()
	{
		return false;
	}

	public static bool IsIOS()
	{
		return false;
	}

	public static bool IsChina()
	{
		return false;
	}

	public static bool IsOneStore()
	{
		return false;
	}

	public static bool IsHuaWei()
	{
		return false;
	}

	public static bool IsFBCloud()
	{
		return false;
	}

	public static string GetPlatformName()
	{
		return null;
	}

	public static int GetKeyBoardHeight()
	{
		return 0;
	}
}
