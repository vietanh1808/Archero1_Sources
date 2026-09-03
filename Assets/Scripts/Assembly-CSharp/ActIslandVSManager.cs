using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class ActIslandVSManager : CInstance<ActIslandVSManager>
{
	private DiceBattleConfigData configData;

	public bool isHavePullData;

	public bool isHaveReReqS3;

	public ActIslandVSData actData;

	public bool isGameing;

	public int propID;

	public int propIDShopA;

	public int propIDShopB;

	public int attackNormal;

	public int attackSuper;

	public int attackSuperTimes;

	public List<ActIslandVSTaskItemData> taskDataList;

	public List<ActIslandVSGiftItemData> giftDataList;

	public List<ActIslandVSShopItemData> shopDataList;

	private Dictionary<int, DiceBattleQuickItemData> quickDataDict;

	public List<ActIslandVSBoxItemData> boxDataList;

	public List<ActIslandVSBoxItemData> boxCommonDataList;

	public List<ActIslandVSBoxItemData> boxLoopDataList;

	public int boxHaveGetTimes;

	private Dictionary<int, int> totalDamageDict;

	public DiceBattleData preBattleData;

	public DiceBattleData nextBattleData;

	public List<Drop_DropModel.DropData> rewardList;

	private List<int> bossRuleList;

	private List<int> meRuleList;

	public int meRuleValue;

	public int bossRuleValue;

	private int PropIdShopA => 0;

	private int PropIdShopB => 0;

	private int DiceId => 0;

	private int AttackNormal => 0;

	private int AttackSuper => 0;

	private int AttackSuperTimes => 0;

	public bool isS3Open => false;

	public int Tag_S3 => 0;

	public long LeftTime => 0L;

	public long LeftTimePlay => 0L;

	public long LeftTimeTask => 0L;

	public long LeftTimeGift => 0L;

	public long LeftTime_Shop => 0L;

	public List<int> BossRuleList => null;

	public List<int> MeRuleList => null;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public List<int> GetRatioList(int dice)
	{
		return null;
	}

	public DBBaseConfig GetBaseConfig(int tag)
	{
		return null;
	}

	public void ReqS3()
	{
	}

	private void ParseJson()
	{
	}

	private void initData()
	{
	}

	private void clearData()
	{
	}

	public bool isOpen()
	{
		return false;
	}

	public bool isOpenPlay()
	{
		return false;
	}

	public void requestClearActData()
	{
	}

	public void requestActData(Action<STRespActivityDiceBattle, int> action = null)
	{
	}

	private void parseActData(STRespActivityDiceBattle data)
	{
	}

	private void parseGiveItem(STRespActivityDiceBattle data)
	{
	}

	public bool isPassDay()
	{
		return false;
	}

	public void initGameData()
	{
	}

	private void parseTaskData(STActivityDiceBattleTask data)
	{
	}

	public void requestTaskGet(int taskId, Action<STRespActivityDiceBattle, int> action = null)
	{
	}

	public ActIslandVSTaskItemData GetTaskItemData(int taskId)
	{
		return null;
	}

	public List<ActIslandVSTaskItemData> GetTaskShowList()
	{
		return null;
	}

	public bool isHaveTaskReward()
	{
		return false;
	}

	public void requestGiftAd(int giftId, Action<STRespActivityDiceBattle, int> action = null)
	{
	}

	public ActIslandVSGiftItemData GetGiftItemData(int giftId)
	{
		return null;
	}

	private void parseGiftData(STActivityDiceBattleGift data)
	{
	}

	public bool isGiftCanAd()
	{
		return false;
	}

	private void parseShopData(STActivityDiceBattleShop data)
	{
	}

	public void requestShopBuyItem(int itemId, int count, Action<STRespActivityDiceBattle, int> action = null)
	{
	}

	public List<ActIslandVSShopItemData> GetSubShopList(int tab)
	{
		return null;
	}

	public ActIslandVSShopItemData GetShopItemData(int shopId)
	{
		return null;
	}

	public bool isHaveShopItemExch()
	{
		return false;
	}

	public bool isOpenShop()
	{
		return false;
	}

	private void parseQuickItemData(STRespActivityDiceBattle data)
	{
	}

	public DiceBattleQuickItemData GetQuickItemData(int pid)
	{
		return null;
	}

	public void requestQuickBuy(int itemId, int count, Action<STRespActivityDiceBattle, int> action = null)
	{
	}

	public void requestInfo_Quick(Action<STRespActivityDiceBattle, int> action = null)
	{
	}

	private void parseBoxData(STActivityDiceBattleAchievement data)
	{
	}

	public void requestBoxGet(int boxId, Action<STRespActivityDiceBattle, int> action = null)
	{
	}

	public int GetShowBoxIndex()
	{
		return 0;
	}

	public bool isBoxCanGetByIndex(int index)
	{
		return false;
	}

	public bool isBoxHaveGetByIndex(int index)
	{
		return false;
	}

	public ActIslandVSBoxItemData GetBoxItemDataById(int boxid)
	{
		return null;
	}

	public ActIslandVSBoxItemData GetBoxItemDataByIndex(int index)
	{
		return null;
	}

	public DBBossRewardConfig GetBossRewardConfigOne(int boxid)
	{
		return null;
	}

	public DBBossRewardConfig GetBossRewardConfigOneByRound(int round)
	{
		return null;
	}

	public List<DBBoxPreviewItemData> GetShowBoxList()
	{
		return null;
	}

	private int GetRoundTotalDamage(int round)
	{
		return 0;
	}

	public int GetTotalDamageValue(int round, int damage)
	{
		return 0;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	private Dictionary<int, int> GetWheelDamageDict()
	{
		return null;
	}

	private List<string> GetWheelRewardsList(int wid)
	{
		return null;
	}

	public List<DBWheelPreviewItemData> GetWheelPreviewShowList()
	{
		return null;
	}

	public void requestBattle(int count, int debug, Action<STRespActivityDiceBattle, int> action = null)
	{
	}

	private void parseBattleData(STActivityDiceBattleCore data, bool init)
	{
	}

	public void copyBattleData(DiceBattleData pre, DiceBattleData next)
	{
	}

	public int GetBattleDamageValue(int diceme, int ratio, bool trime, bool triboss)
	{
		return 0;
	}

	public int GetDiceNum(int stage, int hp, int index, bool isme)
	{
		return 0;
	}

	public DBBossRewardConfig GetBossRewardOne(int stage, int hp)
	{
		return null;
	}

	public List<ActIslandVSWheelOutData> GetWheelOutList(int stage, int hp)
	{
		return null;
	}

	public List<DBWheelRewardConfig> GetWheelInRewardList(int wid)
	{
		return null;
	}

	public List<ActIslandVSWheelInData> GetWheelInList(DiceBattleData dbdata, int layer)
	{
		return null;
	}

	public List<string> GetWheelRewardOne(DBWheelRewardConfig cfg, int layer)
	{
		return null;
	}

	public void initRuleList(int ruleId)
	{
	}

	public int isTriggerRuleBoss(int dice)
	{
		return 0;
	}

	public int isTriggerRuleMe(int dice)
	{
		return 0;
	}

	public bool isHaveProp()
	{
		return false;
	}
}
