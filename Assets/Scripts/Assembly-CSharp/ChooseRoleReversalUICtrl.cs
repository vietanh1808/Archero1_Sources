using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class ChooseRoleReversalUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CPlayAnimation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool useTimeScale;

		public Animation animation;

		public string clipName;

		public Action onComplete;

		private AnimationState _003C_currState_003E5__2;

		private bool _003CisPlaying_003E5__3;

		private float _003C_progressTime_003E5__4;

		private float _003C_timeAtLastFrame_003E5__5;

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
		public _003CPlayAnimation_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CRebuild_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChooseRoleReversalUICtrl _003C_003E4__this;

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
		public _003CRebuild_003Ed__18(int _003C_003E1__state)
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

	private LocalUnityObjctPool mCachePool;

	public GameObject CacheRoot;

	public DxxText mTitle;

	public DxxText mContent;

	public ScrollRect mScrollRect;

	public ReversalRoleItemCtrl CopyOne;

	public ButtonCtrl mColseBtn;

	public RectTransform mTopBar;

	public DxxText mTextHp;

	public DxxText mTextAttack;

	public Transform mCharNode;

	public ButtonCtrl mChangeBtn;

	public DxxText mChangeBtnText;

	private List<ReversalRoleItemCtrl> m_listItems;

	private ChooseRoleReversalProxy.Transfer mTransfer;

	private SequencePool mSeqPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CRebuild_003Ed__18))]
	private IEnumerator Rebuild()
	{
		return null;
	}

	private void OnClickChangeBtn()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayAnimation_003Ed__22))]
	private IEnumerator PlayAnimation(Animation animation, string clipName, bool useTimeScale, Action onComplete)
	{
		return null;
	}
}
