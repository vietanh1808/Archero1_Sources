using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2286 : SkillAloneBase
{
	private class SkillEffect2286_SyncHeartBulletVO : CustomJsonActionVO
	{
		public int Guid;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2286 _003C_003E4__this;

		public EntityBase target;

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
		public _003CDelayCall_003Ed__19(int _003C_003E1__state)
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

	private float callHeartRate;

	private float judgeInterval;

	private int heartDebuffId;

	private float hitRatio;

	private int heartDizzyId;

	private float explodeRatio;

	private float triggerCD;

	private float preCheckMoveTime;

	private float preTrigerTime;

	private int heartBulletId;

	private float delayHit;

	private const string SyncSkill2286_SyncHeartBullet = "SyncSkill2286_SyncHeartBullet";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnMove(bool value)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private BulletBase CreateHeart(int bulletId, Vector3 bulletPos, float rotate, float atkPercent, float radius, int buffId)
	{
		return null;
	}

	private void CreatHeartBullet(EntityBase target)
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCall_003Ed__19))]
	private IEnumerator DelayCall(EntityBase target)
	{
		return null;
	}

	private void SyncHeartBullet(int guid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
