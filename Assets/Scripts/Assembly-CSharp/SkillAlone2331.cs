using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2331 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2331VO : CustomJsonActionVO
	{
		public int TargetGuid;
	}

	[CompilerGenerated]
	private sealed class _003CClawSequence_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2331 _003C_003E4__this;

		public int targetGuid;

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
		public _003CClawSequence_003Ed__15(int _003C_003E1__state)
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

	private float triggerRate;

	private float clawDmgRatio1;

	private float clawDmgRatio2;

	private float clawDmgRatio3;

	private int bleedBuffId;

	private float clawInterval;

	private const int ClawEffectId1 = 2000011;

	private const int ClawEffectId2 = 2000012;

	private const int ClawEffectId3 = 2000013;

	private Coroutine clawCoroutine;

	private const string SyncSkill2331_Claw = "SyncSkill2331_Claw";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private void DoClawAttack(int targetGuid)
	{
	}

	[IteratorStateMachine(typeof(_003CClawSequence_003Ed__15))]
	private IEnumerator ClawSequence(int targetGuid)
	{
		return null;
	}

	private void DealClawDamage(int targetGuid, float dmgRatio, int effectId)
	{
	}

	private void SyncClawAttack(int targetGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
