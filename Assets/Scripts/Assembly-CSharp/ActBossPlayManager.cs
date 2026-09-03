using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public sealed class ActBossPlayManager
{
	private static ActBossPlayManager instance;

	private static object Locker;

	public int Tag;

	private List<BossPlayItemData> bossLayerList;

	public int BattleLevelDayMax;

	public int BattleHave;

	public int BattleTotalTag;

	public int EnterDefaultLevel;

	public int EnterBuyCount;

	public int Diff;

	public int DiffMax;

	public bool IsHaveModeUp;

	public int LayerPassed;

	public long RewardFlag;

	public List<BossPlayBoxItemData> boxItemList;

	public List<int> passFirstList;

	public Dictionary<int, int> battleCountDict;

	public Dictionary<int, int> battleFirstDiff;

	public List<string> currentRewardIfWinList;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_uninit;

	private static DelegateBridge __Hotfix0_get_BossPlayBasicData;

	private static DelegateBridge __Hotfix0_get_timeBegin;

	private static DelegateBridge __Hotfix0_get_timeEnd;

	private static DelegateBridge __Hotfix0_get_bossPlayList;

	private static DelegateBridge __Hotfix0_get_BattleTotal;

	private static DelegateBridge __Hotfix0_get_EnterBuyTotal;

	private static DelegateBridge __Hotfix0_get_EnterNeedKey;

	private static DelegateBridge __Hotfix0_get_DiffMaxReal;

	private static DelegateBridge __Hotfix0_get_LayerNeedGo;

	private static DelegateBridge __Hotfix0_get_MaxLayerId;

	private static DelegateBridge __Hotfix0_get_isSureDiff;

	private static DelegateBridge __Hotfix0_GetRewardPreviewList;

	private static DelegateBridge __Hotfix0_BuyEnterCountNeedDiamond;

	private static DelegateBridge __Hotfix0_GetUnlockDiffChapter;

	private static DelegateBridge __Hotfix0_GetCanUnlockDiff;

	private static DelegateBridge __Hotfix0_isOpenLevel;

	private static DelegateBridge __Hotfix0_isOpenTime;

	private static DelegateBridge __Hotfix0_isOpen;

	private static DelegateBridge __Hotfix0_LevelToChapter;

	private static DelegateBridge __Hotfix0_checkBoxGetReward;

	private static DelegateBridge __Hotfix1_checkBoxGetReward;

	private static DelegateBridge __Hotfix0_GetBoxItemHaveGetCount;

	private static DelegateBridge __Hotfix0_HaveBoxRewardNoGet;

	private static DelegateBridge __Hotfix0_HaveBattleCount;

	private static DelegateBridge __Hotfix0_isLayerPassFirst;

	private static DelegateBridge __Hotfix0_GetBattleHaveEnterCount;

	private static DelegateBridge __Hotfix0_GetDiffColor;

	private static DelegateBridge __Hotfix0_GetBattleMonsterList;

	private static DelegateBridge __Hotfix0_GetFirstPassDiff;

	private static DelegateBridge __Hotfix0_requestBossPlay;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static ActBossPlayManager Instance => null;

	public ASSSDataParser.BossPlayBasicData BossPlayBasicData => null;

	public long timeBegin => 0L;

	public long timeEnd => 0L;

	public List<BossPlayItemData> bossPlayList => null;

	public int BattleTotal => 0;

	public int EnterBuyTotal => 0;

	public int EnterNeedKey => 0;

	public int DiffMaxReal => 0;

	public int LayerNeedGo => 0;

	public int MaxLayerId => 0;

	public bool isSureDiff => false;

	public void init()
	{
	}

	public void uninit()
	{
	}

	public List<string> GetRewardPreviewList(int layer, int diff, bool win, bool first)
	{
		return null;
	}

	public int BuyEnterCountNeedDiamond()
	{
		return 0;
	}

	public int GetUnlockDiffChapter(int diff)
	{
		return 0;
	}

	public bool GetCanUnlockDiff(int diff)
	{
		return false;
	}

	public bool isOpenLevel()
	{
		return false;
	}

	public bool isOpenTime()
	{
		return false;
	}

	public bool isOpen()
	{
		return false;
	}

	public void LevelToChapter(int level, ref int c, ref int i, bool arrive = false)
	{
	}

	public bool checkBoxGetReward(int id)
	{
		return false;
	}

	public bool checkBoxGetReward(long flag, int index)
	{
		return false;
	}

	public int GetBoxItemHaveGetCount()
	{
		return 0;
	}

	public bool HaveBoxRewardNoGet()
	{
		return false;
	}

	public bool HaveBattleCount()
	{
		return false;
	}

	public bool isLayerPassFirst(int layer)
	{
		return false;
	}

	public int GetBattleHaveEnterCount(int layer)
	{
		return 0;
	}

	public Color GetDiffColor(int level)
	{
		return default;
	}

	public List<int> GetBattleMonsterList(int level, int diff)
	{
		return null;
	}

	public int GetFirstPassDiff(int _diff)
	{
		return 0;
	}

	public void requestBossPlay(int type, int tid, int param, Action action = null, Action errorAction = null)
	{
	}
}
