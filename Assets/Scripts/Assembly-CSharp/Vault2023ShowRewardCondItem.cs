using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Vault2023ShowRewardCondItem : MonoBehaviour
{
	[SerializeField]
	private Image bg;

	[SerializeField]
	private GameObject activeMask;

	[SerializeField]
	private GameObject lineMask;

	[SerializeField]
	private PropOneEquip prop;

	private Vault2023ShowRewardCondItemData data;

	private bool isSpecial;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_SetActiveStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(Vault2023ShowRewardCondItemData data, bool isSpecial)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}

	public void SetActiveStatus()
	{
	}
}
