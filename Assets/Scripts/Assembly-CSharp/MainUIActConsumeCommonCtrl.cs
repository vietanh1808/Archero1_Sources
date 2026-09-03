using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActivityConsumeCommon;
using UnityEngine;
using UnityEngine.UI;

public class MainUIActConsumeCommonCtrl : MainUIButtonBase
{
	[CompilerGenerated]
	private sealed class _003CTick_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIActConsumeCommonCtrl _003C_003E4__this;

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
		public _003CTick_003Ed__34(int _003C_003E1__state)
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
	private Image image_box;

	[SerializeField]
	private GameObjectSwitcher switcher;

	public ButtonCtrl mButton;

	public RedNodeCtrl mRedCtrl;

	public DxxText txtTime;

	private ConsumeTab crtTab;

	private HashSet<ConsumeTab> requestingEvents;

	private bool isExecuting;

	private bool isDiamondOn => false;

	private bool isLifeOn => false;

	private bool isBox25On => false;

	private bool isBox41On => false;

	private bool isBox42On => false;

	private bool isBox43On => false;

	private bool isBox44On => false;

	private bool isBox45On => false;

	private bool isBox46On => false;

	private bool isBox47On => false;

	private void Awake()
	{
	}

	private void RequestFinished(ConsumeTab tab)
	{
	}

	private void OnBtnClick()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateRed()
	{
	}

	[IteratorStateMachine(typeof(_003CTick_003Ed__34))]
	private IEnumerator Tick()
	{
		return null;
	}

	public override bool IsShow()
	{
		return false;
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public void Open()
	{
	}

	public new void UpdateUI()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override bool isRed()
	{
		return false;
	}
}
