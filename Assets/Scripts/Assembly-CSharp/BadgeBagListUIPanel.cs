using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class BadgeBagListUIPanel : MediatorCtrlBase, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	[CompilerGenerated]
	private sealed class _003CfreshUI_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BadgeBagListUIPanel _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CfreshUI_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private ButtonCtrl Button_Close;

	[SerializeField]
	private ButtonCtrl Button_AttrTotal;

	[SerializeField]
	private ButtonCtrl Button_Info;

	[SerializeField]
	private BadgeTagItem tagItem;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private BadgeBagItem cellItem;

	[SerializeField]
	private ButtonCtrl Button_Reward;

	[SerializeField]
	private DxxText Text_RewardGet;

	private List<BadgeBagItemData> dataList;

	private BadgeTagItemData _curTagItemData;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CfreshUI_003Ed__13))]
	private IEnumerator freshUI()
	{
		return null;
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

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	public void RefreshUI()
	{
	}

	private void onButtonAttrTotal()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonReward()
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView tableView)
	{
		return 0;
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}
}
