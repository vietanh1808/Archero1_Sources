using UnityEngine;
using XLua;

public class FishingBestiaryFishItem : MonoBehaviour
{
	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private new DxxText name;

	[SerializeField]
	private GameObject mask;

	private FishingBestiaryFishItemData data;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(FishingBestiaryFishItemData data)
	{
	}
}
