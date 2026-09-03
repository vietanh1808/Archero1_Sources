using UnityEngine;
using UnityEngine.UI;
using XLua;

public class SkinAbilityItem : MonoBehaviour
{
	[SerializeField]
	private Image bg;

	[SerializeField]
	private GameObject allHeroStatus;

	[SerializeField]
	private GameObject allHeroMask;

	[SerializeField]
	private DxxText attrDesc;

	[SerializeField]
	private GameObject lockStatus;

	[SerializeField]
	private GameObject unlockStatus;

	[SerializeField]
	private DxxText unlockLevel;

	[SerializeField]
	private DxxText allHeroName;

	private SkinAbilityItemData data;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(SkinAbilityItemData data)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}
}
