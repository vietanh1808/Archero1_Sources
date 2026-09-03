using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2172 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CDelaySetFlashLayerMax_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2172 _003C_003E4__this;

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
		public _003CDelaySetFlashLayerMax_003Ed__8(int _003C_003E1__state)
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

	private float hittedFlashEnergy;

	private int newFlashLayerMax;

	private int consumeFlashBuffId;

	private int previousFlashLayer;

	private int buffAddCount;

	private Coroutine delayCoroutine;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySetFlashLayerMax_003Ed__8))]
	private IEnumerator DelaySetFlashLayerMax()
	{
		return null;
	}

	private void ParseParams()
	{
	}

	private void OnHitted(EntityBase attacker, long damage, HitStruct hs)
	{
	}

	private void OnAthenaFlashConsumed(EntityBase en, HitStruct hs)
	{
	}
}
