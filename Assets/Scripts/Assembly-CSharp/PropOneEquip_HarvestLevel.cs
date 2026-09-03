using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class PropOneEquip_HarvestLevel : PropOneEquip
{
	[SerializeField]
	private Image newIcon;

	[SerializeField]
	private DxxText newText;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void RefreshItem(Drop_DropModel.DropData itemData, bool isNew)
	{
	}
}
