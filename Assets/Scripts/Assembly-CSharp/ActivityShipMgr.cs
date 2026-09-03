using System;
using System.Collections.Generic;
using GameProtocol;

public sealed class ActivityShipMgr : CInstance<ActivityShipMgr>
{
	public enum CargoShipType
	{
		closed = 0,
		free = 1,
		pay = 2
	}

	public const string LOG_TAG = "[货船]";

	public int RequestType;

	public List<CActivityShipNormalItem> NormalItems;

	public List<CActivityShipPayItem> PayItems;

	private long m_lEndTime;

	public ushort refreshUsed;

	public ushort refreshMax;

	public ushort refreshDiamondCost;

	public bool isShow;

	public bool isBusy;

	public bool isProgressing;

	public long FreeStartTime;

	public long FreeEndTime;

	public long PayStartTime;

	public long PayEndTime;

	public long PayExileTime;

	public int RelicsBoxGiftType;

	public bool RelicsBoxGiftGet;

	public int ShipType => 0;

	public long EndTime => 0L;

	public bool IsPayType(int curShipType)
	{
		return false;
	}

	public bool IsFreeType(int curShipType)
	{
		return false;
	}

	public bool IsCurPayType()
	{
		return false;
	}

	public bool IsCurFreeType()
	{
		return false;
	}

	private void GetActivityShipData(CRespActivityShip data, int requestType)
	{
	}

	public void SetPayStartTime(long value)
	{
	}

	public void SetFreeStartTime(long value)
	{
	}

	private int NormalCount()
	{
		return 0;
	}

	public int PayCount()
	{
		return 0;
	}

	public void SetNormalItemBuy(uint m_nId)
	{
	}

	public void SetPayItemBuy(uint m_nId)
	{
	}

	public int getNormalItemSource(uint m_nId)
	{
		return 0;
	}

	public int getNormalItemBuyCount()
	{
		return 0;
	}

	public bool IfCanShow()
	{
		return false;
	}

	public void ReqActivityShipMsgOnLogin(Action callback = null, ushort requestType = 1)
	{
	}

	public void ReqActivityShipMsg(Action callback = null, ushort requestType = 1)
	{
	}

	public int getTime()
	{
		return 0;
	}

	public long GetFreeEndTime()
	{
		return 0L;
	}

	public bool CanShowPayShipButton()
	{
		return false;
	}

	public void requestShipRelicsBox(Action<CRespActivityShip, int> action = null)
	{
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}
}
