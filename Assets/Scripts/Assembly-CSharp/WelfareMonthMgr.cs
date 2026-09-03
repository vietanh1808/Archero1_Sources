using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;

public class WelfareMonthMgr
{
	public class WelfareMonthGiftConfig
	{
		public int ID;

		public int Position;

		public int MinLevel;

		public int MaxLevel;

		public string Product_id;

		public int[] Price;

		public int ShowCond;

		public int Quota;

		public int[][] Rewards;

		public int Discount;

		public int DailyReset;

		public int ShowVersion;
	}

	public class WelfareMonthGiftItemData
	{
		private WelfareMonthGiftConfig config;

		public int Type;

		public Drop_DropModel.DropData Price { get; private set; }

		public List<Drop_DropModel.DropData> Rewards { get; private set; }

		public int LeftBuyCount { get; private set; }

		public int ID => 0;

		public int Position => 0;

		public string ProductID => null;

		public bool IsAdvertising => false;

		public bool IsFree => false;

		public bool IsExchange => false;

		public bool IsProduct => false;

		public int Discount => 0;

		public int MaxBuyCount => 0;

		public bool IsDailyReset => false;

		public bool CanBuy => false;

		public bool isRed => false;

		public WelfareMonthGiftItemData(int type, STActivityCrazyGift severData)
		{
		}

		public void AddBuyCount()
		{
		}

		public void ResetBuyCount()
		{
		}
	}

	private static WelfareMonthMgr instance;

	private STRespActivityCrazyMonth severData;

	private Dictionary<int, List<WelfareMonthGiftItemData>> giftDatas;

	private List<string> PurchseIds;

	[CompilerGenerated]
	private Action m_ReqInfoCallBack;

	[CompilerGenerated]
	private Action<uint, uint> m_ReviceRewardCallBack;

	[CompilerGenerated]
	private Action m_ReviceGiftCallBack;

	private int[] mTypesOrder;

	public static WelfareMonthMgr Instance => null;

	public int CurPurchseType { private get; set; }

	public bool isOpen => false;

	public long MainTimeDown => 0L;

	public int[] TypesOrder => null;

	public event Action ReqInfoCallBack
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

	public event Action<uint, uint> ReviceRewardCallBack
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

	public event Action ReviceGiftCallBack
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

	private WelfareMonthMgr()
	{
	}

	public bool GetIsOpen(STActivityCrazyMonth tagData)
	{
		return false;
	}

	public bool GetIsOpen(int tag)
	{
		return false;
	}

	public bool GetTabIsOpen(STActivityCrazyMonth tagData)
	{
		return false;
	}

	public bool GetTabIsOpen(int tag)
	{
		return false;
	}

	public bool GetTabIsExpired(STActivityCrazyMonth tagData)
	{
		return false;
	}

	public bool GetTabIsExpired(int tag)
	{
		return false;
	}

	public STActivityCrazyMonth GetTagData(int tag)
	{
		return null;
	}

	public List<WelfareMonthGiftItemData> GetTageGiftData(int tag)
	{
		return null;
	}

	public void SetTaskDone(uint type, uint taskid)
	{
	}

	public bool GetTaskCanGetType(int type)
	{
		return false;
	}

	public uint[] GetTask1Types()
	{
		return null;
	}

	public bool GetTaskAnyCanGet()
	{
		return false;
	}

	public bool isCanGetGiftByType(int type)
	{
		return false;
	}

	public bool isCanGetGift()
	{
		return false;
	}

	public bool IsWelfareMonthGetType(string purchaseId, out int curType)
	{
		curType = default;
		return false;
	}

	public void ReqWelfareMonth(Action callback = null)
	{
	}

	public void ReviceWelfareMonthReward(uint type, uint taskid)
	{
	}

	public void ReviceWelfareMonthGift(WelfareMonthGiftItemData giftData, Action callback)
	{
	}

	public void Clear()
	{
	}
}
