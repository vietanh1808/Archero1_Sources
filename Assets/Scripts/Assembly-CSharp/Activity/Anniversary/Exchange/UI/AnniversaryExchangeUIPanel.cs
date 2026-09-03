using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Activity.Anniversary.Exchange.Data;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using XLua;

namespace Activity.Anniversary.Exchange.UI
{
	public class AnniversaryExchangeUIPanel : PanelBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
	{
		[CompilerGenerated]
		private sealed class _003CCountDown_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnniversaryExchangeUIPanel _003C_003E4__this;

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
			public _003CCountDown_003Ed__37(int _003C_003E1__state)
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
		private AnniversaryExchangeRewardExtraItem rewardExtraItem;

		[SerializeField]
		private AnniversaryExchangeRewardItem rewardItem;

		[SerializeField]
		private UITableView tableView;

		[SerializeField]
		private AnniversaryExchangeScrollAni scrollAni;

		[SerializeField]
		private AnniversaryExchangeProgress progress;

		[SerializeField]
		private GameObject openObj;

		[SerializeField]
		private GameObject preOpenObj;

		[SerializeField]
		private DxxText openCountDown;

		[SerializeField]
		private DxxText openTip;

		[SerializeField]
		private ButtonCtrl bubbleBtn;

		[SerializeField]
		private DxxText countDown;

		[SerializeField]
		private GameObject countDownContent;

		private Coroutine coroutineCountDown;

		private WaitForSeconds wait;

		private Action<string> countDownAction;

		private AnniversaryExchangeRewardExtraItem extraItem;

		private static DelegateBridge __Hotfix0_get_IsExtraReward;

		private static DelegateBridge __Hotfix0_get_ExchangeManager;

		private static DelegateBridge __Hotfix0_get_ExchangeData;

		private static DelegateBridge __Hotfix0_get_ExchangeRewardData;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_RefreshStatus;

		private static DelegateBridge __Hotfix0_RefreshOpen;

		private static DelegateBridge __Hotfix0_RefreshPreOpen;

		private static DelegateBridge __Hotfix0_RefreshBubbleBtn;

		private static DelegateBridge __Hotfix0_RefreshScroll;

		private static DelegateBridge __Hotfix0_RefreshProgress;

		private static DelegateBridge __Hotfix0_PlayAni;

		private static DelegateBridge __Hotfix0_StopAni;

		private static DelegateBridge __Hotfix0_InitTableView;

		private static DelegateBridge __Hotfix0_CountDown;

		private static DelegateBridge __Hotfix0_RefreshTime;

		private static DelegateBridge __Hotfix0_RefreshLeftTime;

		private static DelegateBridge __Hotfix0_RefreshPreOpenLeftTime;

		private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

		private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

		private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

		private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

		private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

		private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

		private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_ShowTip;

		private static DelegateBridge _c__Hotfix0_ctor;

		private Func<int, bool> IsExtraReward => null;

		private ExchangeManager ExchangeManager => null;

		private ExchangeData ExchangeData => null;

		private ExchangeRewardData ExchangeRewardData => null;

		public override void Init(IActivityUI ctrl)
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		public override void OnLanguageChange()
		{
		}

		private void RefreshStatus()
		{
		}

		private void RefreshOpen()
		{
		}

		private void RefreshPreOpen()
		{
		}

		private void RefreshBubbleBtn()
		{
		}

		private void RefreshScroll()
		{
		}

		private void RefreshProgress()
		{
		}

		private void PlayAni()
		{
		}

		private void StopAni()
		{
		}

		private void InitTableView()
		{
		}

		[IteratorStateMachine(typeof(_003CCountDown_003Ed__37))]
		private IEnumerator CountDown()
		{
			return null;
		}

		private void RefreshTime()
		{
		}

		private void RefreshLeftTime()
		{
		}

		private void RefreshPreOpenLeftTime()
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

		public override void OnHandleNotification(INotification notification)
		{
		}

		private void ShowTip()
		{
		}

		private void _003C_003ExLuaBaseProxy_Init(IActivityUI P0)
		{
		}

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Close()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnLanguageChange()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}
	}
}
