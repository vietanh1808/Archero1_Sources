using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class ManorShopUIPanel : ManorPanelBase
{
	[CompilerGenerated]
	private sealed class _003CTick_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManorShopUIPanel _003C_003E4__this;

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
		public _003CTick_003Ed__13(int _003C_003E1__state)
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

	public ScrollRectBase scroll;

	public ButtonCtrl btn_InfoBtn;

	public ManorShopItem template;

	public RectTransform CtParent;

	public GameObject go_TimeTitle;

	public DxxText text_Time;

	public DxxText text_Preview;

	private LocalUnityObjctPool pool;

	private Coroutine ticker;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_Tick;

	private static DelegateBridge __Hotfix0_RefreshCountdown;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public override void OnInit()
	{
	}

	public override void Open()
	{
	}

	public void Refresh()
	{
	}

	[IteratorStateMachine(typeof(_003CTick_003Ed__13))]
	public IEnumerator Tick()
	{
		return null;
	}

	private void RefreshCountdown()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_Open()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
