using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoginUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CInitOther_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoginUICtrl _003C_003E4__this;

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
		public _003CInitOther_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003Cstart_load_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoginUICtrl _003C_003E4__this;

		private List<Func<bool>> _003CinitAct_003E5__2;

		private bool _003CtisSuccess_003E5__3;

		private int _003Ci_003E5__4;

		private int _003Clength_003E5__5;

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
		public _003Cstart_load_003Ed__21(int _003C_003E1__state)
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

	[SerializeField]
	private Image GorillaLogo;

	private Sequence seq_load;

	private int loadingindex;

	private int frame;

	private Tweener mProgressAniTweener;

	private float m_fClickCnt;

	private float m_fClickTime;

	private EventSystem eventSystem;

	private GraphicRaycaster RaycastInCanvas;

	private bool isCheck;

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

	[IteratorStateMachine(typeof(_003Cstart_load_003Ed__21))]
	private IEnumerator start_load()
	{
		return null;
	}

	private bool Init1()
	{
		return false;
	}

	private bool Init2()
	{
		return false;
	}

	private bool Init3()
	{
		return false;
	}

	private bool Init4()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CInitOther_003Ed__26))]
	private IEnumerator InitOther()
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

	private void OnClickLogo()
	{
	}

	private void Update()
	{
	}

	private void Check()
	{
	}
}
