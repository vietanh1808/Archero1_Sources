using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using XLua;

public class CumulativeConsumptionData
{
	public class CCItem
	{
		public int id;

		public int param;

		public int[][] reward_free;

		public int open_need_cost;
	}

	[CompilerGenerated]
	private Action m_OnClaimWhenAcivityOver;

	private long _activityEndTime;

	private long _rewardEndTime;

	private ulong _claimMask;

	private ulong _startTime;

	private long _diamond;

	private bool _claiming;

	private CCItem[] _config;

	private static DelegateBridge __Hotfix0_get_ShowEntrance;

	private static DelegateBridge __Hotfix0_get_ActivityOpened;

	private static DelegateBridge __Hotfix0_get_ActivityOver;

	private static DelegateBridge __Hotfix0_get_StartTime;

	private static DelegateBridge __Hotfix0_get_ActivityTimeLeft;

	private static DelegateBridge __Hotfix0_get_RewardTimeLeft;

	private static DelegateBridge __Hotfix0_add_OnClaimWhenAcivityOver;

	private static DelegateBridge __Hotfix0_remove_OnClaimWhenAcivityOver;

	private static DelegateBridge __Hotfix0_set_style;

	private static DelegateBridge __Hotfix0_get_style;

	private static DelegateBridge __Hotfix0_get_Count;

	private static DelegateBridge __Hotfix0_set_Count;

	private static DelegateBridge __Hotfix0_get_List;

	private static DelegateBridge __Hotfix0_get_HasCanClaim;

	private static DelegateBridge __Hotfix0_IsItemClaimed;

	private static DelegateBridge __Hotfix0_ClaimReward;

	private static DelegateBridge __Hotfix0_DiamondChanged;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool ShowEntrance => false;

	public bool ActivityOpened => false;

	public bool ActivityOver => false;

	public ulong StartTime => 0uL;

	public long ActivityTimeLeft => 0L;

	public long RewardTimeLeft => 0L;

	public uint style { get; private set; }

	public long Count { get; private set; }

	public List<CCItem> List { get; }

	public bool HasCanClaim => false;

	public event Action OnClaimWhenAcivityOver
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

	public bool IsItemClaimed(int id)
	{
		return false;
	}

	public void ClaimReward(ushort id, Action onSuccess)
	{
	}

	public void DiamondChanged()
	{
	}

	public void SetData(CActivityCommonData data)
	{
	}
}
