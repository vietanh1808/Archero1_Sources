using System;
using System.Collections.Generic;
using TableTool;

public class PinduoduoPrivilegeData : ViewCellData
{
	public enum Type
	{
		LowerPrices = 1,
		AddContent = 2,
		GiftPack = 3
	}

	public int groupId;

	public int ID;

	public Type curType;

	public List<ViewCellData> dropDatas;

	public int reducePrice;

	public Drop_DropModel.DropData price;

	public int needNum;

	public bool isBuyed;

	public bool isAdded;

	private int mCurNum;

	public bool isBaseBuyed;

	public long endTime;

	public long startTime;

	public Action OnBuyCallBack;

	public int CurNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool isUnLock => false;

	public bool isInSellTime => false;

	public PinduoduoPrivilegeData(PinduoduoGiftMgr.PinduoduoGiftProgressConfig cfg)
	{
	}

	public void SetBuyed()
	{
	}
}
