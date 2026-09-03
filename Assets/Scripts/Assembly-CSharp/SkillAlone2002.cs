using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2002 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2002MeteorVO : CustomJsonActionVO
	{
		public Vector3 EndPos;

		public bool IsCrit;

		public Vector3 ExtraEndPos;
	}

	[Serializable]
	private class SyncSkill2002ConvergeVO : CustomJsonActionVO
	{
		public int TargetGuid;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCheckConverge_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2002 _003C_003E4__this;

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
		public _003CDelayCheckConverge_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CDelayExtraMeteor_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2002 _003C_003E4__this;

		public Vector3 endPos;

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
		public _003CDelayExtraMeteor_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CResetConvergeCooldown_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2002 _003C_003E4__this;

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
		public _003CResetConvergeCooldown_003Ed__42(int _003C_003E1__state)
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

	private float summonRate;

	private float meteorDmgRatio;

	private float meteorRadius;

	private float randomRadius;

	private float meteorCdTime;

	private float critExtraDelay;

	private int starThreshold;

	private float starDmgRatio;

	private int starDebuffId;

	private float convergeCdTime;

	private const int MeteorBulletId = 3086;

	private const int StarGroundEffectId = 5100085;

	private const int HitEnemtEffectId = 5100087;

	private const string SyncSkill2002_Meteor = "SyncSkill2002_Meteor";

	private const string SyncSkill2002_Converge = "SyncSkill2002_Converge";

	private float lastMeteorTime;

	private bool isConvergeCooldown;

	private readonly List<GameObject> starEffectList;

	private readonly List<Vector3> starPositions;

	private Coroutine extraMeteorCoroutine;

	private const float StarFlySpeed = 25f;

	private const float StarFlyDelay = 0.9f;

	private EntityBase convergeTarget;

	private long convergeDamage;

	private Coroutine convergeDelayCoroutine;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private bool IsMeteorReady()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CDelayExtraMeteor_003Ed__31))]
	private IEnumerator DelayExtraMeteor(Vector3 endPos)
	{
		return null;
	}

	private Vector3 GetRandomMeteorEndPos(Vector3 targetPos)
	{
		return default;
	}

	private void DoSummonMeteor(Vector3 endPos)
	{
	}

	private void OnMeteorLanded(BulletSlopeBase bullet)
	{
	}

	private void PlaceStarEffect(Vector3 pos)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCheckConverge_003Ed__36))]
	private IEnumerator DelayCheckConverge()
	{
		return null;
	}

	private void CheckIfConverge()
	{
	}

	private void TriggerConverge()
	{
	}

	private void StartStarsFlyToTarget(EntityBase target)
	{
	}

	private void OnStarArrived(SkillAlone2002StarCtrl ctrl)
	{
	}

	private void DealStarDamage(EntityBase target, long baseDamage)
	{
	}

	[IteratorStateMachine(typeof(_003CResetConvergeCooldown_003Ed__42))]
	private IEnumerator ResetConvergeCooldown()
	{
		return null;
	}

	private EntityBase GetNearestEnemy()
	{
		return null;
	}

	private void ClearAllStars()
	{
	}

	private void SyncMeteor(Vector3 endPos, bool isCrit, Vector3 extraEndPos)
	{
	}

	private void SyncConverge(int targetGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void DoRemoteConverge(EntityBase target)
	{
	}
}
