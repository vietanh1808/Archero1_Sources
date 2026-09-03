using System;
using System.Collections.Generic;
using Activity7thAnniversary;
using newplay122;

public class Daily130RewardUICtrl : DailyTDRewardPanel
{
	private Activity7thAnniversaryMgr _mgr;

	private bool _hasRequestedExpiredRewardInfo;

	protected override WindowID WindowID => WindowID.WindowID_Invaild;

	private Activity7thAnniversaryMgr Mgr => null;

	protected override TDWeekRewardVO ExtraRewardVO => null;

	protected override List<TDWeekRewardVO> NormalRewardVOList => null;

	protected override int CurRewardPoints => 0;

	protected override int CurExtraRewardPoints => 0;

	protected override string ExtraRewardDesc => null;

	protected override string InfoTitle => null;

	protected override string ResetTimeKey => null;

	protected override string Infocontent => null;

	protected override long GetRemainTime(long endTime)
	{
		return 0L;
	}

	protected override void OnOpen()
	{
	}

	protected override void RequestRewardInfo(Action successCallback = null, Action failCallback = null)
	{
	}

	protected override void onGetReward(TDWeekRewardVO rewardVO)
	{
	}

	protected override void onGetExtraReward()
	{
	}

	protected override bool IsAllNormalRewardsGot()
	{
		return false;
	}

	protected override bool IsExtraRewardButtonEnabled(TDWeekRewardVO rewardVO)
	{
		return false;
	}

	private static int ClampLongToInt(long value)
	{
		return 0;
	}

	public override void OnLanguageChange()
	{
	}
}
