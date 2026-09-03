using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Activity7thAnniversary;
using PureMVC.Interfaces;
using UnityEngine;

public class Act7thActBtn : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COnUpdate_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Act7thActBtn _003C_003E4__this;

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
		public _003COnUpdate_003Ed__27(int _003C_003E1__state)
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

	public int actIndex;

	public DxxText nameTex;

	public DxxText timeText;

	public ButtonCtrl clickBtn;

	public GameObject goRed;

	private Action[] openBack;

	private Func<bool>[] IsHaveDataBack;

	private Func<bool>[] IsNotStartBack;

	private long[] StartTime;

	private Func<bool>[] IsEndBack;

	private Func<bool>[] IsGameEndBack;

	private long[] GameEndTime;

	private string[] nameKey;

	private string[] notificationKey;

	private WaitForSeconds _wait;

	private Coroutine _coroutine;

	private Activity7thAnniversaryMgr _mgr;

	private long showTimex;

	private string timeKey;

	public static Act7thManager AMgr => null;

	private long CD => 0L;

	private long EndTime => 0L;

	private string lanKey => null;

	public void Init()
	{
	}

	private void CheckWait()
	{
	}

	[IteratorStateMachine(typeof(_003COnUpdate_003Ed__27))]
	private IEnumerator OnUpdate()
	{
		return null;
	}

	private void UpdateCdText()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void Click()
	{
	}

	private void UpdateTime()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void RefreshShopRed()
	{
	}

	public void checkButtonShow(int index)
	{
	}
}
