using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PayShipCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PayShipCtrl _003C_003E4__this;

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
		public _003CCountdown_003Ed__12(int _003C_003E1__state)
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
	private GameObject child;

	[SerializeField]
	private ButtonCtrl Button_Ship;

	[SerializeField]
	private GameObject time;

	[SerializeField]
	private DxxText timeText;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Animator m_animator;

	private Coroutine m_Coroutine;

	private WaitForSeconds wait;

	public void OnOpen()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__12))]
	private IEnumerator Countdown()
	{
		return null;
	}

	public RectTransform GetTransform()
	{
		return null;
	}

	public void UpdateUI()
	{
	}

	public void OnClose()
	{
	}
}
