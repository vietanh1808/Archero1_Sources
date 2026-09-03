using System;
using System.Collections.Generic;
using GameProtocol;

public class PinduoduoGiftGroupData
{
	public int ID;

	public int index;

	public PinduoduoBaseGiftData baseGiftData;

	public PinduoduoFinalGiftData finalGiftData;

	public List<ViewCellData> PrivilegeDatas;

	public long endTime;

	public long startTime;

	private bool mIsLast;

	private int mCurNum;

	public Action OnNumChange;

	public Action OnBuyBase;

	public bool mIsBuyedBase;

	public bool isLast
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isInSellTime => false;

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

	public bool isReached => false;

	public bool IsBuyedBase
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public PinduoduoGiftGroupData(PinduoduoGiftMgr.PinduoduoGiftGiftConfig giftConfig, PinduoduoGiftMgr.PinduoduoGiftProgressConfig[] progressConfigs, int _index)
	{
	}

	public void Refresh(STActivityHelpGiftBoxGroupProtoData data)
	{
	}
}
