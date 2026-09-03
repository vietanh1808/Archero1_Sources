using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay127RewardCompUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public NewPlay127RewardCompUIPanel _003C_003E4__this;

		public int row;

		internal void _003CDelayOneFrameRate_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDelayOneFrameRate_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NewPlay127RewardCompUIPanel _003C_003E4__this;

		public int row;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		public Sequence seq;

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
		public _003CDelayOneFrameRate_003Ed__27(int _003C_003E1__state)
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

	public DxxText Text_Title;

	public TapToCloseCtrl mTapCloseCtrl;

	[SerializeField]
	private RectTransform bg;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private GridLayoutGroup gridLayoutGroup;

	[SerializeField]
	private NewPlay127RewardCompItem compItem;

	private const float ScrollTimePerRow = 0.1f;

	private const int MaxRow = 6;

	private const float playTime = 0.03f;

	private int perRowCount;

	private float perItemSizeY;

	private RectTransform content;

	private bool needPlayAni;

	private Tweener scrollAni;

	private SequencePool mSeqPool;

	private LocalUnityObjctPool mPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void android_escape()
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

	private void RefreshBgSize(int maxIndex)
	{
	}

	private void RefreshContentSize(int maxIndex)
	{
	}

	private void RefreshGridLayoutGroup(int maxIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayOneFrameRate_003Ed__27))]
	private IEnumerator DelayOneFrameRate(Sequence seq, int row)
	{
		return null;
	}
}
