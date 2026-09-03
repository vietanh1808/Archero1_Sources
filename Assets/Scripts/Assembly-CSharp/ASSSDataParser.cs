using System.Collections.Generic;

public sealed class ASSSDataParser
{
	public class AdBalloon
	{
		public long startTime;

		public long endTime;

		public int version;

		public int cd;

		public int leaveTime;

		public List<AdBalloonCount> countArray;

		public List<AdBalloonReward> reward;
	}

	public class AdBalloonNew
	{
		public long startTime;

		public long endTime;

		public int version;

		public int cd;

		public int leaveTime;

		public int Layer_Min;

		public List<AdBalloonRewardNew> purchase_reward;
	}

	public class AdBalloonRewardNew
	{
		public int id;

		public int purchasemin;

		public int purchasemax;

		public int count;

		public List<AdBalloonLayerRewards> layer_rewards;
	}

	public class AdBalloonLayerRewards
	{
		public int Layer_Min;

		public int Layer_Max;

		public List<AdBalloonReward> rewards;

		public List<ADBallonIapReward> iap_rewards;
	}

	public class ADBallonIapReward
	{
		public int id;

		public string Product_id;

		public int[][] reward1;

		public int[][] reward2;

		public int[][] reward3;

		public List<int> rewardweight;

		public int Quota;

		public int discount;
	}

	public class AdBalloonCount
	{
		public int id;

		public int purchasemin;

		public int purchasemax;

		public int count;
	}

	public class AdBalloonReward
	{
		public int id;

		public int diamondPrice;

		public List<int> reward;

		public int weight;
	}

	public class AdEggHatch
	{
		public int version;

		public int cd;

		public int effect;

		public int count;
	}

	public class AdConfigData
	{
		public AdBalloon ballonAd;

		public AdBalloonNew ballonAdNew;

		public AdEggHatch monsterEggAd;
	}

	public class BossPlayBasicData
	{
		public int ID;

		public long StartTime;

		public long EndTime;

		public int VersionNeed;

		public int FreeTimes;

		public int Energy;

		public List<int> BuyTimesPrice;

		public int StartLevel;

		public List<int> DifficultNeedChapter;
	}

	public class CampBasicData
	{
		public int Tag;

		public int MinVer;

		public int MaxVer;

		public long StartTime;

		public int RegisterTime;

		public int WarTime;

		public int BossCrownTime;

		public int RewardTime;

		public long EndTime;

		public int Style;
	}

	public class CampRankRewardData
	{
		public int Tag;

		public int CampRank;

		public int Rank;

		public int[] Stage;

		public string Reward1;

		public string Reward2;

		public string Reward3;

		public string Reward4;

		public string Reward5;

		public string Reward6;

		public string Reward7;

		public string Reward8;

		public int Reward_img;
	}

	public class CampRankRewardLists
	{
		public List<CampRankRewardData> PerBlockRank;

		public List<CampRankRewardData> PerTalentRank;

		public List<CampRankRewardData> PerBBlockRank;

		public List<CampRankRewardData> PerBossRank;

		public List<CampRankRewardData> CampBlockRank;

		public List<CampRankRewardData> CampTalentRank;

		public List<CampRankRewardData> CampBossRank;

		public List<CampRankRewardData> CrownRank;

		public List<CampRankRewardData> HolyRank;
	}

	public class SailingRankRewardData
	{
		public int Tag;

		public int Stage;

		public int RankFront;

		public int Rank;

		public string Reward1;

		public string Reward2;

		public string Reward3;

		public string Reward4;

		public string Reward5;

		public string Reward6;

		public bool IsLast;
	}

	public class SailingRankRewardLists
	{
		public List<SailingRankRewardData> StrengthRank;

		public List<SailingRankRewardData> TalentRank;

		public List<SailingRankRewardData> SeaAnimalRank;

		public List<SailingRankRewardData> Special1Rank;

		public List<SailingRankRewardData> Special2Rank;

		public List<SailingRankRewardData> Special3Rank;

		public List<SailingRankRewardData> Special4Rank;
	}

	private static ASSSDataParser instance;

	private static object Locker;

	private AdConfigData adConfigData;

	public List<BossPlayBasicData> bossPlayBasicDataList;

	private ActivityRefluxJsonData activityRefluxJsonData;

	public List<CampBasicData> campBasicDataList;

	private CampRankRewardLists campRankRewardLists;

	private SailingRankRewardLists sailingRankRewardLists;

	public static ASSSDataParser Instance => null;

	public AdConfigData GetAdConfigData => null;

	public ActivityRefluxJsonData GetActivityRefluxJsonData => null;

	public int GetCampSeasonTag_Local => 0;

	private void AdConfigData_ParseJson()
	{
	}

	private void BossPlayTowerData_ParseJson()
	{
	}

	public BossPlayBasicData GetBossPlayBasicData(int tag)
	{
		return null;
	}

	private void ActivityRefluxJsonData_ParseJson()
	{
	}

	public void CampBasicData_ParseJson()
	{
	}

	private List<CampBasicData> GetCampBasicDataList()
	{
		return null;
	}

	public CampBasicData GetCampBasicData(int season)
	{
		return null;
	}

	public List<CampRankRewardData> CampRankRewardList(int type, int tab)
	{
		return null;
	}

	private void CampRankRewardData_ParseJson()
	{
	}

	private void sortOneCampRankList(List<CampRankRewardData> list)
	{
	}

	public List<SailingRankRewardData> SailingRankRewardList(RankType type, int stage, int tag)
	{
		return null;
	}

	private void SailingRankRewardData_ParseJson()
	{
	}

	private void sortOneSailRankList(List<SailingRankRewardData> list)
	{
	}
}
