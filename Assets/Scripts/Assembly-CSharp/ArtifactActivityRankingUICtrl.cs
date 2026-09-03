using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UIKit;
using UnityEngine;

public class ArtifactActivityRankingUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003COnUpdate_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ArtifactActivityRankingUICtrl _003C_003E4__this;

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
		public _003COnUpdate_003Ed__23(int _003C_003E1__state)
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
	private ButtonCtrl _btnClose;

	[SerializeField]
	private ButtonCtrl _btnTips;

	[SerializeField]
	private DxxText _textCd;

	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private ArtifactActivityRankingItem _self;

	[SerializeField]
	private ArtifactActivityRankingItem _copyOne;

	[SerializeField]
	private UITableView _tableView;

	[SerializeField]
	private ArtifactActivityTipsUICtrl _artifactActivityTips;

	private LocalUnityObjctPool _pool;

	private Coroutine _coroutine;

	private WaitForSeconds _wait;

	private ArtifactActivityManager _manager;

	private long CD => 0L;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
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

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003COnUpdate_003Ed__23))]
	private IEnumerator OnUpdate()
	{
		return null;
	}

	private void UpdateCdText()
	{
	}

	private void CheckWait()
	{
	}

	private void InitTableView()
	{
	}
}
