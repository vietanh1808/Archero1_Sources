using System.Collections.Generic;

public class MBGlobalManager
{
	public bool DebugStandalone;

	public bool DebugCustomizeStar;

	public bool DebugUseRobot;

	public Dictionary<int, int> DebugMonsterDict;

	private static MBGlobalManager _instance;

	public static MBGlobalManager Instance => null;

	public void Init()
	{
	}
}
