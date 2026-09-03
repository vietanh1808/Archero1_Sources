using System.Collections.Generic;
using TableTool;
using XLua;

public class Vault2023ShowRewardItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_RewardCount;

	private static DelegateBridge __Hotfix0_get_HaveCount;

	private static DelegateBridge __Hotfix0_get_NeedCount;

	private static DelegateBridge __Hotfix0_get_IsActive;

	private static DelegateBridge __Hotfix0_get_Need;

	private static DelegateBridge __Hotfix0_get_Reward;

	private static DelegateBridge __Hotfix0_get_CondItemData;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_AddHaveCount;

	private static DelegateBridge __Hotfix0_GetCondItemData;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Vault2023GameShowRewardItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int RewardCount => 0;

	public int HaveCount => 0;

	public int NeedCount => 0;

	public bool IsActive => false;

	public Drop_DropModel.DropData Need => null;

	public Drop_DropModel.DropData Reward => null;

	public List<Vault2023ShowRewardCondItemData> CondItemData => null;

	public static Vault2023ShowRewardItemData Create(Vault2023GameShowRewardItemConfigData configData)
	{
		return null;
	}

	public void AddHaveCount()
	{
	}

	private List<Vault2023ShowRewardCondItemData> GetCondItemData()
	{
		return null;
	}
}
