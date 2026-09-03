using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;

public class NewChainGiftMgr
{
	public enum NewChainGiftType
	{
		free = 0,
		ad = 1,
		diamond = 2,
		pay = 3,
		starDiamond = 4
	}

	public class NewChainGiftItemData
	{
		private NewChainGiftItemConfig Config;

		public int ID;

		public NewChainGiftType GiftType;

		public List<Drop_DropModel.DropData> Rewards;

		public Drop_DropModel.DropData Price;

		public string Product_id;

		public string BagPicColor;

		public NewChainGiftItemData(NewChainGiftItemConfig config)
		{
		}
	}

	public class NewChainGiftItemConfig
	{
		public int ID;

		public int[][] reward;

		public int[] Price;

		public string Product_id;

		public string BagPicColor;
	}

	private static NewChainGiftMgr instance;

	public CRespActivityChainGiftNew serverData;

	private List<NewChainGiftItemData> giftItems;

	[CompilerGenerated]
	private Action m_ReviceNewChainGiftCallBack;

	public PlayerPrefsMgr.PrefDataBool newChainGiftRed;

	public static NewChainGiftMgr Instance => null;

	public bool IsOpen => false;

	public int ShowRows => 0;

	public long EndTime => 0L;

	public event Action ReviceNewChainGiftCallBack
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

	private NewChainGiftMgr()
	{
	}

	public void ReqNewChainGift()
	{
	}

	public void ReviceNewChainGift(int ID, NewChainGiftType giftType)
	{
	}

	public bool IsBuyedById(int id)
	{
		return false;
	}

	public bool IsCanBuy(int id)
	{
		return false;
	}

	public List<NewChainGiftItemData> GetNewChainGiftItems()
	{
		return null;
	}

	public void SetCurID(int ID)
	{
	}

	public bool EntanceRed()
	{
		return false;
	}

	public void SetHasRed()
	{
	}

	public void UnInit()
	{
	}
}
