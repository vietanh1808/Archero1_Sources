using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BallonAdUICtrl : MediatorCtrlBase
{
	public enum TabType
	{
		Ad = 0,
		PurChase = 1
	}

	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BallonAdUICtrl _003C_003E4__this;

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
		public _003CCountdown_003Ed__32(int _003C_003E1__state)
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

	public Button closeBtn;

	public DxxText titleTex;

	public DxxText timeDownTex;

	public Transform itemParent;

	public DxxText descTex;

	public ButtonCtrl daimBtn;

	public ButtonCtrl adBtn;

	public DxxText adBtnTex;

	public DxxText daimBtnTex;

	public Coroutine m_Coroutine;

	private PropOneEquip equipOneCtrl;

	public GameObject adPart;

	public BallonPurchasePart purchasePart;

	public BallonTabPart tabPart;

	private Vector2 leftPos;

	private Vector2 centorPos;

	public DxxText adFreeTex;

	public StarDiamondItem starItem;

	protected AdCallbackControl mAd;

	private TabType curTab;

	private WaitForSeconds wait;

	public BallonSeverData openData => null;

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}

	private void ShowIapReport()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ClosePanel()
	{
	}

	protected void Refrsh()
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__32))]
	private IEnumerator Countdown(long time)
	{
		return null;
	}

	private void OnAdEndWrapper()
	{
	}

	private void OnAdEnd()
	{
	}
}
