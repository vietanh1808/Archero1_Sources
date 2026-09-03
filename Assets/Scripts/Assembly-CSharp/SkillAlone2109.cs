using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2109 : SkillAloneBase
{
	public class Skill1Effect2109IgniteVO : CustomJsonActionVO
	{
		public Vector3 pos;

		public float rotate;
	}

	[CompilerGenerated]
	private sealed class _003CChangeBoxingGloveEffectId_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CChangeBoxingGloveEffectId_003Ed__19(int _003C_003E1__state)
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

	private float initEffectRate;

	private float backToRate;

	private float addRate;

	private float effectTimeFromEnter;

	private int maxSnowBallCount;

	private float snowBallRadius;

	private float explodeRadius;

	private float damageRatio;

	private float explodeRatio;

	private string SyncSkill2109_bullet;

	private int snowBallBulletId;

	private int snowBallExplodeBulletId;

	private float curEffectRate;

	private float preEnterRoomTime;

	private int snowBallCount;

	private const int superSkillEffectId = 3411661;

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeBoxingGloveEffectId_003Ed__19))]
	private IEnumerator ChangeBoxingGloveEffectId(EntityHero hero, int id)
	{
		return null;
	}

	private void OnHitted(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void MakeSnowBall(Vector3 enemyPos)
	{
	}

	private void CreatSnowBallBullet(Vector3 pos, float rotate)
	{
	}

	public BulletBase CreateBullet(int bulletId, Vector3 bulletPos, float rota, float atkPercent, float radius)
	{
		return null;
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncExplosion(Vector3 pos, float rotate)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
