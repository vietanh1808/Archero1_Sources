using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MonopolySlotUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public NetBox net;

		internal bool _003CStartSlot_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CFlayRate_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolySlotUIPanel _003C_003E4__this;

		public int rate;

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
		public _003CFlayRate_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CStartSlot_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolySlotUIPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		private STRespActivityMonopoly _003Cdata_003E5__2;

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
		public _003CStartSlot_003Ed__14(int _003C_003E1__state)
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

	public MonopolySlotItem monopolySlotItem;

	public MpnopolySlotWheelPart mpnopolySlotWheelPart;

	public ButtonCtrl StartBtn;

	public Animator animator;

	public Image flayImage;

	public GameObject papersEfrfect;

	public Transform lightEffect;

	public DxxText btnTex;

	public DxxText skipTex;

	private bool isSloting;

	private bool isSkiping;

	private List<Drop_DropModel.DropData> rewardList;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CStartSlot_003Ed__14))]
	public IEnumerator StartSlot()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFlayRate_003Ed__15))]
	public IEnumerator FlayRate(int rate)
	{
		return null;
	}

	private void Update()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void onButtonShowResult()
	{
	}

	public bool GetIsSkip()
	{
		return false;
	}
}
