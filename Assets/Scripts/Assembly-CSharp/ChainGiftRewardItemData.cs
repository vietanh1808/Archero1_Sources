using System.Collections.Generic;
using TableTool;
using XLua;

public class ChainGiftRewardItemData
{
	private static DelegateBridge __Hotfix0_get_ItemConfigData;

	private static DelegateBridge __Hotfix0_set_ItemConfigData;

	private static DelegateBridge __Hotfix0_get_ChainGiftManager;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_ProductID;

	private static DelegateBridge __Hotfix0_get_HaveGetReward;

	private static DelegateBridge __Hotfix0_get_CanGetReward;

	private static DelegateBridge __Hotfix0_get_BuyType;

	private static DelegateBridge __Hotfix0_get_IsFree;

	private static DelegateBridge __Hotfix0_get_IsShowBox;

	private static DelegateBridge __Hotfix0_get_IconName;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetRewardData;

	private static DelegateBridge __Hotfix0_GetRewardDataStr;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ChainGiftRewardItemConfigData ItemConfigData { get; set; }

	private ChainGiftManager ChainGiftManager => null;

	public int ID => 0;

	public string ProductID => null;

	public bool HaveGetReward => false;

	public bool CanGetReward => false;

	public ChainGiftBuyType BuyType => ChainGiftBuyType.None;

	public bool IsFree => false;

	public bool IsShowBox => false;

	public string IconName => null;

	public static ChainGiftRewardItemData Create(ChainGiftRewardItemConfigData itemConfigData)
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetRewardData()
	{
		return null;
	}

	public List<string> GetRewardDataStr()
	{
		return null;
	}
}
