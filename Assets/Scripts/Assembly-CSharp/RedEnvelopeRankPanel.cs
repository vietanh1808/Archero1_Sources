using System;
using System.Runtime.CompilerServices;
using GameProtocol;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using XLua;

public class RedEnvelopeRankPanel : ActRedEnvelopePanelBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public UITableView tableView;

	[CompilerGenerated]
	private new Action<string> m_UpdateTimeDown;

	[CompilerGenerated]
	private new Action m_RefreshTokenNum;

	public RedEnvelopeRankItem itemObj;

	public RedEnvelopeRankItem selfObj;

	private CRedpacketRank[] dataList;

	private long showTimex;

	private static DelegateBridge __Hotfix0_add_UpdateTimeDown;

	private static DelegateBridge __Hotfix0_remove_UpdateTimeDown;

	private static DelegateBridge __Hotfix0_add_RefreshTokenNum;

	private static DelegateBridge __Hotfix0_remove_RefreshTokenNum;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge __Hotfix0_get_timeDownColor;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_UpdateTime;

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

	private void Refresh(CRespActivityRedpacketRank data)
	{
	}

	public override void Close()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	private void freshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
