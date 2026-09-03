using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class PrizeWheelPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PrizeWheelPanel _003C_003E4__this;

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
			public _003CTick_003Ed__46(int _003C_003E1__state)
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
		private ButtonCtrl btnSpin;

		[SerializeField]
		private ButtonCtrl btnTask;

		[SerializeField]
		private ButtonCtrl btnNext;

		[SerializeField]
		private DxxText txtBtnSpin;

		[SerializeField]
		private DxxText txtBtnTicketCount;

		[SerializeField]
		private DxxText txtBtnFree;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTime;

		[SerializeField]
		private DxxText txtInfo;

		[SerializeField]
		private DxxText txtInfo2;

		[SerializeField]
		private DxxText txtHintNext;

		[SerializeField]
		private DxxText txtMatPreviewCount;

		[SerializeField]
		private DxxText txtBtnTask;

		[SerializeField]
		private DxxText txtBtnNextRound;

		[SerializeField]
		private SpinWheel sw;

		[SerializeField]
		private PropOneEquip[] items;

		[SerializeField]
		private GameObject[] goTicks;

		[SerializeField]
		private GameObject goTxtFree;

		[SerializeField]
		private GameObject goTxtPrice;

		[SerializeField]
		private GameObject goMaterial;

		[SerializeField]
		private Image imgMaterial;

		[SerializeField]
		private DxxText[] txtLeftTimes;

		[SerializeField]
		private ParticleSystem spinEffect;

		[SerializeField]
		private ParticleSystem finishEffect;

		[SerializeField]
		private DxxImage imgMatPreview;

		[SerializeField]
		private DxxImage imgBg;

		[SerializeField]
		private DxxImage imgSpin;

		[SerializeField]
		private DxxImage imgBar;

		[SerializeField]
		private DxxImage imgKv;

		[Header("额外奖励")]
		[SerializeField]
		private ButtonCtrl mExtraBoxBtn;

		[SerializeField]
		private RedNodeCtrl mExtraBoxRedNode;

		[SerializeField]
		private PrizeWheelExtraTips mPrizeWheelExtraTips;

		[SerializeField]
		private DxxText mTextExtraBoxProgress;

		[Header("任务")]
		[SerializeField]
		private ButtonCtrl mRewardPreviewBtn;

		[SerializeField]
		private RewardPreviewPanel mRewardPreviewPanel;

		[SerializeField]
		private DxxText mRewardPreviewBtnText;

		[SerializeField]
		private PrizeWheelTaskPanel taskPanel;

		[SerializeField]
		private RedNodeCtrl redNodeTask;

		[SerializeField]
		private DxxImage imgIconTicket;

		[SerializeField]
		private PrizeWheelPanelStyle[] styles;

		[SerializeField]
		private Button maskButton;

		private const int itemCount = 6;

		private PrizeWheelPanelStyle curStyle;

		private bool spinning;

		private static DelegateBridge __Hotfix0_get_ticketCount;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnClickBoxBtn;

		private static DelegateBridge __Hotfix0_OnClickRewardPreviewBt;

		private static DelegateBridge __Hotfix0_OnBtnSpinClick;

		private static DelegateBridge __Hotfix0_OnBtnNextClick;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_RefreshStyle;

		private static DelegateBridge __Hotfix0_RefreshChancesAndCost;

		private static DelegateBridge __Hotfix0_RefreshPreviews;

		private static DelegateBridge __Hotfix0_Spin;

		private static DelegateBridge __Hotfix0_DoSpinWheel;

		private static DelegateBridge __Hotfix0_GetItemAnglePos;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_Escape;

		private static DelegateBridge _c__Hotfix0_ctor;

		private long ticketCount => 0L;

		public override void Open()
		{
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__46))]
		private IEnumerator Tick()
		{
			return null;
		}

		public override void Init(IActivityUI activityUI)
		{
		}

		public override void Close()
		{
		}

		private void OnClickBoxBtn()
		{
		}

		private void OnClickRewardPreviewBt()
		{
		}

		private void OnBtnSpinClick()
		{
		}

		private void OnBtnNextClick()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public override void Refresh()
		{
		}

		private void RefreshStyle()
		{
		}

		private void RefreshChancesAndCost()
		{
		}

		private void RefreshPreviews()
		{
		}

		private void Spin()
		{
		}

		private void DoSpinWheel(CRewardItem[] rewards)
		{
		}

		private float GetItemAnglePos(int index)
		{
			return 0f;
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		public override bool Escape()
		{
			return false;
		}

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Init(IActivityUI P0)
		{
		}

		private void _003C_003ExLuaBaseProxy_Close()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnLanguageChange()
		{
		}

		private void _003C_003ExLuaBaseProxy_Refresh()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}

		private bool _003C_003ExLuaBaseProxy_Escape()
		{
			return false;
		}
	}
}
