using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AI1830_TD : AIBase
{
	[CompilerGenerated]
	private sealed class _003CDelaySetRendderOrder_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform transform;

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
		public _003CDelaySetRendderOrder_003Ed__10(int _003C_003E1__state)
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

	private const string ANIM_BOOM = "Dead";

	private const string ANIM_IDLE = "Idle";

	private const string ANIM_READY = "Ready";

	private AnimationState ReadyState;

	public GameObject idleEffect;

	public GameObject WaveObj;

	private const string sortingLayerName = "Player";

	protected override void OnInitOnce()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void onHeroDrop2Floor()
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySetRendderOrder_003Ed__10))]
	public IEnumerator DelaySetRendderOrder(Transform transform)
	{
		return null;
	}

	public void showWaveAni()
	{
	}
}
