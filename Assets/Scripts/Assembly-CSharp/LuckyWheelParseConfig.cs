using System;
using System.Collections.Generic;
using XLua;

[Serializable]
public class LuckyWheelParseConfig
{
	public List<LuckyWheelRewardItemConfigData> Items;

	public List<LuckyWheelTaskItemConfigData> Tasks;

	public List<LuckyWheelExtraRewardItemConfigData> Special_Count_Reward;

	private static DelegateBridge _c__Hotfix0_ctor;
}
