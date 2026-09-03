using System;
using System.Collections.Generic;
using Activity;
using PureMVC.Interfaces;
using UnityEngine;

public class NewActiveBpUICtrl : MediatorCtrlBase, IActivityUI
{
	[SerializeField]
	private ButtonCtrl btnActivityBp;

	[SerializeField]
	private ButtonCtrl btnCheckBp;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private PanelBase activityPanel;

	[SerializeField]
	private PanelBase checkPanel;

	[SerializeField]
	private GameObject goActSelected;

	[SerializeField]
	private GameObject goCheckSelected;

	[SerializeField]
	private GameObject goBottomTab;

	[SerializeField]
	private GameObject goActiveRed;

	[SerializeField]
	private GameObject goCheckRed;

	private List<Tab> openTabs;

	private Tab _currentTab;

	public WindowID windowID => WindowID.WindowID_Invaild;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnBtnTabClick(Tab tabType)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void SetOpenTabs()
	{
	}

	public void OpenPopPanel(string title, string content, Action onClose = null)
	{
	}

	public void SetGlobalButtons(bool enabled)
	{
	}

	public void RefreshUI()
	{
	}

	public void SetStyle(ActivityMgr.Event curEvent)
	{
	}

	public RectTransform GetPanelRoot()
	{
		return null;
	}

	public T GetPop<T>(string path) where T : Component
	{
		return null;
	}

	public void OnCLoseBtnClick()
	{
	}
}
