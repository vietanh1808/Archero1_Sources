using System.Collections.Generic;
using XLua;
using newplay122;

public class NewPlay122Manager : CInstance<NewPlay122Manager>
{
	public enum TutorialEnum
	{
		ChooseTip = 0,
		PlaceTip = 1
	}

	public int BattleCost;

	public const int MAX_TUTORIAL_STEP = 2;

	public const int DAILY_ID = 122;

	public const int MAX_NORMAL_REWARD_COUNT = 6;

	public const int NORMAL_REWARD = 1;

	public const int EXTRA_REWARD = 2;

	public static string LOG_TAG;

	private TDMapPreviewController previewController;

	private DailyTDServerController serverController;

	public int CurRewardLayer;

	public int CurRewardPoints;

	public int CurLevelId;

	public int CurChangeMapTimes;

	public Dictionary<int, int> RewardDict;

	public long WeekEndTimestamp;

	public TDWeekReward[] ConfigRewards;

	private static DelegateBridge __Hotfix0_get_PreviewController;

	private static DelegateBridge __Hotfix0_get_ServerController;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_CanShowGuide;

	private static DelegateBridge __Hotfix0_ClearPreview;

	private static DelegateBridge __Hotfix0_get_BestWave;

	private static DelegateBridge __Hotfix0_set_BestWave;

	private static DelegateBridge __Hotfix0_refreshAfterGetReward;

	private static DelegateBridge __Hotfix0_refreshAfterChangeMap;

	private static DelegateBridge __Hotfix0_refreshByServerData;

	private static DelegateBridge __Hotfix0_refreshRewardDictByServer;

	private static DelegateBridge __Hotfix0_refreshWeekEndTimestamp;

	private static DelegateBridge __Hotfix0_getRewardIdList;

	private static DelegateBridge __Hotfix0_HasAvailableReward;

	private static DelegateBridge __Hotfix0_GetAllRewardVOList;

	private static DelegateBridge __Hotfix0_get_FinalNormalRewardVO;

	private static DelegateBridge __Hotfix0_get_CurExtraRewardPoints;

	private static DelegateBridge __Hotfix0_GetNormalRewardVOList;

	private static DelegateBridge __Hotfix0_GetExtraRewardVO;

	private static DelegateBridge __Hotfix0_GetRemainTime;

	private static DelegateBridge __Hotfix0_GetStyleSequence;

	private static DelegateBridge _c__Hotfix0_ctor;

	public TDMapPreviewController PreviewController => null;

	public DailyTDServerController ServerController => null;

	public int BestWave { get; private set; }

	public TDWeekRewardVO FinalNormalRewardVO => null;

	public int CurExtraRewardPoints => 0;

	public new void Init()
	{
	}

	public bool CanShowGuide(TutorialEnum tutorialEnum)
	{
		return false;
	}

	public void ClearPreview()
	{
	}

	public void refreshAfterGetReward(ServerDailyTDVO vo)
	{
	}

	public void refreshAfterChangeMap(ServerDailyTDVO vo)
	{
	}

	public void refreshByServerData(ServerDailyTDVO vo, TDWeekReward[] rewards)
	{
	}

	private void refreshRewardDictByServer(Dictionary<int, int> reward_cnts)
	{
	}

	private void refreshWeekEndTimestamp(ServerDailyTDVO vo)
	{
	}

	private List<int> getRewardIdList()
	{
		return null;
	}

	public bool HasAvailableReward()
	{
		return false;
	}

	public List<TDWeekRewardVO> GetAllRewardVOList()
	{
		return null;
	}

	public List<TDWeekRewardVO> GetNormalRewardVOList()
	{
		return null;
	}

	public TDWeekRewardVO GetExtraRewardVO()
	{
		return null;
	}

	public long GetRemainTime(long endTime)
	{
		return 0L;
	}

	public string GetStyleSequence()
	{
		return null;
	}
}
