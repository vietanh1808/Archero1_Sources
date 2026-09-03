using UnityEngine;

public class CheckObject
{
	private static CheckObject sIns;

	private static AndroidJavaClass _unityPlayerClass;

	private static AndroidJavaObject _unityActivity;

	private static AndroidJavaObject _OBBMgrObject;

	public static CheckObject Ins => null;

	private static AndroidJavaClass unityPlayerClass => null;

	public static AndroidJavaObject unityActivity => null;

	public static AndroidJavaObject OBBMgrObject => null;

	private CheckObject()
	{
	}

	public int GetTargetFrameRate()
	{
		return 0;
	}

	public int GetVSyncCount()
	{
		return 0;
	}

	public T CallFun<T>(AndroidJavaObject obj, string fun, params object[] args)
	{
		return default;
	}

	public void CallFun(AndroidJavaObject obj, string fun, params object[] args)
	{
	}

	public void RestartApplication()
	{
	}

	public bool CheckOBBMD5()
	{
		return false;
	}

	public bool IsOBBOK()
	{
		return false;
	}

	public string GetMD5FromXML()
	{
		return null;
	}

	public string GetValueFromXML(string vKey)
	{
		return null;
	}

	public int GetVisonCode()
	{
		return 0;
	}

	public string GetObbDirectory()
	{
		return null;
	}

	public string GetObbFileName()
	{
		return null;
	}

	public string GetObbFilePath()
	{
		return null;
	}

	public bool CheckWritePermission()
	{
		return false;
	}

	public void StartAPP()
	{
	}
}
