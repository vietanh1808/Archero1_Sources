using System.Collections.Generic;
using Habby.Model;

public class PlayerPrefsMgr : CInstance<PlayerPrefsMgr>
{
	public abstract class PrefDataBase
	{
		public string name { get; private set; }

		public bool HasKey => false;

		public PrefDataBase(string name)
		{
		}

		public void flush()
		{
		}

		public void Delete()
		{
		}

		protected abstract void OnFlush();
	}

	public class PrefDataInt : PrefDataBase
	{
		private int value;

		public PrefDataInt(string name, int default_value = 0)
			: base(null)
		{
		}

		public int get_value()
		{
			return 0;
		}

		public void set_value(int t)
		{
		}

		protected override void OnFlush()
		{
		}
	}

	public class PrefDataDayInt : PrefDataInt
	{
		public PrefDataDayInt(string name, int default_value = 0)
			: base(null)
		{
		}

		public int get_current_day_count()
		{
			return 0;
		}

		public void add_curreny_day_count()
		{
		}

		private string get_day_string()
		{
			return null;
		}

		private bool is_new_day()
		{
			return false;
		}
	}

	public class PrefDataUInt : PrefDataBase
	{
		private uint value;

		public PrefDataUInt(string name, uint default_value = 0u)
			: base(null)
		{
		}

		public uint get_value()
		{
			return 0u;
		}

		public void set_value(uint t)
		{
		}

		protected override void OnFlush()
		{
		}
	}

	public class PrefDataLong : PrefDataBase
	{
		private long value;

		public PrefDataLong(string name, long default_value = 0L)
			: base(null)
		{
		}

		public long get_value()
		{
			return 0L;
		}

		public void set_value(long t)
		{
		}

		protected override void OnFlush()
		{
		}
	}

	public class PrefDataBool : PrefDataBase
	{
		private bool value;

		public PrefDataBool(string name, bool defaultvalue)
			: base(null)
		{
		}

		public bool get_value()
		{
			return false;
		}

		public void set_value(bool t)
		{
		}

		public void change_value()
		{
		}

		protected override void OnFlush()
		{
		}
	}

	public class PrefDataBoolID : PrefDataBase
	{
		private bool defaultvalue;

		public PrefDataBoolID(string name, bool defaultvalue)
			: base(null)
		{
		}

		public bool get_value(int id)
		{
			return false;
		}

		public void set_value(int id, bool t)
		{
		}

		protected override void OnFlush()
		{
		}
	}

	public class PrefOneDay
	{
		private string name;

		private int value_day;

		private int value_count;

		public PrefOneDay(string name, int default_day = 0, int default_count = 0)
		{
		}

		private string get_string_day()
		{
			return null;
		}

		private string get_string_count()
		{
			return null;
		}

		public int get_value()
		{
			return 0;
		}

		public void add_value()
		{
		}
	}

	public class PrefDataString : PrefDataBase
	{
		private string value;

		public PrefDataString(string name, string default_value = "")
			: base(null)
		{
		}

		public string get_value()
		{
			return null;
		}

		public void set_value(string t)
		{
		}

		protected override void OnFlush()
		{
		}
	}

	public class PrefDataInterval : PrefDataBase
	{
		private int interval;

		private int value;

		public PrefDataInterval(string name, int interval)
			: base(null)
		{
		}

		public bool add_value()
		{
			return false;
		}

		protected override void OnFlush()
		{
		}
	}

	public class PrefDataFloat : PrefDataBase
	{
		private float value;

		public PrefDataFloat(string name, float default_value = 0f)
			: base(null)
		{
		}

		public float get_value()
		{
			return 0f;
		}

		public void set_value(float t)
		{
		}

		protected override void OnFlush()
		{
		}
	}

	public class PrefDataDic<TKey, TValue> : PrefDataBase
	{
		private Dictionary<TKey, TValue> prefValue;

		public TValue this[TKey key]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public PrefDataDic(string name)
			: base(null)
		{
		}

		public Dictionary<TKey, TValue> get_value()
		{
			return null;
		}

		public void set_value(Dictionary<TKey, TValue> t)
		{
		}

		public void SetDicValue(TKey dicKey, TValue dicValue)
		{
		}

		public TValue GetDicValue(TKey dicKey)
		{
			return default;
		}

		protected override void OnFlush()
		{
		}
	}

	public enum ExpDropShowType
	{
		eNormal = 0,
		eHalf = 1,
		eLess = 2,
		Length = 3
	}

	public class BinaryMd5 : BinaryBase
	{
		public const bool Encrypt = true;

		public string name;

		public Dictionary<string, string> list;

		private object mLock;

		public bool ContainsKey(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out string value)
		{
			value = null;
			return false;
		}

		public void Update(string key, string value)
		{
		}

		protected override void OnReadFromStream(CustomBinaryReader reader)
		{
		}

		protected override void OnWriteToStream(CustomBinaryWriter writer)
		{
		}

		private void log(string value, params object[] args)
		{
		}
	}

	public class MD5Data
	{
		public const bool bEmptyIsValid = false;

		public const bool LogEnable = false;

		public Dictionary<string, string> mWriteList;

		public Dictionary<string, string> mList;

		private BinaryMd5 mBinary;

		private object mLock;

		public string get_md5(string fullpath)
		{
			return null;
		}

		private void set_md5_internal(string last_name, string startvalue)
		{
		}

		public void set_md5(string fullpath, string startvalue)
		{
		}

		public bool check_md5(string fullpath, string newdata)
		{
			return false;
		}

		private string get_path_last_name(string path)
		{
			return null;
		}

		private string get_prefs_name(string name)
		{
			return null;
		}

		private void log(string value, params object[] args)
		{
		}
	}

	public PrefDataLong userid;

	public PrefDataInt gametime;

	public PrefDataInt apptime;

	public PrefDataBool report;

	public PrefDataLong adjust_retention_time;

	public PrefDataInt adjust_retention_report;

	public PrefDataUInt transid;

	public PrefDataBool GDPR_Shown;

	public PrefDataBool IDFA_Shown;

	public PrefDataBool BattleStatistics_Shown;

	public PrefDataBool Left_Habit_Priority;

	public PrefDataInt main_mode;

	public PrefDataInt main_pve_mode;

	public Dictionary<int, PrefDataBool> mainactivityrednode;

	public PrefOneDay high_ecpm_count;

	public PrefDataInt stage_normal;

	public PrefDataInt stage_hero;

	public PrefDataInt stage_hell;

	public PrefDataBool rate_donotask;

	public PrefDataInt high_ecpm_config_index;

	public PrefDataInt high_ecpm_config_count;

	public PrefDataInt high_ecpm_config_interval;

	public PrefDataBool purchasereward_redshow;

	public PrefDataDayInt reborn_ad_count;

	public PrefDataBoolID character_gets;

	public PrefDataBool guide_battle;

	public PrefDataInt guide_dailyActivity;

	public PrefDataBool first_register;

	public PrefDataInterval adjust_ad3report;

	public PrefDataInterval adjust_ad5report;

	public PrefDataInterval adjust_ad10report;

	public PrefDataInterval adjust_reborn3report;

	public PrefDataInterval adjust_reborn5report;

	public PrefDataInterval adjust_reborn10report;

	public PrefDataInterval adjust_blackad3;

	public PrefDataInterval adjust_gameend3;

	public PrefDataString tga_game_user_id;

	public PrefDataInt maze_difficulty;

	public PrefDataBool Daily_109_new_flag;

	public PrefDataInt PVPfailures;

	public PrefDataBool IsUnLockSweep;

	public PrefDataInt activity_year_id;

	public PrefDataInt activity_year_popup;

	public PrefDataBool monthly_card_subscribed;

	public PrefDataString old_user_id;

	public PrefDataInt net_cache_size;

	public PrefDataString social_user_id;

	public PrefDataBool unlockModuleShown_Talents;

	public PrefDataBool unlockModuleShown_Equipments;

	public PrefDataBool unlockModuleShown_DailyActivities;

	public PrefDataBool unlockModuleShown_HeroUpgrade;

	public PrefDataBool unlockModuleShown_MonsterEggs;

	public PrefDataBool unlockModuleShown_HeroMode;

	public PrefDataBool unlockModuleShown_Harvest;

	public PrefDataBool unlockModuleShown_Altar;

	public PrefDataBool unlockModuleShown_Gems;

	public PrefDataBool unlockModuleShown_Tower;

	public PrefDataBool unlockModuleShown_AltarHero;

	public PrefDataBool unlockModuleShown_AltarHeroEx;

	public PrefDataBool unlockModuleShown_AltarRelics;

	public PrefDataBool unlockModuleShown_Artifact;

	public PrefDataBool unlockModuleShown_Badge;

	public PrefDataBool unlockModuleShown_PveSeason;

	public PrefDataBool unlockModuleShown_Refine;

	public PrefDataBool unlockModuleShown_Relics;

	public PrefDataBool unlockModuleShown_MeadowBattle;

	public PrefDataBool pirate_ship_first;

	public PrefDataLong worldcup_open_timestamp;

	public PrefDataBool worldcup_open_champbet;

	public PrefDataBool worldcup_event_items_updated;

	public PrefDataLong dragon_drop_up;

	public PrefDataLong equips_drop_up;

	public PrefDataLong pet_drop_up;

	private PrefDataInt christmas2022_difficulty;

	private PrefDataBool christmas2022_rednode;

	private PrefDataLong growthfund_unlock_timestamp;

	public PrefDataInt newplay120_difficulty_level;

	public PrefDataBool newplay120_difficulty_FirstEnter;

	public PrefDataBool newplay120_difficulty_UpdateLevel;

	public PrefDataLong lattice_auto_flip_auth_time;

	public PrefDataBool lattice_flip_empty_confirm;

	public PrefDataInt lattice_flip_count_until_big_reward;

	private PrefDataString prizewheel_confirm_to_continue_on_round;

	public PrefDataBool first_see_chain_gift;

	private PrefDataBool anniversary_first_entrance;

	private PrefDataString anniversary_tower_selection;

	private PrefDataBool anniversary_tower_defense_guide_shown;

	private PrefDataLong camp_normalGift_popupTime;

	private PrefDataBool camp_timingGift_popupTime;

	private PrefDataLong camp_normalgift_lastentertime;

	public PrefDataInt camp_timingGift_maxpopupid;

	public PrefDataInt camp_season;

	public PrefDataBool have_see_boss_die;

	public PrefDataString need_show_reset_type;

	public PrefDataInt pirate_ship_tag;

	public PrefDataBool pirate_ship_havepopup;

	public PrefDataInt christmas2023_guide_index;

	public PrefDataInt christmas2023_guide_draw_index;

	public PrefDataInt fishing_select_lure_count;

	public PrefDataInt fishing_select_area;

	public PrefDataBool fishing_guide_trigger;

	public PrefDataInt fishing_tag;

	public PrefDataInt TargetFrameRate_High;

	public PrefDataInt hunting_tag;

	public PrefDataInt hunting_select_scene;

	public PrefDataBool hunting_game_haveplayguide;

	public PrefDataBool hide_movejoy;

	public PrefDataBool hide_droppropname;

	public PrefDataInt battle_prop_clearness;

	public PrefDataBool campkingscramble_needshow;

	public PrefDataBool addressableUpdateCompleted;

	public PrefDataFloat hotfixVersion;

	public PrefDataInt newplay125_guide_step;

	public PrefDataFloat newplay125speedup;

	public PrefDataInt newplay125havepassmaxlevel;

	public PrefDataBool equipstorage_show;

	public PrefDataBool WingShowInCard;

	public PrefDataBool WingShowInRanking;

	public PrefDataBool WingShowInGameIn;

	public PrefDataBool hasNewFirstCharge;

	public PrefDataInt newFirstChargeRepeatPoppingCount;

	public PrefDataInt newFirstChargeRecordFailureCount;

	public PrefDataInt newFirstChargeRecordDay;

	public PrefDataBool hasOpenGoldBox;

	public PrefDataBool unlockModuleShown_HellMode;

	public PrefDataBool showEnvironmentEffect_HellMode;

	public PrefDataString oldLoadMapData;

	public PrefDataString newLoadMapData;

	public PrefDataString oldPlayModeData;

	public PrefDataFloat sailingBagBattleSpeedUp;

	public PrefDataBool sailingGhostFleetShipNeedPlayAni;

	public PrefDataInt sailingShipBattleSpeedUpIndex;

	public PrefDataFloat newplay102speedup;

	public PrefDataFloat newplay109speedup;

	public PrefDataFloat newplay113speedup;

	public PrefDataFloat newplay116speedup;

	public PrefDataFloat newplay120speedup;

	public PrefDataFloat newplay128speedup;

	public PrefDataFloat newplay129speedup;

	public PrefDataFloat newplay401speedup;

	public PrefDataFloat newplay601speedup;

	public PrefDataFloat newplay121speedup;

	public PrefDataFloat newplay122speedup;

	public PrefDataFloat newplay126speedup;

	public PrefDataFloat newplay127speedup;

	public PrefDataFloat mainlevelspeedup;

	public PrefDataBool settingEffectWeakenStatus;

	public PrefDataBool settingAbbreviation;

	public PrefDataInt daily128MaxLevel;

	public PrefDataInt daily129_merge_guide_count;

	public PrefDataBool unlockModuleShown_Totem;

	public PrefDataString Act7thAnniversaryBattleStage;

	public PrefDataInt Act7thAnniversaryClickedBattleStage;

	private readonly int[] DailyIds;

	private PrefDataLong sailing_normalGift_popupTime;

	private PrefDataBool sailing_timingGift_popupTime;

	private PrefDataLong sailing_normalgift_lastentertime;

	public PrefDataInt sailing_timingGift_maxpopupid;

	public PrefDataInt sailing_season;

	private const string KEY_PVE_SEASON_FIRST_OPEN = "KEY_PVE_SEASON_FIRST_OPEN";

	private const string KEY_PVE_SEASON_OPEN = "KEY_PVE_SEASON_OPEN";

	private const string KEY_PVE_SEASON_END_TIME = "KEY_PVE_SEASON_END_TIME";

	private PrefDataBool m_IsPveSeasonFirstOpen;

	private PrefDataBool m_IsPveShowSeasonOpenUI;

	private PrefDataLong m_lPveSeasonEndTime;

	public static readonly string KEY_BattlePass_ISFirstOpen;

	public static readonly string KEY_BattlePass_BattlePassTag;

	public static readonly string KEY_BattlePass_PveBattlePassTag;

	public static readonly string KEY_EquipBattlePass_ISFirstOpen;

	public static readonly string KEY_EquipBattlePass_BattlePassTag;

	public static readonly string KEY_PetBattlePass_ISFirstOpen;

	public static readonly string KEY_PetBattlePass_BattlePassTag;

	public static readonly string KEY_DragonBattlePass_ISFirstOpen;

	public static readonly string KEY_DragonBattlePass_BattlePassTag;

	public static readonly string KEY_ImprintBattlePass_ISFirstOpen;

	public static readonly string KEY_ImprintBattlePass_BattlePassTag;

	public static readonly string KEY_ManorBattlePass_ISFirstOpen;

	public static readonly string KEY_ManorBattlePass_BattlePassTag;

	public static readonly string KEY_UserBackBattlePass_ISFirstOpen;

	public static readonly string KEY_UserBackBattlePass_BattlePassTag;

	public static readonly string KEY_TotemBattlePass_ISFirstOpen;

	public static readonly string KEY_TotemBattlePass_BattlePassTag;

	public PrefDataBool IsFirstOpen;

	public PrefDataInt BattlePassTag;

	public PrefDataBool IsFirstOpenEquip;

	public PrefDataInt EquipBattlePassTag;

	public PrefDataBool IsFirstOpenPet;

	public PrefDataInt PetBattlePassTag;

	public PrefDataBool IsFirstOpenDragon;

	public PrefDataInt DragonBattlePassTag;

	public PrefDataBool IsFirstOpenImprint;

	public PrefDataInt ImprintBattlePassTag;

	public PrefDataBool IsFirstOpenManor;

	public PrefDataInt ManorBattlePassTag;

	public PrefDataInt PveBattlePassTag;

	public PrefDataBool IsFirstOpenUserBack;

	public PrefDataInt UserBackBattlePassTag;

	public PrefDataBool IsFirstOpenTotem;

	public PrefDataInt TotemBattlePassTag;

	public static readonly string KEY_CLEVERNOTIFICATION;

	public static readonly string KEY_FIRSTBUY_BATTLECOUNT;

	public static readonly string KEY_FIRSTBUY_SHOW;

	public static readonly string KEY_FIRSTBUY_BUY;

	public static readonly string KEY_STAGEBUY_NEWSTAGE;

	public static readonly string KEY_STAGEBUY_SHOWID;

	public static readonly string KEY_EQUIIPBUY_SHOWTIMES;

	public static readonly string KEY_EQUIPBUY_LASTSHOWTIME;

	public static readonly string KEY_EQUIIPBUY_PUSHID;

	public static readonly string KEY_EQUIIPBUY_HAVEBUY;

	public static readonly string KEY_GEMBUY_SHOWTIMES;

	public static readonly string KEY_GOLDBUY_SHOWTIMES;

	public static readonly string KEY_DIAMONDBUY_SHOWTIMES;

	public static readonly string KEY_SCROLLBUY_SHOWTIMES;

	public static readonly string KEY_STONEBUY_SHOWTIMES;

	public static readonly string KEY_FRAGMENTBUY_SHOWTIMES;

	public static readonly string KEY_COOKIEBUY_SHOWTIMES;

	public static readonly string KEY_RUNEBUY_SHOWTIMES;

	public static readonly string KEY_GOLDBUY_LASTSHOWTIME;

	public static readonly string KEY_GOLDBUY_BUYLIST;

	public static readonly string KEY_BRACELETNECKLACEBUY_STATE;

	public static readonly string KEY_BRACELETNECKLACEBUY_INFO;

	public static readonly string KEY_BOOKBUY_STATE;

	public static readonly string KEY_BOOKBUY_INFO;

	public static readonly string KEY_AWAKENBUY_STATE;

	public static readonly string KEY_ADVSKINCOUPONBUY_STATE;

	public static readonly string KEY_EQUIPDOUBLEBUY_NEWSTAGE;

	public static readonly string KEY_EQUIPDOUBLEBUY_EQUIPLIST;

	public static readonly string KEY_EQUIPDOUBLEBUY_SHOWTIMES;

	public static readonly string KEY_EQUIPDOUBLEBUY_LASTSHOWTIME;

	public static readonly string KEY_EQUIIPDOUBLEBUY_HAVEBUY;

	public static readonly string KEY_EQUIPDOUBLEBUY_STAGE;

	public static readonly string KEY_EQUIPDOUBLEBUY_FAILTIMES;

	public static readonly string KEY_BACKBUY_VALIDINFO;

	public static readonly string KEY_BACKBUY_LASTSHOWTIME;

	public static readonly string KEY_BACKBUY_HAVEBUY;

	public static readonly string KEY_BACKBUY_BUYLIST;

	public PrefDataInt FirstBuy_BattleCount;

	public PrefDataBool FirstBuy_Show;

	public PrefDataInt StageBuy_NewStage;

	public PrefDataString StageBuy_ShowId;

	public PrefDataString EquipBuy_LastShow;

	public PrefDataString GoldBuy_LastShow;

	public PrefDataString GoldBuy_BuyList;

	public PrefDataInt BraceletNecklaceBuy_State;

	public PrefDataString BraceletNecklaceBuy_Info;

	public PrefDataInt BookBuy_State;

	public PrefDataString BookBuy_Info;

	public PrefDataInt AwakenBuy_State;

	public PrefDataInt AdvSkinCouponBuy_State;

	public PrefDataString EquipDoubleBuy_LastShow;

	public PrefDataInt EquipDoubleBuy_NewStage;

	public PrefDataString EquipDoubleBuy_EquipList;

	public PrefDataInt EquipDoubleBuy_Stage;

	public PrefDataInt EquipDoubleBuy_FailTimes;

	public PrefDataString BackBuy_ValidInfo;

	public PrefDataString BackBuy_LastShow;

	public PrefDataString BackBuy_BuyList;

	private static readonly string KEY_NEW_PUSH_LAST_SEEN_TIME;

	private static readonly string KEY_NEW_PUSH_LAST_SEEN_TIME_ALL;

	private static readonly string KEY_NEW_PUSH_IDS;

	private static readonly string KEY_NEW_PUSH_STATES;

	private static readonly string KEY_NEW_PUSH_INFO_BY_TYPE;

	private static readonly string KEY_NEW_PUSH_LAST_PURCHASE_TIME;

	private static readonly string KEY_NEW_PUSH_SHOW_TIMES;

	private PrefDataString NewPush_LastSeenTime;

	private PrefDataLong NewPush_LastSeenTimeAll;

	private PrefDataString NewPush_Ids;

	private PrefDataString NewPush_States;

	private PrefDataString NewPush_InfoByType;

	private PrefDataString NewPush_LastPurchaseTime;

	private PrefDataString NewPush_ShowTimes;

	private Dictionary<CleverBuyType, long> lastPushTimeByType;

	private long lastSeenTimeAll;

	private Dictionary<CleverBuyType, int> idByType;

	private Dictionary<CleverBuyType, CleverPushState> stateByType;

	private Dictionary<CleverBuyType, string> infoByType;

	private Dictionary<CleverBuyType, long> lastPurchaseTimeByType;

	private Dictionary<CleverBuyType, int> showTimesByType;

	public static readonly string KEY_EXP_DROP_SHOW_TYPE;

	private PrefDataUInt CurrentExpDrop;

	public static readonly string KEY_STAGE_ATTEMPTSBEFORECOMPLETE;

	public static readonly string KEY_STAGE_PLAYEDTIMES;

	public static readonly string KEY_GUILD_JOIN_APPLIED;

	public PrefDataString Stage_AttemptsBeforeComplete;

	public PrefDataInt Stage_PlayedTimes;

	public PrefDataBool Guild_JoinApplied;

	public static readonly string KEY_GAMEACHIEVE_LIST;

	public PrefDataString GAMEACHIEVE_LIST;

	public static readonly string KEY_MAGICIAN_GUIDE;

	public static readonly string KEY_MAGICIAN_TRANSID;

	public static readonly string KEY_MAGICIAN_SHOWN;

	public PrefDataBool MAGICIAN_GUIDE;

	public PrefDataUInt MAGICIAN_TRANSID;

	public PrefDataInt MAGICIAN_SHOWN;

	public static readonly string KEY_HABBY_MAILIDS;

	public static readonly string KEY_MAIL_HEAD;

	public HashSet<string> localMails;

	public PrefDataString mailIds;

	public PrefDataString HabbyCloudConfigJson;

	public static readonly string KEY_MAINACTIVITY_LASTBUY_ID;

	public static readonly string KEY_MAINACTIVITY_LASTBUY_PRODUCT;

	public PrefDataInt MAINACTIVITY_LASTBUY_ID;

	public PrefDataString MAINACTIVITY_LASTBUY_PRODUCT;

	private static PlayerPrefsEncryptBase _encrypt_instance;

	public MD5Data m_MD5Data;

	public static readonly string KEY_NetConfig_NetVersion;

	public PrefDataInt NetVersion;

	public const int REDNODE_BATTLEPASSBUY = 0;

	private PrefDataLong m_rednode;

	public static readonly string KEY_RUNE_INFO;

	public static readonly string KEY_RUNE_TEMP;

	public static readonly string KEY_RUNE_ACHIEVE;

	public static readonly string KEY_RUNE_101_COUNT;

	public static readonly string KEY_RUNE_102_COUNT;

	public static readonly string KEY_RUNE_103_COUNT;

	public static readonly string KEY_RUNE_104_COUNT;

	public static readonly string KEY_RUNE_105_COUNT;

	public PrefDataString RUNE_INFO;

	public PrefDataString RUNE_TEMP;

	public PrefDataString RUNE_ACHIEVE;

	public PrefDataInt RUNE_101_COUNT;

	public PrefDataInt RUNE_102_COUNT;

	public PrefDataInt RUNE_103_COUNT;

	public PrefDataInt RUNE_104_COUNT;

	public PrefDataInt RUNE_105_COUNT;

	public string get_old_user_id => null;

	public int get_net_cache_size => 0;

	public long get_user_id => 0L;

	public bool AddressableUpdateCompleted => false;

	public float HotfixVersion => 0f;

	public uint CacheSweepTransId { get; set; }

	public static PlayerPrefsEncryptBase EncryptInstance => null;

	public new void Init()
	{
	}

	public new void Clear()
	{
	}

	public void transid_init(uint id)
	{
	}

	public uint gettransid()
	{
		return 0u;
	}

	public GameMode get_main_mode()
	{
		return (GameMode)0;
	}

	public void update_main_mode(GameMode mode)
	{
	}

	public GameMode get_pve_mode()
	{
		return (GameMode)0;
	}

	public void update_pve_mode(GameMode mode)
	{
	}

	public bool get_goldturn_ad()
	{
		return false;
	}

	private int get_goldturn_count()
	{
		return 0;
	}

	public bool get_show_report_rednode()
	{
		return false;
	}

	private bool is_new_day(string name)
	{
		return false;
	}

	private int get_currentday_count(string name)
	{
		return 0;
	}

	private void add_currenyday_count(string name)
	{
	}

	private int get_main_gold_count()
	{
		return 0;
	}

	public void add_main_gold_count()
	{
	}

	public int get_main_gold_last_count()
	{
		return 0;
	}

	public bool get_main_gold_show()
	{
		return false;
	}

	public void show_GDPR()
	{
	}

	private bool get_mainactivity_red_show(int productid)
	{
		return false;
	}

	private PrefDataBool get_mainactivity_valuedata(int productid)
	{
		return null;
	}

	public void set_mainactivity_already_show()
	{
	}

	private void set_mainactivity_already_show(int productid)
	{
	}

	public bool get_mainactivity_red_show()
	{
		return false;
	}

	public bool get_high_ecpm_ad_can_show()
	{
		return false;
	}

	public void high_ecpm_ad_day_count_add()
	{
	}

	public bool get_reborn_ad_can_show()
	{
		return false;
	}

	public void set_character_gets(int id)
	{
	}

	public int GetDailyActivityGuide()
	{
		return 0;
	}

	public void SetDailyActivityGuide(int progress)
	{
	}

	public void ChooseDifficultyInMaze(int mode)
	{
	}

	public int GetDifficultyInMaze()
	{
		return 0;
	}

	public void ChooseDifficultyInDailyChristmas2022(int mode)
	{
	}

	public int GetDifficultyInDailyChristmas2022()
	{
		return 0;
	}

	public void SetRedNodeInDailyChristmas2022(bool value)
	{
	}

	public bool GetRedNodeInDailyChristmas2022()
	{
		return false;
	}

	public void SetGrowthFundUnlockTimestamp(long timestamp)
	{
	}

	public long GetGrowthFundUnlockTimestamp()
	{
		return 0L;
	}

	public void SetDaily109NewFlag()
	{
	}

	public bool GetDaily109NewFlag()
	{
		return false;
	}

	public bool get_idfa_shown()
	{
		return false;
	}

	public void set_idfa_shown()
	{
	}

	public bool get_BattleStatistics_Shown()
	{
		return false;
	}

	public bool get_LeftHabitPriority()
	{
		return false;
	}

	public bool get_EquipStorageShow()
	{
		return false;
	}

	public bool get_WingShowInCard()
	{
		return false;
	}

	public bool get_WingShowInRanking()
	{
		return false;
	}

	public bool get_WingShowInGameIn()
	{
		return false;
	}

	public bool Change_BattleStatistics_Shown()
	{
		return false;
	}

	public int ChangeTargetFrameRate()
	{
		return 0;
	}

	public int get_TargetFrameRate()
	{
		return 0;
	}

	public bool Change_LeftHabitPriority()
	{
		return false;
	}

	public bool Change_WingShowInCard()
	{
		return false;
	}

	public bool Change_WingShowInRanking()
	{
		return false;
	}

	public bool Change_WingShowInGameIn()
	{
		return false;
	}

	public bool Change_EquipStorage_Show()
	{
		return false;
	}

	public int get_activity_year_id()
	{
		return 0;
	}

	public void set_activity_year_id(int activityYearId)
	{
	}

	public int get_activity_year_popup()
	{
		return 0;
	}

	public void set_activity_year_popup(int activityYearPopup)
	{
	}

	public bool get_monthly_card_subscribed()
	{
		return false;
	}

	public void set_monthly_card_subscribed(bool subscribed)
	{
	}

	public void set_old_user_id(string id)
	{
	}

	public void set_net_cache_size(int size)
	{
	}

	public void set_user_id(ulong id)
	{
	}

	public bool PrizeWheel_GetConfirmToContinueRound(out long startTimestamp, out int round)
	{
		startTimestamp = default;
		round = default;
		return false;
	}

	public void PrizeWheel_SetConfirmToContinueRound(long startTimestamp, int round)
	{
	}

	public bool Anni_GetFirstEntrance()
	{
		return false;
	}

	public void Anni_SetFirstEntrance(bool value)
	{
	}

	public List<int> Anni_GetTowerSelection()
	{
		return null;
	}

	public void Anniversary_SetTowerSelection(List<int> selection)
	{
	}

	public bool Anni_GetTowerDefenseGuideShown()
	{
		return false;
	}

	public void Anni_SetTowerDefenseGuideShown(bool value)
	{
	}

	public long GetCampNormalGiftPopupTime()
	{
		return 0L;
	}

	public void SetCampNormalGiftPopupTime(long time)
	{
	}

	public bool GetCampTimingGiftNeedPopup()
	{
		return false;
	}

	public void SetCampTimingGiftNeedPopup(bool isNeed)
	{
	}

	public void SetCampTimingGiftMaxPopupID(int id)
	{
	}

	public int GetCampTimingGiftMaxPopupID()
	{
		return 0;
	}

	public void SetCampSeason(int seasonID)
	{
	}

	public int GetCampSeason()
	{
		return 0;
	}

	public long GetCampNormalGiftLastEnterTime()
	{
		return 0L;
	}

	public void SetCampNormalGiftLastEnterTime(long time)
	{
	}

	public bool GetSeeBossDie()
	{
		return false;
	}

	public void SetSeeBossDie(bool haveSee)
	{
	}

	public string GetNeedShowResetType()
	{
		return null;
	}

	public void SetNeedShowResetType(string type)
	{
	}

	public void ResetNeedShowResetType()
	{
	}

	public void SetPirateShipTag(int tag)
	{
	}

	public int GetPirateShipTag()
	{
		return 0;
	}

	public void SetPirateShipHavePopup(bool needPopup)
	{
	}

	public bool GetPirateShipPopup()
	{
		return false;
	}

	public void PirateShipClear()
	{
	}

	public void SetChristmas2023GuideIndex(int index)
	{
	}

	public int GetChristmas2023GuideIndex()
	{
		return 0;
	}

	public void SetChristmas2023GuideDrawIndex(int drawIndex)
	{
	}

	public int GetChristmas2023GuideDrawIndex()
	{
		return 0;
	}

	public void ClearChristmas2023Guide()
	{
	}

	public void SetFishingSelectLureCount(int count)
	{
	}

	public int GetFishingSelectLureCount()
	{
		return 0;
	}

	public void SetFishingSelectArea(int count)
	{
	}

	public int GetFishingSelectArea()
	{
		return 0;
	}

	public void SetFishingTag(int tag)
	{
	}

	public int GetFishingTag()
	{
		return 0;
	}

	public void SetFishingGuideTrigger(bool isTrigger)
	{
	}

	public bool GetFishingGuideTrigger()
	{
		return false;
	}

	public void ClearFishingData()
	{
	}

	public void SetHuntingTag(int tag)
	{
	}

	public int GetHuntingTag()
	{
		return 0;
	}

	public void SetHuntingSelectSceneID(int sceneID)
	{
	}

	public int GetHuntingSelectSceneID()
	{
		return 0;
	}

	public void SetHuntingHavePlayGuide(bool isPlay)
	{
	}

	public bool GetHuntingHavePlayGuide()
	{
		return false;
	}

	public void ClearHuntingData()
	{
	}

	public bool GetHideMoveJoy()
	{
		return false;
	}

	public void SetHideMoveJoy(bool isHide)
	{
	}

	public void ClearHideMoveJoy()
	{
	}

	public bool GetHideDropPropName()
	{
		return false;
	}

	public void SetHideDropPropName(bool isHide)
	{
	}

	public void ClearHideDropPropName()
	{
	}

	public int GetPropClearness()
	{
		return 0;
	}

	public void SetPropClearness(int value)
	{
	}

	public void ClearPropClearness()
	{
	}

	public bool GetCampKingScrambleNeedShow()
	{
		return false;
	}

	public void SetCampKingScrambleNeedShow(bool needShow)
	{
	}

	public void ClearCampKingScrambleNeedShow()
	{
	}

	public void SetAddressableUpdateCompleted(bool value)
	{
	}

	public void SetHotfixVersion(float value)
	{
	}

	public void SetNewPlay125GuideStep(int step)
	{
	}

	public int GetNewPlay125GuideStep()
	{
		return 0;
	}

	public void ClearNewPlay125GuideStep()
	{
	}

	public void SetNewPlay125SpeedUp(float step)
	{
	}

	public float GetNewPlay125SpeedUp()
	{
		return 0f;
	}

	public PrefDataFloat DailySpeedUp(int id)
	{
		return null;
	}

	public void SetDailySpeed(int id, float value)
	{
	}

	public float GetDailySpeed(int id)
	{
		return 0f;
	}

	public void SetBattleSpeed(float value)
	{
	}

	public float GetBattleSpeed()
	{
		return 0f;
	}

	public void ClearBattleSpeed()
	{
	}

	public void SetSailingBagBattleSpeedUp(float step)
	{
	}

	public float GetSailingBagBattleSpeedUp()
	{
		return 0f;
	}

	public void ClearNewPlay125SpeedUp()
	{
	}

	public void SetNewPlay125HavePassMaxLevel(int maxLevel)
	{
	}

	public int GetNewPlay125HavePassMaxLevel()
	{
		return 0;
	}

	public void ClearNewPlay125HavePassMaxLevel()
	{
	}

	public void ClearEquipStorageStatus()
	{
	}

	public bool HasPoppingNewFirstCharge()
	{
		return false;
	}

	public void SetPoppingNewFirstCharge(bool havePopping)
	{
	}

	public void AddFailureCountNewFirstCharge()
	{
	}

	public int GetFailureCountNewFirstCharge()
	{
		return 0;
	}

	public void AddRepeatPoppingCountNewFirstCharge()
	{
	}

	public int GetRepeatPoppingCountNewFirstCharge()
	{
		return 0;
	}

	private bool IsRecordSameDayNewFirstCharge()
	{
		return false;
	}

	public void ResetNewFirstChargePopping()
	{
	}

	public bool HasOpenGoldBox()
	{
		return false;
	}

	public void SetOpenGoldBox()
	{
	}

	public long GetSailingNormalGiftPopupTime()
	{
		return 0L;
	}

	public void SetSailingNormalGiftPopupTime(long time)
	{
	}

	public bool GetSailingTimingGiftNeedPopup()
	{
		return false;
	}

	public void SetSailingTimingGiftNeedPopup(bool isNeed)
	{
	}

	public void SetSailingTimingGiftMaxPopupID(int id)
	{
	}

	public int GetSailingTimingGiftMaxPopupID()
	{
		return 0;
	}

	public void SetSailingSeason(int seasonID)
	{
	}

	public int GetSailingSeason()
	{
		return 0;
	}

	public long GetSailingNormalGiftLastEnterTime()
	{
		return 0L;
	}

	public void SetSailingNormalGiftLastEnterTime(long time)
	{
	}

	public void SetOldLoadMapData(string mapPath)
	{
	}

	public string GetOldLoadMapData()
	{
		return null;
	}

	public void ClearOldLoadMapData()
	{
	}

	public void SetNewLoadMapData(string mapPath)
	{
	}

	public string GetNewLoadMapData()
	{
		return null;
	}

	public void ClearNewLoadMapData()
	{
	}

	public void SetOldPlayModeData(string oldPlayData)
	{
	}

	public string GetOldPlayModeData()
	{
		return null;
	}

	public void ClearOldPlayModeData()
	{
	}

	public void SetSailingGhostFleetShipNeedPlayAniData(bool needPlayAni)
	{
	}

	public bool GetSailingGhostFleetShipNeedPlayAniData()
	{
		return false;
	}

	public void ClearSailingGhostFleetShipNeedPlayAniData()
	{
	}

	public void SetSailingShipBattleSpeedUpIndex(int curSpeedUpIndex)
	{
	}

	public int GetSailingShipBattleSpeedUpIndex()
	{
		return 0;
	}

	public void ClearSailingShipBattleSpeedUpIndex()
	{
	}

	public void SetSettingEffectWeakenStatus(bool status)
	{
	}

	public bool GetSettingEffectWeakenStatus()
	{
		return false;
	}

	public void ClearSettingEffectWeakenStatus()
	{
	}

	public void SetSettingAbbreviation(bool status)
	{
	}

	public bool GetSettingAbbreviation()
	{
		return false;
	}

	public void ClearSettingAbbreviation()
	{
	}

	public bool IsPveSeasonFirstOpen()
	{
		return false;
	}

	public void ChangePveSeasonIsFirstOpen()
	{
	}

	public bool IsShowPveSeasonOpenUI(long lStartTime, long lEndTime)
	{
		return false;
	}

	public void ChangePveSeasonUIIsShow(bool value)
	{
	}

	public bool IsNewTag(int tag)
	{
		return false;
	}

	public bool IsNewTagByBpType(int tag, LocalSave.NewBpType bpType)
	{
		return false;
	}

	private int GetBpTagByBpType(LocalSave.NewBpType bpType)
	{
		return 0;
	}

	public void ChangeBattlePassTag(int tag)
	{
	}

	public void ChangeBattlePassTagByBpType(int tag, LocalSave.NewBpType bpType)
	{
	}

	public bool GetIsFirstOpen()
	{
		return false;
	}

	public void ChangeIsFirstOpenStage()
	{
	}

	public bool IsPveNewTag(int tag)
	{
		return false;
	}

	public void ChangePveBattlePassTag(int tag)
	{
	}

	public void ClearAllBattlePass()
	{
	}

	public void ClearAllCleverNotification()
	{
	}

	public int GetFirstBuyBattleCount()
	{
		return 0;
	}

	public void SetFirstBuyBattleCount(int count)
	{
	}

	public void SetFirstBuyShow()
	{
	}

	public bool GetFirstBuyShow()
	{
		return false;
	}

	public string GetStageBuyShowId()
	{
		return null;
	}

	public void SetStageBuyShowId(string showId)
	{
	}

	public void SetStageBuyNewStage(int newStage)
	{
	}

	public int GetStageBuyNewStage()
	{
		return 0;
	}

	public void SetEquipDoubleBuyStage(int stage)
	{
	}

	public int GetEquipDoubleBuyStage()
	{
		return 0;
	}

	public void SetEquipDoubleBuyFailTimes(int count)
	{
	}

	public int GetEquipDoubleBuyFailTimes()
	{
		return 0;
	}

	private void CheckLastPushTimeByType()
	{
	}

	public long Push_GetLastPushTime(CleverBuyType type)
	{
		return 0L;
	}

	public long Push_GetLastPushTimeAll()
	{
		return 0L;
	}

	public bool Push_SetLastPushTime(CleverBuyType type, bool flush)
	{
		return false;
	}

	public bool Push_SetLastPushTime(CleverBuyType type, long t, bool flush)
	{
		return false;
	}

	public void Push_ClearLastPushTime()
	{
	}

	public void Push_FlushLastPushTime()
	{
	}

	private void CheckIdByType()
	{
	}

	public int Push_GetPushId(CleverBuyType type)
	{
		return 0;
	}

	public void Push_SetPushId(CleverBuyType type, int id, bool flush)
	{
	}

	public void Push_FlushIds()
	{
	}

	private void CheckStateByType()
	{
	}

	public CleverPushState Push_GetState(CleverBuyType type)
	{
		return CleverPushState.NOT_SHOWN;
	}

	public void Push_SetState(CleverBuyType type, CleverPushState state, bool flush)
	{
	}

	public void Push_FlushState()
	{
	}

	private void CheckInfoByType()
	{
	}

	public string Push_GetInfo(CleverBuyType type)
	{
		return null;
	}

	public void Push_SetInfo(CleverBuyType type, string info, bool flush)
	{
	}

	public void Push_FlushInfo()
	{
	}

	private void CheckLastPurchaseTimeByType()
	{
	}

	public long Push_GetLastPurchaseTime(CleverBuyType type)
	{
		return 0L;
	}

	public void Push_SetLastPurchaseTime(CleverBuyType type, long purchasedTimestamp, bool flush)
	{
	}

	public void Push_ClearLastPurchaseTime()
	{
	}

	public void Push_FlushLastPurchaseTime()
	{
	}

	private void CheckShowTimesByType()
	{
	}

	public int Push_GetShowTimes(CleverBuyType type)
	{
		return 0;
	}

	public void Push_SetShowTimes(CleverBuyType type, int showTimes, bool flush)
	{
	}

	public void Push_FlushShowTimes()
	{
	}

	public ExpDropShowType GetExpDropType()
	{
		return ExpDropShowType.eNormal;
	}

	public void SetExpDropType(ExpDropShowType expType)
	{
	}

	public void ClearExpDropType()
	{
	}

	public void AddAttemptsBeforeCompleteChapter(int cptId, bool heroMode)
	{
	}

	public int GetAttemptsBeforeCompleteChapter(int cptId, bool heroMode)
	{
		return 0;
	}

	public void AddPlayedTimesByOne()
	{
	}

	public void SetGuildJoinApplied(bool applied)
	{
	}

	public bool GetGuildJoinApplied()
	{
		return false;
	}

	public void ClearExtra()
	{
	}

	public string GetGameAhievement()
	{
		return null;
	}

	public void SetGameAchievement(string info)
	{
	}

	public void ClearGameAchievement()
	{
	}

	public bool GetMagicianGuide()
	{
		return false;
	}

	public void SetMagicianGuide(bool val)
	{
	}

	public uint GetMagicianTransId()
	{
		return 0u;
	}

	public void ClearMagicianTransId()
	{
	}

	public int GetMagicianShown()
	{
		return 0;
	}

	public void SetMagicianShown(int chapter)
	{
	}

	public void InitLocalMail()
	{
	}

	private string[] GetAllMailIds()
	{
		return null;
	}

	private MailData GetMailById(string mailId)
	{
		return null;
	}

	public void GetAllLocalMails(out List<MailData> mailList, out HashSet<string> mailSet)
	{
		mailList = null;
		mailSet = null;
	}

	public void AddMail(MailData mailData)
	{
	}

	public void AddMail(string mailId, string mailInfo)
	{
	}

	public void ReadMail(MailData mailData)
	{
	}

	public void ReceiveReward(MailData mailData)
	{
	}

	public void RemoveAllMails(bool forceRemoveAnnouncements = false)
	{
	}

	public void RemoveMail(MailData data)
	{
	}

	public void RemoveMail(string mailId)
	{
	}

	public MailData ReplaceMailContent(MailData data)
	{
		return null;
	}

	public void UpdateMail(MailData mailData)
	{
	}

	public string ToMailListStr(HashSet<string> mailSet)
	{
		return null;
	}

	public bool TrimMail(List<MailData> remainList)
	{
		return false;
	}

	public string GetMainActivityLastBuyProduct()
	{
		return null;
	}

	public void SetMainActivityLastBuyProduct(string product)
	{
	}

	public int GetMainActivityLastBuyId()
	{
		return 0;
	}

	public void SetMainActivityLastBuyId(int id)
	{
	}

	public void ClearMainActivityBuyId()
	{
	}

	public void ChangeNetVersion(int tag)
	{
	}

	public int GetNetVersion()
	{
		return 0;
	}

	public void ClearAllNetVersion()
	{
	}

	public bool get_red_node_once(int index)
	{
		return false;
	}

	public void set_red_node_once(int index)
	{
	}

	public void ClearRed()
	{
	}

	public string GetRuneInfo()
	{
		return null;
	}

	public void SetRuneInfo(string val)
	{
	}

	public string GetRuneTemp()
	{
		return null;
	}

	public void SetRuneTemp(string val)
	{
	}

	public string GetRuneAchieve()
	{
		return null;
	}

	public void SetRuneAchieve(string val)
	{
	}

	public void ClearRuneData()
	{
	}

	public int GetRuneCount(int runeId)
	{
		return 0;
	}

	public void SetRuneCount(int runeId, int val)
	{
	}

	public int AppendRuneCount(int runeId)
	{
		return 0;
	}
}
