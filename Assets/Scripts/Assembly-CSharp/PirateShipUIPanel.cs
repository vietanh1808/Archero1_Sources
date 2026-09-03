using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PirateShipUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PirateShipUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__22(int _003C_003E1__state)
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
	private ButtonCtrl close;

	[SerializeField]
	private PirateShipItem item;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private StarDiamondItem sItem;

	private LocalUnityObjctPool pool;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private PirateShipManager PirateShipManager => null;

	private PirateShipData PirateShipData => null;

	private void InitObjectPool()
	{
	}

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

	private void RefreshItem()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__22))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void RefreshTime()
	{
	}

	private void CloseWindow()
	{
	}
}
