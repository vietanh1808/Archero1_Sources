using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using UnityEngine;

public class Act5thHuntingManager : SingletonNetConfig<Act5thHuntingManager, STReqActivityHunting, STRespActivityHunting>
{
	public const int ReadyCountDownTime = 3;

	public const float GameEndTipFadeTime = 0.35f;

	public const float GameEndTipLastTime = 3f;

	public const float EntityCheckTime = 0.2f;

	public const int GameGuideMaxIndex = 2;

	public const float GameGuideMaxPointAngle = -10f;

	public const float GameGuideMinPointAngle = 0f;

	public const float GameGuideMinPointRotateTime = 1f;

	public const float GameGuideMinPointMoveTime = 1f;

	public const float GameGuideTipFadeTime = 0.3f;

	public const float DropScale = 0.8f;

	public const float DropMiddlePosScale = 0.3f;

	public const float DropIndexChangeScale = 0.4f;

	public const float DropEndPosScale = 0.65f;

	public const float DropTime = 0.5f;

	public const float AnimalCreateDelay = 0.6f;

	public const float CanvasFadeTime = 0.6f;

	public readonly List<Vector2> AnimalCreateSide;

	public const float AnimalCreateRange = 250f;

	public const float AnimalCreateOffset = 2f;

	public (float, float) AnimalCreatePerIntervalRange;

	public const float AnimalSpineAniOriginScale = 0.7f;

	public const float AnimalShakeTime = 0.5f;

	public const float AnimalShakeScale = 5f;

	public const float AttributeContinuousFireInterval = 0.18f;

	public const float AttributeSlantingArrowAngle = 30f;

	public const float AttributeForwardArrowWidth = 22f;

	public const int TalentRandomCount = 5;

	public const float TalentRandomInterval = 0.3f;

	public const int TalentRandomFinalCount = 3;

	public const float TalentRandomFinalInterval = 0.25f;

	public const float ResultItemInterval = 0.1f;

	public const float ResultItemScaleTime = 0.4f;

	public const int ResultMaxShowAnimalRow = 3;

	public const int ResultMaxShowRewardRow = 2;

	public const float ResultPerRowScrollTime = 0.5f;

	public const string HuntingAnimalHeadQuality = "Act5thHunting_AnimalQuality";

	public const string HuntingBattleScene = "Act5thHuntingBattleScene";

	public const string BattleSceneName = "Act5thHunting_BattleScene";

	public const string TalentQualityName = "New_CardUI_Quality";

	public const string TalentUnknownName = "New_CardUI_Unknow";

	public const string TalentAttributeIconName = "Act5thHunting_Talent_";

	public const string AnimalUrgencyStateAniName = "sweating";

	public const string AnimalBeAttackStateAniName = "arrow_bow1";

	public const int GameSoundCountDownID = 6000005;

	public const int GameSoundBeHitID = 6000006;

	public const int GameSoundDeadID = 6000007;

	public const int GameSoundBackgroundID = 6000008;

	public const int GameSoundGameStartID = 6000009;

	public List<Act5thHuntingGiftItemData> giftDataList;

	public List<Act5thHuntingShopItemData> shopDataList;

	private Dictionary<int, Act5thHuntingQuickItemData> quickDataDict;

	public List<Act5thHuntingTaskItemData> taskDataList;

	protected override string Name => null;

	protected override string ConfigFolderPath => null;

	protected override string ConfigFolderName => null;

	private Act5thHuntingData HuntingData { get; set; }

	private Act5thHuntingConfigData HuntingConfigData { get; set; }

	private bool HaveSyncProtocolData { get; set; }

	private bool HaveSyncConfigData { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqActivityHunting RequestPacket()
	{
		return null;
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, STRespActivityHunting data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	protected override void ResponseConfig(string configData)
	{
	}

	private (bool, bool) GetSyncStatus()
	{
		return default;
	}

	private void CheckTag(int tag)
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public bool IsSyncAllData()
	{
		return false;
	}

	public bool IsHuntingOpen()
	{
		return false;
	}

	public bool IsShoppingOpen()
	{
		return false;
	}

	private bool IsReachOpenCond()
	{
		return false;
	}

	public bool IsUnlockAttribute(Act5thHuntingTalentAttributeType attributeType)
	{
		return false;
	}

	public bool HaveRed()
	{
		return false;
	}

	public bool HaveGiftRed()
	{
		return false;
	}

	public bool HaveShopRed()
	{
		return false;
	}

	public bool HaveTaskRed()
	{
		return false;
	}

	public bool HaveTalentRed()
	{
		return false;
	}

	public bool HaveHuntingGameRed()
	{
		return false;
	}

	public bool HaveHuntingSweepRed()
	{
		return false;
	}

	public Act5thHuntingData GetHuntingData()
	{
		return null;
	}

	public Act5thHuntingConfigData GetHuntingConfigData()
	{
		return null;
	}

	public Act5thHuntingBaseData GetHuntingBaseData()
	{
		return null;
	}

	public Act5thHuntingSceneData GetHuntingSceneData()
	{
		return null;
	}

	public Act5thHuntingPreviewData GetHuntingPreviewData()
	{
		return null;
	}

	public Act5thHuntingTalentData GetHuntingTalentData()
	{
		return null;
	}

	public Act5thHuntingRankingData GetHuntingRankingData()
	{
		return null;
	}

	public Act5thHuntingRankingRewardData GetHuntingRankingRewardData()
	{
		return null;
	}

	public Act5thHuntingGameData GetHuntingGameData()
	{
		return null;
	}

	public float GetAttributeValue(Act5thHuntingTalentAttributeType attributeType)
	{
		return 0f;
	}

	public string GetGameEndAnalysisType(Act5thHuntingGameEndType gameEndType)
	{
		return null;
	}

	public void RequestDeleteHuntingData()
	{
	}

	public void RequestHuntingStart(int selectSceneID, Action<STRespActivityHunting> success = null, Action<STRespActivityHunting> failure = null)
	{
	}

	public void RequestHuntingEnd(int selectSceneID, STActivityHuntingPreyStatus[] preyStatusArray, Action<STRespActivityHunting> success = null, Action<STRespActivityHunting> failure = null)
	{
	}

	public void RequestHuntingSweep(int selectSceneID, int sweepCount, Action<STRespActivityHunting> success = null, Action<STRespActivityHunting> failure = null)
	{
	}

	public void RequestTalentUpgrade(Action<STRespActivityHunting> success = null, Action<STRespActivityHunting> failure = null)
	{
	}

	public void RequestRanking(Action<STRespActivityHunting> success = null, Action<STRespActivityHunting> failure = null)
	{
	}

	public void OpenGameBackgroundMusic()
	{
	}

	public void OpenMainBackgroundMusic()
	{
	}

	private void parseGiveItem(STRespActivityHunting data)
	{
	}

	public void requestQueryInfo(Action<STRespActivityHunting, int> action = null)
	{
	}

	private void parseGiftData(STActivityHuntingGift data)
	{
	}

	public void requestGiftAd(int giftId, Action<STRespActivityHunting, int> action = null)
	{
	}

	public Act5thHuntingGiftItemData GetGiftItemData(int giftId)
	{
		return null;
	}

	public bool isGiftAdGet()
	{
		return false;
	}

	private void parseShopData(STActivityHuntingShop data)
	{
	}

	public void requestShopBuyItem(int itemId, int count, Action<STRespActivityHunting, int> action = null)
	{
	}

	public Act5thHuntingShopItemData GetShopItemData(int shopId)
	{
		return null;
	}

	private void parseQuickBuyItemData(STRespActivityHunting data)
	{
	}

	public Act5thHuntingQuickItemData GetQuickBuyItemData(int pid)
	{
		return null;
	}

	public void requestShopQuickBuyItem(int itemId, int count, Action<STRespActivityHunting, int> action = null)
	{
	}

	public List<Act5thHuntingShopItemData> GetShowShopList()
	{
		return null;
	}

	public bool isShopCanExch()
	{
		return false;
	}

	private void parseTaskData(STActivityHuntingTask data)
	{
	}

	public void requestTaskGet(int taskId, Action<STRespActivityHunting, int> action = null)
	{
	}

	public Act5thHuntingTaskItemData GetTaskItemData(int taskId)
	{
		return null;
	}

	public List<Act5thHuntingTaskItemData> GetTaskShowList()
	{
		return null;
	}

	public bool isTaskCanGet()
	{
		return false;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}
}
