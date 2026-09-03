using UnityEngine;
using XLua;

public class CampTownSkinAttributeItem : MonoBehaviour
{
	[SerializeField]
	private DxxText allAttr;

	[SerializeField]
	private FitContentText allAttrDesc;

	[SerializeField]
	private GameObject allSkinStatus;

	[SerializeField]
	private GameObject selfStatus;

	[SerializeField]
	private FitContentText selfAttrDesc;

	private CampTownSkinAttributeItemData data;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CampTownSkinAttributeItemData data)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}
}
