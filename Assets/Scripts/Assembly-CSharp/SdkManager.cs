using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Activity;
using Facebook.Unity;
using Firebase;
using GameProtocol;
using Habby.Guild.Data;
using TableTool;
using UnityEngine;

public class SdkManager
{
	public class LoginData
	{
		public bool bSuccess;

		public string userid;

		public string gamePlayerID;

		public string username;

		public string email;
	}

	public class game_end_data
	{
		public int survive_times;

		public BattleEndType end_type;

		public int coins;

		public int equipment;

		public int end_stage;

		public int end_layer;

		public int newbest;

		public int exp;

		public int levelupcount;

		public int level;

		public int killMonster;

		public int atk;

		public int hpmax;

		public int equipCount;

		public int scrollCount;

		public int stoneCount;

		public float time;

		public int gemid;

		public int gemcount;

		public int attempts;

		public int gold_leaf;

		public int dew;

		public string material_cardlist;

		public int imprint_books;

		public int imprint_oracles;

		public int imprint_divine_stones;

		public int imprint_fragment;

		public int BlueImprintStone;

		public int PurpleImprintStone;

		public int Snack;

		public int biscuit;

		public int imprintMt;

		public int ChristmasBall;

		public string holy_spical_mosnter;

		public string reward_list;
	}

	public class game_end_daily
	{
		public int dailyId;

		public int survive_times;

		public BattleEndType end_type;

		public int coins;

		public int equipment;

		public int end_stage;

		public int end_layer;

		public int newbest;

		public int exp;

		public int levelupcount;

		public int level;

		public int killMonster;

		public int deltaDailyScore;

		public int currentDailyScore;

		public int currentDailyLevel;

		public int atk;

		public int hpmax;

		public int equipCount;

		public int scrollCount;

		public int stoneCount;

		public float time;

		public int result;

		public int gemid;

		public int gemcount;

		public int line;

		public int boneCnt;

		public int hornCnt;

		public int gold_leaf;

		public int dew;

		public string material_cardlist;

		public int BlueImprintStone;

		public int PurpleImprintStone;

		public int Snack;

		public int biscuit;

		public int imprintMt;

		public int ChristmasBall;

		public int pack_tokens;
	}

	public class GameOverPointData
	{
		public int[] skileList;

		public string source;

		public int stage;

		public int end_stage;

		public int level;

		public int layer;

		public int talent;

		public long count;

		public long coins;

		public long gems;
	}

	public class MatchPVPData
	{
		public const string CHOICE_TYPE_CLICK = "CHOICE_TYPE_CLICK";

		public const string START_MATCH_CLICK = "START_MATCH_CLICK";

		public const string MATCH_FINISH = "MATCH_FINISH";

		public const string CONNECT_BATTLE_SERVER = "CONNECT_BATTLE_SERVER";

		public const string EXCHANGE_USER_DATA = "EXCHANGE_USER_DATA";

		public const string START_BATTLE = "START_BATTLE";

		public const string END_BATTLE = "END_BATTLE";

		public const string SUCCESS = "SUCCESS";

		public const string FAIL = "FAIL";

		public string step;

		public string result;

		public string reason;

		public int matchCount;

		public string mapStr;

		public int battleType;

		public float matchTime;

		public float battleTime;
	}

	public class PVPCheat
	{
		public string winner_id;

		public long winner_atk;

		public int winner_total_iap;

		public string loser_id;

		public long loser_atk;

		public int loser_total_iap;

		public int iap_diff;

		public int super_battle;

		public int source;
	}

	public enum LoginEventType
	{
		_ = 999,
		SetGraphic = 1000,
		HotFix = 1001,
		LoadConfig = 1002,
		LoadMainUI = 1003,
		Update = 1004,
		Init1 = 1005,
		Init2 = 1006,
		Init3 = 1007,
		Init4 = 1008
	}

	public class TableEventGuildData
	{
		public int source;

		public int gems;

		public int conins;

		public GuildInfoData infoData;

		public GuildSigninInfo siginInfo;

		public GuildMemberInfo selfInfo;

		public TableEventDonate donateData;

		public TableEventTask taskData;

		public void AddUserInfo(Dictionary<string, object> keyList)
		{
		}

		public void AddGuildInfo(Dictionary<string, object> keyList)
		{
		}
	}

	public class TableEventDonate
	{
		public int donateType;

		public int itemId;

		public int itemCount;

		public int score;

		public int xp;
	}

	public class TableEventTask
	{
		public int score;

		public int xp;

		public int lastTaskId;

		public int nextTaskId;
	}

	public class GuildCreationReportData
	{
		public string clanId;

		public int gemCost;

		public int badgeChangeTimes;

		public int tagChangeTimes;

		public int openType;

		public int requiredCpt;

		public int guildBadgeUp;

		public int guildBadgeDown;
	}

	public class GuildPushListReportData
	{
		public int appliedCount;

		public int viewedCount;

		public int refreshCount;

		public int searchCount;

		public int isClosedByAfterJoin;
	}

	public class GuildJoinReportData
	{
		public string clan_name;

		public string clan_Id;

		public int clanLevel;

		public int clanPeople;

		public int chapterLimit;

		public int joinedGuildTimes;

		public long currentGuildPoints;
	}

	public class GuildShopReportData
	{
		public string guildId;

		public string goodId;

		public int gems;

		public int guildLevel;

		public int guildPeople;

		public long curPoints;

		public int goodPos;

		public int goodCount;

		public int pointCost;

		public int purchasedTimes;
	}

	public enum NewPlayerGuideEventType
	{
		Base = 1999,
		InitFinished = 2000,
		FirstGame = 2001,
		BattleGuide_1 = 2002,
		BattleGuide_2 = 2003,
		BattleGuide_3 = 2004
	}

	private class Message
	{
		public string name;

		public string message;

		public string stackTrace;
	}

	[Serializable]
	public class GameCenterLoginData
	{
		public string id;

		public string gamePlayerID;

		public string teamPlayerID;

		public string name;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass528_0
	{
		public Action<bool> onShare;

		internal void _003CFacebook_Share_003Eb__0(IMediaUploadResult result)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CFacebook_Share_003Ed__528 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<bool> onShare;

		private _003C_003Ec__DisplayClass528_0 _003C_003E8__1;

		private string _003CimgPathAbsolute_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFacebook_Share_003Ed__528(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const string DRAGON_SET = "dragonset";

	public const string app_start = "app_start";

	public const string app_end = "app_end";

	public const string game_start = "game_start";

	public const string game_end = "game_end";

	private static bool bLogEnable;

	public static string ad_mopubid;

	private static string cooperationOtherServerID;

	private const int WIN = 1;

	private static Dictionary<uint, DC_TeamInfo> selfTeamDict;

	private static Dictionary<uint, DC_TeamInfo> enemyTeamDict;

	private static bool buglyInited;

	private static FirebaseApp app;

	private static List<Message> m_listMsgCache;

	private static bool ifFBLogin;

	public static readonly string ShareImageName;

	private static bool isInitializing;

	private static bool isCloudInitialized;

	public static Action OnFBInitializedCallback;

	private static Action OnFBCloudInitializedCallback;

	public static Action<Purchase> OnConsumeUnconsumedPurchases;

	public static Action<LoginData> logincallback;

	public static Action<LoginData> logincheckcallback;

	public static bool isTryGoogleLogin;

	private static Dictionary<string, object> SLG_COMMON_DATA => null;

	private static Dictionary<string, object> SLG_COMMON_DATA_PRE => null;

	private static void Log(string value)
	{
	}

	public static void InitSdks()
	{
	}

	public static void set_first_setup_time()
	{
	}

	public static long get_first_setup_time()
	{
		return 0L;
	}

	public static int get_play_days()
	{
		return 0;
	}

	private static int GetBeforePurchaseHour()
	{
		return 0;
	}

	public static void send_deadlayer(int layer)
	{
	}

	public static void send_event(string eventId)
	{
	}

	public static void send_event_http(string step)
	{
	}

	public static void send_app_start()
	{
	}

	public static void send_app_end()
	{
	}

	public static void send_event_page_show(WindowID windowid, string step)
	{
	}

	public static void send_event_revival(string result, int stage, int layer, int gems, RebornSource source, int dailyId)
	{
	}

	public static void send_event_mainactivity(string step, string result)
	{
	}

	public static void send_event_game_start(int chapter, int data3, int data4, int atk, int hp, int layer)
	{
	}

	private static void CheckHellMode(BattleModuleData battleData, Dictionary<string, object> pro)
	{
	}

	public static void send_event_game_start_daily(int dailyId, int chapter, int data3, int data4, int layer)
	{
	}

	private static void Log(string eventName, Dictionary<string, object> dic)
	{
	}

	private static void PassAtkHp2Pro(Dictionary<string, object> pro)
	{
	}

	public static void send_event_game_end(game_end_data data)
	{
	}

	public static void send_game_end_cheat(uint power_transid, uint settlement_transid, string server_list, string client_list, long agreement_time, long settlement_time)
	{
	}

	public static void send_game_begin_cheat(uint power_transid, uint settlement_transid, string server_list, string client_list, long agreement_time, long settlement_time)
	{
	}

	public static void send_event_game_end_daily(game_end_daily data, List<LocalSave.EquipOne> equipOnes)
	{
	}

	public static void send_event_game_end_daily(int dailyId, int survive_times, BattleEndType end_type, int coins, int equipment, int end_stage, int end_layer, int newbest, int exp, int levelupcount, int level, int killMonster, int deltaDailyScore, int currentDailyScore, int currentDailyLevel, int atk, int hpmax, int equipCount, int scrollCount, int stoneCount, float time, int result = 0, int gemid = 0, int gemcount = 0, int line = 0, int boneCnt = 0, int hornCnt = 0)
	{
	}

	public static void send_event_special_box(SpecialBoxStep step, int source, int gems = 0, int coins = 0, int count = 0, int equip1 = 0, int equip2 = 0, int equip3 = 0)
	{
	}

	public static void send_event_achieve(AchieveStep step, int source = 0, int stage = 0, int gems = 0, AchieveType type = AchieveType.Achieve)
	{
	}

	public static void send_event_achieve_pve_task(AchieveStep step, int source, string result, string reason, long soul = 0L, long bigSoul = 0L, long superSoul = 0L)
	{
	}

	public static void send_event_rune_forge(int runeId, int count, RuneItemData[] data)
	{
	}

	public static void send_forge_reward(int runeId, int rewardId)
	{
	}

	public static void send_event_daily_buy(int dailyId, int gems)
	{
	}

	public static void send_event_download(DownloadStep step, DownloadResult result, string reason, string downloadName)
	{
	}

	public static void send_event_clever_push(PushStep step, PushSource source, string product, int gems, int equipId1 = 0, int equipId2 = 0, int coins = 0, int pushLevel = -1)
	{
	}

	public static void send_event_equipment(string step, int equipment, int count, int target_level, EquipSource source, int coins, int dailyId = -1, string result = "", string reason = "")
	{
	}

	public static void send_event_equipment(string step, int equipment, int count, int target_level, EquipSource source, int coins, int equipcnt, int dailyId = -1)
	{
	}

	public static void sendEventWishBox(int eid1, int eid2, int eid3, int eid4, bool isReduce)
	{
	}

	public static void sendEventEditName(string name, string old, int gems, int count)
	{
	}

	public static void sendEventTrain(string source, int level, int target_level, int layer, int shoptype, int count)
	{
	}

	public static void sendEventExchange(int source, int level, int count)
	{
	}

	public static void sendEventWeekGift(int tag, int day, int index)
	{
	}

	public static void sendEventEquipMelt(string result, int error, int diamond, int eid1, int eid2, int eid3)
	{
	}

	public static void sendEventEquipBreak(string breaks, string lvs, int count, string rewards)
	{
	}

	public static void sendEventEggHatch(int mid, string step)
	{
	}

	public static void sendEventUnlock(string source, int gems, string step)
	{
	}

	public static void sendEventLevelUp(int mid, string source, string step, string result, int reason, int data1, int coins, int data2 = 0)
	{
	}

	public static void sendEventEquipBox(string source, int layer, string product)
	{
	}

	public static void sendEventGemCombine(string result, string reason, string step, int equipment, int basic)
	{
	}

	public static void sendHarvestTime(string privilege_id, int task_id)
	{
	}

	public static void sendFarmVisit(string step, string raw, string source, string result, int data1, int data2, int data3, int data4)
	{
	}

	public static void sendFarmVisitBubble()
	{
	}

	public static void sendSevenDayBox(int carnival_id, int reward_id, string reward_list)
	{
	}

	public static void sendSevenDayTask(int carnival_id, int task_id, int integral_num, string reward_list)
	{
	}

	public static void send_advanced_carnival(string source, int task_id, int carnival_currency, string reward_list)
	{
	}

	public static void send_advanced_carnival_shop(string commodity_id, string commodity_list, int carnival_currency)
	{
	}

	public static void sendCashGift(string source, string step, string result, int data1, int data2)
	{
	}

	public static void sendDispatchUnlcok()
	{
	}

	public static void sendDispatchRefresh(string source, int gems, string ids)
	{
	}

	public static void sendDispatchFinish(string source, int tid, int gems, int small, int big)
	{
	}

	public static void sendVIPBuyInfo(int purchase_num, int gems_num, int gems_count)
	{
	}

	public static void sendVIPChest(string source)
	{
	}

	public static void sendEventGuildWish(string step, string result, int code, int source, int equipid, int equipcount, int cardLeft = 0)
	{
	}

	public static void sendEventGuildGetItem(int source, int equipid, string another)
	{
	}

	public static void sendEventGuildEgg(string step, string result, int code, int eggid, int current, int total)
	{
	}

	public static void sendEventGuildEggSpeed(int eggid, int times, string another)
	{
	}

	public static void sendEventGuildHelp(string step, string result, int reason, int source, string another, int equipid)
	{
	}

	public static void sendEventGetGift(string step, string result, int reason, int source, string another, int giftid)
	{
	}

	public static void sendEventLike(int source, string another)
	{
	}

	public static void sendEventTalk(int source, int chatid)
	{
	}

	public static void sendEventChat(int source, string content, string result, int reason)
	{
	}

	public static void sendNoteUI(string step, string source, string result)
	{
	}

	public static void sendAltar(string end_type, string source, string step, string result, int reason, int data1, int data2, int data3, int data4, int data5, int data6, string equipment0, string equipment_0, string relics_altar_cost)
	{
	}

	public static void sendAltarBless(string source, string step, string result, int reason, int gems, int data1, int data2, int data3, string data_altar, string reward_list)
	{
	}

	public static void sendEggTimeCard(string result, int data1, int data2, int data3, int data4, int data5, int data6, int data7, int data8, string equipment_0)
	{
	}

	public static void send_Incubation_acceleration(string egg_id, long timeleft, string cost_item, string return_item)
	{
	}

	public static void sendGamblingShop(string source, string step, string result, int reason, int gem, int data1, int data2, int data3)
	{
	}

	public static void sendGamblingLevel()
	{
	}

	public static void send_event_talent(string step, int talent, int target_level, int coins)
	{
	}

	public static void send_character_discount(character_rebate step, int source)
	{
	}

	public static void send_event_mysteries(string step, int shoptype, int index, int equipment, int equipment1, int equipment2, int equipment3, int equipment4, int equipment5, int equipment6, int equipment7, int equipment8, int coins, int gems, string result, string reason, MysteriesSource source, int dailyId)
	{
	}

	public static void send_event_admysteries(string step, int shoptype, int index, int equipment, int equipment1, int equipment2, int equipment3, int equipment4, int equipment5, int equipment6, int equipment7, int equipment8, string result, string reason, MysteriesSource source, int dailyId)
	{
	}

	public static void send_event_shop(string purchase, int coins, int gems, int equipment, int continue_count, string source = "", string step = "")
	{
	}

	public static void send_event_http_time(int type, int subtype, int millseconds, string requestId, string step = "", string result = "", string reason = "")
	{
	}

	public static void send_event_exchange(CoinExchangeSource source, int coins, int gems)
	{
	}

	public static void send_event_cheat(string cheat)
	{
	}

	public static void send_event_skin_exchange(int source, int count, int purchase, int equipment_1, int equipment_2)
	{
	}

	public static void send_event_strength(string step, KeyBuySource source, string result, string reason, int gems)
	{
	}

	public static string GetRewardListStr(List<Drop_DropModel.DropData> rewards)
	{
		return null;
	}

	public static void send_event_iap(string step, ShopOpenSource source, string product, string result, string reason, int gems = 0, long coins = 0L, float count = 0f, string type = "iap", int row_id = 0, string stellarite = "", string reward_list = "")
	{
	}

	public static void send_event_ad(ADSource source, string step, int coins, int gems, string result, string reason)
	{
	}

	public static void sendEventAdNew(string source, string step, string result, string error_code)
	{
	}

	public static void sendEventEquipDown(int equipment_id, int equipment_0, int get_id, int get_num, int coin, int item, int itemcount, int stone, int stonecount)
	{
	}

	public static void sendEventLoginSign(int reward_id, string reward_list)
	{
	}

	public static void sendEventLoginGift(int login_id, int giftbag_id, string giftbag_list)
	{
	}

	public static void sendEventAssistLevelUp(int hero_id, string hero_name, int star, int after_level, int braveemblem_count, int everlifetrialstone_count, int immortaltrialstone_count, int eternaltrialstone_count, int coin_count)
	{
	}

	public static void sendEventBox4thOpen(string box_type, string reward_list, int keys_consumed)
	{
	}

	public static void sendEventBox4thExch(string box_type, int monster_teeth, int monster_slime, string source)
	{
	}

	public static void sendEventBox4thTask(int task_id, int keys_consumed)
	{
	}

	public static void sendEventBoxSelect(int box_id, int box_reward)
	{
	}

	public static void send_event_equip_combine(string step, int equipment, string result, string reason)
	{
	}

	public static void send_event_equip_level_down(int equipId, int level, int coin, int scrollCount, int scrollId)
	{
	}

	public static void send_event_harvest(string step, int source, string result, string reason, int coins, int scrollcount, int harvestLevel, int gemcost = 0)
	{
	}

	public static void send_cheat_once(string userid, int sendcode, int sendchildtype, int type, long realvalue, long referencevalue)
	{
	}

	public static void send_cheat_once_client(string userid, CheatOnceType type, string info)
	{
	}

	public static void OnLogin()
	{
	}

	public static void send_character_get(int source, string step, string result, int coins, int gems, string product)
	{
	}

	public static void send_battlepass_get(string step, int source, int shoptype, int equipment1, int equipment2, int equipment3, int rewardId, string bp_type)
	{
	}

	public static void sendPVE_battlepass_get(string step, int source, int index, int tag)
	{
	}

	public static Dictionary<string, object> GetCommonDict_PVE()
	{
		return null;
	}

	public static void sdk_PVEExchangeOut(int ConvertNum)
	{
	}

	public static void sdk_PVEExchangeIn(int ConvertShopID)
	{
	}

	public static void sdk_PVEExchange(string cost_currency, int cost_amt, string reward_list)
	{
	}

	public static void sdk_PVEHarvest(int soul, int SumTime, int Type, string step, string result, string reason)
	{
	}

	public static void sdk_PVETalentReward(int source, string step, string result, string reason, int score)
	{
	}

	public static void sdk_PVEShop(int shoptype, int score, int gems, string step, string result, string reason, int equipment_1, int equipment_2, int equipment_3)
	{
	}

	public static void sdk_PVETalent(int talentID, int target_level, string step, int soul, int bigsoul)
	{
	}

	public static void send_battlepass_killMonster(int count)
	{
	}

	public static void send_battlepass_buyLevel(string step, int gems, int level, string bp_type)
	{
	}

	public static void send_tryPlay_Click_Character_try(string step, int sourceid)
	{
	}

	public static void send_NetHeroData(string step, Dictionary<string, object> values)
	{
	}

	public static void SetOtherServerID(string pOtherID)
	{
	}

	public static void Send_CooperationMatchData(string step, string result)
	{
	}

	public static void Send_CooperationMatchDataPVP(MatchPVPData pData)
	{
	}

	public static void Send_PVPCheat(PVPCheat pData)
	{
	}

	public static void Send_SkillListDataPVP(GameOverPointData pData)
	{
	}

	public static void send_habbyMail_step(HabbyMailStep step, string source, string dropStr = "")
	{
	}

	public static void send_equip_breakdown(EquipBreakDownStep step, int equipment, int level, int coins, int scrolls)
	{
	}

	public static void send_old_user_back(BackRewardStep step, string deltaDays, int coins, int gems, int scrolls, int box_normal, int box_special, int energies, int keys)
	{
	}

	public static void send_signin_reward(Sign step, int count)
	{
	}

	public static void DailyTask(DTask step, DTaskType source, int number, string sc, string sx, int id = 0, int gems = 0, int exp = 0, int coins = 0)
	{
	}

	public static void WeeklyTask(string step, string source, string result, string reason, int id)
	{
	}

	public static void year_change(int source, int count, int gems)
	{
	}

	public static void year_award(int count, int source, int level)
	{
	}

	public static void activity_drop(DropUp step, int source, int count)
	{
	}

	public static void send_christmas_task(string step, string source, string taskId1, string taskId2, string taskId3, string finishDailyCount, string finishedAllCount, string stage)
	{
	}

	public static void send_turntable(string step, string result, string reason, string source, string curSpinTimes, object curRewardType, object curRewardId, object curRewardCount, int type, long cost)
	{
	}

	public static void send_christmas_cost(string step, string source, string totalFinishedCount, string diamondNeeded, string diamondSpent)
	{
	}

	public static void send_box_activity(BoxActivity step, string source = "", string result = "")
	{
	}

	public static void send_level_up(LevelUp step, int level = 0, int gems = 0)
	{
	}

	public static void send_stage_box(StageBox step, GameMode source, int stage, int layer, int gems = 0, int coins = 0, int equipment_1 = 0, int equipment_2 = 0, int equipment_3 = 0, int equipment_4 = 0)
	{
	}

	public static void send_event_normalwheel(string step, int level, int talent, int layer, int source, int gems = 0, string result = "", string reason = "", int equipment_1 = -1, int equipment_2 = -1, int equipment_3 = -1, int equipment_4 = -1)
	{
	}

	public static void send_event_wheeltask(string result, int source, int count, int level, int talent, int layer, int equipment_1, string reason = "")
	{
	}

	public static void send_event_superwheel(string step, int level, int talent, int layer, int source, int gems = 0, string result = "", string reason = "", int equipment_1 = -1, int equipment_2 = -1, int equipment_3 = -1, int equipment_4 = -1)
	{
	}

	public static void send_event_wheelreward(string step, int level, int talent, int layer, int source, string result = "", string reason = "", int equipment0 = -1, int equipment_1 = -1, int equipment_2 = -1, int equipment_3 = -1, int equipment_4 = -1, int equipment_5 = -1, int equipment_6 = -1, int equipment1 = -1, int equipment2 = -1, int equipment3 = -1, int equipment4 = -1, int equipment5 = -1, int equipment6 = -1)
	{
	}

	public static void send_event_ship(string step, int level = 0, int talent = 0, int layer = 0, string result = "", string reason = "", int gems = 0, int coins = 0, int equipment_1 = 0, int equipment_2 = 0, int equipment_3 = 0, int source = 0, int count = 0, int equipment1 = 0, string shop_type = "", int data1 = 0, int data2 = 0)
	{
	}

	public static void send_pvp_report(string step, ulong raw_Id, ulong another_raw_Id, int count, int source, int end_type, int equipment1, int equipment2, int equipment3, int equipment_1, int equipment_2, int equipment_3, int level, int talent, int layer, string shop_type)
	{
	}

	public static void send_event_game_start_pvp(int gems, string raw_Id, string another_raw_Id, int equipment1, int equipment2, int equipment3, int equipment_1, int equipment_2, int equipment_3, int level, int talent, int layer, string shop_type, int data1, int data2, int data3, int data4)
	{
	}

	public static void send_event_game_end_pvp(string raw_Id, string another_raw_Id, int gems, int result, int shop_type, int gold, PVPBattleEndType end_type, int data1, int data2)
	{
	}

	public static void send_event_game_start_pve(int HeroID, int level, int talent, int chapter, int PVESeason, int PVEPartition, int PVETalent, int PVEStage, int PVEToken, int PVEAbility, int PVEWeekAbility, int layer, int PVEDay, int vocation, int heroAssistId)
	{
	}

	public static void send_event_game_end_pve(int HeroID, int chapter, int stage, string result, int coins, int soul, int PVESeason, int level, int talent, int vocation, int PVEPartition, int PVETalent, int PVEStage, int PVEToken, int PVEAbility, int PVEWeekAbility, int layer, int PVEDay, int cheatData1, int cheatData2, string cheatData3, int slotinSkillCnt, string skills, int maxStage, int heroAssistId, int heroAssistCount)
	{
	}

	public static void send_event_buy_key_pve(int PVESeason, int PVEPartition, int PVETalent, int PVEStage, int PVEToken, int PVEAbility, int PVEWeekAbility, int PVEDay, int layer, int level, int talent, int gems, string step, string reason = "", string result = "")
	{
	}

	public static void send_event_farm(string step, int source = 0, int gems = 0, int coins = 0, int equipment_1 = 0, int equipment_2 = 0, int equipment_3 = 0, int equipment_4 = 0, int equipment_5 = 0, int equipment_6 = 0, int equipment_7 = 0, int equipment_8 = 0, int equipment_9 = 0, string result = "", int data1 = 0, int data2 = 0, int data3 = 0)
	{
	}

	public static void send_event_sweep(string step, string result, int stage, int level, int talent, int layer, string rewards = "")
	{
	}

	public static void send_event_hotupdate(string step, string source, int versionOld, int versionNew, string reason = null)
	{
	}

	public static void send_event_idfa(int status, int realStatus, string idfa, string iosVersion)
	{
	}

	public static void send_event_subscription_get(string step)
	{
	}

	public static void send_event_backmail(string step, string result, string reason, string giftCode = null, string mailId = null)
	{
	}

	public static void send_event_applink(bool success, string reason = null)
	{
	}

	public static void send_event_login(int login_id)
	{
	}

	private static string getEquippedDragonInfo()
	{
		return null;
	}

	public static void Send_Dragon_Chest(int source, int itemid, int itemCount, bool isUp)
	{
	}

	public static void Send_Dragon_LevelUp(string step, string source, LocalSave.EquipOne dragonEquip, string result = "", int skillSlotIndex = -1, bool is_fast = false)
	{
	}

	public static void Send_Dragon_Synthesis_dragon(string get_dragon_list, string cost_dragon_list, string source, string coin, string magic_stones, string magic_type, string dragon_crystal, string dragon_crystal_type)
	{
	}

	public static void SendRelicStarUp(int rarity, int costId, int costNum, int coinCoist, int relicStar, string relicId)
	{
	}

	public static void SendRelicLevelUp(int rarity, int costNum, int relicFragCount, int coinCost, string relicId)
	{
	}

	public static void SendRelicBox(string relicList, int gems, string source)
	{
	}

	public static void SendBox_EquipS(string rewards, int gems, string source, bool isUp)
	{
	}

	public static void SendBox_Manor(string rewards, int gems, string source)
	{
	}

	public static void SendNaturalDrop(string relicList, int layer)
	{
	}

	public static void SendRelicCombine(int rarity, int relicId, int relicFragNum)
	{
	}

	public static void Send_MB_UI_Steps(string source, object result)
	{
	}

	public static void Send_MB_Battle(string source, string result, uint transId)
	{
	}

	public static void send_dailytd_reward(int rewardPoints, string rewardStr, int rewardLayer, string source = null)
	{
	}

	public static void Send_MB_Battle_ExitGame(string source, string result, uint transId)
	{
	}

	private static Dictionary<string, object> dc_getBattleInfo(string source, string result, uint transId)
	{
		return null;
	}

	public static void Send_Clan_Login(TableEventGuildData pData, string step, string result, string reason, string guildId = "")
	{
	}

	public static void Send_Clann_TableShow(TableEventGuildData pData)
	{
	}

	public static void Send_Clan_Reward_Weekly(TableEventGuildData pData, string step, string result, string reason)
	{
	}

	public static void Send_Clan_Reward_Daily(TableEventGuildData pData, string step, string result, string reason)
	{
	}

	public static void Send_Clan_Reward_Donate(TableEventGuildData pData, string step, string result, string reason)
	{
	}

	public static void Send_Clan_Task(TableEventGuildData pData, string step, string result, string reason)
	{
	}

	private static void add_basic_info(Dictionary<string, object> pro)
	{
	}

	public static void send_clan_create(string step, string result, string reason, GuildCreationReportData data)
	{
	}

	public static void send_clan_pushlist(int source, string step, GuildPushListReportData data)
	{
	}

	public static void send_clan_join(string step, string result, GuildJoinReportData data)
	{
	}

	public static void send_event_clan_shop(string step, string result, string reason, int source, GuildShopReportData data)
	{
	}

	public static void send_event_clan_collect_box(int giftId)
	{
	}

	public static void send_event_activity_common(string step, string result, string reason, int source, int type, int count, int idOfReward)
	{
	}

	public static void send_event_activity_common_buyLevel(string activity_type, int gems, int buylevel)
	{
	}

	public static void send_optional_prop_choice(string source, string result, int fragId, int fragCount)
	{
	}

	public static void send_gem_chest(int sourceType, int id, int count)
	{
	}

	public static void send_event_delete_account(string result, string reason, string source)
	{
	}

	public static void send_event_create_new_account(string oldId)
	{
	}

	private static void AddRefineData(Dictionary<string, object> pro)
	{
	}

	private static void AddRefineDetails(Dictionary<string, object> pro)
	{
	}

	public static void send_event_refining(string source, string result, string reason, int pos, int resultLevel, int[] materialIds, int materialCounts, int gold)
	{
	}

	public static void send_event_refining_advance(string result, string reason, string resultId, string materials)
	{
	}

	public static void send_event_refining_extract(string result, string reason, string carvings, string materials, string scrolls, int coin)
	{
	}

	public static void send_event_new_player_guide(NewPlayerGuideEventType type)
	{
	}

	public static void send_event_consume(string source, string step, string result, string reason, long gems, int id)
	{
	}

	public static void send_event_world_cup_show()
	{
	}

	public static void send_event_world_cup_task_get(uint taskId, bool isWorld, int count, string rewards)
	{
	}

	public static void send_event_world_cup_bet(uint matchId, bool isChamp, int count, float odd, string teamId)
	{
	}

	public static void send_event_world_cup_get(bool isChamp, uint matchId, string result, int count, string reward_list)
	{
	}

	public static void send_event_world_cup_exchange(uint id, int cnt, string item, int ballCount, int cupCount)
	{
	}

	public static void send_event_world_cup_match_bet_get(uint id, string bet_result, string reward_list)
	{
	}

	public static void send_event_christmas_make_wish(string wish_id, int wish_coin, int wish_value)
	{
	}

	public static void send_event_christmas_get_make_wish(string award, string wish_id, string source)
	{
	}

	public static void send_event_christmas_wish_task(bool isActive, string task_id, string get_award)
	{
	}

	public static void send_event_christmas_wish_check_in(int check_day, string award, string full_server, bool isDaily)
	{
	}

	public static void send_event_make_wish(string wish_id, int wish_coin, int wish_value)
	{
	}

	public static void send_event_get_make_wish(string award, string wish_id, string source)
	{
	}

	public static void send_event_wish_task(bool isActive, string task_id, string get_award)
	{
	}

	public static void send_event_lattice_get_key(string source, int count)
	{
	}

	public static void send_event_lattice_exchange_shop(string exchange_id, int stage, int points)
	{
	}

	public static void send_event_activity_lattice_jackpot_time(int latticeCount, int stage, string jackpot, int jackpot_count)
	{
	}

	public static void send_event_activity_bingo(uint bingo_id, uint bingo_rounds, int reward_id, string reward_list, string source, int bingo_num)
	{
	}

	public static void send_event_activity_bingo_get_ticket(string source, int gems_count, int ticket_count, int taskid)
	{
	}

	public static void send_event_growth_fund(ushort type, uint id, int count, int source)
	{
	}

	public static void send_event_bigmap_layer_end(int duration, long consume_HP, bool result)
	{
	}

	public static void send_event_medal_gain(string medalid)
	{
	}

	public static void send_event_w_skin_get(string skinid, string type, string source, int count)
	{
	}

	public static void send_event_challenge_reward(string challenge_id, string rank, string result, string error)
	{
	}

	public static void send_event_linkage_gift(string activityTag, string rewardID, string rewardType)
	{
	}

	public static void send_anniversary_exchange(string exchange_id, int soul_grudge, string reward_list)
	{
	}

	public static void send_anniversary_check_in(string day_id, string reward_list)
	{
	}

	public static void send_anniversary_mirror_puzzle(string puzzle_id, string reward_list, string source, string box_id)
	{
	}

	public static void send_anniversary_full_benefits(string benefits_id, string reward_list, string task_id, string box_id, string source)
	{
	}

	public static void send_anniversary_quick_of_td(int chapter, string reward_list)
	{
	}

	public static void send_anniversary_first_pass_td(int chapter, string reward_list)
	{
	}

	public static void send_resource_retrieval(string when, string type, string reward, string remaining_times, string source, int coin_count, int gems_count, int power_count)
	{
	}

	public static void Send_Activity_Puzzle(string puzzle_id, string reward_list, string source, string box_id)
	{
	}

	public static void Send_Activity_Rebate(string task_id)
	{
	}

	public static void Login(Action<LoginData> callback)
	{
	}

	public static void TryLogin(Action<LoginType, LoginData> callback)
	{
	}

	public static string GetLoginType()
	{
		return null;
	}

	public static void send_event_treasure_get(string treasure_id, string normal_id, string secret_wish, string type)
	{
	}

	public static void send_event_lucky_bag(int eventId, int count, int source)
	{
	}

	public static void send_event_treasure_bp(int eventId, int level, ActivityTreasureData.RewardType source)
	{
	}

	public static void sendPVEReport(string get_id, int Data1, string clan_id, int PVESeason, int PVEPartition, int PVETalent, int PVEStage, int soul)
	{
	}

	private static void AddPackDetailData(Dictionary<string, object> dic)
	{
	}

	public static void upgrade_nobility()
	{
	}

	public static void Send_Camp_Sweep(string source, string plot__id, string plot_coordinate, string reward_list, int contribution_count)
	{
	}

	public static void Send_Camp_Battle_Arrow(string source, string plot_id, string plot_coordinate, int iron_arrow, int golden_arrow, int total_damage, int contribution_count)
	{
	}

	public static void Send_Camp_Personal_Upgrade(int after_upgrade, string talent_Location, int currency_A, int currency_B)
	{
	}

	public static void Send_Camp_Team_Upgrade(int crystal_count, int contribution_count)
	{
	}

	public static void Send_Camp_Resource_Gather(int wood, int forage, int iron, int crystal, int gold, int talent_points)
	{
	}

	public static void Send_Obtain_Camp_Rewards(string source, string plot_ID, string plot_coordinate, string box_id, string task_id, string reward_list, int rank_reward = 0, int camp_rank = 0)
	{
	}

	public static void Send_Obtain_Camp_Rewards(string source, string plot_ID, string plot_coordinate, string box_id, string cost_currency, int cost_currencynum)
	{
	}

	public static void Send_Camp_Hero_Dispatch(string plot_ID, string plot_coordinate, string plot_type, string hero_id, int hero_star)
	{
	}

	public static void Send_Camp_Shop_Buy(string item_id, int item_count, int currency_A, int currency_B)
	{
	}

	public static void SendCampKeyBuy(string source, int gems)
	{
	}

	public static void SendCampBPGet(int camp_bp_level, string camp_bp_type)
	{
	}

	public static void SendCampTownLevel(int level_after_upgrade)
	{
	}

	public static void SendCampTownArrow(string source, int count, int count_group)
	{
	}

	public static void SendCampTownAuto(int duration, int talent_points, int iron_arrow)
	{
	}

	public static void SendCampPreActive(string uid, string list)
	{
	}

	public static void SendCampChangeTown(string plot_ID, string plot_coordinate)
	{
	}

	public static void SendCampResourceReplacement(string source, int cost_count, int talent_num, int remaining_times)
	{
	}

	public static void Send_Bc_Change_Skin(string bc_skin_id)
	{
	}

	public static void send_camp_team(string type, string result, string reason, string member_id, string member_source, int teamid, int count)
	{
	}

	public static void send_optional_gemsgift(int gems_count, string gear_id, string gear_list)
	{
	}

	public static void sendEvent_HallCrystalActive(string crystal_color, int round, bool color_reward, int group_id, int monster_1, int monster_2, int monster_3, int monster_4, int monster_5)
	{
	}

	public static void sendEvent_HallReward(int reward_id, string reward_list, int reward_type, int round)
	{
	}

	public static void sendEvent_Coupon(int group_id, int round)
	{
	}

	public static void sendEvent_GetCoupon(int number)
	{
	}

	public static void Send_Task_Crystal(string task_id, int energy_bottle_count, int crystal_voucher_count, string round)
	{
	}

	public static void Send_Crystal_Shop(string shop_id, string shop_list, int monster_egg_fragments, int crystal_coupon, int energy_bottle_count)
	{
	}

	public static void Send_Crystal_Hammer_Get(string source, int hammer_amt, int cost_currency)
	{
	}

	public static void Send_Lucky_Wheel(string activity_id, int gems_count, string type, string source, string reward_list)
	{
	}

	public static void Send_Wheel_Tasks(string activity_id, string task_id, string reward_list)
	{
	}

	public static void send_event_box_chest_rebate(string type, string reward_id, string reward_list, string reward_count)
	{
	}

	public static void send_event_cost_gems_activities(string reward_id, string reward_list, string reward_count)
	{
	}

	public static void send_event_cost_power_activities(string reward_id, string reward_list, string reward_count)
	{
	}

	public static void Send_Christmas2023_Treasure_Trove(string accessories_id)
	{
	}

	public static void Send_Christmas2023_Exchange_Tokens(string accessories_id, int accessories_count, string token_type, int token_count)
	{
	}

	public static void Send_Christmas2023_Redemption_Rewards(string token_type, int token_count, string reward_id, string reward_list)
	{
	}

	public static void Send_Christmas2023_Task(string task_id, string reward_list)
	{
	}

	public static void Send_Manor_territory_upgrade(int after_upgrade)
	{
	}

	public static void Send_Manor_use_material_card(string material_card, int material_card_count, string reward_id, int reward_count)
	{
	}

	public static void Send_Manor_store(int manor_token, string reward_id, string reward_count1)
	{
	}

	public static void sendEvent_Building(int source, string type, int material_1, int material_2, int material_3, int material_1_count, int material_2_count, int material_3_count, int after_upgrade)
	{
	}

	public static void sendEvent_WorkerBox(string source, string reward_id, string type, int gems_count, int keys_count)
	{
	}

	public static void sendEvent_Worker(int worker_id, string type, int worker_fragments_count)
	{
	}

	public static void sendEvent_BuildingRes(int building_id, int duration, int building_level, int building_star, int building_worker, int building_worker_star, string type, string other_account_id, int material_id, int material_count, int remaining_times, int proportion, string reward_list, string op_account_id)
	{
	}

	public static void sendEvent_StealKeyAll(int proportion, string reward_list, string op_account_id)
	{
	}

	public static void sendEvent_ActiveSkill(int skills_id, int building_id, int building_level, int building_star)
	{
	}

	public static void sendEvent_SpringWish(string type, int gold_leaf, string reward_list, int number_of_gifts)
	{
	}

	public static void sendEvent_ExchInfo(int material_1, int material_2, int material_3, int material_1_count, int material_2_count, int material_3_count, int manor_token, int order_id, int remaining_times, string type, string other_account_id)
	{
	}

	public static void Send_Skin_Level_Up(string skin_id, int coin_count, int skin_exquisite, int skin_noble, string source, int clothing_essence)
	{
	}

	public static void Send_Skin_Reset(string skin_id, int coin_count, int skin_exquisite, int skin_noble, int clothing_essence, string source, int gems_count)
	{
	}

	public static void send_exchange_red_packet(int get_count, string group, int cost_1, int cost_2)
	{
	}

	public static void send_cost_red_packet(int cost_count, int type, string group)
	{
	}

	public static void send_get_red_packet(int count, string group, int type, string os_account, int count_b, string reward_list)
	{
	}

	public static void send_exchange_shop_red_packet(string shop_id, int cost_count, string reward_list, string group, int cost_count_b)
	{
	}

	public static void Send_Fishing(int fishing_points, int weight, int scales, string source, string type, int count, string result, int broken_line)
	{
	}

	public static void Send_Get_Bait(string source, int gems_count, string task_id, int broken_line, int bait_count, int get_bait_relics_count)
	{
	}

	public static void Send_Fishing_Shop(string reward_id, string reward_list, int fishing_points, int broken_line, int scales, string source)
	{
	}

	public static void Battle_Cheat(string userid, HTTPSendClient.CheatOnceData data)
	{
	}

	public static void sendEventMiningQuickBuy(int gems_count, string type, int prop_count)
	{
	}

	public static void sendEventMiningShopBuy(int shop_id, int hard_outer_skin, int crushed_ore, string shop_list)
	{
	}

	public static void sendEventMiningTask(int task_id, string task_list, int hard_outer_skin, int crushed_ore)
	{
	}

	public static void sendEventMiningDepthBox(int reward_id, string reward_list, int hard_outer_skin, int crushed_ore)
	{
	}

	public static void send_Event_Dig(string type, string source, int count, string reward, int hard_outer_skin, int crushed_ore, int distance)
	{
	}

	public static void Send_pet_open_box(string relicList, int gems, string source, string type)
	{
	}

	public static void Send_pet_shop(string shop_id, string shop_list, int count, string type, int cost_count)
	{
	}

	public static void sendEvent_PetLevelUp(int pet, int level, int cost_count, int coin_count, int after_level)
	{
	}

	public static void sendEvent_PetStarUp(int pet, int star, int after_star, int cost_count)
	{
	}

	public static void sendEvent_PetSkillUp(int pet, int skill_id, int level, int cost_count, int coin_count, int after_level)
	{
	}

	public static void sendEvent_PetSkillChange(int pet, int skill_id, int new_skill_id)
	{
	}

	public static void sendEvent_ActivityLottery(int type, int stage, string reward_list, int item)
	{
	}

	public static void sendEvent_ActivityLotteryShop(int item, string shop_id, string reward_list)
	{
	}

	public static void sendEvent_ActivityLotteryTicket(string source, int gemscount, int taskid, int ticket)
	{
	}

	public static void sendEvent_ActivityLotteryTask(int task_id, string reward_list, int count)
	{
	}

	public static void sendEvent_HuntingTask(int task_id, string reward_list, int count)
	{
	}

	public static void sendEvent_HuntingShop(int reward_id, string reward_list, int cost1, int cost2, string source)
	{
	}

	public static void sendEvent_HuntingTicket(string source, int gems, int taskid, int ticket)
	{
	}

	public static void Send_treasure_hunt(string layer, string round, string treasure_type, int count, string reward_list, int hammer)
	{
	}

	public static void Send_treausre_hunt_task(string task_id, int hammer, string reward_list)
	{
	}

	public static void Send_treausre_hunt_gems(int gems_count, int hammer)
	{
	}

	public static void Send_gardentreasure_hunt(string layer, string round, string treasure_type, int count, string reward_list, int hammer)
	{
	}

	public static void Send_gardentreasure_hunt_task(string task_id, int hammer, string reward_list)
	{
	}

	public static void Send_gardentreasure_hunt_gems(int gems_count, int hammer)
	{
	}

	public static void Send_Activity_Hiking(int count, string reward_list, int item, int extra_height, int layer, string type)
	{
	}

	public static void Send_Activity_Hiking_box(string box_id, string reward_list)
	{
	}

	public static void Send_Activity_Hiking_task(string task_id, string reward_list, int count)
	{
	}

	public static void Send_Activity_Hiking_shop(int count, int gems)
	{
	}

	public static void send_Activity_Hiking_newshop(int item, string shop_id, string reward_list)
	{
	}

	public static void Send_Activity_Fire(int count, string source, string reward_list = null, int item = 0)
	{
	}

	public static void Send_Activity_Fire_box(string box_id, string box_type, string reward_list)
	{
	}

	public static void send_Activity_Forever_Card_Buy(int diamond)
	{
	}

	public static void send_Activity_Forever_Card_Get(string reward_list, int times)
	{
	}

	public static void sendEvent_crazy_month(string type, string task_id, string reward_list)
	{
	}

	public static void sendEvent_crazy_month_iap(string type, string product_id, string reward_list)
	{
	}

	public static void sendEvent_newchain_gift(string gift_id, string gift_type, string gift_list)
	{
	}

	public static void Send_Activity_5anniversary(string reward_list, int item)
	{
	}

	public static void Send_Activity_5anniversary_shop(string reward_list, int item, string shop_id)
	{
	}

	public static void Send_Activity_5anniversary_Hunting_Start(int Remaining_tickets, string Scene, int Bows, int prey, int Talent)
	{
	}

	public static void Send_Activity_5anniversary_Hunting_End(string Scene, int Bows, int prey, int Talent, string source, string reward_list, int item, int hunting_coins, int genetic_debris, int hunting_porint)
	{
	}

	public static void Send_Activity_5anniversary_Hunting_Sweep(int Remaining_tickets, string Scene, int Talent, string hunting5th_sweep_count, string reward_list, int item, int hunting_coins, int genetic_debris, int hunting_porint, string hunting5th_max_point)
	{
	}

	public static void Send_Activity_5anniversary_Talent_Level_Up(int genetic_debris, string talent_id, int level, int talent_level)
	{
	}

	public static void Send_Activity_5anniversary_Hunting_Remain_One(int animalCrateCount, int animalCreateHighQualityCount, int animalCanCreateRealCountAB, int animalNeedCreatePoolACount, int animalNeedCreatePoolBCount, int animalNeedCreatePoolCCount, int remainAnimalID, int remainAnimalUniqueID, string remainAnimalStatus)
	{
	}

	public static void Send_Game_End_First(string type, int chapter, long hp, long atk, long atk_final)
	{
	}

	public static void Send_imprint_upgrade(string imprint_id, int before_level, string type, int imprint_books, int imprint_oracles, int imprint_divine_stones, int imprint_fragment, int faith_points, int faith_level)
	{
	}

	public static void Send_imprint_illuminate(string imprint_id, int imprint_fragment)
	{
	}

	public static void Send_imprint_box(string source, string reward_list)
	{
	}

	public static void Send_bless_tree(string tree_id, int bless_point, int belss_point_surplus)
	{
	}

	public static void Send_bless_tree_bonus(string tree_id, string reward_list)
	{
	}

	public static void Send_wings_synthesis(string wings_id, int wings_fragment_count, string wings_quality, string source, int gems_count)
	{
	}

	public static void AddWingInfos(Dictionary<string, object> pro)
	{
	}

	public static void send_wings_levelup(int cost_gold, int wings_levelup_cost_item, LocalSave.WingOne wing)
	{
	}

	public static void send_wings_upgrade(int wings_upgrade_cost_item, LocalSave.WingOne wing)
	{
	}

	public static void send_equip_helpwings(LocalSave.WingOne wing)
	{
	}

	public static void Send_welcome_back(string type, string reward_id, string reward_list)
	{
	}

	public static void sendEvent_BagLikeShop(int shoptag, int tokends, string shop_id, string shop_list, int remaining_times)
	{
	}

	public static void sendEvent_BagLikeBox(int shoptag, string source, int tokens, string reward_list)
	{
	}

	public static void Send_plinko_task(string task_id, int count)
	{
	}

	public static void Send_plinko_exchange_shop(string plinko_shoptype, int count, string reward_list, int remaining_times)
	{
	}

	public static void Send_plinko_ball_get(string source, int count)
	{
	}

	public static void sendEvent_PlinkoBox(string box_id, string box_list)
	{
	}

	public static void sendEvent_PlinkoGame(int round, int lollipops, int christmas_stockings, string reward_list, string grand_prize, string pit_id, string nail)
	{
	}

	[Conditional("EnableSendEventError")]
	public static void SendEventError(string log)
	{
	}

	public static void Send_First_Recharge(string step, string id, int rank, List<Drop_DropModel.DropData> drops)
	{
	}

	public static void sendEvent_NewPlay127_Box(int shoptag, string source, int tokens, string reward_list)
	{
	}

	public static void sendEvent_Monopoly_Task(int task_id, int dice_count)
	{
	}

	public static void sendEvent_Monopoly_Shop(int shop_id, int shop_count, int token_a, int token_b)
	{
	}

	public static void sendEvent_Monopoly_Dice(string source, int count)
	{
	}

	public static void sendEvent_monopoly_game(string reward_list, int dice_count, int walking, int token_a, int token_b)
	{
	}

	public static void sendEvent_monopoly_special(string special_type, string reward_list, int dice_count, int walking, int token_a, int token_b, int damage)
	{
	}

	public static void sendEvent_Monopoly_QuickBuy(int count, int gems)
	{
	}

	public static void sendEvent_Monopoly_AchReward(int id, int progress, string rewards)
	{
	}

	public static void send_event_piggy_bank(int gems_count, int gear)
	{
	}

	public static void sendEventMagcian(int reward_id, int reward_count, int gems, bool bBuy, bool bBoom, int sourceId, int chapter, int random_number)
	{
	}

	public static void SendMonsterChangeLevel(string path)
	{
	}

	public static void Send_Sail_Ship_Battle(string team_id, string group_id, string enemy_type, int talent_level, string ship_parts, string sailor, int skin_id, int player_battle_power, int enemy_battle_power, string player_stats, string enemy_stats, string result, string reward_list)
	{
	}

	public static void Send_Sail_PVP(string team_id, string group_id, string arena_grade, int arena_rank, int challenge_player_id, int player_battle_power, int enemy_battle_power, string result)
	{
	}

	public static void Send_Sail_Final_Boss(string team_id, string group_id, string days, string boss_stage, int talent_level, string ship_parts, string sailor, int skin_id, int player_battle_power, long damage_total, long damage_dealt, long boss_hp, string cannon_type, string cost_cannon, int damage_missile)
	{
	}

	public static void sendEvent_DiceBattle_Task(string step, string task_id)
	{
	}

	public static void sendEvent_DiceBattle_Shop(int activity_id, int good_id, string cost_currency, int cost_amt, string reward_item)
	{
	}

	public static void sendEvent_DiceBattle_VS(int boss_health, int health_times, int damage_dealt, int muti_times, int player_dice, int boss_dice, string result, string reward_item)
	{
	}

	public static void Send_Sail_Fleet(string team_id, string group_id, string step, int cost_gems, int fleet_level)
	{
	}

	public static void sendEvent_SailReday(int require_xp, int current_xp, int gems)
	{
	}

	public static void sendEvent_SailPreShow(string step)
	{
	}

	public static void SendEvent_SailEnd()
	{
	}

	public static void sendEvent_SailShop(string source, string cost_currency, int cost_amt, string reward_list)
	{
	}

	public static void sendEvent_SailAchi(string type, int progress_id, int achieve_level, string reward_list)
	{
	}

	public static void sendEvent_SailArenaBox(int days, string reward_list)
	{
	}

	public static void Send_Sail_Roulette(string team_id, string group_id, string step, string refresh_reward, string cost_currency, int cost_amt, int muti_times, bool is_big, string reward_list)
	{
	}

	public static void Send_Sail_Monster(string team_id, string group_id, string step, int select_id)
	{
	}

	public static void Send_Sail_Idle(string team_id, string group_id, string hook_level, int idle_duration, string reward_list)
	{
	}

	public static void SendTreasureMapClaimReward(string team_id, string group_id, int treasure_id, string reward_list)
	{
	}

	public static void SendSailBp(string team_id, string group_id, string bp_id, string bp_type, int bp_level, string reward_list)
	{
	}

	public static void SendSailPackageBattleGameOver(string team_id, string group_id, string source, string difficulty, int result, string reward_list)
	{
	}

	public static void SendSailingPersonalUpgrade(string team_id, string group_id, int talent_id, int talent_level, string cost_currency, int cost_amt)
	{
	}

	public static void Send_Sail_Boat_Upgrade(string team_id, string group_id, string update_parts, int level_after, string cost_currency)
	{
	}

	public static void Send_Boss_Battle(string team_id, string group_id, string cannon_type, string cost_cannon, int damage_dealt)
	{
	}

	public static void Send_Boss_Reward(string team_id, string group_id, string reward_list)
	{
	}

	public static void Send_treasure_draw(string team_id, string group_id, int lucky_point, string cost_currency, int cost_amt, bool is_big, string reward_list)
	{
	}

	public static void Send_boss_progress_reward(string team_id, string group_id, int treasure_id, int days, string reward_list)
	{
	}

	public static void Send_artifact_evaluate_levelup(int box_level, string cost_currency, int cost_amt, string result, string reward_list)
	{
	}

	public static void Send_artifact_evaluate_boxopen(int box_level, string reward_list)
	{
	}

	public static void Send_activity_evaluate_task(int task_id, string reward_list)
	{
	}

	public static void Send_activity_summon_archers_task(int task_id, string reward_list)
	{
	}

	public static void Send_activity_get_hammer(int cost_gems, int get_hammer)
	{
	}

	public static void Send_activity_artifact_exchange(string cost_currency, int cost_amt, string reward_list)
	{
	}

	public static void sendEvent_Act6th_Sign(int day, string reward_list)
	{
	}

	public static void sendEvent_Act6th_Shop(string cost_currency, int cost_amt, string reward_list)
	{
	}

	public static void sendEvent_Act7th_SignIn(int day, string reward_list)
	{
	}

	public static void sendEvent_Act7th_EventExchange(string cost_currency, int cost_amt, string reward_list)
	{
	}

	public static void sendEvent_Artifact_Get(int artifact_id, string artifact_name, int cost_shards)
	{
	}

	public static void sendEvent_Artifact_Upgrade(string source, int artifact_id, string artifact_name, int artifact_progress, int artifact_star, string cost_item_name_1, int cost_item_amt_1, string cost_item_name_2, int cost_item_amt_2, string cost_item_name_3, int cost_item_amt_3)
	{
	}

	public static void send_anniversary_bp(string step, string bp_type, int bp_level, int cost_gems, string reward_list)
	{
	}

	public static void send_activity_minecar(string minecart_type, int count, string reward_list, int height)
	{
	}

	public static void send_minecar_task(int task_id, string reward_list)
	{
	}

	public static void send_minecar_box(int box_id, int depth, string reward_list)
	{
	}

	public static void send_minecar_buy(int cost_gems, string reward_list)
	{
	}

	public static void send_minecar_exchange(string cost_currency, int cost_amt, string reward_list)
	{
	}

	public static void UpgradeArtifactTalent(string talent_level, string cost_currency, int cost_amt, string talent_name, string talent_small_level)
	{
	}

	public static void ClaimArtifactBox(uint box_id, uint depth, string reward_list)
	{
	}

	public static void sendEvent_Artifact_Battle_Start(string talentLevel, int difficulty, int cost_stamina, string cost_currency)
	{
	}

	public static void sendEvent_Artifact_Battle_End(string talentLevel, int difficulty, int wave_id, string result, string skill_list, string reward_list, bool is_fast_clear)
	{
	}

	public static void sendEvent_Daily128_Battle_Start(int season_id, int max_difficulty, int difficulty, int cost_stamina, string cost_currency)
	{
	}

	public static void sendEvent_Daily128_Battle_End(int season_id, int max_difficulty, int difficulty, int wave_id, string result, string skill_list, string reward_list, bool is_fast_clear, int get_point, int total_point)
	{
	}

	public static void send_trade_shop_buy(int cost_amt, string buy_goods_id, int buy_amt, int buy_price, int total_trade_currency, int total_trade_profit)
	{
	}

	public static void send_trade_shop_sell(int get_amt, string sell_goods_id, int sell_amt, int sell_price, int total_trade_currency, int total_trade_profit)
	{
	}

	public static void send_event_rank(string source, int player_rank, int rank_point)
	{
	}

	public static void send_event_exchange(string source, string cost_currency, int cost_amt, string reward_list)
	{
	}

	public static void send_trade_progress_reward(int total_trade_currency, int max_trade_currency, int total_trade_profit, int trade_currency, string reward_list)
	{
	}

	public static void send_trade_quickbuy(int cost, int amt)
	{
	}

	public static void send_webstore(string is_webstore)
	{
	}

	public static void send_webstore2(string pop_window, string event_pack_ui, string stop_stellarite_ui)
	{
	}

	public static void Send_holy_light_contribute(int total_holy_point, int current_holy_level, int total_holy_times, string ult_prize, int is_grand_prize, string reward_list, string cost_currency, int cost_amt, int is_guaranteed)
	{
	}

	public static void Send_holy_task(int task_id, string reward_list)
	{
	}

	public static void Send_holy_server_reward(int task_id, string reward_list)
	{
	}

	public static void Send_holy_personal_reward(int task_id, string reward_list)
	{
	}

	public static void Send_totem_equip(int equip_type, string equip_totem_type, int equip_totem_id, int equip_totem_level, string equip_totem_quality, int equip_totem_refine_level, string equip_totem_mainAttrType, string equip_totem_subAttr, string equip_totem_AttrLock, string current_totem)
	{
	}

	public static void Send_totem_fuse(string totem_cid, string totem_level, string totem_fused, string reward_list)
	{
	}

	public static void Send_totem_upgrade(int totem_id, string totem_quality, bool can_refined, int level_after, string equip_totem_mainAttrType, string equip_totem_subAttr, string equip_totem_AttrLock, string cost_currency)
	{
	}

	public static void Send_totem_refine(int totem_id, string totem_quality, string totem_type, int level_after, int sub_attr_lock_num, string sub_attr_lock, string totem_mainAttrType, string totem_mainAttrValue, string sub_attr_before, string sub_attr_after, string cost_currency, string refine_result)
	{
	}

	public static void Send_totem_lock(int lock_type, string totem_id, string totem_rowId)
	{
	}

	public static void Send_christmas_build(int cost_amt, string tower_level, int current_slot, string slot_list, int group)
	{
	}

	public static void Send_christmas_build_reward(string source, string reward_list, int group)
	{
	}

	public static void Send_christmas_build_hook_buy(int cost_gems, int get_hook)
	{
	}

	public static void Send_christmas_build_task(int task_id, string reward_list)
	{
	}

	public static void Send_christmas_build_schedule(int require_point, int tresure_id, string reward_list)
	{
	}

	public static void Send_fortess_battle_start(int difficulty, string hero_list)
	{
	}

	public static void Send_fortess_battle_end(int difficulty, int wave, int point_get, int point_cost, int summon_slot_amt, int duration, int monster_kill, int reward_point, int hp_left, string result, string tower_list, string hero_list, string buff_list, string reward_list)
	{
	}

	public static void sendEvent_Daily129_BoxGet(int require_point, string reward_list)
	{
	}

	public static void sendEvent_Daily129_Totem(string totem, string mats)
	{
	}

	public static void sendEvent_statue_worship(string source, string other_worship_id, int other_worship_vip, string worship_id, int worship_vip, string reward_list)
	{
	}

	public static void sendEvent_other_statue_worship(string source, string worship_id, int worship_vip, string other_worship_id, int other_worship_vip, string other_reward_list)
	{
	}

	public static void Send_sweapon_skin_boxopen(string cost_currency, int cost_amt, string pool_type, int reward_place, int pool_turn, string reward_list)
	{
	}

	public static void sendEventEquipCast(string equips, int count, int targetid, string haves)
	{
	}

	public static void sendss_equipment_chroma(string cost_chroma_stone, int cost_chroma_stone_amt, int original_equip_id, int chroma_skin_id)
	{
	}

	public static void sendweapon_book_level(int book_level_after, string reward_list)
	{
	}

	public static void sendweapon_skin_reward(int skin_id, string reward_list)
	{
	}

	public static void sendhero_skin_book_level(int level_after, string reward_list)
	{
	}

	public static void sendhero_skin_reward(int skin_id, string reward_list)
	{
	}

	public static void Send_surprise_pack_get(string pack_id, string pack_type, string cost_currency, int cost_amt, int voucher_remaining, string pack_reward_list, int support_num)
	{
	}

	public static void Send_surprise_voucher_get(string source, int voucher_amt, int cost_currency)
	{
	}

	public static void Send_surprise_task(int task_id, string reward_list)
	{
	}

	public static void sendweapon_weapon_skin_level(int weapon_id, int skin_id, int weapon_skin_level_current, string cost_currency)
	{
	}

	public static void send_valentines_shop(int activity_id, string reward_list, bool is_big, int reward_current = 0)
	{
	}

	public static void send_activity_quick_sweep(int source, string activity_info, string reward_list)
	{
	}

	public static void send_event_push_pillar_choice(int round, string row1Rewards, string row2Rewards, string rowElseRewards)
	{
	}

	public static void send_event_push_pillar_achievement(int achievementId, int requireAmt, string rewardList)
	{
	}

	public static void send_event_push_pillar_task(int taskId, string rewardList)
	{
	}

	public static void send_event_push_pillar_buy(int costGems, int todayBuyCount, int rewardAmt)
	{
	}

	public static void send_event_push_pillar_push(int round, int pushCount, int costAmt, int colCount, int colBottomed, string pushRewardList)
	{
	}

	public static void send_event_push_pillar_refresh(int round, int colBottomed, int pushCount, string row1RewardsLeft, string row2RewardsLeft)
	{
	}

	public static void send_event_get_ticket(int cost_gems, int today_buy_count, int reward_amt)
	{
	}

	public static void sendEvent_Act7thBP(string step, string bp_type, int bp_level, int cost_gems, string reward_list)
	{
	}

	public static void sendEvent_Act7thTimeMachine(string reward_list)
	{
	}

	public static void sendEvent_BadgeBagGet(string source, int box_id, string task_id_list, string reward_list)
	{
	}

	public static void sendEvent_BadgeBagOpen(string pack_id, int group_id, int set_id, string reward_list)
	{
	}

	public static void sendEvent_BadgeCardActive(int card_id, int group_id, int set_id, int card_quality, string reward_list)
	{
	}

	public static void sendEvent_BadgeCollect(string reward_type, int group_id, int set_id, string reward_list)
	{
	}

	public static void Bugly_Init()
	{
	}

	public static void Bugly_SetUserID(string userid)
	{
	}

	public static void Bugly_Report(Exception e, string message)
	{
	}

	public static void Bugly_Report(bool excute, string name, string message)
	{
	}

	public static void Bugly_Report(string name, string message, string stackTrace)
	{
	}

	public static void Bugly_LogError(string name, string message)
	{
	}

	public static void Bugly_Report(string name, string message)
	{
	}

	public static void Bugly_EquipError(EquipErrorType type)
	{
	}

	public static void ReportCheatOnce(CheatOnceType type, string info)
	{
	}

	private static void Facebook_Init()
	{
	}

	private static void InitCallback()
	{
	}

	private static void DeepLinkCallback(IAppLinkResult result)
	{
	}

	public static bool Facebook_IfLogin()
	{
		return false;
	}

	public static bool Facebook_ShouldShowShare()
	{
		return false;
	}

	public static void Facebook_Login_New(Action<LoginData> onLogin)
	{
	}

	public static void Facebook_Login(Action<bool> onLogin)
	{
	}

	public static void Facebook_Logout()
	{
	}

	[IteratorStateMachine(typeof(_003CFacebook_Share_003Ed__528))]
	public static IEnumerator Facebook_Share(GameObject UI, Action<bool> onShare)
	{
		return null;
	}

	private static void CaptureScreenShot(string imagePath)
	{
	}

	public static void Facebook_GetAwardByChapter(int chapterId, Action<bool, CRespFBShare> onResponse)
	{
	}

	public static void Facebook_GetAwardBySuperEquip(uint transId, Action<bool, CRespFBShare> onResponse)
	{
	}

	public static void Facebook_GetAwardByBoxTen(uint transId, Action<bool, CRespFBShare> onResponse)
	{
	}

	public static void Init_FB()
	{
	}

	private static void InitCloudGameCallback(IInitCloudGameResult result)
	{
	}

	private static void OnReadyCallback(IIAPReadyResult result)
	{
	}

	private void Buy(Product product)
	{
	}

	private static void Consume()
	{
	}

	public static void login_check()
	{
	}

	public static void login_check_start()
	{
	}

	public static void GameCenter_Login(Action<LoginData> callback)
	{
	}

	private static void GameCenter_TryLogin(Action<LoginType, LoginData> callback)
	{
	}

	public static void GameCenter_add_login_count()
	{
	}

	public static int GameCenter_get_login_count()
	{
		return 0;
	}

	public static void GameCenter_clear_login_count()
	{
	}

	public static void Google_Login(Action<LoginData> callback)
	{
	}

	public static void Google_TryLogin(Action<LoginType, LoginData> callback)
	{
	}

	[Conditional("EnablePoco")]
	public static void Poco_Init()
	{
	}

	private static void ShuShu_Init()
	{
	}

	public static void ShuShu_Login(string name)
	{
	}
}
