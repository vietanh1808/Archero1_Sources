using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2007 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2007NearDeathVO : CustomJsonActionVO
	{
		public long TargetHp;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2007 _003C_003E4__this;

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
		public _003CDelayCall_003Ed__10(int _003C_003E1__state)
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

	private float whirlwindRadiusBoost;

	private int warGodBuffId;

	private float clearBulletRadius;

	private float nearDeathHpPercent;

	private int previousFlashLayer;

	private bool hasUsedNearDeathThisBuff;

	private Coroutine co;

	private const string ClearBulletEffPath = "Effect/Battle/eff_athena_god_clear";

	private const int nearDeathBuffId = 1815;

	private const string SyncSkill2007_NearDeath = "SyncSkill2007_NearDeath";

	protected override void OnInstall()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCall_003Ed__10))]
	private IEnumerator DelayCall()
	{
		return null;
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnFlashLayerChanged(int newLayerCount)
	{
	}

	private void EnterWarGodState()
	{
	}

	private bool TryWarGodResistDamage(EntityBase attacker, long damage, HitStruct hs)
	{
		return false;
	}

	private bool IsWarGodActive()
	{
		return false;
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void ClearEnemyBulletsInRange(Vector3 center, float radius)
	{
	}

	private void PlayClearBulletEffect(Vector3 center, float radius)
	{
	}

	private void SyncNearDeathResist(long targetHp)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
