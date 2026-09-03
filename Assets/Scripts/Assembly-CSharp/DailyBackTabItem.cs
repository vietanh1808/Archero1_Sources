using UnityEngine;
using XLua;

public class DailyBackTabItem : MonoBehaviour, INewPlay120RefreshItem<DailyBackTabItemData>
{
	[SerializeField]
	private DxxText date;

	[SerializeField]
	private ToggleButton toggleButton;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	private DailyBackTabItemData itemData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_GetToggleButton;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(DailyBackTabItemData itemData)
	{
	}

	public void RefreshItem(DailyBackTabItemData itemData)
	{
	}

	public ToggleButton GetToggleButton()
	{
		return null;
	}

	private void RefreshRed()
	{
	}
}
