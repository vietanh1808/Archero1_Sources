using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;

namespace Activity7thAnniversary
{
	public class Activity7thAnniversaryBattleUICtrl : MediatorCtrlBase
	{
		[CompilerGenerated]
		private sealed class _003COnUpdate_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Activity7thAnniversaryBattleUICtrl _003C_003E4__this;

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
			public _003COnUpdate_003Ed__50(int _003C_003E1__state)
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
		private DxxText _textTitle;

		[SerializeField]
		private DxxText _textStage;

		[SerializeField]
		private DxxText _textBoss;

		[SerializeField]
		private DxxText _textInfo;

		[SerializeField]
		private DxxText _textDrop;

		[SerializeField]
		private DxxText _textHit;

		[SerializeField]
		private DxxText _textTryPlay;

		[SerializeField]
		private DxxText _textBattle;

		[SerializeField]
		private DxxText _textBuy;

		[SerializeField]
		private DxxText _textTimes;

		[SerializeField]
		private DxxText _textTipsTitle;

		[SerializeField]
		private DxxText _textTips;

		[SerializeField]
		private DxxText _textTips2;

		[SerializeField]
		private DxxText _textReset;

		[SerializeField]
		private ButtonCtrl _btnHelp;

		[SerializeField]
		private ButtonCtrl _btnClose;

		[SerializeField]
		private ButtonCtrl _btnTryPlay;

		[SerializeField]
		private ButtonCtrl _btnPlay;

		[SerializeField]
		private ButtonCtrl _btnBuy;

		[SerializeField]
		private ButtonCtrl _btnRank;

		[SerializeField]
		private ButtonCtrl _btnMaxScore;

		[SerializeField]
		private RectTransform _rtStageParent;

		[SerializeField]
		private RectTransform _rtBossParent;

		[SerializeField]
		private RectTransform _rtInfoParent;

		[SerializeField]
		private GameObject _goTips;

		[SerializeField]
		private GameObject _goTips2;

		[SerializeField]
		private InfoItemCtrl _infoItemCopy;

		[SerializeField]
		private ProgressItemCtrl _progressItemCopy;

		[SerializeField]
		private BossItemCtrl _bossItemCopy;

		[SerializeField]
		private PlayInfoCtrl _playInfoCtrl;

		[SerializeField]
		private BuyTimesCtrl _buyTimesCtrl;

		[SerializeField]
		private GameObject _goDropsInfo;

		private LocalUnityObjctPool _pool;

		private Activity7thAnniversaryMgr _mgr;

		private WaitForSeconds _wait;

		private Coroutine _coroutine;

		private bool IsRankRewardPeriod => false;

		private long CD => 0L;

		protected override void OnInit()
		{
		}

		protected override void OnOpen()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		private void UpdateUI()
		{
		}

		private void ShowRankRewardPeriodTip()
		{
		}

		private void UpdateStageInfo()
		{
		}

		private void UpdateStageInfoUI()
		{
		}

		private void CenterStageItem(RectTransform stageItem)
		{
		}

		private void UpdateBossInfoUI()
		{
		}

		private void UpdatePlayInfoUI()
		{
		}

		protected override void OnClose()
		{
		}

		public override void OnLanguageChange()
		{
		}

		[IteratorStateMachine(typeof(_003COnUpdate_003Ed__50))]
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
