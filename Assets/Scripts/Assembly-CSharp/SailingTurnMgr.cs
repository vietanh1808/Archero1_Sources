using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;

public class SailingTurnMgr
{
	private static SailingTurnMgr instance;

	private SailingTurnData[] sailingTurnDatas;

	public WheelItemConfig[] wheelItemConfigs;

	public long StartTime;

	public long EndTime;

	public const int WheelPrivilegeVipConfigID = 63;

	public bool IsGiftAlreadyGot;

	public long RefreshTime;

	[CompilerGenerated]
	private Action<bool> m_OnRefreshCallBack;

	public static SailingTurnMgr Instance => null;

	public bool isOpen => false;

	public event Action<bool> OnRefreshCallBack
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

	private SailingTurnMgr()
	{
	}

	public int GetVipGiftCanGetCount()
	{
		return 0;
	}

	public long GetRefreshLeftTime()
	{
		return 0L;
	}

	public List<SailingTurnPreviewItemData> GetTurnPreviewDatas(int index)
	{
		return null;
	}

	public List<SailingTurnItemData> GetTurnWheelDatas(int index)
	{
		return null;
	}

	public uint[] GetWheelRates(int index)
	{
		return null;
	}

	public int GetPosById(int index, int rewardId)
	{
		return 0;
	}

	public int GetPosByRate(int index, int rate)
	{
		return 0;
	}

	public SailingTurnData GetWheelData(int index)
	{
		return null;
	}

	public void ReqSailingTurnInfo(Action callBack)
	{
	}

	public void ReqStartSailingTurn(int wheelType)
	{
	}

	public void ReqRefreshSailingTurn(int wheelType)
	{
	}

	public void ReqTurnVipGiftGot(Action<bool> callBack)
	{
	}

	public void requestTurnQuick(int equipid, int wheel, int count, Action<CRespShipBattleSeasonWheel, int> action = null)
	{
	}

	public int GetQuickConfigMax()
	{
		return 0;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}
}
