using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SeasonHardUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SeasonHardUICtrl _003C_003E4__this;

		private LanguageManager _003Clanguage_003E5__2;

		private LocalSave _003Clocal_003E5__3;

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
		public _003CCountdown_003Ed__27(int _003C_003E1__state)
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
	private ButtonCtrl BattleBtn;

	[SerializeField]
	private DxxText Text_Start;

	[SerializeField]
	private DxxText mTextPrice;

	[SerializeField]
	private ScrollRect mScrollView;

	[SerializeField]
	private SeasonHeadCtrl mHeroBtn;

	[SerializeField]
	private SeasonChapter mCopyOne;

	[SerializeField]
	private Image mPoint;

	[SerializeField]
	private Canvas mBg;

	[SerializeField]
	private MeshLayerHelper mBgRipple;

	[SerializeField]
	private DxxText mTextCd;

	[SerializeField]
	private Button changeBtn;

	[SerializeField]
	private GameObject qipao;

	[SerializeField]
	private DxxText diffcultTex;

	private Coroutine qipaoTimer;

	private LocalUnityObjctPool mChapterPool;

	private LocalUnityObjctPool mPointPool;

	private List<SeasonChapter> m_listChapters;

	private Coroutine m_Coroutine;

	private WaitForSeconds wait;

	protected override void OnInit()
	{
	}

	private void TEST_PRINT_INFO(int nCurChapter)
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateBtnState(long nCurTime)
	{
	}

	private void CheckUnlockStage()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__27))]
	private IEnumerator Countdown()
	{
		return null;
	}

	private long GetNextChapterOpenTime()
	{
		return 0L;
	}

	public void ShowQiPao()
	{
	}
}
