using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UIKit;
using UnityEngine;

namespace Activity7thAnniversary
{
	public class Activity7thAnniversaryRankUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
	{
		[CompilerGenerated]
		private sealed class _003COnUpdate_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Activity7thAnniversaryRankUICtrl _003C_003E4__this;

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
			public _003COnUpdate_003Ed__36(int _003C_003E1__state)
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
		private DxxText title;

		[SerializeField]
		private DxxText countDown;

		[SerializeField]
		private DxxText areaName;

		[SerializeField]
		private DxxText noneText;

		[SerializeField]
		private DxxText TabText1;

		[SerializeField]
		private DxxText TabText2;

		[SerializeField]
		private DxxText RewardText;

		[SerializeField]
		private ButtonCtrl closeBtn;

		[SerializeField]
		private ButtonCtrl infoBtn;

		[SerializeField]
		private ButtonCtrl _btnReward;

		[SerializeField]
		private RankPersonalItem _copy;

		[SerializeField]
		private RankPersonalItem selfItem;

		[SerializeField]
		private GameObject[] Tab_BottomFocus;

		[SerializeField]
		private List<RankCharItem> TopThreeList;

		[SerializeField]
		private UITableView tableView;

		[SerializeField]
		private PlayInfoCtrl _playInfoCtrl;

		[SerializeField]
		private RankDamagesInfoCtrl _rankDamagesInfoCtrl;

		private int _curTab;

		private Activity7thAnniversaryMgr _mgr;

		private WaitForSeconds _wait;

		private Coroutine _coroutine;

		private RankingItemData[] _rankData;

		private long CD => 0L;

		private long EndTime => 0L;

		private string lanKey => null;

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

		public void OnClickTab(int index)
		{
		}

		private void OnClickInfoBtn(RankingItemData data, Vector3 pos)
		{
		}

		private void InitTableView()
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

		[IteratorStateMachine(typeof(_003COnUpdate_003Ed__36))]
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
	}
}
