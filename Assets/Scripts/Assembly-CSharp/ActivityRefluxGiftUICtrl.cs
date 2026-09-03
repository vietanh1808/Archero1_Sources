using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class ActivityRefluxGiftUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActivityRefluxGiftUICtrl _003C_003E4__this;

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
		public _003CCountdown_003Ed__21(int _003C_003E1__state)
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

	public DxxText titleTex;

	public DxxText remainTex;

	public DxxText descTex;

	public ButtonCtrl closeBtn;

	public RefluxGiftScrollPart scrollPart;

	public RefluxGiftItem showBigItem;

	public GameObject normalCopyObj;

	public GameObject advanceCopyObj;

	public RectTransform view;

	public RectTransform itemParent;

	public float startPos;

	public float interVal;

	public Coroutine m_Coroutine;

	private WaitForSeconds wait;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_ShowTimeDown;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_GetCurDayReward;

	private static DelegateBridge __Hotfix0_ClosePanel;

	private static DelegateBridge __Hotfix0_Countdown;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge _c__Hotfix0_ctor;

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void ShowTimeDown()
	{
	}

	protected override void OnClose()
	{
	}

	public void GetCurDayReward()
	{
	}

	private void ClosePanel()
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__21))]
	private IEnumerator Countdown(long time)
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}
}
