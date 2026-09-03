using TableTool;
using UnityEngine;
using XLua;

public class LuckyWheelRewardProbabilityItem : MonoBehaviour
{
	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private new DxxText name;

	[SerializeField]
	private DxxText probability;

	private LuckyWheelRewardItemData luckyWheelRewardItemData;

	private Drop_DropModel.DropData propData;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_GetPropName;

	private static DelegateBridge __Hotfix0_GetPropNameOne;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(LuckyWheelRewardItemData luckyWheelRewardItemData)
	{
	}

	private string GetPropName()
	{
		return null;
	}

	private string GetPropNameOne()
	{
		return null;
	}
}
