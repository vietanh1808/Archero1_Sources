using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorBuildingItem : MonoBehaviour
{
	public int buildingId;

	public Image Icon;

	public Image Ruins;

	public ManorBuildingBottom Bottom;

	public GameObject Bubble;

	public Image BubbleIcon;

	public Image BubbleProgress;

	public DxxText Text_Count;

	public GameObject levelUpEffect;

	public GameObject RepairFist;

	public DxxText Text_First;

	public DxxImage Image_Res;

	public ManorStealFlyItem flyItem;

	private ManorBuildingData mbData;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_PlayLevelEffect;

	private static DelegateBridge __Hotfix0_showRepairFirst;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge __Hotfix0_onButtonBubble;

	private static DelegateBridge __Hotfix0_freshRedPoint;

	private static DelegateBridge __Hotfix0_flyStealItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init()
	{
	}

	public void PlayLevelEffect()
	{
	}

	public void showRepairFirst()
	{
	}

	public void onButtonClick()
	{
	}

	public void onButtonBubble()
	{
	}

	public void freshRedPoint()
	{
	}

	public void flyStealItem(ManorStealFlyData mssd)
	{
	}
}
