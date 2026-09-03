using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;

public class PVESeasonGiftManager
{
	private static PVESeasonGiftManager instance;

	private STRespPveSeasonGift serverData;

	private const string PopKey = "PveSeasonGiftPop";

	private const string NewKey = "PveSeasonGiftNew";

	private List<PVESeasonGiftItemData> giftItemDatas;

	[CompilerGenerated]
	private Action<bool> m_OnReqInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqGiftCallBack;

	public static PVESeasonGiftManager Instance => null;

	public int Tag => 0;

	public bool isOpen => false;

	public int OpenTalentLevel => 0;

	public long DailyTime => 0L;

	public bool isPoped
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isHaveNew
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

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

	public event Action<bool> OnReqGiftCallBack
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

	private PVESeasonGiftManager()
	{
	}

	public List<PVESeasonGiftItemData> GetGiftShowList()
	{
		return null;
	}

	public void ReqInfo()
	{
	}

	public void ReqGiftBuy(PVESeasonGiftItemData gift)
	{
	}

	public bool EntanceRed()
	{
		return false;
	}
}
