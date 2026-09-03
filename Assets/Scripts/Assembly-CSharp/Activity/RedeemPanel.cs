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
	public class RedeemPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003CNextFrame_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RedeemPanel _003C_003E4__this;

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
			public _003CNextFrame_003Ed__31(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTick_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RedeemPanel _003C_003E4__this;

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
			public _003CTick_003Ed__37(int _003C_003E1__state)
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
		private DxxText txtItemCount;

		[SerializeField]
		private DxxText txtItemCount2;

		[SerializeField]
		private DxxText txtDiamondCount;

		[SerializeField]
		private DxxText txtTime;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtPopTitle;

		[SerializeField]
		private DxxText txtPopContent;

		[SerializeField]
		private ShrinkDxxText txtDesc2;

		[SerializeField]
		private RectTransform rtContent;

		[SerializeField]
		private ScrollRect sr;

		[SerializeField]
		private DxxImage imgBgPanel;

		[SerializeField]
		private DxxImage imgBgPop;

		[SerializeField]
		private DxxImage imgBgPopText;

		[SerializeField]
		private DxxImage imgIcon1;

		[SerializeField]
		private DxxImage imgIcon2;

		[SerializeField]
		private DxxImage[] imgItemBgs;

		[SerializeField]
		private ButtonCtrl btnInfo;

		[SerializeField]
		private ButtonCtrl btnCloseInfo;

		[SerializeField]
		private ButtonCtrl btnBG;

		[SerializeField]
		private GameObject goPop;

		[SerializeField]
		private RedeemPanelStyle[] styles;

		private RedeemPanelStyle curStyle;

		private ActivityMgr.Event curEvent;

		private CRespActivityExchange data;

		[SerializeField]
		private RedeemItem template;

		[SerializeField]
		private RectTransform currencyTrans;

		private LocalUnityObjctPool pool;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_GetCurEvent;

		private static DelegateBridge __Hotfix0_NextFrame;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge _c__Hotfix0_ctor;

		public override void Init(IActivityUI activityUI)
		{
		}

		public override void Open()
		{
		}

		private ActivityMgr.Event GetCurEvent()
		{
			return ActivityMgr.Event.None_CheckIn;
		}

		[IteratorStateMachine(typeof(_003CNextFrame_003Ed__31))]
		private IEnumerator NextFrame()
		{
			return null;
		}

		public override void Close()
		{
		}

		private void OnDisable()
		{
		}

		public override void Refresh()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__37))]
		private IEnumerator Tick()
		{
			return null;
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

		private void _003C_003ExLuaBaseProxy_Refresh()
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
