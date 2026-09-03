using UnityEngine;

public class VipPrivilegeTipsUIPanel : MediatorCtrlBase
{
	public DxxText txtTitle;

	public DxxText txtCampTips;

	public ButtonCtrl btnClose;

	public VipGiftTipsItem crtItem;

	public VipGiftTipsItem nextItem;

	public GameObject goArrow;

	public GameObject[] bgArray;

	public GameObject[] titleArray;

	private VipPrivilegeType _crtType;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshBg()
	{
	}

	private void RefreshVipItems()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void OnCloseBtnClicked()
	{
	}
}
