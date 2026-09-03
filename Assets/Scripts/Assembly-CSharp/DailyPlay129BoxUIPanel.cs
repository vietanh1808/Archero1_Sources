using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine.UI;

public class DailyPlay129BoxUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003CscrollToChoosed_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyPlay129BoxUIPanel _003C_003E4__this;

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
		public _003CscrollToChoosed_003Ed__26(int _003C_003E1__state)
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

	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Box;

	public DxxText Text_Info;

	public Slider slider;

	public DxxText Text_Progress;

	public ButtonCtrl Button_BoxGet;

	public DxxText Text_BoxGet;

	public DxxText Text_BoxGetCount;

	public DxxText Text_Have;

	public DxxText Text_BottomTips;

	private bool canBoxGetScore;

	private bool canBoxGetCount;

	public UITableView tableView;

	public DailyPlay129BoxItem itemCell;

	private List<DailyPlay129BoxItemData> dataList;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnClose()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonBoxGet()
	{
	}

	private void onButtonBox()
	{
	}

	private void initUI()
	{
	}

	private void initTop()
	{
	}

	private void initBottom()
	{
	}

	[IteratorStateMachine(typeof(_003CscrollToChoosed_003Ed__26))]
	private IEnumerator scrollToChoosed()
	{
		return null;
	}

	private void freshTime()
	{
	}

	private void initTableView()
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
}
