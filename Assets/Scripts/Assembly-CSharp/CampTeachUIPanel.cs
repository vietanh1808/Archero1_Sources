using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class CampTeachUIPanel : MediatorCtrlBase
{
	public CampTeachTabCtrl tabItem;

	public DxxText Text_Title;

	public DxxFitContentText Text_Desc;

	public DxxImage Image_Kv;

	public ButtonCtrl Btn_Close;

	public ButtonCtrl Btn_Left;

	public ButtonCtrl Btn_Right;

	public RectTransform rect_TabParent;

	private LocalUnityObjctPool _pool;

	private int _crtTabIndex;

	private List<CampTeachTabCtrl> _tabList;

	private int TabCount => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshList()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void onButtonClose()
	{
	}

	public void onButtonCloseWindow()
	{
	}

	private void RefreshUI()
	{
	}

	private void OnBtnTabClick(int index)
	{
	}
}
