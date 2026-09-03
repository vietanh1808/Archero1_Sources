using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act6thBPUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003CCheckPos_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Act6thBPUIPanel _003C_003E4__this;

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
		public _003CCheckPos_003Ed__33(int _003C_003E1__state)
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

	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public DxxText Text_Level;

	public DxxText Text_Progress;

	public Slider slider;

	public ButtonCtrl Button_Normal;

	public DxxText Text_Free;

	public DxxText Text_Normal;

	public RectTransform rectBox;

	[Header("最终宝箱")]
	public DxxText txtExtraTitle;

	public DxxText txtExtraContent;

	public DxxText txtExtraCount;

	public DxxText txtExtraGet;

	public BattlePass_BigPropOne extraProp;

	public BattlePassChestInformation chestInfo;

	private int currentLevel;

	private long showTimex;

	public UITableView tableView;

	[HideInInspector]
	public int dataCount;

	public Act6thBPItemCell cellItem;

	private RectTransform rectBuyItem;

	private bool isInitBox;

	private Act6thManager AMgr => null;

	private Act6thBpExtraData _extraData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public void RefreshExtraBox()
	{
	}

	public void OnClickedExtraBox(PropOneBase prop, object obj)
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onButtonOpenNormal()
	{
	}

	public void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckPos_003Ed__33))]
	private IEnumerator CheckPos()
	{
		return null;
	}

	private void RefreshLevel()
	{
	}

	private void freshTime()
	{
	}

	public int checkScorllTo()
	{
		return 0;
	}

	public void initTableView()
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
