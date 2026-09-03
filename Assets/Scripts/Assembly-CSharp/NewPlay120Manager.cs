using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay120Manager : CInstance<NewPlay120Manager>
{
	public const int DAILY_ID = 120;

	public const string LOG_TAG = "[NewPlay120]";

	public const int PreviewDifficultyCount = 1;

	public const int PerSeasonDecreaseDifficultyLevel = 10;

	public const int DefaultDifficulty = 0;

	public const int PerRowRewardCount = 5;

	public const string NewPlay120Atlas = "newplay120";

	public const string UnSelect = "NewPlay120_BlackAlpha_BG";

	public const string SelectBg = "NewPlay120_Difficulty_Select_BG";

	public const string SelectLevelBg = "NewPlay120_Difficulty_Select_Level_BG";

	public const string DifficultyLevelQualityBg = "NewPlay120_Difficulty_";

	private (bool, bool) isLoadingData;

	private (int, int) repeatRequestCount;

	private NewPlay120DifficultyData DifficultyData { get; set; }

	private NewPlay120SeasonData SeasonData { get; set; }

	private NewPlay120GetRewardData GetRewardData { get; set; }

	private bool IsSyncServer { get; set; }

	private bool IsSyncConfig { get; set; }

	private Action EntryRefreshEvent { get; set; }

	private int CurSeasonModelID { get; set; }

	private Action SyncConfigEvent { get; set; }

	private Action SyncServerEvent { get; set; }

	public new void Init()
	{
	}

	private new void Clear()
	{
	}

	private NewPlay120DifficultyData InitDifficultyData()
	{
		return null;
	}

	private NewPlay120SeasonData InitSeasonData()
	{
		return null;
	}

	private NewPlay120GetRewardData InitGetRewardData()
	{
		return null;
	}

	public bool CheckRefreshSeason()
	{
		return false;
	}

	private void CheckSeasonValid(GamePlayActivityOneData_Server[] servData)
	{
	}

	private void RequestServerAndCheckConfig(Action successCallBack = null, Action failureCallBack = null)
	{
	}

	private void RequestServerAndConfig(Action successCallBack = null, Action failureCallBack = null)
	{
	}

	private void RequestNewPlay120Server(Action successCallBack = null, Action failureCallBack = null)
	{
	}

	public void RequestNewPlay120Config(Action successCallBack = null)
	{
	}

	public void RequestNewPlay120SeasonReward(Action<int, int, string[]> successCallBack = null, Action<NetResponse> failureCallBack = null)
	{
	}

	public void SetConfigLoadingState(bool state)
	{
	}

	public (bool, bool) GetLoadingState()
	{
		return default;
	}

	public (bool, (bool, bool), bool, bool) IsAllDataReady()
	{
		return default;
	}

	public bool CheckAllDataReady()
	{
		return false;
	}

	public (bool, bool) IsSyncData()
	{
		return default;
	}

	public void SyncData(CRespDailyPlayInfo info)
	{
	}

	private void SyncDifficultyData(int curSeasonMaxDifficultyLevel, int lastSeasonMaxDifficultyLevel)
	{
	}

	private void SyncSeasonData(int curScore, int curSeasonOtherMaxScore)
	{
	}

	private void SyncGetRewardData(int lastSeasonID, int lastSeasonScore, int rewardGetState, int serverMaxScore)
	{
	}

	public void ParseSeasonConfig()
	{
	}

	public NewPlay120DifficultyData GetDifficultyData()
	{
		return null;
	}

	public bool UpdatePassDifficultyLevel()
	{
		return false;
	}

	public bool UpdatePassDifficultyLevel(int level)
	{
		return false;
	}

	public void UpdateChapterLevel(int level)
	{
	}

	public int GetCurSelectDifficultyLevel()
	{
		return 0;
	}

	public int GetCurSeasonMaxDifficultyLevel()
	{
		return 0;
	}

	public int GetLastSeasonMaxDifficultyLevel()
	{
		return 0;
	}

	private void CheckSelectDifficultyLevel()
	{
	}

	public NewPlay120SeasonData GetSeasonData()
	{
		return null;
	}

	public List<NewPlay120SeasonTimeData> GetSeasonModel()
	{
		return null;
	}

	public List<NewPlay120RewardItemData> GetSeasonRewardModel()
	{
		return null;
	}

	public int GetCurScore()
	{
		return 0;
	}

	public void RefreshMaxScore(int points)
	{
	}

	public int GetNextSeasonCanSelectMaxLevel()
	{
		return 0;
	}

	public NewPlay120GetRewardData GetGetRewardData()
	{
		return null;
	}

	public void CheckGetReward(bool isForce = false)
	{
	}

	public void AddEntryRefreshEvent(Action refreshEvent)
	{
	}

	public void DoEntryRefreshEvent()
	{
	}

	public void AddSyncConfigEvent(Action refreshEvent)
	{
	}

	private void DoSyncConfigEvent()
	{
	}

	public void ClearSyncConfigEvent()
	{
	}

	public void AddSyncServerEvent(Action refreshEvent)
	{
	}

	private void DoSyncServerEvent()
	{
	}

	public void ClearSyncServerEvent()
	{
	}

	public void RefreshItemList<T1, T2>(List<T1> itemList, T1 copyTarget, Transform parent, List<T2> itemDataList, bool isInverted) where T1 : MonoBehaviour, INewPlay120RefreshItem<T2> where T2 : new()
	{
	}

	public void ScrollToTarget(ScrollRect scrollRect, VerticalLayoutGroup layoutGroup, RectTransform target)
	{
	}

	public (int, int) GetRankData(int curScore, int curSeasonOtherMaxScore)
	{
		return default;
	}

	public bool IsEntryActive()
	{
		return false;
	}

	public bool IsConfigOpenTime()
	{
		return false;
	}

	public string GetMapFilePath(int difficultyId, string roomName)
	{
		return null;
	}

	public int GetDeltaScore(EntityType entityType)
	{
		return 0;
	}

	public void PassGameInfo2Pro(string eventType, Dictionary<string, object> pro)
	{
	}
}
