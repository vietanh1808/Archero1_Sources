using System;
using System.Runtime.CompilerServices;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class RedEnvelopePanel : ActRedEnvelopePanelBase
{
	public static bool isSkipAni;

	public RedEnvelopeList redEnvelopeList;

	public RectTransform itemContent;

	public RectTransform view;

	public DxxText descTex;

	public ButtonCtrl filterBtn;

	public GameObject filterClickObj;

	public GameObject filterUnClickObj;

	public IssueRedEnvelopeItem issueRedEnvelopeItem1;

	public IssueRedEnvelopeItem issueRedEnvelopeItem2;

	public IssueRedEnvelopPanel issueRedEnvelopPanel;

	public ShowRedEnvelopePanel showRedEnvelopePanel;

	[SerializeField]
	private Toggle toggle_SkipAni;

	[SerializeField]
	private DxxText text_SkipAni;

	private float reqCd;

	private long lastReqTime;

	private long showTimex;

	[CompilerGenerated]
	private new Action<string> m_UpdateTimeDown;

	[CompilerGenerated]
	private new Action m_RefreshTokenNum;

	private static DelegateBridge __Hotfix0_get_timeDownColor;

	private static DelegateBridge __Hotfix0_add_UpdateTimeDown;

	private static DelegateBridge __Hotfix0_remove_UpdateTimeDown;

	private static DelegateBridge __Hotfix0_add_RefreshTokenNum;

	private static DelegateBridge __Hotfix0_remove_RefreshTokenNum;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_IssueCallBack;

	private static DelegateBridge __Hotfix0_OpenRedShowPanel;

	private static DelegateBridge __Hotfix0_ClickIssueRedEnvelope;

	private static DelegateBridge __Hotfix0_OnValueChange;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge _c__Hotfix0_ctor;

	public override Color timeDownColor => default;

	public override event Action<string> UpdateTimeDown
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override event Action RefreshTokenNum
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void Init()
	{
	}

	public override void Open()
	{
	}

	public override void Close()
	{
	}

	private void Refresh()
	{
	}

	private void IssueCallBack()
	{
	}

	private void OpenRedShowPanel(CRespActivityRedpacketDetail data)
	{
	}

	private void ClickIssueRedEnvelope(ActRedEnvelopeMgr.RedEnvelopeItem red)
	{
	}

	public void OnValueChange(Vector2 pos)
	{
	}

	private void freshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
