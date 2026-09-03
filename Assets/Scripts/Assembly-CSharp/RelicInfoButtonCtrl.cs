using UnityEngine;
using UnityEngine.UI;

public class RelicInfoButtonCtrl : MonoBehaviour
{
	public enum BtnType
	{
		evolution = 0,
		forge = 1,
		star = 2
	}

	private BtnType curBtnType;

	private LocalSave.EquipOne mRelicOne;

	public DxxText txt_maxTip;

	public RedNodeCtrl redNodeCtrl;

	public PropOneEquip propOneCtrl;

	public Image img_icon;

	public Slider slider;

	public DxxText txt_progress;

	public DxxText txt_btnName;

	public ButtonCtrl btn_do;

	protected string Tag => null;

	public void RefreshUI(BtnType btnType, LocalSave.EquipOne relicOne)
	{
	}

	private void refreshTxtMaxTip()
	{
	}

	private void refreshSlider()
	{
	}

	private void refreshRedNode()
	{
	}

	private void refreshPropOneCtrl()
	{
	}

	private string getBtnKey()
	{
		return null;
	}

	private int getHaveNum()
	{
		return 0;
	}

	private int getNeedNum()
	{
		return 0;
	}
}
