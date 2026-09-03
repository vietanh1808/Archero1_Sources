using System.Collections.Generic;
using PureMVC.Interfaces;
using Spine.Unity;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ActRedEnvelopeUIPanel : MediatorCtrlBase
{
	public DxxText titleTex;

	public DxxText timeDownTex;

	public DxxText subTitleTex;

	public ButtonCtrl closeBtn;

	public DxxText tokenNumTex1;

	public DxxText tokenNumTex2;

	public Image tokenImage1;

	public Image tokenImage2;

	public ActRedEnvelopeTab[] tabs;

	public Transform Content;

	public ButtonCtrl tipsBtn;

	public GameObject AniObj;

	public SkeletonGraphic skeletonGraphic;

	private int CurIndex;

	private Dictionary<int, ActRedEnvelopePanelBase> panels;

	private string[] PanelPath;

	private ActRedEnvelopePanelBase CurPanel;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_ClickTab;

	private static DelegateBridge __Hotfix0_UpdateTimeDown;

	private static DelegateBridge __Hotfix0_ClosePanel;

	private static DelegateBridge __Hotfix0_ClickInfo;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshtokenNum;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_GetTitleByIndex;

	private static DelegateBridge __Hotfix0_OpenAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public bool ClickTab(int index)
	{
		return false;
	}

	public void UpdateTimeDown(string timeDown)
	{
	}

	public void ClosePanel()
	{
	}

	private void ClickInfo()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void RefreshtokenNum()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void RefreshRed()
	{
	}

	public string GetTitleByIndex(int _index)
	{
		return null;
	}

	public void OpenAni(int type, List<Drop_DropModel.DropData> rewards)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
