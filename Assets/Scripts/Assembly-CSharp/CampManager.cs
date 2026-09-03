using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using XLua;

public class CampManager : CInstance<CampManager>
{
	public CampData campData;

	public int LifeMax;

	public int joinCount;

	public const float NetDoingMaxTime = 8f;

	public int Pre_ActivePoint;

	public string Pre_RewardPreview;

	public long Pre_RewardFlag;

	public List<CampPreCallData> callDataList;

	public string rewardPreview;

	public int buyKeyHaveCountDiamond;

	public int buyKeyHaveCountAd;

	public int BossBattleState;

	public List<CampRankItemData> tileRankList;

	public List<CampRankItemData> talentRankList;

	public List<CampRankItemData> bossRankList;

	public List<CampRankItemData> townRankList;

	public List<CampRankItemData> holyCampRankList;

	public List<CampRankItemData> homeRankList;

	public List<CampRankItemData> tileCampIDList;

	public List<CampRankItemData> talentCampIDList;

	public List<CampRankItemData> bossCampIDList;

	public CampRankItemData MyTileRankData;

	public CampRankItemData MyTownRankData;

	public CampRankItemData MyTalentRankData;

	public CampRankItemData MyBossRankData;

	public CampRankItemData MyHomeRankData;

	public CampRankItemData MyHolyRankData;

	public int Holy_Stage;

	public long TownAutoLastTime;

	public int TownArrowCount;

	public int TownSuperArrowCount;

	public int TownMatExchangedTime;

	public string TownAutoProp;

	private CCampRank[] m_arrayRank;

	private ulong[] m_arrayLeaders;

	private long m_nRewardBits;

	private int m_nMyselfRank;

	public List<ulong> leaderList;

	public bool isPullPeerageData;

	private List<CampBuffItemData> buffDataList;

	private List<CampBuffItemData> selfBuffDataList;

	public const int TicketSkinId = 107;

	public List<CampTicketItemData> ticketList;

	public CampTeamData teamData;

	public List<CampTeamItemData> teamInvitedList;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_get_CampResource;

	private static DelegateBridge __Hotfix0_set_CampResource;

	private static DelegateBridge __Hotfix0_get_HeroDispatch;

	private static DelegateBridge __Hotfix0_set_HeroDispatch;

	private static DelegateBridge __Hotfix0_get_BanTime;

	private static DelegateBridge __Hotfix0_get_Zone;

	private static DelegateBridge __Hotfix0_get_Nobility;

	private static DelegateBridge __Hotfix0_get_NobilityExp;

	private static DelegateBridge __Hotfix0_get_NobilityReward;

	private static DelegateBridge __Hotfix0_isShowIconRedPoint;

	private static DelegateBridge __Hotfix0_EnterCampMainUI;

	private static DelegateBridge __Hotfix0_ExitCampMainUI;

	private static DelegateBridge __Hotfix0_HaveClickCampIcon;

	private static DelegateBridge __Hotfix0_SetClickCampIcon;

	private static DelegateBridge __Hotfix0_checkCampOpen_Level;

	private static DelegateBridge __Hotfix0_checkCampIconShow;

	private static DelegateBridge __Hotfix0_checkCampOpen_ToServer;

	private static DelegateBridge __Hotfix0_isOpenCamp;

	private static DelegateBridge __Hotfix0_get_curCampBasicData;

	private static DelegateBridge __Hotfix0_get_SeasonDay_Left;

	private static DelegateBridge __Hotfix0_get_TimeLeft;

	private static DelegateBridge __Hotfix0_get_TimeLeft_Register;

	private static DelegateBridge __Hotfix0_get_TimeLeft_War;

	private static DelegateBridge __Hotfix0_get_TimeLeft_Reward;

	private static DelegateBridge __Hotfix0_Time_War;

	private static DelegateBridge __Hotfix0_GetKingScrambleAheadTime;

	private static DelegateBridge __Hotfix0_get_CurSeasonDay;

	private static DelegateBridge __Hotfix0_get_CurSeasonDay_Battle;

	private static DelegateBridge __Hotfix0_get_TotalSeasonDay;

	private static DelegateBridge __Hotfix0_get_CurrentSeasonStage;

	private static DelegateBridge __Hotfix0_get_isStageWar;

	private static DelegateBridge __Hotfix0_get_isStageReward;

	private static DelegateBridge __Hotfix0_get_NeedDay_CloseIcon;

	private static DelegateBridge __Hotfix0_get_CurSeasonTime_Battle;

	private static DelegateBridge __Hotfix0_requestSignup;

	private static DelegateBridge __Hotfix0_checkBoxGetReward;

	private static DelegateBridge __Hotfix1_checkBoxGetReward;

	private static DelegateBridge __Hotfix0_GetPreCallData;

	private static DelegateBridge __Hotfix0_GetActionLevel;

	private static DelegateBridge __Hotfix0_GetActivePointCurrentValue;

	private static DelegateBridge __Hotfix0_canHaveRewardGet_Pre;

	private static DelegateBridge __Hotfix0_requestSeasonInfo;

	private static DelegateBridge __Hotfix0_get_CampKeyBuyCountOne;

	private static DelegateBridge __Hotfix0_get_CampKeyNeedDiamond;

	private static DelegateBridge __Hotfix0_get_CampKeyAdCountOne;

	private static DelegateBridge __Hotfix0_get_CampKeyAdTotal;

	private static DelegateBridge __Hotfix0_requestCampRank;

	private static DelegateBridge __Hotfix0_ReqHolyRank;

	private static DelegateBridge __Hotfix0_clearAllRankData;

	private static DelegateBridge __Hotfix0_isCanOpenRankUI;

	private static DelegateBridge __Hotfix1_isCanOpenRankUI;

	private static DelegateBridge __Hotfix0_openRankOne;

	private static DelegateBridge __Hotfix0_openRankOne_NotRequest;

	private static DelegateBridge __Hotfix0_setRankDataList;

	private static DelegateBridge __Hotfix0_setRankCampIDList;

	private static DelegateBridge __Hotfix0_GetRankItemDataList;

	private static DelegateBridge __Hotfix0_GetTopRankList;

	private static DelegateBridge __Hotfix0_GetHomeRankDataByCamp;

	private static DelegateBridge __Hotfix0_GetMyRankItemData;

	private static DelegateBridge __Hotfix0_GetRankRewards;

	private static DelegateBridge __Hotfix0_GetRankRewardIcon;

	private static DelegateBridge __Hotfix0_requestTownInfo;

	private static DelegateBridge __Hotfix0_GetTownMaxLevel;

	private static DelegateBridge __Hotfix0_get_MyTownLevel;

	private static DelegateBridge __Hotfix0_GetTownLevelUpNeedMat;

	private static DelegateBridge __Hotfix0_GetTownMatCapacity;

	private static DelegateBridge __Hotfix0_GetProduceArrowNeedMinute;

	private static DelegateBridge __Hotfix0_GetTalentAdd;

	private static DelegateBridge __Hotfix0_GetArrowGroupOneCount;

	private static DelegateBridge __Hotfix0_GetProduceArrowGroup;

	private static DelegateBridge __Hotfix0_GetProduceMatWood;

	private static DelegateBridge __Hotfix0_GetProduceMatIron;

	private static DelegateBridge __Hotfix0_get_TownMinTimeSecond;

	private static DelegateBridge __Hotfix0_get_TownMaxTimeSecond;

	private static DelegateBridge __Hotfix0_get_ProduceArrowNeedLevel;

	private static DelegateBridge __Hotfix0_get_ProduceArrowGroupAddOnce;

	private static DelegateBridge __Hotfix0_get_IsLearnTalentArrow;

	private static DelegateBridge __Hotfix0_get_isExchangeMatOpen;

	private static DelegateBridge __Hotfix0_canTownLevelUp;

	private static DelegateBridge __Hotfix0_canTownTimeArriveMax;

	private static DelegateBridge __Hotfix0_GetTownLevelUpEffectList;

	private static DelegateBridge __Hotfix0_GetSelfCamp;

	private static DelegateBridge __Hotfix0_GetCampCount;

	private static DelegateBridge __Hotfix0_GetCampResourceCount;

	private static DelegateBridge __Hotfix0_SetCampResourceCount;

	private static DelegateBridge __Hotfix0_ReduceCampResourceCount;

	private static DelegateBridge __Hotfix0_GetAllHeroDispatch;

	private static DelegateBridge __Hotfix0_GetHeroDispatch;

	private static DelegateBridge __Hotfix1_GetHeroDispatch;

	private static DelegateBridge __Hotfix0_SetHeroDispatch;

	private static DelegateBridge __Hotfix0_RemoveHeroDispatch;

	private static DelegateBridge __Hotfix0_get_Ranks;

	private static DelegateBridge __Hotfix0_get_MyselfRank;

	private static DelegateBridge __Hotfix0_get_CanReward;

	private static DelegateBridge __Hotfix0_get_RewardLevel;

	private static DelegateBridge __Hotfix0_get_CanUpgrade;

	private static DelegateBridge __Hotfix0_IsLeader;

	private static DelegateBridge __Hotfix0_RequestCampSeasonPeerage;

	private static DelegateBridge __Hotfix0_UpgradePeerage;

	private static DelegateBridge __Hotfix0_GetPeerageReward;

	private static DelegateBridge __Hotfix0_IsRegisterAndInBattle;

	private static DelegateBridge __Hotfix0_get_ActionPowerBuyMax;

	private static DelegateBridge __Hotfix0_get_ActionPowerDayMax;

	private static DelegateBridge __Hotfix0_TryEnterCampGame;

	private static DelegateBridge __Hotfix0_TryBattleReOpen;

	private static DelegateBridge __Hotfix0_parseBuffData;

	private static DelegateBridge __Hotfix0_parseSelfBuffData;

	private static DelegateBridge __Hotfix0_GetBuffShowList;

	private static DelegateBridge __Hotfix0_GetSelfBuffShowList;

	private static DelegateBridge __Hotfix0_GetBuffPreviewList;

	private static DelegateBridge __Hotfix0_GetSelfBuffPreviewList;

	private static DelegateBridge __Hotfix0_GetBuffEffectList;

	private static DelegateBridge __Hotfix0_GetCampStyle;

	private static DelegateBridge __Hotfix0_setBossDeadTime;

	private static DelegateBridge __Hotfix0_requestTicketData;

	private static DelegateBridge __Hotfix0_requestTicketLike;

	private static DelegateBridge __Hotfix0_requestTicketBox;

	private static DelegateBridge __Hotfix0_parseTicketList;

	private static DelegateBridge __Hotfix0_sortTicketList;

	private static DelegateBridge __Hotfix0_GetTicketItemData;

	private static DelegateBridge __Hotfix0_GetBossBeginTime;

	private static DelegateBridge __Hotfix0_GetBossEndTime;

	private static DelegateBridge __Hotfix0_isInTicketTime;

	private static DelegateBridge __Hotfix0_get_LeftTimeTicket;

	private static DelegateBridge __Hotfix0_TicketLeft;

	private static DelegateBridge __Hotfix0_GetBossRewardPreview_Boss;

	private static DelegateBridge __Hotfix0_requestBossGuideReward;

	private static DelegateBridge __Hotfix0_GetBossHP;

	private static DelegateBridge __Hotfix0_GetBossGuardHP;

	private static DelegateBridge __Hotfix0_ShowRewardWindow;

	private static DelegateBridge __Hotfix0_showRewardWindow;

	private static DelegateBridge __Hotfix0_GetHolySelfBuffCond;

	private static DelegateBridge __Hotfix0_get_CampAttribute;

	private static DelegateBridge __Hotfix0_get_CampBattleAttributes;

	private static DelegateBridge __Hotfix0_get_CampBattleSkillIds;

	private static DelegateBridge __Hotfix0_add2SkillIds;

	private static DelegateBridge __Hotfix0_add2Attrs;

	private static DelegateBridge __Hotfix1_add2Attrs;

	private static DelegateBridge __Hotfix0_requestTeamData;

	private static DelegateBridge __Hotfix0_requestTeamCreate;

	private static DelegateBridge __Hotfix0_GetTeamNeedDiamond;

	private static DelegateBridge __Hotfix0_requestTeamInvite;

	private static DelegateBridge __Hotfix0_requestTeamJoin;

	private static DelegateBridge __Hotfix0_requestTeamExit;

	private static DelegateBridge __Hotfix0_requestTeamRefuse;

	private static DelegateBridge __Hotfix0_parseTeamData;

	private static DelegateBridge __Hotfix0_parseInvitedList;

	private static DelegateBridge __Hotfix0_isTeamUserSubID;

	private static DelegateBridge __Hotfix0_isTeamUser;

	private static DelegateBridge __Hotfix0_isTeamLeader;

	private static DelegateBridge __Hotfix0_isTeamLeaderMe;

	private static DelegateBridge __Hotfix0_showTeamError;

	private static DelegateBridge __Hotfix0_getTeamPrivilege;

	private static DelegateBridge __Hotfix0_getTeamPrivilegeShowList;

	private static DelegateBridge __Hotfix0_getTeamPrivilegeList;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Dictionary<CurrencyType, int> CampResource { get; set; }

	private Dictionary<(int, int), int> HeroDispatch { get; set; }

	public long BanTime => 0L;

	public int Zone => 0;

	public int Nobility => 0;

	public int NobilityExp => 0;

	public int NobilityReward => 0;

	public ASSSDataParser.CampBasicData curCampBasicData => null;

	public int SeasonDay_Left => 0;

	public long TimeLeft => 0L;

	public long TimeLeft_Register => 0L;

	public long TimeLeft_War => 0L;

	public long TimeLeft_Reward => 0L;

	public int CurSeasonDay => 0;

	public int CurSeasonDay_Battle => 0;

	public int TotalSeasonDay => 0;

	public CampSeasonStage CurrentSeasonStage => CampSeasonStage.Unknown;

	public bool isStageWar => false;

	public bool isStageReward => false;

	public int NeedDay_CloseIcon => 0;

	public long CurSeasonTime_Battle => 0L;

	public int CampKeyBuyCountOne => 0;

	public int CampKeyNeedDiamond => 0;

	public int CampKeyAdCountOne => 0;

	public int CampKeyAdTotal => 0;

	public int MyTownLevel => 0;

	public int TownMinTimeSecond => 0;

	public int TownMaxTimeSecond => 0;

	public int ProduceArrowNeedLevel => 0;

	public int ProduceArrowGroupAddOnce => 0;

	public bool IsLearnTalentArrow => false;

	public bool isExchangeMatOpen => false;

	public CCampRank[] Ranks => null;

	public int MyselfRank => 0;

	public bool CanReward => false;

	public int RewardLevel => 0;

	public bool CanUpgrade => false;

	public int ActionPowerBuyMax => 0;

	public int ActionPowerDayMax => 0;

	public long LeftTimeTicket => 0L;

	public CampAttribute CampAttribute => null;

	public List<string> CampBattleAttributes => null;

	public List<int> CampBattleSkillIds => null;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public bool isShowIconRedPoint()
	{
		return false;
	}

	public void EnterCampMainUI(int x, int y, Action enterSuccess = null, Action enterFailure = null)
	{
	}

	public void ExitCampMainUI(bool isShowMain = true)
	{
	}

	public bool HaveClickCampIcon()
	{
		return false;
	}

	public void SetClickCampIcon(int flag)
	{
	}

	public bool checkCampOpen_Level()
	{
		return false;
	}

	public bool checkCampIconShow()
	{
		return false;
	}

	public bool checkCampOpen_ToServer()
	{
		return false;
	}

	public bool isOpenCamp()
	{
		return false;
	}

	public (long, long) Time_War()
	{
		return default;
	}

	public long GetKingScrambleAheadTime()
	{
		return 0L;
	}

	public void requestSignup(int type, int tid, Action<bool> action = null)
	{
	}

	public bool checkBoxGetReward(int id)
	{
		return false;
	}

	private bool checkBoxGetReward(long flag, int index)
	{
		return false;
	}

	public CampPreCallData GetPreCallData(int level)
	{
		return null;
	}

	public int GetActionLevel()
	{
		return 0;
	}

	public (int, int, int) GetActivePointCurrentValue()
	{
		return default;
	}

	public bool canHaveRewardGet_Pre()
	{
		return false;
	}

	public void requestSeasonInfo(int type, Action<bool> action = null)
	{
	}

	public void requestCampRank(int type, Action<bool, bool> callback = null)
	{
	}

	public void ReqHolyRank(int type, int tilePos, Action<bool> callback = null)
	{
	}

	private void clearAllRankData()
	{
	}

	public int isCanOpenRankUI(int type)
	{
		return 0;
	}

	public bool isCanOpenRankUI(int type, int tab)
	{
		return false;
	}

	public void openRankOne(int type, int tab)
	{
	}

	public void openRankOne_NotRequest(int type, int tab)
	{
	}

	private void setRankDataList(int type, int tab, List<CampRankItemData> list, CCampRank[] array, int rank, int value)
	{
	}

	private void setRankCampIDList(int tab, CCampRank[] array, List<CampRankItemData> list)
	{
	}

	public List<CampRankItemData> GetRankItemDataList(int type, int tab)
	{
		return null;
	}

	public List<CampRankItemData> GetTopRankList(int tab)
	{
		return null;
	}

	private CampRankItemData GetHomeRankDataByCamp(int camp)
	{
		return null;
	}

	public CampRankItemData GetMyRankItemData(int type, int tab)
	{
		return null;
	}

	public List<string> GetRankRewards(int type, int tab, int season, int zone, int rank)
	{
		return null;
	}

	public int GetRankRewardIcon(int type, int tab, int season, int zone, int rank)
	{
		return 0;
	}

	public void requestTownInfo(int type, int arrow, int count, Action<bool> action = null)
	{
	}

	public int GetTownMaxLevel()
	{
		return 0;
	}

	public List<(CurrencyType, int)> GetTownLevelUpNeedMat(int level)
	{
		return null;
	}

	public int GetTownMatCapacity(CurrencyType type, int level)
	{
		return 0;
	}

	public int GetProduceArrowNeedMinute(int level)
	{
		return 0;
	}

	public int GetTalentAdd()
	{
		return 0;
	}

	public int GetArrowGroupOneCount(int type)
	{
		return 0;
	}

	public int GetProduceArrowGroup(int type)
	{
		return 0;
	}

	public int GetProduceMatWood(int type)
	{
		return 0;
	}

	public int GetProduceMatIron(int type)
	{
		return 0;
	}

	public bool canTownLevelUp()
	{
		return false;
	}

	public bool canTownTimeArriveMax()
	{
		return false;
	}

	public List<string> GetTownLevelUpEffectList()
	{
		return null;
	}

	public CampID GetSelfCamp()
	{
		return CampID.Unknown;
	}

	public int GetCampCount()
	{
		return 0;
	}

	public int GetCampResourceCount(CurrencyType type)
	{
		return 0;
	}

	public void SetCampResourceCount(CurrencyType type, int count)
	{
	}

	public bool ReduceCampResourceCount(CurrencyType type, int reduceCount)
	{
		return false;
	}

	public List<((int, int), CampTileModelData, LocalSave.CharacterOne)> GetAllHeroDispatch()
	{
		return null;
	}

	public LocalSave.CharacterOne GetHeroDispatch(int x, int y)
	{
		return null;
	}

	public (int, int) GetHeroDispatch(int heroID)
	{
		return default;
	}

	public void SetHeroDispatch(int x, int y, int heroID)
	{
	}

	public void RemoveHeroDispatch(int heroID)
	{
	}

	public bool IsLeader(ulong id)
	{
		return false;
	}

	public void RequestCampSeasonPeerage()
	{
	}

	public void UpgradePeerage(Action<int> callback)
	{
	}

	public void GetPeerageReward(Action<int, CRewardItem[]> callback)
	{
	}

	public bool IsRegisterAndInBattle()
	{
		return false;
	}

	public void TryEnterCampGame(int posX, int posY, Action enterSuccess = null, Action enterFailure = null)
	{
	}

	public void TryBattleReOpen(CampTileReOpenTransData data, Action success, Action failure)
	{
	}

	public void parseBuffData(STCampBuildingOccupyTime cbotime)
	{
	}

	public void parseSelfBuffData(STCampBuildingOccupyTime cbotime)
	{
	}

	public List<CampBuffItemData> GetBuffShowList()
	{
		return null;
	}

	public List<CampBuffItemData> GetSelfBuffShowList()
	{
		return null;
	}

	public List<CampBuffItemData> GetBuffPreviewList(int buildId)
	{
		return null;
	}

	public List<CampBuffItemData> GetSelfBuffPreviewList(int buildId)
	{
		return null;
	}

	public List<string> GetBuffEffectList()
	{
		return null;
	}

	public int GetCampStyle()
	{
		return 0;
	}

	public void setBossDeadTime(long time)
	{
	}

	public void requestTicketData(Action<CRespCampLike, int> action = null)
	{
	}

	public void requestTicketLike(ulong usid, Action<CRespCampLike, int> action = null)
	{
	}

	public void requestTicketBox(ulong usid, Action<CRespCampLike, int> action = null)
	{
	}

	private void parseTicketList(CRespCampLike data)
	{
	}

	private void sortTicketList()
	{
	}

	public CampTicketItemData GetTicketItemData(ulong usid)
	{
		return null;
	}

	public long GetBossBeginTime()
	{
		return 0L;
	}

	public long GetBossEndTime()
	{
		return 0L;
	}

	public bool isInTicketTime()
	{
		return false;
	}

	public int TicketLeft()
	{
		return 0;
	}

	public List<Drop_DropModel.DropData> GetBossRewardPreview_Boss(int season, int zone)
	{
		return null;
	}

	public void requestBossGuideReward(Action<CRespCampSeasonInfo, int> action = null)
	{
	}

	public int GetBossHP(int hp, int zone)
	{
		return 0;
	}

	public int GetBossGuardHP(int hp, int zone)
	{
		return 0;
	}

	public void ShowRewardWindow(STCommonData stcd)
	{
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	public int GetHolySelfBuffCond()
	{
		return 0;
	}

	private void add2SkillIds(string[] attributes, List<int> skillIds)
	{
	}

	private void add2Attrs(List<string> attrs, string attrName, int attrValue)
	{
	}

	private void add2Attrs(List<string> attrs, string attr)
	{
	}

	public void requestTeamData(Action<STRespCampSeasonTeam, int> action = null)
	{
	}

	public void requestTeamCreate(string name, Action<STRespCampSeasonTeam, int> action = null)
	{
	}

	public int GetTeamNeedDiamond(int tag)
	{
		return 0;
	}

	public void requestTeamInvite(int path, int teamid, ulong usid, Action<STRespCampSeasonTeam, int> action = null)
	{
	}

	public void requestTeamJoin(int teamid, Action<STRespCampSeasonTeam, int> action = null)
	{
	}

	public void requestTeamExit(int teamid, Action<STRespCampSeasonTeam, int> action = null)
	{
	}

	public void requestTeamRefuse(int type, int teamid, Action<STRespCampSeasonTeam, int> action = null)
	{
	}

	private void parseTeamData(STRespCampSeasonTeam data)
	{
	}

	public void parseInvitedList(STRespCampSeasonTeam data)
	{
	}

	public bool isTeamUserSubID(ulong subid)
	{
		return false;
	}

	public bool isTeamUser(ulong userid)
	{
		return false;
	}

	public bool isTeamLeader(ulong userid)
	{
		return false;
	}

	public bool isTeamLeaderMe()
	{
		return false;
	}

	public void showTeamError(int code)
	{
	}

	public List<string> getTeamPrivilege(int tag, bool leader)
	{
		return null;
	}

	public List<CampTeamPrivilegeItemData> getTeamPrivilegeShowList()
	{
		return null;
	}

	public List<string> getTeamPrivilegeList()
	{
		return null;
	}
}
