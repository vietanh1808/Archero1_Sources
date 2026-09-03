using System;
using System.Collections.Generic;
using XLua;

public class FishingResultData
{
	private static DelegateBridge __Hotfix0_get_Result;

	private static DelegateBridge __Hotfix0_set_Result;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_set_Rewards;

	private static DelegateBridge __Hotfix0_get_CloseEvent;

	private static DelegateBridge __Hotfix0_set_CloseEvent;

	private static DelegateBridge __Hotfix0_get_HaveMoreFish;

	private static DelegateBridge __Hotfix0_get_MaxWeightFishID;

	private static DelegateBridge __Hotfix0_get_MaxWeight;

	private static DelegateBridge __Hotfix0_get_FishType;

	private static DelegateBridge __Hotfix0_get_TotalWeight;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge _c__Hotfix0_ctor;

	public FishingResult Result { get; set; }

	public List<FishingResultItemData> Rewards { get; set; }

	public Action CloseEvent { get; set; }

	public bool HaveMoreFish => false;

	public int MaxWeightFishID => 0;

	public int MaxWeight => 0;

	public FishingFishType FishType => FishingFishType.None;

	public int TotalWeight => 0;

	public static FishingResultData Create(FishingResult result, List<FishingResultItemData> rewards, Action closeEvent)
	{
		return null;
	}
}
