using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorStealQuickItem : MonoBehaviour
{
	public Image Image_Icon;

	public DxxText Text_Percent;

	public DxxText Text_Count;

	public GameObject Check;

	public GameObject Mask;

	public Button button;

	private ManorStealItemData data;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(ManorStealItemData data)
	{
	}

	public void onButtonClick()
	{
	}
}
