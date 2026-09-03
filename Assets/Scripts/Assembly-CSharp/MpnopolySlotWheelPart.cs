using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MpnopolySlotWheelPart : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public bool startPlaySound;

		public SoundManager.SoundData sound;

		internal void _003CStartWheel_003Eb__0(SoundManager.SoundData s)
		{
		}

		internal bool _003CStartWheel_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartWheel_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MpnopolySlotWheelPart _003C_003E4__this;

		public Func<bool> backIsSkip;

		public int rate;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		private float _003Cspeed_003E5__2;

		private float _003CAcceleration_003E5__3;

		private bool _003CisStartTarget_003E5__4;

		private float _003CtragetAngle_003E5__5;

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
		public _003CStartWheel_003Ed__12(int _003C_003E1__state)
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

	private int[] rates;

	public MonopolySlotWheelRewardItem copyItem;

	public Transform itemParent;

	public Transform arrawTrans;

	private Animator animator;

	private List<MonopolySlotWheelRewardItem> items;

	public float StartSpeed;

	public float Duration;

	public float StopSlotSpeed;

	public float MinSpeed;

	public void Init()
	{
	}

	public void Open(Animator ani)
	{
	}

	[IteratorStateMachine(typeof(_003CStartWheel_003Ed__12))]
	public IEnumerator StartWheel(int rate, Func<bool> backIsSkip)
	{
		return null;
	}

	public int GetNearAngle(int rate, float angle)
	{
		return 0;
	}

	public int GetLastAngle(int rate, float angle)
	{
		return 0;
	}

	public int GetNearIndex(float angle)
	{
		return 0;
	}
}
