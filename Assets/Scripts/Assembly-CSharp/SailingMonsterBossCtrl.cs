using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SailingMonsterBossCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingMonsterBossCtrl _003C_003E4__this;

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
		public _003CCountDown_003Ed__17(int _003C_003E1__state)
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

	public GameObject preAttackEffect;

	public DxxText text_Time;

	public ButtonCtrl btnMonster;

	public DxxImage bosIcon;

	public DxxImage attackIcon;

	public DxxImage rankIcon;

	public DxxText rankTxt;

	private WaitForSeconds wait;

	private Coroutine coroutineCountDown;

	private SailingMonsterCommingMgr SmMgr => null;

	public void Init()
	{
	}

	public void Show()
	{
	}

	public void OnOpen()
	{
	}

	public void RefreshStatus()
	{
	}

	public void SetPreAttackEffect(bool status)
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__17))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public void OnBtnMonsterClicked()
	{
	}

	private void Close()
	{
	}
}
