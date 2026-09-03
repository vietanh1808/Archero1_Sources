using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone9024 : SkillAloneBase
{
	public class Skill9024_TCP : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCallPvP_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone9024 _003C_003E4__this;

		public EntityBase entity;

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
		public _003CDelayCallPvP_003Ed__21(int _003C_003E1__state)
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

	private float callTCPRate;

	private int TCPBuffId;

	private float TCPRatio;

	private float TCPRadius;

	private int hitTimes;

	private float CDTime;

	private float CDReducePerHit;

	private int StickBulletId;

	private int PartNums;

	private float CDReducePerHitExternal;

	private float CDReduceMaxExternal;

	private int attackedTimes;

	private float preCallTCPTime;

	private float CdTimeReduce;

	private float CdTimeReduceExternal;

	private const string SyncSkill9024_TCP = "SyncSkill9024_TCP";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnAttackEnd(WeaponBase weaponBase)
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void CallTCP(EntityBase entity)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCallPvP_003Ed__21))]
	private IEnumerator DelayCallPvP(EntityBase entity)
	{
		return null;
	}

	private void CallTCPExternal(EntityBase entity)
	{
	}

	private bool IsStickCallTCP(int Id)
	{
		return false;
	}

	private void SetStickBulletId(int Id)
	{
	}

	private void SetPartNums(int num)
	{
	}

	private float GetRealCdTime()
	{
		return 0f;
	}

	private void ReduceCDTimeExternal()
	{
	}

	private void SetTCPCDReduceExternal(float reduceMax, float reducePerHit)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}

	public BulletBase CreateTCPBullet(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void SyncTCP(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
