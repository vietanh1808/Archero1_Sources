using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;
using XLua;

public class ActRedEnvelopeMgr
{
	public class RedEnvelopeItem
	{
		public int Id;

		public int DailyExchangeMaxNum;

		public int DailyExchangeNum;

		public int DailyReviceMaxNum;

		public int DailyReviceNum;

		public int DailyIssueMaxNum;

		public int DailyIssueNum;

		public int MaxOpenCount;

		public int[] ExchangeIds;

		public int Num
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string Name => null;

		public string Desc => null;

		public bool DailyIsCanExchange => false;

		public bool DailyIsCanRevice => false;

		public bool DailyIsCanIssue => false;

		public RedEnvelopeItem(RedEnvelopeConfig _data)
		{
		}
	}

	public class ActivityTagConfig
	{
		public int tag;

		public long startTime;

		public long endTime;

		public long rankingEndTime;

		public long entranceEndTime;

		public int minversion;

		public int OpenGameLevel;

		public int[] itemId;

		public int Number;

		public int[] layer;

		public int[] RedEnvelopeitemId;

		public int[] currency;

		public int[] Score;

		public int[] DeleteitemId;
	}

	public class RedEnvelopeRankingConfig
	{
		public int ID;

		public int tag;

		public int[] Rank;

		public string Reward1;

		public string Reward2;

		public string Reward3;

		public string Reward4;

		public string Reward5;

		public string Reward6;

		public string Reward7;

		public string Reward8;

		public string Reward_img;
	}

	public class RedEnvelopeGiftConfig
	{
		public int ID;

		public int Layer;

		public string Product_Id;

		public int Discount;

		public int Show;

		public int[][] Reward;

		public int Quota;

		public int DailyReset;
	}

	public class RedEnvelopeConfig
	{
		public int ID;

		public int Number;

		public int Times1;

		public int Times2;

		public int Times3;

		public int[] Exchange;
	}

	public class ActRedEnvelopeConfig
	{
		public ActivityTagConfig[] ActivityTag;

		public RedEnvelopeConfig[] RedEnvelope;

		public RedEnvelopeRankingConfig[] Ranking;
	}

	private static ActRedEnvelopeMgr instance;

	private ActRedEnvelopeConfig mActRedEnvelopeConfig;

	private CRespActivityRedpacketInfo severData;

	private ActivityTagConfig curTagConfig;

	public RedEnvelopeItem RedEnvelope1;

	public RedEnvelopeItem RedEnvelope2;

	public Dictionary<ulong, CRedpacketUser> Members;

	public List<CRedpacketInfo> ShowListRedEnvelopes;

	public List<RedEnvelopeRankingConfig> RanksConfigs;

	public List<ActRedEnvelopeGiftData> GiftConfigs;

	public int Tag;

	[CompilerGenerated]
	private Action m_RedEnvelopeListCallBack;

	[CompilerGenerated]
	private Action m_IssueRedEnvelopeCallBack;

	[CompilerGenerated]
	private Action m_ExchangeRedEnvelopeCallBack;

	[CompilerGenerated]
	private Action m_ReciveRedEnvelopeCallBack;

	[CompilerGenerated]
	private Action<int, List<Drop_DropModel.DropData>> m_PlayRedEnvelopeCallBack;

	[CompilerGenerated]
	private Action<CRespActivityRedpacketDetail> m_OpenRedEnvelopeCallBack;

	public CRedpacketExchangeData[] vecExchangeData;

	[CompilerGenerated]
	private Action m_ExchangeRedEnvelopeStoreCallBack;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge _c__Hotfix0_ctor;

	private static DelegateBridge __Hotfix0_get_CurTagConfig;

	private static DelegateBridge __Hotfix0_get_isS3Open;

	private static DelegateBridge __Hotfix0_get_isOpen;

	private static DelegateBridge __Hotfix0_get_isExchangeOpen;

	private static DelegateBridge __Hotfix0_get_EntranceTimeDown;

	private static DelegateBridge __Hotfix0_get_StartTime;

	private static DelegateBridge __Hotfix0_get_EndTime;

	private static DelegateBridge __Hotfix0_get_ActivityEndTime;

	private static DelegateBridge __Hotfix0_get_RankEndTime;

	private static DelegateBridge __Hotfix0_get_exchangeItem1Id;

	private static DelegateBridge __Hotfix0_get_exchangeItem1Num;

	private static DelegateBridge __Hotfix0_set_exchangeItem1Num;

	private static DelegateBridge __Hotfix0_get_exchangeItem1NeedNum;

	private static DelegateBridge __Hotfix0_get_exchangeItem2Id;

	private static DelegateBridge __Hotfix0_get_exchangeItem2Num;

	private static DelegateBridge __Hotfix0_set_exchangeItem2Num;

	private static DelegateBridge __Hotfix0_get_exchangeItem2NeedNum;

	private static DelegateBridge __Hotfix0_get_TokenId1;

	private static DelegateBridge __Hotfix0_get_TokenNum1;

	private static DelegateBridge __Hotfix0_set_TokenNum1;

	private static DelegateBridge __Hotfix0_get_TokenId2;

	private static DelegateBridge __Hotfix0_get_TokenNum2;

	private static DelegateBridge __Hotfix0_set_TokenNum2;

	private static DelegateBridge __Hotfix0_ReqS3;

	private static DelegateBridge __Hotfix0_RefreshData;

	private static DelegateBridge __Hotfix0_UnInit;

	private static DelegateBridge __Hotfix0_BossPlayTowerData_ParseJson;

	private static DelegateBridge __Hotfix0_EntranceHaveRed;

	private static DelegateBridge __Hotfix0_HaveRedCanIssue;

	private static DelegateBridge __Hotfix0_HaveRedCanRecive;

	private static DelegateBridge __Hotfix0_HaveRedCanExchange;

	private static DelegateBridge __Hotfix0_GetRankingConfig;

	private static DelegateBridge __Hotfix0_GetLayerId;

	private static DelegateBridge __Hotfix0_ReqRedEnvelope;

	private static DelegateBridge __Hotfix0_add_RedEnvelopeListCallBack;

	private static DelegateBridge __Hotfix0_remove_RedEnvelopeListCallBack;

	private static DelegateBridge __Hotfix0_ReqRedEnvelopeList;

	private static DelegateBridge __Hotfix0_add_IssueRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_remove_IssueRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_IssueRedEnvelope;

	private static DelegateBridge __Hotfix0_add_ExchangeRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_remove_ExchangeRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_ExchangeRedEnvelope;

	private static DelegateBridge __Hotfix0_add_ReciveRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_remove_ReciveRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_add_PlayRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_remove_PlayRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_ReciveRedEnvelope;

	private static DelegateBridge __Hotfix0_ReciveRedEnvelopeGift;

	private static DelegateBridge __Hotfix0_add_OpenRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_remove_OpenRedEnvelopeCallBack;

	private static DelegateBridge __Hotfix0_OpenRedEnvelope;

	private static DelegateBridge __Hotfix0_ReqRedEnvelopeRank;

	private static DelegateBridge __Hotfix0_ReqRedEnvelopeStore;

	private static DelegateBridge __Hotfix0_add_ExchangeRedEnvelopeStoreCallBack;

	private static DelegateBridge __Hotfix0_remove_ExchangeRedEnvelopeStoreCallBack;

	private static DelegateBridge __Hotfix0_ExchangeRedEnvelopeStore;

	private static DelegateBridge __Hotfix0_GetGiftDatas;

	public static ActRedEnvelopeMgr Instance => null;

	public ActivityTagConfig CurTagConfig => null;

	public bool isS3Open => false;

	public bool isOpen => false;

	public bool isExchangeOpen => false;

	public long EntranceTimeDown => 0L;

	public long StartTime => 0L;

	public long EndTime => 0L;

	public long ActivityEndTime => 0L;

	public long RankEndTime => 0L;

	public int exchangeItem1Id => 0;

	public int exchangeItem1Num
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int exchangeItem1NeedNum => 0;

	public int exchangeItem2Id => 0;

	public int exchangeItem2Num
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int exchangeItem2NeedNum => 0;

	public int TokenId1 => 0;

	public int TokenNum1
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int TokenId2 => 0;

	public int TokenNum2
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public event Action RedEnvelopeListCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action IssueRedEnvelopeCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action ExchangeRedEnvelopeCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action ReciveRedEnvelopeCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<int, List<Drop_DropModel.DropData>> PlayRedEnvelopeCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<CRespActivityRedpacketDetail> OpenRedEnvelopeCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action ExchangeRedEnvelopeStoreCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private ActRedEnvelopeMgr()
	{
	}

	public void ReqS3()
	{
	}

	public void RefreshData()
	{
	}

	public void UnInit()
	{
	}

	private void BossPlayTowerData_ParseJson()
	{
	}

	public bool EntranceHaveRed()
	{
		return false;
	}

	public bool HaveRedCanIssue()
	{
		return false;
	}

	public bool HaveRedCanRecive()
	{
		return false;
	}

	public bool HaveRedCanExchange()
	{
		return false;
	}

	public RedEnvelopeRankingConfig GetRankingConfig(int rank)
	{
		return null;
	}

	public int GetLayerId()
	{
		return 0;
	}

	public void ReqRedEnvelope()
	{
	}

	public void ReqRedEnvelopeList()
	{
	}

	public void IssueRedEnvelope(int configId, int num)
	{
	}

	public void ExchangeRedEnvelope(int configId, int num)
	{
	}

	public void ReciveRedEnvelope(ulong id)
	{
	}

	public void ReciveRedEnvelopeGift(ActRedEnvelopeGiftData giftData, Action callBack)
	{
	}

	public void OpenRedEnvelope(ulong id)
	{
	}

	public void ReqRedEnvelopeRank(Action<CRespActivityRedpacketRank> callBack)
	{
	}

	public void ReqRedEnvelopeStore()
	{
	}

	public void ExchangeRedEnvelopeStore(ushort id, ushort count = 1)
	{
	}

	public List<ActRedEnvelopeGiftData> GetGiftDatas()
	{
		return null;
	}
}
