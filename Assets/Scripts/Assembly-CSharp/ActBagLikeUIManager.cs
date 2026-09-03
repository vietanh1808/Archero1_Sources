using System;
using System.Collections.Generic;
using GameProtocol;

public sealed class ActBagLikeUIManager : CInstance<ActBagLikeUIManager>
{
	public ActBagLikeDiffData diffData;

	public ActBagLikeShopData shopData;

	public List<ActBagLikeDiffItemData> diffList;

	public bool isPullNewData;

	public int ShopPropId;

	public List<ActBagLikeShopItemData> shopDataList;

	public float SpeedUpNeedDifficulty => 0f;

	public float[] AllSpeedUpGrade => null;

	public bool IsPassNeedDifficulty => false;

	public long ShopLeftTime => 0L;

	public int GetShopCoinNum => 0;

	public int GetDiffRunningMax => 0;

	public int GetDiffPassMax => 0;

	public long actLeftTime => 0L;

	public void init()
	{
	}

	public void uninit()
	{
	}

	public void requestActData(Action<STRespBagChallenge, int> action = null)
	{
	}

	private void parseActDiffData(STChapterPassData data)
	{
	}

	private void parseGiveItem(STRespBagChallenge data)
	{
	}

	private void parseShopData(STBagChallengeShop data)
	{
	}

	public void requestShopBuyItem(int itemId, int count, Action<STRespBagChallenge, int> action = null)
	{
	}

	public ActBagLikeShopItemData GetShopItemData(int shopId)
	{
		return null;
	}

	public List<ActBagLikeShopItemData> GetShowShopList()
	{
		return null;
	}

	public bool isShopCanExch()
	{
		return false;
	}

	public bool isOpenShop()
	{
		return false;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	public void requestChooseDiff(int diffId, Action<STRespBagChallenge, int> action = null)
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

	public ActBagLikeDiffItemData GetDiffItemData(int diffId)
	{
		return null;
	}

	public void requestBoxItem(int itemId, Action<STRespBagChallenge, int> action = null)
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
