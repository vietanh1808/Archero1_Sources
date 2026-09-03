using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class SailingSalvageManager
{
	private static SailingSalvageManager instance;

	private List<SailingSalvageItemData> drops;

	private long lastRerviceTime;

	public const int TalentId = 34106;

	public float TalentAddRate;

	private Dictionary<uint, uint> _mapResourceAdds;

	public static SailingSalvageManager Instance => null;

	private int maxTime => 0;

	private int cdime => 0;

	public bool isOpen => false;

	public long hasSalvageTime => 0L;

	public long timeDownRevice => 0L;

	private SailingSalvageManager()
	{
	}

	public List<SailingSalvageItemData> GetSailingSalvageItems()
	{
		return null;
	}

	public int GetTalentAdd()
	{
		return 0;
	}

	public void ReqGetSalvage(Action<bool> callback)
	{
	}

	public void ReqSalvageInfo(Action<bool> callback)
	{
	}

	public int GetSalvageLevel()
	{
		return 0;
	}

	private List<Drop_DropModel.DropData> showRewardWindow(STCommonData stcd)
	{
		return null;
	}

	public float GetAddRate(uint itemId)
	{
		return 0f;
	}
}
