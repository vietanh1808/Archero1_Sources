using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2270 : SkillAloneBase
{
	public class SkillEffect2270_Sync2270_CallPartVO : CustomJsonActionVO
	{
		public float Duration;

		public Vector3 Pos;
	}

	[CompilerGenerated]
	private sealed class _003CDelayFxSweep_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2270 _003C_003E4__this;

		public Vector3 bulletPos;

		public Vector3 forward;

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
		public _003CDelayFxSweep_003Ed__25(int _003C_003E1__state)
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

	private float partDuration;

	private int partGenRange;

	private float sweepHitRatio;

	private float newPartDuration;

	private float secondPartDuration;

	private float godHitRise;

	private int partid;

	private bool isFistAtk;

	private float GodSweepFxDelay;

	private int SweepPartId;

	private int PartWeaponId;

	private int callPartRoomId;

	private ActionBasic action;

	private const string SyncSkill2270_CallPart = "SyncSkill2270_CallPart";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void CreatPart(float duration, Vector3 pos, bool isSync = false)
	{
	}

	private void OnRemovePartBody(EntityPartBodyBase entity, int id)
	{
	}

	private Vector3 GetRandomPos(EntityBase entity)
	{
		return default;
	}

	private void OnAttack()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SetTridentPartDuration(float duration)
	{
	}

	private void SetTridentDualHit(float rise)
	{
	}

	private void CreatPartExternal(float duration)
	{
	}

	private void CreateExtraBullets(EntityBase entity)
	{
	}

	private void GodSweepSequence(Vector3 bulletPos, EntityBase entity, Vector3 forward)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayFxSweep_003Ed__25))]
	private IEnumerator DelayFxSweep(Vector3 bulletPos, Vector3 forward)
	{
		return null;
	}

	private void CreatSweepPart(Vector3 pos, EntityBase entity)
	{
	}

	private void SweepAttack(EntityPartBodyBase en)
	{
	}

	private BulletBase GodSweep(int bulletId, Vector3 bulletPos, float atkPercent, Vector3 forward)
	{
		return null;
	}

	private void SyncPartExternal(Vector3 pos, float duration)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
