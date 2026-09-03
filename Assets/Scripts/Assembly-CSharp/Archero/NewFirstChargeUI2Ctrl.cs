using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Archero
{
	public class NewFirstChargeUI2Ctrl : MediatorCtrlBase
	{
		[CompilerGenerated]
		private sealed class _003CCountdown_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewFirstChargeUI2Ctrl _003C_003E4__this;

			public int actIndex;

			public long time;

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
			public _003CCountdown_003Ed__35(int _003C_003E1__state)
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
		private ButtonCtrl[] _CloseBtn;

		[SerializeField]
		private GameObject _ItemOne;

		[SerializeField]
		private Transform[] _ItemParents;

		[SerializeField]
		private DxxText[] _DayFocusTxts;

		[SerializeField]
		private GameObject[] _Contents;

		[SerializeField]
		private GameObject[] _TabButtons;

		[SerializeField]
		private GameObject[] _TabGOs;

		[SerializeField]
		private DxxText[] _TitleTxt;

		[SerializeField]
		private DxxText[] _DescTxt;

		[SerializeField]
		private DxxText[] _TipTxt;

		[SerializeField]
		private ButtonCtrl[] _GetBtn;

		[SerializeField]
		private DxxText[] _BtnTxt;

		[SerializeField]
		private Image[] _BtnImg;

		[SerializeField]
		private DxxText[] _TabTxts;

		[SerializeField]
		private RedNodeCtrl[] _TabRedCtrls;

		[SerializeField]
		private DxxImage[] _HeadImg;

		[SerializeField]
		private DxxText[] _DiscountValueTxts;

		[SerializeField]
		private Image[] _TitleImgs;

		[SerializeField]
		private HorizontalLayoutGroup[] _Reward1Layouts;

		private LocalUnityObjctPool mPool;

		private int _CurTab;

		private bool _IsBuyTimeOver;

		private WaitForSeconds[] waits;

		private Coroutine[] m_Coroutines;

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

		public override void OnHandleNotification(INotification notification)
		{
		}

		private void _OnCloseBtnClicked()
		{
		}

		private bool CanShowTab(int actIndex)
		{
			return false;
		}

		private void _Refresh()
		{
		}

		private void _Refresh(int actIndex)
		{
		}

		private void _InitRewards(int[][] rewards, Transform parent, bool isReviced, bool bBig)
		{
		}

		public void _OnButtonTab(int tab)
		{
		}

		[IteratorStateMachine(typeof(_003CCountdown_003Ed__35))]
		private IEnumerator Countdown(int actIndex, long time)
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
