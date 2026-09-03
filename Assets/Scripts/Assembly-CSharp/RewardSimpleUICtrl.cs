using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class RewardSimpleUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public RewardSimpleUICtrl _003C_003E4__this;

		public int row;

		internal void _003CDelayOneFrameRate_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDelayClose_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CDelayClose_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CDelayOneFrameRate_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RewardSimpleUICtrl _003C_003E4__this;

		public int row;

		private _003C_003Ec__DisplayClass46_0 _003C_003E8__1;

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
		public _003CDelayOneFrameRate_003Ed__46(int _003C_003E1__state)
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

	public DxxText Text_ExtraReward;

	public DxxText Text_Desc;

	public TapToCloseCtrl mTapCloseCtrl;

	[SerializeField]
	private RectTransform bg;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private GridLayoutGroup gridLayoutGroup;

	public GameObject go_Process;

	public GameObject go_Diamond;

	public Slider piggy_Slider;

	public DxxText text_Progress;

	public DxxText text_Completed;

	public DxxText text_Min;

	public DxxText Text_Max;

	public DxxImage img_Piggy;

	private const float ScrollTimePerRow = 0.1f;

	private int MaxRow;

	private const float playTime = 0.03f;

	private int perRowCount;

	private float perItemSizeY;

	private RectTransform content;

	private bool needPlayAni;

	private Tweener scrollAni;

	private RewardSimpleProxy.Transfer mTransfer;

	private SequencePool mSeqPool;

	private LocalUnityObjctPool mPool;

	private Coroutine delayClose;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayClose_003Ed__29))]
	private IEnumerator DelayClose()
	{
		return null;
	}

	private bool InitPiggyCond()
	{
		return false;
	}

	private void InitUI()
	{
	}

	public void AddShipSkin(PropOneEquip one)
	{
	}

	public void RefreshSailingTownRed(Drop_DropModel.DropData data)
	{
	}

	private void addRateDataShow(PropOneEquip one, Drop_DropModel.DropData drop)
	{
	}

	private void InitPiggy()
	{
	}

	private void RefreshPiggy(int value)
	{
	}

	public void CheckIsShowSkinGet(int id)
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

	[IteratorStateMachine(typeof(_003CDelayOneFrameRate_003Ed__46))]
	private IEnumerator DelayOneFrameRate(Sequence seq, int row)
	{
		return null;
	}
}
