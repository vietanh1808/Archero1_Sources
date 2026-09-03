using System.Collections.Generic;

public sealed class ActivityShowManager
{
	private static ActivityShowManager instance;

	private static object Locker;

	public Dictionary<PopWindowType, int> PopWindowDict;

	private Dictionary<int, int> actShowDict;

	public static ActivityShowManager Instance => null;

	public List<ActivityShowData> showList => null;

	public List<ActivityShowCacheData> cacheShowList => null;

	public void init()
	{
	}

	public void uninit()
	{
	}

	public void setPopWindow(PopWindowType type)
	{
	}

	public void ShowPopWindow()
	{
	}

	private void showActWindow(int type)
	{
	}

	private int GetActShowWindow()
	{
		return 0;
	}

	private bool isCanPopWindow(ActivityShowData data)
	{
		return false;
	}

	private bool canShowInCache(ActivityShowData data, int tag)
	{
		return false;
	}

	private ActivityShowData GetShowData(int type)
	{
		return null;
	}

	private ActivityShowCacheData GetShowCacheData(int type)
	{
		return null;
	}
}
