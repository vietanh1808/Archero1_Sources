using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Addressable;
using UnityEngine;
using UnityEngine.UI;

public class DownloadLevelUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CLoop_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DownloadLevelUICtrl _003C_003E4__this;

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
		public _003CLoop_003Ed__16(int _003C_003E1__state)
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
	private ButtonCtrl m_btnClose;

	[SerializeField]
	private DxxText m_textTitle;

	[SerializeField]
	private DxxText m_textDownloadContent;

	[SerializeField]
	private Slider m_slider;

	[SerializeField]
	private DxxText m_textSliderValue;

	[SerializeField]
	private Image m_imgModule;

	[SerializeField]
	private Image m_imgCdBg;

	[SerializeField]
	private DxxText m_textCd;

	private Coroutine m_coroutine;

	private WaitForSeconds m_wait;

	private long m_cd;

	private Func<FunctionalModule, float> m_process;

	private FunctionalModule m_emModule;

	private Action m_endCallback;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CLoop_003Ed__16))]
	private IEnumerator Loop()
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void OnClickClose()
	{
	}
}
