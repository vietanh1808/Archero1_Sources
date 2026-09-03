using UnityEngine;
using XLua;

public class SkinAbilityMaterialItem : MonoBehaviour
{
	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private DxxText propName;

	[SerializeField]
	private DxxText propCount;

	private SkinAbilityMaterialItemData data;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_GetPropNameOne;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(SkinAbilityMaterialItemData data)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private string GetPropNameOne()
	{
		return null;
	}
}
