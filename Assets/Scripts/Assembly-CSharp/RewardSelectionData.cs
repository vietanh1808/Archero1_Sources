using System;
using System.Collections.Generic;
using TableTool;

public class RewardSelectionData
{
	public List<Drop_DropModel.DropData> OriginalItems;

	public List<Drop_DropModel.DropData> Items;

	public string RewardId;

	public Drop_DropModel.DropData Selection;

	public Action<Drop_DropModel.DropData> OnSelect;

	public string Source;

	public bool CacheUntilOverwrite;

	public List<RewardSelectionDisplayConfig> Configs;

	public bool LimitChar;

	public RewardSelectionData()
	{
	}

	public RewardSelectionData(RewardSelectionData copy)
	{
	}

	public int GetSelectionIndex()
	{
		return 0;
	}
}
