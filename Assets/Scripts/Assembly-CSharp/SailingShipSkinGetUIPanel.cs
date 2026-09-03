using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class SailingShipSkinGetUIPanel : MediatorCtrlBase
{
	public DxxText titleTex;

	public DxxImage skinIcon;

	public DxxText nameTex;

	public DxxText timeTex;

	public ButtonCtrl buttonWear;

	public ButtonCtrl buttonSkin;

	public DxxText buttonWearTex;

	public DxxText buttonSkinTex;

	public DxxText closeText;

	public DxxText skinAttItem;

	public RectTransform rectAttParent;

	private int skinID;

	private LocalUnityObjctPool _pool;

	private SailingShipPartSkinItemData _crtSkinData;

	private ShipBattle_ShipSkinPart _skinPartConfig;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshAtt()
	{
	}

	private void RefreshAttWithoutData()
	{
	}

	public void OnBtnCloseClicked()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnBtnWearClicked()
	{
	}

	private void OnBtnShipSkinClicked()
	{
	}
}
