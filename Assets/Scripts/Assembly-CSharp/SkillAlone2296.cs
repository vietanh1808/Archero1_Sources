using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2296 : SkillAloneBase
{
	private class SkillEffect2296_ExplodeVO : CustomJsonActionVO
	{
		public Vector3 Position;

		public int TargetGuid;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2296 _003C_003E4__this;

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

	private float flySwordTriggerRate;

	private int burnDebuffId;

	private int dragonMarkBuffId;

	private float explodeDamageRatio;

	private float dragonMarkCooldown;

	private const int explodeBulletId = 1606;

	private int currentImpulseSequenceId;

	private Dictionary<int, int> enemyLastImpulseSequenceId;

	private Dictionary<int, float> enemyMarkApplyTime;

	private const string ImpulseFxPathExternal = "Effect/Battle/eff_dragonarthur_firedragon";

	private const string ImpulseEnemyFxPathExternal = "Effect/Battle/eff_dragonarthur_firedragonpvp";

	private const string SyncSkill2296_Explode = "SyncSkill2296_Explode";

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

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void OnCastImpulse()
	{
	}

	private void HandleImpulseHit(EntityBase enemy)
	{
	}

	private void DoExplodeDragonMark(EntityBase enemy)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncExplode(Vector3 pos, int targetGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
