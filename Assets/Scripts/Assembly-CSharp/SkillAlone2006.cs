using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2006 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2006ExtraVO : CustomJsonActionVO
	{
		public bool IsMeteor;

		public int BulletId;

		public Vector3 StartPos;

		public Vector3 EndPos;

		public int Count;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2006 _003C_003E4__this;

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
		public _003CDelayCall_003Ed__17(int _003C_003E1__state)
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

	private float whirlwindDamageBoostRatio;

	private int damageReduceBuffId;

	private int[] starBulletIds;

	private float starDropRadius;

	private float starHitRatio;

	private int starMin;

	private int starMax;

	private int[] meteorBulletIds;

	private float meteorDropRadius;

	private float meteorInnerRadius;

	private float meteorInnerHitRatio;

	private float meteorOutRadius;

	private float meteorOutHitRatio;

	private Coroutine co;

	private const string SyncSkill2006_ExtraEffect = "SyncSkill2006_ExtraEffect";

	private const int WhirlwindBulletId = 1618;

	protected override void OnInstall()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCall_003Ed__17))]
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

	private void OnAthenaCloseRangeHit(EntityBase enemy, HitStruct hs)
	{
	}

	private void OnAthenaFlashConsumed(EntityBase attacker, HitStruct hs)
	{
	}

	private void OnAthenaWhirlwindCreated(BulletBase bullet, EntityBase target)
	{
	}

	private bool ShouldIgnoreExtraEffect(HitStruct hs)
	{
		return false;
	}

	private void CreateRandomExtraEffects(EntityBase target, bool needSync)
	{
	}

	private void CreateExtraStarBulletAtPos(int bulletId, Vector3 startPos, Vector3 endPos)
	{
	}

	private void CreateExtraMeteorBulletAtPos(int bulletId, Vector3 pos)
	{
	}

	private void SyncExtraEffect(bool isMeteor, int bulletId, Vector3 startPos, Vector3 endPos, int count)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
