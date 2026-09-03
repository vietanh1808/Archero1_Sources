using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;

public class PinduoduoGiftMgr
{
	public class PinduoduoGiftConfig
	{
		public PinduoduoGiftBaseConfig[] Base;

		public PinduoduoGiftGiftConfig[] Gift;

		public PinduoduoGiftProgressConfig[] Progress;
	}

	public class PinduoduoGiftBaseConfig
	{
		public int Tag;

		public int Version;

		public long StartTime;

		public long EndTime;

		public int OpenGameLevel;

		public int ItemID;

		public int MaxBuyItemNum;

		public int BuyItemPrice;

		public int ConvertGold;
	}

	public class PinduoduoGiftGiftConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public long BaseGiftOpenTime;

		public long BaseGiftOverTime;

		public int BaseGiftPrice;

		public int[][] BaseGift;

		public long UltimateGiftOpenTime;

		public long UltimateGiftOverTime;

		public int UltimateGiftPrice;

		public int UltimateGiftMinPrice;

		public int[][] UltimateGift;
	}

	public class PinduoduoGiftProgressConfig
	{
		public int ID;

		public int GiftID;

		public int Number;

		public int Type;

		public int[][] Parameter1;

		public int[][] Parameter2;
	}

	private static PinduoduoGiftMgr instance;

	public PinduoduoGiftConfig S3Config;

	private STRespActivityHelpGiftBox severData;

	public STCommonQuickBuyData QuickBuy;

	[CompilerGenerated]
	private Action<bool> m_OnReqInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqBaseGiftCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqFinalGiftCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqPrivilegeGiftCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqQuickBuyCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqTaskCallBack;

	private List<PinduoduoGiftGroupData> groupDatas;

	private List<PinduoduoTaskItemData> taskItemDatas;

	public static PinduoduoGiftMgr Instance => null;

	public PinduoduoGiftBaseConfig S3BaseConfig => null;

	public bool isS3Open => false;

	public long S3StartTime => 0L;

	public long S3EndTime => 0L;

	public int Tag_S3 => 0;

	public long StartTime => 0L;

	public long EndTime => 0L;

	public int OpenLevel => 0;

	public bool isOpen => false;

	public long leftTime => 0L;

	public int MatId => 0;

	public int MatCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int HasBuyCount => 0;

	public int MaxBuyCount => 0;

	public int LeftBuyCount => 0;

	public int BuyPrice => 0;

	public event Action<bool> OnReqInfoCallBack
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

	public event Action<bool> OnReqBaseGiftCallBack
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

	public event Action<bool> OnReqFinalGiftCallBack
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

	public event Action<bool> OnReqPrivilegeGiftCallBack
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

	public event Action<bool> OnReqQuickBuyCallBack
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

	public event Action<bool> OnReqTaskCallBack
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

	private PinduoduoGiftMgr()
	{
	}

	public void ReqS3()
	{
	}

	private void ParseJson()
	{
	}

	public void ReqInfo()
	{
	}

	public void ReqBaseGift(PinduoduoBaseGiftData gift)
	{
	}

	public void ReqFinalGift(PinduoduoBaseGiftData gift)
	{
	}

	public void ReqPrivilegeGift(PinduoduoPrivilegeData gift)
	{
	}

	public void ReqQuickBuy(int buyNum)
	{
	}

	public void ReqTaskGet(PinduoduoTaskItemData task)
	{
	}

	public List<PinduoduoGiftGroupData> GetGroupDatas()
	{
		return null;
	}

	public List<ViewCellData> GetTaskShowList()
	{
		return null;
	}

	public bool isRed()
	{
		return false;
	}

	public bool isTaskRed()
	{
		return false;
	}

	public bool IsInLastFinalSell()
	{
		return false;
	}

	public void ReqCleanData()
	{
	}
}
