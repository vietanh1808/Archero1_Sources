using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2328 : SkillAloneBase
{
	private class SyncVO : CustomJsonActionVO
	{
		public Vector3 Pos;

		public Quaternion Rotation;
	}

	[CompilerGenerated]
	private sealed class _003CChangeBoxingGloveEffectId_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityHero hero;

		public int id;

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
		public _003CChangeBoxingGloveEffectId_003Ed__11(int _003C_003E1__state)
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

	private float triggerCD;

	private int guardBuffId;

	private float ShieldDuration;

	private int[] bulletThresholds;

	private float lastTriggerTime;

	private SkillAlone2328ShieldCtrl currentShield;

	private const int superSkillEffectId = 3411665;

	private const string SyncAction = "SyncSkill2328_CreateShield";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeBoxingGloveEffectId_003Ed__11))]
	private IEnumerator ChangeBoxingGloveEffectId(EntityHero hero, int id)
	{
		return null;
	}

	private bool TryResistDamage(EntityBase attacker, long damage, HitStruct hs)
	{
		return false;
	}

	private void DoCreateShield(Vector3 createPos, Quaternion rotation)
	{
	}

	private void OnShieldEnd(int absorbedCount)
	{
	}

	private int GetBuffLayers(int absorbedCount)
	{
		return 0;
	}

	private void ClearShield()
	{
	}

	private void SyncCreateShield(Vector3 pos, Quaternion rotation)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
