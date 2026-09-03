using System.Collections.Generic;
using XLua;

public class HalloweenJsonData
{
	public int ID;

	public int Layer_Min;

	public int Layer_Max;

	public List<HalloweenRewardOneData> GroupReward;

	public List<HalloweenRewardData> SubGroupReward;

	public List<HalloweenRewardData> UltimateRewards;

	public List<HalloweenTaskItemConfigData> Task;

	public List<HalloweenShopItemConfigData> ShopItems;

	public List<HalloweenExchageItemConfigData> Exchange;

	private static DelegateBridge _c__Hotfix0_ctor;
}
