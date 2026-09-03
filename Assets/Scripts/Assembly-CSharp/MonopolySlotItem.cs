using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonopolySlotItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public bool startPlaySound;

		public SoundManager.SoundData sound;

		internal void _003CStartSlot_003Eb__0(SoundManager.SoundData s)
		{
		}

		internal bool _003CStartSlot_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlayCountChange_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolySlotItem _003C_003E4__this;

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
		public _003CPlayCountChange_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CPlayCountSmall_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolySlotItem _003C_003E4__this;

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
		public _003CPlayCountSmall_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CStartSlot_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolySlotItem _003C_003E4__this;

		public Func<bool> backIsSkip;

		public int id;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		private float _003Cspeed_003E5__2;

		private float _003CAcceleration_003E5__3;

		private bool _003CisStartTarget_003E5__4;

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
		public _003CStartSlot_003Ed__16(int _003C_003E1__state)
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

	public MonopolySlotRewardItem[] rewardItems;

	public GameObject arrawEffect;

	public GameObject stopEffect;

	private float[] posYs;

	private float lowstY;

	private float offset;

	private int hightstIndex;

	private int hightstConfigIndex;

	private List<MonopolyManager.WheelConfig> wheelConfigs;

	private int[] showIds;

	private Animator animator;

	public float StartSpeed;

	public float Duration;

	public float StopSlotSpeed;

	public float MinSpeed;

	public void Open(List<MonopolyManager.WheelConfig> rewards, Animator ani)
	{
	}

	[IteratorStateMachine(typeof(_003CStartSlot_003Ed__16))]
	public IEnumerator StartSlot(int id, Func<bool> backIsSkip)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayCountChange_003Ed__17))]
	public IEnumerator PlayCountChange(int rate)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayCountSmall_003Ed__18))]
	public IEnumerator PlayCountSmall()
	{
		return null;
	}

	public MonopolyManager.WheelConfig GetWeelConfig(int id)
	{
		return null;
	}

	public int GetWeelConfigIndex(int id)
	{
		return 0;
	}

	public void ShowFinal(int id)
	{
	}
}
