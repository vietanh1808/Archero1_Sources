using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2314 : SkillAloneBase
{
	private class SyncVO : CustomJsonActionVO
	{
		public Vector3 Pos;

		public Quaternion Rotation;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2314 _003C_003E4__this;

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
		public _003CDelayCall_003Ed__11(int _003C_003E1__state)
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

	private string rateStr;

	private float bigBallProbability;

	private float bigBallRadius;

	private float explosionInterval;

	private float explosionBulletRadius;

	private float explosionDamageRatio;

	private const int BIG_BALL_BULLET_ID = 1616;

	private const int EXPLOSION_BULLET_ID = 1617;

	private List<BulletBase> bigBalls;

	private Dictionary<BulletBase, float> bigBallExplosionTime;

	private const string SyncAction = "SyncSkill2314_BigBall";

	protected override void OnInstall()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCall_003Ed__11))]
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

	private void OnAttack()
	{
	}

	private void DoCreateBigBall(Vector3 pos, Quaternion rotation)
	{
	}

	private void OnBigBallUpdate(float delta)
	{
	}

	private void CreateExplosionBullet(Vector3 pos)
	{
	}

	private void OnBigBallCache(BulletBase bullet)
	{
	}

	private void SyncBigBall(Vector3 pos, Quaternion rotation)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
