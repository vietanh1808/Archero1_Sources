using System.Collections.Generic;
using UnityEngine;

public class SailingShipPartItemChangeUIPanel : MediatorCtrlBase
{
	public Transform skinAttParent;

	public Transform skinParent;

	public DxxFitContentText attItem;

	public DxxText titleText;

	public DxxText attTitleText;

	public DxxText partName;

	public DxxText partDesc;

	public DxxText partPower;

	public DxxText changeBtnTxt;

	public GameObject go_Power;

	public SailingShipPartInfoOne propShow;

	public ButtonCtrl changeBtn;

	public ButtonCtrl closeBtn;

	private LocalUnityObjctPool pool;

	private SailingShipPartItemData _crtData;

	private List<SailingShipPartInfoOne> _skinList;

	private int selectID;

	private List<SailingShipPartSkinItemData> CrtSkinData => null;

	private List<SailingShipPartSkinItemData> CrtLockSkinData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitSkinList()
	{
	}

	private void OnSkinItemClicked(int skinID)
	{
	}

	private void RefreshPartInfo()
	{
	}

	private void RefreshSkinAtt()
	{
	}

	private void Esc()
	{
	}

	public void OnCloseBtnClicked()
	{
	}

	public void OnBtnChangeClicked()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
