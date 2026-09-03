using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class BPPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BPPanel _003C_003E4__this;

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
			public _003CTick_003Ed__49(int _003C_003E1__state)
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
		private ButtonCtrl btnSubscribePremium;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTime;

		[SerializeField]
		private DxxText txtBtnSubscribe;

		[SerializeField]
		private DxxText txtBtnSubscribeDiamond;

		[SerializeField]
		private DxxText txtCurActiveVal;

		[SerializeField]
		private DxxText txtCurCheckIn;

		[SerializeField]
		private DxxText txtFreeDesc;

		[SerializeField]
		private DxxText hasBuyText;

		[SerializeField]
		private DxxText txtActiveLv;

		[SerializeField]
		private DxxText txtActiveMaxLvTips;

		[SerializeField]
		private DxxImage imgBar;

		[SerializeField]
		private GameObject propOneTemplate;

		[SerializeField]
		private GameObject goCurActiveRoot;

		[SerializeField]
		private GameObject goBtnSubscribe;

		[SerializeField]
		private GameObject goBtnSubscribeDiamond;

		[SerializeField]
		private GameObject goLockTemplate;

		[SerializeField]
		private GameObject goGotTemplate;

		[SerializeField]
		private GameObject goCanGetTemplate;

		[SerializeField]
		private BPInfinity infinity;

		[SerializeField]
		private BPDetailPanel bpDetail;

		[SerializeField]
		private ushort type;

		[SerializeField]
		private BPPanelStyle[] styles;

		[SerializeField]
		private RectTransform bgProgress;

		[SerializeField]
		private Slider activeLvProgress;

		[SerializeField]
		private GameObject goActiveLv;

		[SerializeField]
		private GameObject goCrit;

		[SerializeField]
		private DxxText txtCritContent;

		[SerializeField]
		private DxxText txtCritValue;

		private LocalUnityObjctPool pool;

		private BPPanelStyle curStyle;

		public ButtonCtrl Button_Star;

		public DxxText Text_Star;

		private const int TimeInterval = 5;

		private float m_fTime;

		private bool updatingInfo;

		private ActivityMgr.Event curEvent;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_OnBtnSubscribeClick;

		private static DelegateBridge __Hotfix0_onButtonStar;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_ScrollAtTarget;

		private static DelegateBridge __Hotfix0_GetCurEvent;

		private static DelegateBridge __Hotfix0_SetBackground;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_Escape;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge __Hotfix0_ShowDetail;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge _c__Hotfix0_ctor;

		public override void Init(IActivityUI activityUI)
		{
		}

		private void OnBtnSubscribeClick()
		{
		}

		private void onButtonStar()
		{
		}

		public override void Open()
		{
		}

		private void ScrollAtTarget()
		{
		}

		private ActivityMgr.Event GetCurEvent()
		{
			return ActivityMgr.Event.None_CheckIn;
		}

		private void SetBackground()
		{
		}

		public override void Close()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public override void Refresh()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		public override bool Escape()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__49))]
		private IEnumerator Tick()
		{
			return null;
		}

		private void ShowDetail()
		{
		}

		private void SetStyle()
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
