using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine.UI;

public class VideoUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CWaitGoToMain_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CWaitGoToMain_003Ed__10(int _003C_003E1__state)
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

	public Image Image_Boss;

	public Image Image_Hero;

	public DxxText Text_1;

	public DxxText Text_2;

	private bool bStartLogin;

	private bool bShowNet;

	private int mLoginSate;

	private Sequence seq;

	private Sequence seq_login;

	protected override void OnInit()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitGoToMain_003Ed__10))]
	private IEnumerator WaitGoToMain()
	{
		return null;
	}

	private void ShowRetry()
	{
	}

	private void OnLoginCallback_Retry()
	{
	}

	private void OnLoginCallback()
	{
	}

	private void ShowNetDoing(bool value)
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void KillSequence()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
