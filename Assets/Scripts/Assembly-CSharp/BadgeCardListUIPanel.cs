using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class BadgeCardListUIPanel : MediatorCtrlBase, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	[CompilerGenerated]
	private sealed class _003CfreshUI_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BadgeCardListUIPanel _003C_003E4__this;

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
		public _003CfreshUI_003Ed__26(int _003C_003E1__state)
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
	private GameObject UpObj;

	[SerializeField]
	private Image Image_Card;

	[SerializeField]
	private Image Image_BagQuality;

	[SerializeField]
	private DxxText Text_Reward;

	[SerializeField]
	private Image Image_Progress;

	[SerializeField]
	private DxxText Text_Progress;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private BadgeCardItem cellItem;

	[SerializeField]
	private ButtonCtrl Button_Reward;

	[SerializeField]
	private DxxText Text_RewardGet;

	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	private List<BadgeCardItemData> dataList;

	private BadgeBagItemData _curBagItemData;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}

	private void onButtonReward()
	{
	}

	[IteratorStateMachine(typeof(_003CfreshUI_003Ed__26))]
	private IEnumerator freshUI()
	{
		return null;
	}

	public void RefreshUI()
	{
	}

	private void initTop()
	{
	}

	private void refreshReward()
	{
	}

	public void onButtonUp()
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
