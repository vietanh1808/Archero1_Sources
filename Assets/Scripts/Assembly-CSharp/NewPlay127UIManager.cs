using System;
using System.Collections.Generic;
using GameProtocol;

public sealed class NewPlay127UIManager : CInstance<NewPlay127UIManager>
{
	public NewPlay127UIData actData;

	public NewPlay127DiffData diffData;

	public List<NewPlay127DiffItemData> diffList;

	public bool isPullNewData;

	public int GetDiffRunningMax => 0;

	public int GetDiffPassMax => 0;

	public long actLeftTime => 0L;

	public new void Init()
	{
	}

	public new void Clear()
	{
	}

	public void requestActData(Action<STRespWeaponAdventureNew, int> action = null)
	{
	}

	private void parseActDiffData(STAdventurePassData data)
	{
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	public void requestChooseDiff(int diffId, Action<STRespWeaponAdventureNew, int> action = null)
	{
	}

	public LocalSave.GamePlayActivityOneData getActBasicData()
	{
		return null;
	}

	public void setChooseDiffID(int diffId)
	{
	}

	public int getChooseDiffID()
	{
		return 0;
	}

	public string getDiffTitle(int diffId)
	{
		return null;
	}

	public NewPlay127DiffItemData GetDiffItemData(int diffId)
	{
		return null;
	}

	public void requestBoxItem(int itemId, Action<STRespWeaponAdventureNew, int> action = null)
	{
	}

	public bool isHaveGetReward(int diffId)
	{
		return false;
	}

	public bool isPassDiff(int diffId)
	{
		return false;
	}

	public bool isChooseDiffId(int diffId)
	{
		return false;
	}

	public bool isUnlockDiff(int diffId)
	{
		return false;
	}

	public bool isOpenAct()
	{
		return false;
	}

	public bool canGetBoxReward()
	{
		return false;
	}

	public void updateDiffAddValue(int value)
	{
	}
}
