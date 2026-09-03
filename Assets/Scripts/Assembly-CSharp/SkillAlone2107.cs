using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2107 : SkillAloneWing
{
	public class Skill1Effect2107IgniteVO : CustomJsonActionVO
	{
		public int bulletId;

		public float atkPercent;

		public float radius;

		public Vector3 pos;

		public float wait;
	}

	[CompilerGenerated]
	private sealed class _003CCreateThunderCo_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public Vector3 pos;

		public SkillAlone2107 _003C_003E4__this;

		public int _bulletId;

		public float _hitRatio;

		public float _thunderRadius;

		private GameObject _003Ceffect_003E5__2;

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
		public _003CCreateThunderCo_003Ed__35(int _003C_003E1__state)
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

	private float HPRiseRate;

	private float CritRiseRate;

	private float searchEnemyRadius;

	private int bulletId;

	private float thunderRiseRate;

	private float thunderEffectInterval;

	private float thunderRadius;

	private float hitRatio;

	private float thunderEffectdelayTime;

	private int IsSkill1Effect;

	private int smallThunderBulletId;

	private int smallThunderCount;

	private float smallHitRatio;

	private float smallThunderFallDelayTime;

	private float smallThunderFallInterval;

	private int IsSkill2Effect;

	private int bigThunderBulletId;

	private float changeToBiggerRate;

	private float biggerThunderRadius;

	private int IsSkill3Effect;

	private long hpReduce;

	private int IsSkill4Effect;

	private float thunderHitRise;

	private float thunderRateRise;

	private int smallThunderAdd;

	private const string SyncSkill2107_bullet = "SyncSkill2107_bullet";

	private float preEffectTime;

	private int meetDemonTimes;

	private int meetAngleTimes;

	private float curThunderRise;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void DemonSelectAction()
	{
	}

	private void AngelRoomSelectAction()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateThunderCo_003Ed__35))]
	private IEnumerator CreateThunderCo(int _bulletId, Vector3 pos, float _hitRatio, float _thunderRadius, float waitTime)
	{
		return null;
	}

	public BulletBase _CreateThunder(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void SyncCreateThunder(int bulletId, Vector3 pos, float atk, float radius, float waitTime)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
