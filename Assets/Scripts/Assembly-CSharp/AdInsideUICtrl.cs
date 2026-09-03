using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class AdInsideUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003Cplay_video_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdInsideUICtrl _003C_003E4__this;

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
		public _003Cplay_video_003Ed__12(int _003C_003E1__state)
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

	public ButtonCtrl Button_shadow;

	public RawImage image;

	public VideoPlayer mPlayer;

	public AudioSource mAudioSource;

	public AdInsideTimeCtrl mTimeCtrl;

	private AdInsideProxy.Transfer mTransfer;

	private bool bSoundOpen;

	private bool bMusicOpen;

	private float updatetime;

	protected override void OnInit()
	{
	}

	private void OnLoopPointReached(VideoPlayer video)
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003Cplay_video_003Ed__12))]
	private IEnumerator play_video()
	{
		return null;
	}

	private void InitUI()
	{
	}

	private void Update()
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
