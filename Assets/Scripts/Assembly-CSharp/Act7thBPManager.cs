using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class Act7thBPManager : CInstance<Act7thBPManager>
{
	public Act7thBPData bpData;

	public Act7thBPBoxData boxData;

	public List<Act7thBPItemData> itemDataList;

	public bool haveBuyBPNormal => false;

	public bool haveBuyBPPremium => false;

	public int PowerTotal => 0;

	public string BP_NormalPrice => null;

	public string BP_PremiumPrice => null;

	public int Bp_Normal_Rate => 0;

	public int Bp_Premium_Rate => 0;

	public int Bp_Normal_PrivilegeType => 0;

	public int Bp_Normal_PrivilegeValue => 0;

	public int Bp_Premium_PrivilegeType => 0;

	public int Bp_Premium_PrivilegeValue => 0;

	public long TimeLeft => 0L;

	public int GetBoxShowId => 0;

	public List<string> GetBoxShowRewards => null;

	public int GetBPLevelMax => 0;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public void requestData(Action<STRespActivity7thAnniversary, int> action = null)
	{
	}

	private void parseBasicData(STRespActivity7thAnniversary data)
	{
	}

	private void parseItemData(STRespActivity7thAnniversary data)
	{
	}

	private void parseBoxData(STRespActivity7thAnniversary data)
	{
	}

	public void parseBPDataAll(STRespActivity7thAnniversary data)
	{
	}

	public Act7thBPItemData GetItemData(int bpid)
	{
		return null;
	}

	public void requestRewardGet(int type, int bpid, Action<STRespActivity7thAnniversary, int> action = null)
	{
	}

	public void requestBoxGet(Action<STRespActivity7thAnniversary, int> action = null)
	{
	}

	public void requestBuyScore(int next, Action<STRespActivity7thAnniversary, int> action = null)
	{
	}

	public bool isOpen()
	{
		return false;
	}

	public bool isRewardHaveGet(int id, int index)
	{
		return false;
	}

	public (int, int, int) GetBPLevelCurrentValue()
	{
		return default;
	}

	public int GetBoxMaxCanGetCount()
	{
		return 0;
	}

	public bool canGetExtraBoxReward()
	{
		return false;
	}

	public int GetLevelNeedDiamond()
	{
		return 0;
	}

	public bool isHaveRewardCanGet()
	{
		return false;
	}

	public List<Drop_DropModel.DropData> GetBPNormalRewardList()
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetBPPremiumRewardList()
	{
		return null;
	}

	public List<Act7thBPPrivilegeItemData> GetPrivilegeNormalList()
	{
		return null;
	}

	public List<Act7thBPPrivilegeItemData> GetPrivilegePremiumList()
	{
		return null;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	public bool isAllItemRewardClaimed()
	{
		return false;
	}

	public bool isHaveRed_Icon()
	{
		return false;
	}
}
