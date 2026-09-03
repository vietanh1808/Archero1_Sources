using System.Collections.Generic;
using TableTool;
using XLua;

public class LuckyWheelRewardItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_Theme;

	private static DelegateBridge __Hotfix0_get_ProbabilityNum;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetTheme;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelRewardItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public LuckyWheelRewardTheme Theme => LuckyWheelRewardTheme.None;

	public string ProbabilityNum => null;

	public List<Drop_DropModel.DropData> Rewards => null;

	public static LuckyWheelRewardItemData Create(LuckyWheelRewardItemConfigData configData)
	{
		return null;
	}

	private LuckyWheelRewardTheme GetTheme()
	{
		return LuckyWheelRewardTheme.None;
	}
}
