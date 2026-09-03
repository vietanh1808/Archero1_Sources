using System.Collections.Generic;
using Newtonsoft.Json;

public class GameConfig
{
	public class GameConfigData
	{
		public int key_max;

		public int key_max_start;

		public int key_recover_second;

		public int ad_key_count;

		public int[] high_ecpm;

		public int[] high_interval;

		public int new_mail_open_1;

		public int mail_safe_1;

		public int invitecode_open;

		public int probability_open;

		public string hero_discount_config;

		public string new_hero_config;

		public string heroskin_config;

		public int cache_clear_show;

		public bool SubDisplayOpen;

		public int pvp_pause_dead_enable;

		public int SubDisplayVersion;

		public int BigMap_ABTest;

		public int BigMapOpenFlag;

		public int StageDiscount_ABTest;

		public string GuildServerUrl;

		public string GuildQuasiServerUrl;

		public string GuildTestServerUrl;

		public string GuildImUrl;

		public string GuildQuasiImUrl;

		public string GuildTestImUrl;

		public string weaponskin_config;

		public AdsRequestHelper.AdsConfigData ads_config;

		[JsonProperty("Activity")]
		public List<ActivityShowData> actShowDataList;

		private int get_high_ecpm(int index)
		{
			return 0;
		}

		private int get_interval(int index)
		{
			return 0;
		}

		public void show_high_ecpm()
		{
		}

		public bool get_can_show_high_ecpm()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}

	public class MapGoodData
	{
		private string[] attributes;

		private EntityAttributeBase.ValueFloatBase HPAddPercent;

		private EntityAttributeBase.ValueBase TrapHit;

		private EntityAttributeBase.ValueBase FireTrapHit;

		private EntityAttributeBase.ValueBase ThunderCloudHit;

		private EntityAttributeBase.ValueFloatBase ExpGet;

		private EntityAttributeBase.ValueFloatBase ReFreshMonsterNumPercent;

		private long StandardDefence;

		public void Init()
		{
		}

		public void InitTD2023(int lastWaveId, int curWaveId)
		{
		}

		public void InitCampBattle()
		{
		}

		private void AddAttributes(string[] attributes, int symbol = 1)
		{
		}

		public float GetHPAddPercent()
		{
			return 0f;
		}

		public long GetTrapHit()
		{
			return 0L;
		}

		public long GetFireTrapHit()
		{
			return 0L;
		}

		public long GetThunderCloudHit()
		{
			return 0L;
		}

		public long GetStandardDefence()
		{
			return 0L;
		}

		public float GetExpGet()
		{
			return 0f;
		}

		public float GetReFreshMonsterNumPercent()
		{
			return 0f;
		}
	}

	public const int EndlessMode = 300;

	public const int EndlessMode_MaxLevel = 999;

	public const int DailyMazeID = 401;

	public const int DailyChristmasID = 110;

	public const int DailyCooperationPVPID = 501;

	public const int DailyGuildID = 601;

	public const int DailyValentine = 111;

	public const int DailyTowerDefence = 113;

	public const int DailyRoleReversal = 114;

	public const int DailyChristmasID_2021 = 115;

	public const int DailyDungeonID = 116;

	public const int DailyPvpId = 501;

	public const int DailyCooperationId = 201;

	public const int Daily3rdAnniversary = 117;

	public const int DailySurvival = 701;

	public const int DailyChristmasID_2022 = 118;

	public const int DailySpringFestival_2023 = 119;

	public const int DailyNewPlay120 = 120;

	public const int DailyNewPlay121 = 121;

	public const int DailyNewPlay122 = 122;

	public const int DailyNewPlay124 = 124;

	public const int DailyNewPlay125 = 125;

	public const int DailyNewPlay126 = 126;

	public const int DailyNewPlay127 = 127;

	public const int DailyPlay128 = 128;

	public const int DailyNewPlay129 = 129;

	public const int DailyPlay130 = 130;

	public const int DailyBulletFly = 102;

	public const int DailyNearbyDangerous = 109;

	public static GameConfigData config_game;

	public static bool bShowGDPR;

	public static bool _showTestServer;

	public static bool ifShowDebugButton;

	public static bool ifShowRoomInfo;

	private static int gameconfig_sendcount;

	public const int HPItemCount = 4;

	public static int MonthlyCardBattlePassPoints;

	public static int MonthlyCardQuickRaidNormal;

	public static int MonthlyCardQuickRaidPremium;

	public static int MonthlyCardGemDropEnhancement;

	public static int MonthlyCardBuyGoldBonus;

	public static int MonthlyCardEquipMeltDownDiscount;

	public static int MonthlyCardEquipWishEnhancement;

	public static int MonthlyCardBattlePassGoldBonus;

	public static int MonthlyCardDailyDiamondNormal;

	public static int MonthlyCardDailyDiamondPremium;

	private static long MaxAttack;

	private static MapGoodData _MapGood;

	public static int NormalModeStage => 0;

	public static int HeroModeStage => 0;

	public static int HellModeStage => 0;

	public static bool bShowTestServer => false;

	public static bool invitcode_open => false;

	public static bool is_probability_open => false;

	public static string get_new_hero_config => null;

	public static string get_heroskin_config => null;

	public static string get_shop_weaponskin_config => null;

	public static string get_hero_discount_config => null;

	public static bool is_new_mail_open => false;

	public static AdsRequestHelper.AdsConfigData ads_config => null;

	public static bool is_mail_safe => false;

	public static bool bShowAdInside => false;

	public static int BattleAdUnlockTalentLevel => 0;

	public static int FirstGold1TalentLevel => 0;

	public static int MainGoldCount => 0;

	public static int high_ecpm_max_count => 0;

	public static int heromode_openlayer => 0;

	public static int heromode_monsterelitehpratio => 0;

	public static int heromode_bosselitehpratio => 0;

	public static int hellmode_openlayer => 0;

	public static int hellmode_passLevel => 0;

	public static int event_strengthen_open_talent_level => 0;

	public static int reborn_ad_count => 0;

	public static int diamond_large_ten_price => 0;

	public static int diamond_mix_ten_price => 0;

	public static ushort diamond_dragon_ten_price => 0;

	public static int event_strength_open_stage => 0;

	public static int character_unlock_layer => 0;

	public static int battlepass_unlock_layer => 0;

	public static int dailyActivity_unlock_layer => 0;

	public static int weeklyTask_unlock_layer => 0;

	public static int medal_unlock_layer => 0;

	public static int weaponskin_unlock_layer => 0;

	public static int pet_unlock_layer => 0;

	public static int imprint_unlock_layer => 0;

	public static int wing_unlock_layer => 0;

	public static float endless_layer_add_percent => 0f;

	public static float endless_gold_random_percent => 0f;

	public static int endless_hero_use_max_count => 0;

	public static int strength_max_count => 0;

	public static int tower_first_prefix => 0;

	public static int tower_openlayer => 0;

	public static int tower_max_chance => 0;

	public static int tower_hero_max_chance => 0;

	public static int short_harvest_price => 0;

	public static int sweep_unlock_stage => 0;

	public static int sweep_limit => 0;

	public static int emoji_unlock_stage => 0;

	public static int rotate_ball_skill_cnt => 0;

	public static int rotate_sword_skill_cnt => 0;

	public static int fly_sword_skill_cnt => 0;

	public static int meteor_skill_cnt => 0;

	public static int star_skill_cnt => 0;

	public static int Tower_Hero_Open_Level => 0;

	public static int Guild_Open_Level => 0;

	public static int Pvp_Energy_Attack_Count => 0;

	public static int[] ChristmasElkRewardConfig => null;

	public static int ChristmasElkRewardId => 0;

	public static string[] MazeBuffConfig => null;

	public static bool FliterExceptionNetCache => false;

	public static int SeasonKeyCost => 0;

	public static int SeasonKeyMax => 0;

	public static int SeasonKeyBuyCnt => 0;

	public static int[] SeasonKeyBuyPrice => null;

	public static int PveSeasonKeyBpAdd => 0;

	public static float GetPveSeasonBpSoulRatio => 0f;

	public static int PveSeasonOpenChapter => 0;

	public static string[] PveSeasonOverseeAttributes => null;

	public static float EventTreasuresAd => 0f;

	public static float EventTreasuresHpExchangePercent => 0f;

	public static int EventTreasuresHpDiamondPrice => 0;

	public static int EquipReduceOpenLevel => 0;

	public static int ActivityCheckInBuyLevelDiamond => 0;

	public static int ActiveBpBuyLevelPrice => 0;

	public static int PushGlobalLimit => 0;

	public static int PushGlobalCoolDown => 0;

	public static int PveSeasonHeroProfessionRefreshMaxTimes => 0;

	public static int DailySurvivalMonsterMax => 0;

	public static bool IsForceSubscribe => false;

	public static bool BigMapABTest => false;

	public static float BigMapAttackXRange => 0f;

	public static float BigMapAttackZRange => 0f;

	public static bool PreloadTmxEnable => false;

	public static int PreloadTmxCnt => 0;

	public static int UnloadUnusedAssetRoomCnt => 0;

	public static float Daily119MaemonRate => 0f;

	public static int OfflineBattleMax => 0;

	public static int OfflineDropSameEquipMax => 0;

	public static int Daily120MagicEventRateInFirstRoom => 0;

	public static int Daily120MagicEventRateInSecondLastRoom => 0;

	public static float AssistantCd => 0f;

	public static int AssistanterCanLearnSkillCnt => 0;

	public static float AssistanterHPRatio => 0f;

	public static float AssistanterAttackRatio => 0f;

	public static float AssistanterTime => 0f;

	public static int AssistLevel => 0;

	public static string GuildServerUrl => null;

	public static string GuildQuasiServerUrl => null;

	public static string GuildTestServerUrl => null;

	public static string GuildImUrl => null;

	public static string GuildQuasiImUrl => null;

	public static string GuildTestImUrl => null;

	public static float Attack_Value_LowerLimit => 0f;

	public static ushort NetVersion => 0;

	public static float AngelOfJudgmentShouldShowRate => 0f;

	public static float AngelOfJudgmentShowRate => 0f;

	public static float Elite_HP_Ratio_InHellMode => 0f;

	public static float Elite_Boss_HP_Ratio_InHellMode => 0f;

	public static float Elite_Rate_InHellMode => 0f;

	public static int Elite_Cnt_InHellMode => 0;

	public static int MaxLevel_HellMode => 0;

	public static List<float> MonthlyCardBattleSpeeds => null;

	public static List<int> MonthlyCardDailyIDs => null;

	public static bool CanShowOfficialStorePop => false;

	public static bool CanShowOfficialStoreShopBanner => false;

	public static bool CanShowOfficialStoreBanner => false;

	public static float AngelOfLightShouldShowRate => 0f;

	public static int CanStrengthenAfterCallCnt => 0;

	public static float PVPCoefficientRatio => 0f;

	public static (int minAtk, int minLv) PVPHighCondition => default;

	public static List<int> SpeedUpDailyIDs => null;

	public static MapGoodData MapGood => null;

	public static int GetModeStage(GameMode mode)
	{
		return 0;
	}

	public static void Init()
	{
	}

	private static void Init_Game()
	{
	}

	private static bool init_config()
	{
		return false;
	}

	public static void OnConfigDownload()
	{
	}

	public static void ShowGDPR()
	{
	}

	public static bool GetCanOpenRateUI()
	{
		return false;
	}

	public static int GetMapStyleID(int RoomID)
	{
		return 0;
	}

	public static bool GetFirstDeadRecover()
	{
		return false;
	}

	public static float GetArrowEject()
	{
		return 0f;
	}

	public static float GetReboundHit()
	{
		return 0f;
	}

	public static float GetReboundSpeed()
	{
		return 0f;
	}

	public static int GetDemonMin()
	{
		return 0;
	}

	public static int GetDemonPerHit()
	{
		return 0;
	}

	public static int Get100AttackValue()
	{
		return 0;
	}

	public static int Get100HPValue()
	{
		return 0;
	}

	public static int GetFirstShopStartStage()
	{
		return 0;
	}

	public static int GetEquipGuide_alllayer()
	{
		return 0;
	}

	public static int GetEquipDrop_NewPlayer()
	{
		return 0;
	}

	public static float GetEquipDropMaxRate()
	{
		return 0f;
	}

	public static int GetHarvestMaxDay()
	{
		return 0;
	}

	public static short GetKeyTrustCount()
	{
		return 0;
	}

	public static int GetMaxKeyCount()
	{
		return 0;
	}

	public static int GetBuyKeyCount()
	{
		return 0;
	}

	public static int GetMaxKeyStartCount()
	{
		return 0;
	}

	public static int GetKeyRecoverTime()
	{
		return 0;
	}

	public static int GetAdKeyCount()
	{
		return 0;
	}

	public static int GetModeLevelKey()
	{
		return 0;
	}

	public static float GetCoin1Wave()
	{
		return 0f;
	}

	public static int GetKeyBuyDiamond()
	{
		return 0;
	}

	public static int GetRebornCount()
	{
		return 0;
	}

	public static int GetNetRebornCount()
	{
		return 0;
	}

	public static int GetRebornDiamond()
	{
		return 0;
	}

	public static int GetNetRebornDiamond()
	{
		return 0;
	}

	public static int GetCooperationRewardCount()
	{
		return 0;
	}

	public static long GetCooperationRoomStoreTime()
	{
		return 0L;
	}

	public static int GetBoxDropGold()
	{
		return 0;
	}

	public static T GetValue<T>(int id)
	{
		return default;
	}

	public static int GetBoxChooseGold(LocalSave.TimeBoxType type)
	{
		return 0;
	}

	public static long GetBoxChooseTime(LocalSave.TimeBoxType type)
	{
		return 0L;
	}

	public static float GetEquipUpgradeSellRatio()
	{
		return 0f;
	}

	public static float GetEquipOneRatio()
	{
		return 0f;
	}

	public static int GetTimeBoxTime(LocalSave.TimeBoxType type)
	{
		return 0;
	}

	public static int GetEquipUnlockTalentLevel()
	{
		return 0;
	}

	public static int GetEquipExpUnlockTalentLevel()
	{
		return 0;
	}

	public static int GetBattlePassHarvestExpAdd()
	{
		return 0;
	}

	public static int GetBattlePassHarvestGoldAdd()
	{
		return 0;
	}

	public static int GetIdfaHarvestGoldAdd()
	{
		return 0;
	}

	public static int GetDungeonPrice(int times)
	{
		return 0;
	}

	public static int GetBossBgm()
	{
		return 0;
	}

	public static int PveSeasonHeroProfessionRefreshPrice(int times)
	{
		return 0;
	}

	public static float ArtifactSkillShowRate128(int artifactCnt, int times)
	{
		return 0f;
	}

	public static float ArtifactActivityFailRewardRatio()
	{
		return 0f;
	}

	public static string GetChapterColumnName(int id)
	{
		return null;
	}

	public static float PVPHPRatio(long hpMax)
	{
		return 0f;
	}

	public static string[] PVPAttrs()
	{
		return null;
	}

	public static long GetMaxBulletAttack()
	{
		return 0L;
	}

	public static long GetMaxHitted()
	{
		return 0L;
	}

	public static int GetTrapHitBase()
	{
		return 0;
	}

	public static int GetFireTrapHitBase()
	{
		return 0;
	}

	public static int GetThunderCloudHitBase()
	{
		return 0;
	}
}
