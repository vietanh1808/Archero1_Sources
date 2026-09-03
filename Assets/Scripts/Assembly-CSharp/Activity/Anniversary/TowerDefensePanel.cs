using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UIKit;
using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class TowerDefensePanel : PanelBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TowerDefensePanel _003C_003E4__this;

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
			public _003CTick_003Ed__16(int _003C_003E1__state)
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
		private DxxText txtCountDownEnd;

		[SerializeField]
		private DxxText txtCountdownOpen;

		[SerializeField]
		private DxxText txtCountDownDesc;

		[SerializeField]
		private GameObject goPreviewRoot;

		[SerializeField]
		private GameObject goContentRoot;

		[SerializeField]
		private UITableView tableView;

		[SerializeField]
		private TDLevelItem itemTemplate;

		[SerializeField]
		private ButtonCtrl btnInfo;

		private Coroutine coroutine;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnBtnInfoClick;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_ShowRewards;

		private static DelegateBridge __Hotfix0_ShowLevelDetail;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix1_Refresh;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

		private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

		private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

		private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

		private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

		private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

		private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnBtnInfoClick()
		{
		}

		public override void Open()
		{
		}

		public void ShowRewards(int index, Transform anchor)
		{
		}

		public void ShowLevelDetail(int index)
		{
		}

		private void Refresh(bool init)
		{
		}

		public override void Refresh()
		{
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__16))]
		private IEnumerator Tick()
		{
			return null;
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

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Refresh()
		{
		}
	}
}
