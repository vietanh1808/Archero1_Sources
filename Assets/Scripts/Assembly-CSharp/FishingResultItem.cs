using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingResultItem : MonoBehaviour
{
	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private GameObject weightObj;

	[SerializeField]
	private Image weightIcon;

	[SerializeField]
	private DxxText weight;

	private FishingResultItemData data;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(FishingResultItemData data)
	{
	}
}
