using System.IO;

namespace GameProtocol
{
	public sealed class CCommonRespMsg : IProtocol
	{
		public class ReadOptions
		{
			public bool ignoreGoldUpdate;

			public bool ignoreGemUpdate;
		}

		public const ushort MsgType = 6;

		public const short MSG_RESPONSE_OK = 0;

		public const short MSG_RESP_DATA_EXIST = 1;

		public const short MSG_SELECT_DATA_FAILED = 2;

		public const short MSG_EXPIRED_LOGIN_INFO = 5;

		public const short MSG_USER_LOGIN_FAILED = 6;

		public const short MSG_ARG_INVALID = 7;

		public const short MSG_NOT_ENOUGH_CURRENCY = 8;

		public const short MSG_NOT_ENOUGH_EXP_UPGRADE = 9;

		public const short MSG_NOT_ENOUGH_MATERIAL = 10;

		public const short MSG_NOT_ENOUGH_LIFE = 11;

		public const short MSG_CLIENT_JSON_FORMAT_FAILED = 12;

		public const short MSG_IAP_VERIFY_SERVER_UNAVAILABLE = 13;

		public const short MSG_IAP_VERIFY_PRODUCT_ID_INVALID = 14;

		public const short MSG_IAP_VERIFY_FAILED = 15;

		public const short MSG_APP_VERSION_TOO_LOW = 16;

		public const short MSG_CHEAT_NOTICE = 17;

		public const short MSG_SERVER_MAINTAIN = 18;

		public const short MSG_OPERATE_DATA_EXIST = 19;

		public const short MSG_CHEAT_ONCE_NOTICE = 20;

		public const short MSG_NOT_ENOUGH_COUNT = 21;

		public const short MSG_REACH_LEVEL_LIMIT = 22;

		public const short MSG_EQUIP_NUM_NOT_ENOUGH = 23;

		public const short MSG_SIGNINREWARD_RECEIVED = 24;

		public const short MSG_SIGNINREWARD_NOTARRIVED = 25;

		public const short MSG_ACTIVE_NOT_OPENED = 26;

		public const short MSG_CHAPTER_NOT_DONE = 27;

		public const short MSG_STEP_NOT_ENOUGH = 28;

		public const short MSG_HATCH_NOT_ENOUGH = 29;

		public const short MSG_USER_NICK_NAME_LEN_RULES_ERROR = 30;

		public const short MSG_USER_NICK_NAME_REPEAT = 31;

		public const short MSG_USER_NICK_NAME_RULES_ERROR = 32;

		public const short MSG_PVP_NO_RANK = 33;

		public const short MSG_FARM_EVENT_NOT_FOUND = 34;

		public const short MSG_SWEEP_NOT_FIN_CHAPTER = 35;

		public const short MSG_MYSTIC_NOT_SHOW = 36;

		public const short MSG_MYSTIC_NOT_EXIST = 37;

		public const short MSG_PUSH_COND_NOT_MEET = 38;

		public const short MSG_MEADOW_COULD_NOT_FOUND_USER = 39;

		public const short MSG_MEADOW_NO_DEF_FORMATION = 40;

		public const short MSG_USER_HIDE_CARD = 41;

		public const short MSG_SOUL_POINT_NOT_ENOUGH = 42;

		public const short MSG_PVE_LIFE_NOT_ENOUGH = 43;

		public const short MSG_PVE_SEASON_NOT_OPEN = 44;

		public const short MSG_PVE_SEASON_BAN = 45;

		public const short MSG_FRAGMENT_CANNOT_EXCHANGE = 46;

		public const short MSG_FRAGMENT_CANNOT_USE = 47;

		public const short MSG_EMPLOY_POS_UNLOCKED = 48;

		public const short MSG_WORLD_CUP_BET_NOT_OPEN = 49;

		public const short MSG_RELICS_COMPOSE_EXIST = 50;

		public const short MSG_OFFLINE_BATTLE_LIMIT = 51;

		public const short MSG_CAMP_SEASON_NOT_REGISTERD = 52;

		public const short MSG_CAMP_SEASON_PRE_NO_ZONE = 53;

		public const short MSG_CAMP_SEASON_REGISTER_FAILED = 54;

		public const short MSG_CAMP_SEASON_NOT_CAMP_BLOCK = 55;

		public const short MSG_CAMP_SEASON_RESOURCE_LIMIT = 56;

		public const short MSG_CAMP_SEASON_BLOCK_NOT_OPEN = 57;

		public const short MSG_PRIVILEGELY_CARD_EXPIRED = 58;

		public const short MSG_MANOR_BUILDING_NOT_FOUND = 59;

		public const short MSG_MANOR_NOT_OPEN = 60;

		public const short MSG_MANOR_VERSION_INVALID = 61;

		public const short MSG_ACTIVE_DATA_OUT_OF_SYNC = 64;

		public const short MSG_SAILING_EVENT_EMPTY = 88;

		public const short MSG_SAILING_EVENT_STAGE_END = 98;

		public const short MSG_ACTIVE_REGISTER_TIME_TOO_LATE = 120;

		public const short MSG_BATTLE_PASS_TAG_EXPIRED = 1001;

		public const short MSG_ACTIVATION_CODE_ERROR = 1002;

		public const short MSG_ACTIVATION_CODE_TIME_EXPIRED = 1003;

		public const short MSG_ACTIVATION_CODE_RECEIVED = 1004;

		public const short MSG_ACTIVATION_CODE_ISUSED = 1006;

		public const short MSG_ACTIVATION_CODE_ISOLDVERSION = 1007;

		public const short MSG_ACHIEVE_NOT_MEETED = 1008;

		public const short MSG_DAILY_POINT_NOT_MEETED = 1009;

		public const ushort MSG_LOCAL_TIME_OUT = 4001;

		public const ushort MSG_LOCAL_HTTP_ERROR = 4002;

		public const ushort MSG_LOCAL_NO_NET = 4010;

		public const ushort MSG_LOCAL_RETRY_COUNT_MAX = 4011;

		public const ushort MSG_LOCAL_NOT_ACHIEVE = 4012;

		public const short MSG_IOS_IAP_JSON_PARSE_FAILED = 21000;

		public const short MSG_IOS_IAP_RECEIPT_DATA_MALFORMED = 21002;

		public const short MSG_IOS_IAP_RECEIPT_AUTHENTICATED_FAILED1 = 21003;

		public const short MSG_IOS_IAP_SECRET_NOT_MATCH = 21004;

		public const short MSG_IOS_IAP_RECEIPT_SERVER_UNAVAILABLE = 21005;

		public const short MSG_IOS_IAP_RECEIPT_AUTHENTICATED_FAILED2 = 21010;

		public const short MSG_JOIN_COOP_BATTLE_ROOM_FAILED = 30000;

		public const short MSG_JOIN_COOP_BATTLE_ROOM_OVER_CAP_FAILED = 30001;

		public const short MSG_CREATE_COOP_BATTLE_ROOM_FAILED = 30002;

		public const short MSG_JOIN_COOP_BATTLE_ROOM_CLIEN_VERSION_FAILED = 30003;

		public const short MSG_JOIN_COOP_BATTLE_ROOM_CAP_VERSION_FAILED = 30004;

		public const short MSG_FORMAT_ERROR = -1;

		public const short MSG_REGEX_ERROR = -2;

		public const short MSG_THREADING_DATABASE_FAILED = -3;

		public const short MSG_STORE_RESULT_FAILED = -4;

		public const short MSG_BAD_LEXICAL_EXCEPTION = -5;

		public const short MSG_COLUMN_UNEXPECTED = -6;

		public const short MSG_SQL_FETCH_FAILED = -7;

		public const short MSG_SQL_QUERY_FAILED = -8;

		public const short MSG_COMMIT_DATA_FAILED = -9;

		public const short MSG_INTERNAL_ARG_FAILED = -10;

		public const short MSG_WRONG_NUM_COL_FIELDS = -11;

		public const short MSG_INSERT_DATA_FAILED = -12;

		public const short MSG_UPDATE_DATA_FAILED = -13;

		public const short MSG_DELETE_DATA_FAILED = -14;

		public const short MSG_IAP_REQUEST_FAILED = -15;

		public const short MSG_BASE64_ENCODE_FAILED = -16;

		public const short MSG_INTERNAL_JSON_LOADS_FAILED = -17;

		public const short MSG_PARSE_STRING_VALUE_FAILED = -18;

		public ushort m_unStatusCode;

		public string m_strInfo;

		public STCommonData stCommonData;

		public ushort GetMsgType => 0;

		public short m_nStatusCode => 0;

		public bool IsOK => false;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void ReadFromStream(BinaryReader reader, ReadOptions opt)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}

		public string dump()
		{
			return null;
		}
	}
}
