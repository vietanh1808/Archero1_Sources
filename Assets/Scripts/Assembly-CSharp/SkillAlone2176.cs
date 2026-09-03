using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2176 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CDelaySetFlashEnergyRatio_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2176 _003C_003E4__this;

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
		public _003CDelaySetFlashEnergyRatio_003Ed__10(int _003C_003E1__state)
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

	private int darkDebuffId;

	private float flashEnergyRatio;

	private bool forceNextWhirlwind;

	private Coroutine delayCoroutine;

	private GameObject handEffect;

	private const string handEffPath = "Effect/Battle/eff_nightathena_buff";

	private const int whirlwindBulletId = 1618;

	private int newFlashConsumeBuffId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySetFlashEnergyRatio_003Ed__10))]
	private IEnumerator DelaySetFlashEnergyRatio()
	{
		return null;
	}

	private void ParseParams()
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private void OnFlashLayerGained()
	{
	}

	private void OnHitForceWhirlwind(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private void ShowHandEffect()
	{
	}

	private void RemoveHandEffect()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
