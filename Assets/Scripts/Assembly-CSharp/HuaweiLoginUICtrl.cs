using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class HuaweiLoginUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003Cstart_load_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HuaweiLoginUICtrl _003C_003E4__this;

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
		public _003Cstart_load_003Ed__16(int _003C_003E1__state)
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

	public GameObject loginobj;

	public Image Image_BG;

	public Image Image_Splash1;

	public CanvasGroup mCanvasGroup;

	public DxxText Text_Loading;

	public ProgressTextCtrl mProgress;

	private Sequence seq_load;

	private int loadingindex;

	private int frame;

	private Tweener mProgressAniTweener;

	public GameObject beginObj;

	public ButtonCtrl startBtn;

	public bool IsLogin => false;

	protected override void OnInitBefore()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnLogin()
	{
	}

	private void update_progress(int percent)
	{
	}

	private void update_progress_ani(int percent)
	{
	}

	[IteratorStateMachine(typeof(_003Cstart_load_003Ed__16))]
	private IEnumerator start_load()
	{
		return null;
	}

	private void SetLoading(int index)
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

	public void ChangeWindow()
	{
	}

	public void OnClickStartBtn()
	{
	}

	private void OnLoginSuccess()
	{
	}
}
