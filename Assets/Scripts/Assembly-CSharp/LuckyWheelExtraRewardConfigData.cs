using System.Collections.Generic;
using XLua;

public class LuckyWheelExtraRewardConfigData
{
	public int progress;

	public ulong rewardProgress;

	public List<LuckyWheelExtraRewardItemConfigData> itemConfigData;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UpdateProgress;

	private static DelegateBridge __Hotfix0_UpdateRewardProcess;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static LuckyWheelExtraRewardConfigData Create(int progress, ulong rewardProgress, List<LuckyWheelExtraRewardItemConfigData> itemConfigData)
	{
		return null;
	}

	public void UpdateProgress(int progress)
	{
	}

	public void UpdateRewardProcess(ulong rewardProgress)
	{
	}
}
