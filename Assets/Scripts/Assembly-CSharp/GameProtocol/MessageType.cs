namespace GameProtocol
{
	public sealed class MessageType
	{
		public const byte MSG_HEADER_TAG = 13;

		public const ushort MSG_REQ_BATTLE_RESULT_REQUEST = 1;

		public const ushort MSG_GAME_SETTLEMENT_RESPONSE = 2;

		public const ushort MSG_REQ_MAIL_LIST = 4;

		public const ushort MSG_RESP_MAIL_LIST = 5;

		public const ushort MSG_RESP_RETURN_MESSAGE = 6;

		public const ushort MSG_REQ_ITEM_PACKET = 7;

		public const ushort MSG_REQ_USER_LOGIN = 8;

		public const ushort MSG_REQ_ITEM_UPGRADE = 9;

		public const ushort MSG_REQ_DIAMOND_TO_COIN = 10;

		public const ushort MSG_REQ_EQUIP_TRANS = 11;

		public const ushort MSG_REQ_TRUNCATE_USER = 12;

		public const ushort MSG_REQ_LIFE_TRANS = 13;

		public const ushort MSG_REQ_OBTAIN_TREASURE = 14;

		public const ushort MSG_REQ_APP_IN_PURCHASE = 15;

		public const ushort MSG_QUERY_IN_APP_PURCHASE = 16;

		public const ushort MSG_QUERY_LAYER_IAP_INFO = 17;

		public const ushort MSG_REQ_EQUIP_COMPOSITE_TRANS = 18;

		public const ushort MSG_SYNC_GAME_SYSTEM_MASK = 19;

		public const ushort MSG_IAP_DISCOUNT = 20;

		public const ushort MSG_ONE_STORE_FIRST_REWARD = 21;

		public const ushort MSG_SYNC_TIME_RESTORE_ITEMS = 22;

		public const ushort MSG_QUERY_FIRST_IAP_REWARD = 23;

		public const ushort MSG_OBTAIN_BATLLE_PASS_REWARD = 24;

		public const ushort MSG_DAILY_IAP_REWARD = 25;

		public const ushort MSG_DAILY_PLAY = 26;

		public const ushort MSG_REQ_HERO_UPGRADE = 27;

		public const ushort MSG_REQ_EQUIP_DECOMPOSE = 28;

		public const ushort MSG_REQ_OLD_USERS_BACK = 29;

		public const ushort MSG_REQ_RUNE_COMPOSE = 30;

		public const ushort MSG_IAP_PUSH = 31;

		public const ushort MSG_REQ_SHOP_BOX_ACTIVITY = 32;

		public const ushort MSG_REQ_ACTIVATION_CODE = 33;

		public const ushort MSG_QUERY_IAP_COUNT = 34;

		public const ushort MSG_QUERY_IAP_DOUBLE = 35;

		public const ushort MSG_LOGIN_GIFT_REWARD = 36;

		public const ushort MSG_GAME_ACHIEVE = 37;

		public const ushort MSG_WEEK_IAP_REWARD = 38;

		public const ushort MSG_DAILY_TASK = 39;

		public const ushort MSG_OPEN_BOX_GEM = 40;

		public const ushort MSG_ACTIVITY_DROP_RATE = 41;

		public const ushort MSG_ACTIVITY_YEAR_AWARD = 42;

		public const ushort MSG_REQ_ACTIVITY_EXCHANGE = 43;

		public const ushort MSG_REQ_RUNE_POLISH = 44;

		public const ushort MSG_REQ_GAME_TOWER = 45;

		public const ushort MSG_REQ_FB_SHARE = 46;

		public const ushort MSG_REQ_BIND_MAIL = 47;

		public const ushort MSG_REQ_OPEN_IDFA = 48;

		public const ushort MSG_REQ_DAILY_PLAY_EXCHANGE = 49;

		public const ushort MSG_REQ_WEEKLY_GIFT = 50;

		public const ushort MSG_REQ_EQUIP_BATCH_DECOMPOSE = 51;

		public const ushort MSG_REQ_EQUIP_EXCHANGE = 52;

		public const ushort MSG_REQ_SUPER_ROULETTE = 53;

		public const ushort MSG_REQ_MONSTER_HATCH = 54;

		public const ushort MSG_REQ_HERO_SKIN = 56;

		public const ushort MSG_REQ_BUY_ITEM = 57;

		public const ushort MSG_REQ_EQUIP_WISH = 58;

		public const ushort MSG_REQ_USER_UPDATE_INFO = 59;

		public const ushort MSG_REQ_PVP = 60;

		public const ushort MSG_REQ_CHECK_PVP_JOIN = 61;

		public const ushort MSG_REQ_USER_GET_INFO = 62;

		public const ushort MSG_REQ_FARM = 63;

		public const ushort MSG_REQ_SWEEP = 64;

		public const ushort MSG_REQ_MYSTIC_SHOP = 66;

		public const ushort MSG_REQ_ACTIVITY_INVEST = 67;

		public const ushort MSG_REQ_FETCH_BP_CONF = 68;

		public const ushort MSG_REQ_PVP_EXCHANGE = 69;

		public const ushort MSG_REQ_QUERY_ITEMS = 70;

		public const ushort MSG_EQUIP_BATCH_COMPOSITE = 71;

		public const ushort MSG_GEM_COMPOSITE = 72;

		public const ushort MSG_MONTH_CARD = 73;

		public const ushort MSG_GAMBLING_SHOP = 74;

		public const ushort MSG_USER_BACK = 75;

		public const ushort MSG_FARM_PLAY = 77;

		public const ushort MSG_GUILD_TASK = 78;

		public const ushort MSG_DAILY_IAP_GIFT = 79;

		public const ushort MSG_GUILD_USER_LOGIN = 80;

		public const ushort MSG_GEM_BATCH_COMPOSITE = 81;

		public const ushort MSG_ACTIVITY_CHRISTMAS = 82;

		public const ushort MSG_REQ_FARM_PVP_INFO = 83;

		public const ushort MSG_REQ_FARM_PVP_BATTLE = 84;

		public const ushort MSG_REQ_FARM_PVP_REWARD = 85;

		public const ushort MSG_REQ_EQUIP_ALTAR_UPGRADE = 86;

		public const ushort MSG_REQ_ACTIVITY_COMMON = 87;

		public const ushort MSG_REQ_QUERY_GUILD_REDPACKET = 88;

		public const ushort MSG_REQ_GAME_GUIDE = 89;

		public const ushort MSG_REQ_WEEEKLY_TASK = 90;

		public const ushort MSG_REQ_DELETE_ACCOUNT = 91;

		public const ushort MSG_REQ_GAME_HARVEST = 92;

		public const ushort MSG_REQ_EQUIP_WEAR = 93;

		public const ushort MSG_REQ_QUERY_OTHER_USER = 94;

		public const ushort MSG_REQ_OPEN_MIX_BOX = 95;

		public const ushort MSG_REQ_PVE_SEASON_INFO = 96;

		public const ushort MSG_REQ_PVE_SEASON_BATTLE = 97;

		public const ushort MSG_REQ_PVE_SEASON_TALENT = 99;

		public const ushort MSG_REQ_PVE_SEASON_HARVEST = 100;

		public const ushort MSG_REQ_PVE_SEASON_ACHIEVE = 101;

		public const ushort MSG_REQ_PVE_SEASON_STORE = 102;

		public const ushort MGS_REQ_PVE_SEASON_BATTLEPASS = 103;

		public const ushort MSG_REQ_PVE_SEASON_RANK = 104;

		public const ushort MSG_REQ_OPEN_DRAGON_BOX = 105;

		public const ushort MSG_REQ_DRAGON_UPGRADE = 106;

		public const ushort MSG_REQ_DRAGON_COMPOSE = 107;

		public const ushort MSG_REQ_DRAGON_DECOMPOSE = 108;

		public const ushort MSG_REQ_DRAGON_WEAR = 109;

		public const ushort MSG_REQ_EQUIP_UPGRADE = 110;

		public const ushort MSG_REQ_COMMON_TURN = 111;

		public const ushort MSG_REQ_HERO_FRAGMENT_EXCHANGE = 112;

		public const ushort MSG_REQ_ACTIVITY_PAYMENT = 113;

		public const ushort MSG_REQ_EQUIP_REFINE = 114;

		public const ushort MSG_REQ_ACTIVITY_EMPLOY = 115;

		public const ushort MSG_REQ_VIP = 116;

		public const ushort MSG_REQ_WORLD_CUP = 117;

		public const ushort MSG_Month_IAP_REWARD = 118;

		public const ushort MSG_REQ_ACTIVITY_PRIVILEGE = 119;

		public const ushort MSG_REQ_EQUIP_RESET = 120;

		public const ushort MSG_REQ_PVE_SEASON_ACTIVITY = 121;

		public const ushort MSG_REQ_GAME_RELICS = 122;

		public const ushort MSG_REQ_OPEN_RELICS_BOX = 123;

		public const ushort MSG_REQ_WATCH_AD = 124;

		public const ushort MSG_REQ_ACTIVITY_SHIP = 125;

		public const ushort MSG_REQ_MEDAL = 126;

		public const ushort MSG_REQ_ACTIVITY_TREASURE = 127;

		public const ushort MSG_REQ_ACTIVITY_WISH = 128;

		public const ushort MSG_REQ_WEAPON_SKIN = 129;

		public const ushort MSG_REQ_EQUIP_QA_RESET = 130;

		public const ushort MSG_REQ_ACTIVITY_GROWTH = 131;

		public const ushort MSG_REQ_GAME_AD = 132;

		public const ushort MSG_REQ_ACTIVITY_LATTICE = 133;

		public const ushort MSG_REQ_ACTIVITY_SEVENDAYS = 134;

		public const ushort MSG_REQ_PLAY_TOWER = 135;

		public const ushort MSG_REQ_ACTIVITY_LOGIN_PACKAGE = 136;

		public const ushort MSG_REQ_ACTIVITY_BINGO = 137;

		public const ushort MSG_REQ_USE_CHOICE_ITEM = 138;

		public const ushort MSG_REQ_ACTIVITY_CHAIN_GIFT = 139;

		public const ushort MSG_REQ_ACTIVITY_ANNIVERSARY = 140;

		public const ushort MSG_REQ_ACTIVITY_BACK_REWARD = 141;

		public const ushort MSG_REQ_OPEN_EQUIP_S_BOX = 142;

		public const ushort MSG_REQ_TOWER_DEFENCE_BATTLE = 143;

		public const ushort MSG_REQ_RESOURCE_FIND_BACK = 144;

		public const ushort MSG_REQ_GAME_HARVEST_2 = 145;

		public const ushort MSG_REQ_ACTIVITY_PUZZLE = 146;

		public const ushort MSG_REQ_CAMP_MAP = 147;

		public const ushort MSG_REQ_CAMP_BLOCK = 148;

		public const ushort MSG_REQ_CAMP_SEAON_INFO = 149;

		public const ushort MSG_REQ_CAMP_BP_CONF = 150;

		public const ushort MSG_REQ_CAMP_PRE_REWARD = 151;

		public const ushort MSG_REQ_CAMP_ACHIEVE = 152;

		public const ushort MSG_REQ_CAMP_TALENT = 153;

		public const ushort MSG_REQ_CAMP_STORE = 154;

		public const ushort MSG_REQ_CAMP_HOME = 155;

		public const ushort MSG_REQ_CAMP_PEERAGE = 156;

		public const ushort MSG_REQ_CAMP_RANK = 157;

		public const ushort MSG_REQ_CAMP_GIFT = 158;

		public const ushort MSG_REQ_CAMP_BASE_BLOCK = 159;

		public const ushort MSG_REQ_CAMP_BATTLE = 161;

		public const ushort MSG_REQ_ACTIVITY_REBATE = 162;

		public const ushort MSG_REQ_ACTIVITY_OPEN_BOX = 163;

		public const ushort MSG_REQ_ACTIVITY_MAGIC_CRYSTAL = 164;

		public const ushort MSG_REQ_ACTIVITY_CHARGE_REWARD = 165;

		public const ushort MSG_REQ_ACTIVITY_CHARGE_ONCE = 166;

		public const ushort MSG_REQ_ACTIVITY_DAILY_TOTAL_CHARGE = 167;

		public const ushort MSG_REQ_ACTIVITY_LUCKY_WHEEL = 168;

		public const ushort MSG_REQ_ACTIVITY_DIAMOND_CHOICE = 169;

		public const ushort MSG_REQ_CAMP_MAP_SUMMARY = 170;

		public const ushort MSG_REQ_ACTIVITY_COST_LIFE = 171;

		public const ushort MSG_REQ_ACTIVITY_COST_DIAMOND = 172;

		public const ushort MSG_PRIVILEGE_CARD = 173;

		public const ushort MSG_DAILY_PLAY_SWEEP = 174;

		public const ushort MSG_MANOR_INFO = 175;

		public const ushort MSG_MANOR_WORKER = 176;

		public const ushort MSG_MANOR_BUILDING = 177;

		public const ushort MSG_OPEN_WORKER_BOX = 178;

		public const ushort MSG_MANOR_STORE = 179;

		public const ushort MSG_CHRISTMAS_2023 = 180;

		public const ushort MSG_VIEW_ROLE = 181;

		public const ushort MSG_REQ_ACTIVITY_SEVEN_DAYS_APPEND = 182;

		public const ushort MSG_GAME_FISHING = 183;

		public const ushort MSG_ACTIVITY_CONTINUE_GIFT = 186;

		public const ushort MSG_REQ_RED_PACKET_INFO = 190;

		public const ushort MSG_REQ_RED_PACKET_RANK = 191;

		public const ushort MSG_REQ_RED_PACKET_STORE = 192;

		public const ushort MSG_REQ_RED_PACKET_DETAIL = 193;

		public const ushort MSG_ACTIVITY_PIRATE_TREASURE = 194;

		public const ushort MSG_ACTIVITY_MINING = 195;

		public const ushort MSG_GAME_PET = 196;

		public const ushort MSG_OPEN_PET_BOX = 197;

		public const ushort MSG_PET_EXCHANGE = 198;

		public const ushort MSG_REQ_BINDING_HABBYID = 199;

		public const ushort MSG_ACTIVITY_CIRCLE_TREASURE = 200;

		public const ushort MSG_REQ_ACTIVITY_CHAIN_GIFT_NEW = 201;

		public const ushort MSG_REQ_ACTIVITY_FIFTH_ANNIVERSARY = 202;

		public const ushort MSG_ACTIVITY_SCRATCH_LOTTERY = 203;

		public const ushort MSG_ACTIVITY_GARDEN_TREASURE = 204;

		public const ushort MSG_ACTIVITY_HUNTING = 205;

		public const ushort MSG_ACTIVITY_HIKING = 206;

		public const ushort MSG_REQ_CAMP_HOLY_RANK = 207;

		public const ushort MSG_REQ_CAMP_BOSS_CROWN = 208;

		public const ushort MSG_REQ_ACTIVITY_NOVICE_RANKING = 209;

		public const ushort MSG_REQ_BAG_CHALLENGE = 210;

		public const ushort MSG_REQ_EQUIP_IMPRINT = 211;

		public const ushort MSG_OPEN_IMPRINT_BOX = 212;

		public const ushort MSG_REQ_ACTIVITY_CRAZY_MONTH = 213;

		public const ushort MSG_REQ_ACTIVITY_LUCKY_PLINKO = 215;

		public const ushort MSG_REQ_WEAPON_ADVENTURE_NEW = 216;

		public const ushort MGS_TREASURE_SHOP = 217;

		public const ushort MGS_REQ_ACTIVITY_PIGGY_BANK = 218;

		public const ushort MSG_REQ_CAMP_LIKE = 219;

		public const ushort MSG_REQ_GAME_CLIENT_DATA = 220;

		public const ushort MSG_REQ_DAILY_PLAY_STAGE130 = 221;

		public const ushort MSG_REQ_WING = 227;

		public const ushort MSG_REQ_FIRST_CHARGE = 228;

		public const ushort MSG_ACTIVITY_MONOPOLY = 229;

		public const ushort MSG_ACTIVITY_DICEBATTLE = 230;

		public const ushort MSG_REQ_SHIP_BATTLE_FIRE = 238;

		public const ushort MSG_REQ_SHIP_BATTLE_SEASON_ARENA = 242;

		public const ushort MSG_CHARGE = 214;

		public const ushort MSG_REQ_SHIP_BATTLE_MAP = 230;

		public const ushort MSG_REQ_SHIP_BATTLE_FIGHT = 231;

		public const ushort MSG_REQ_SHIP_BATTLE_SEAON_INFO = 232;

		public const ushort MSG_REQ_SHIP_BATTLE_BATTLE_PASS = 233;

		public const ushort MSG_REQ_SHIP_BATTLE_PRE_REWARD = 234;

		public const ushort MSG_REQ_SHIP_BATTLE_ACHIEVE = 235;

		public const ushort MSG_REQ_SHIP_BATTLE_TALENT = 236;

		public const ushort MSG_REQ_SHIP_BATTLE_STORE = 237;

		public const ushort MSG_REQ_SHIP_BATTLE_HOME = 238;

		public const ushort MSG_REQ_SHIP_BATTLE_SEASON_MILITARY = 239;

		public const ushort MSG_REQ_SHIP_BATTLE_RANK = 240;

		public const ushort MSG_REQ_SHIP_BATTLE_GIFT = 241;

		public const ushort MSG_REQ_SHIP_BATTLE_BASE_BLOCK = 242;

		public const ushort MSG_REQ_SHIP_BATTLE_BATTLE = 243;

		public const ushort MSG_REQ_SHIP_BATTLE_MAP_SUMMARY = 244;

		public const ushort MSG_REQ_SHIP_BATTLE_HOLY_RANK = 245;

		public const ushort MSG_REQ_SHIP_BATTLE_BOSS_CROWN = 246;

		public const ushort MSG_REQ_SHIP_BATTLE_LIKE = 247;

		public const ushort MSG_REQ_SHIP_BATTLE_SHIP_INFO = 248;

		public const ushort MSG_REQ_SHIP_BATTLE_TREASURE_MAP = 249;

		public const ushort MSG_REQ_SHIP_BATTLE_EVENT = 250;

		public const ushort MSG_REQ_SHIP_BATTLE_WHEEL = 251;

		public const ushort MSG_REQ_SHIP_BATTLE_HARVEST = 253;

		public const ushort MSG_REQ_SHIP_BATTLE_MONSTER_ISLAND = 254;

		public const ushort MSG_REQ_SHIP_BATTLE_GHOST_SHIP = 255;

		public const ushort MSG_REQ_SHIP_BATTLE_PLAYER_INFO = 256;

		public const ushort MSG_REQ_SHIP_BATTLE_DEEP_SEA_BIG_BEAST = 257;

		public const ushort MSG_REQ_EQUIP_ARTIFACT = 258;

		public const ushort MSG_REQ_ACTIVITY_ARTIFACT_TRAIL = 259;

		public const ushort MSG_REQ_ACTIVITY_SIXTH_ANNIVERSARY = 260;

		public const ushort MSG_ACTIVITY_MineCar = 261;

		public const ushort MSG_REQ_ACTIVITY_ARTIFACT_IDENTIFY_ANNIVERSARY = 263;

		public const ushort MSG_REQ_PVE_SEASON_GIFT = 264;

		public const ushort MSG_REQ_ACTIVITY_TRADING_POST = 265;

		public const ushort MSG_ACTIVITY_SUMMON_ARCHERS = 266;

		public const ushort MSG_REQ_EQUIP_TOTEM = 267;

		public const ushort MSG_REQ_ACTIVITY_ANGEL_PURIFY = 268;

		public const ushort MSG_REQ_ACTIVITY_GIFT_TOWER = 269;

		public const ushort MSG_REQ_WORSHIP = 270;

		public const ushort MSG_REQ_ACTIVITY_FROZEN_FORTRESS = 271;

		public const ushort MSG_REQ_ACTIVITY_LAMP_WISH = 272;

		public const ushort MSG_EQUIP_SS_COMPOSITE = 273;

		public const ushort MSG_REQ_ACTIVITY_HELP_GIFT_BOX = 274;

		public const ushort MSG_REQ_ACTIVITY_VALENTINE_DAY = 275;

		public const ushort MSG_REQ_ACTIVITY_PUSH_PILLAR = 277;

		public const ushort MSG_REQ_ACTIVITY_7TH_ANNIVERSARY = 278;

		public const ushort MSG_REQ_CAMP_SEASON_TEAM = 276;

		public const ushort MSG_GAME_BADGE = 279;

		public const ushort MSG_ACTIVITY_BADGE = 280;

		public const ushort MSG_REQ_ACTIVITY_DAILY_PLAY_STAGE130 = 281;

		public const ushort MSG_REQ_ACTIVITY_ANNIVERSARY_CARD = 282;

		public const ushort MSG_BATTLE_CREATE_ROOM = 10000;

		public const ushort MSG_BATTLE_JOIN_ROOM = 10001;
	}
}
