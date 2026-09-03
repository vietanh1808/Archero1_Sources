using UnityEngine;
using XLua;

public class EquipCombineKeyAll : MonoBehaviour
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Sure;

	public DxxText Text_Sure;

	public DxxText Text_Title;

	public DxxText[] Text_Line;

	public GameObject[] ChoosedFlag;

	public int[] choosed;

	private EquipCombineCtrl combineCtrl;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonChoose;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonSure;

	private static DelegateBridge __Hotfix0_freshButtonState;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Awake()
	{
	}

	public void init(EquipCombineCtrl ui)
	{
	}

	public void onButtonChoose(int index)
	{
	}

	public void onButtonClose()
	{
	}

	public void onButtonSure()
	{
	}

	private void freshButtonState()
	{
	}
}
