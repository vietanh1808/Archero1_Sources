using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2279 : SkillAloneBase
{
	public class SkillEffect2279_SyncGodSweepVO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2279 _003C_003E4__this;

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
		public _003CDelayCall_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CDelayFxSweep_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2279 _003C_003E4__this;

		public Vector3 bulletPos;

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
		public _003CDelayFxSweep_003Ed__17(int _003C_003E1__state)
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

	private float callSweepRate;

	private float callSweepCDTime;

	private float sweepHitRatio;

	private float godHitRise;

	private bool isUsingDagger;

	private float preSweepTime;

	private int SweepPartId;

	private int PartWeaponId;

	private float GodSweepFxDelay;

	private ActionBasic action;

	private const string SyncSkill2279_SyncGodSweep = "SyncSkill2279_SyncGodSweep";

	private LocalSave.TridentDivinityV0 tridentDivinityV0 => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCall_003Ed__14))]
	private IEnumerator DelayCall()
	{
		return null;
	}

	private void OnTridentSweep()
	{
	}

	private void GodSweepSequence(Vector3 bulletPos)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayFxSweep_003Ed__17))]
	private IEnumerator DelayFxSweep(Vector3 bulletPos)
	{
		return null;
	}

	private BulletBase GodSweep(int bulletId, Vector3 bulletPos, float atkPercent)
	{
		return null;
	}

	private void OnTridentChangeState(bool isUsingDagger)
	{
	}

	private void CreatPart(Vector3 pos)
	{
	}

	private void SweepAttack(EntityPartBodyBase en)
	{
	}

	private void SyncGodSweep(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
