using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1729 : SkillAloneBase
{
	public class Skill1729_LearnStarSkill : CustomJsonActionVO
	{
		public int SkillId;

		public int Guid;
	}

	public class Skill1729_StarCircle : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	[CompilerGenerated]
	private sealed class _003CLearnRandomSkill_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1729 _003C_003E4__this;

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
		public _003CLearnRandomSkill_003Ed__18(int _003C_003E1__state)
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

	private string skillParams;

	private float starCircleRate;

	private float starCircleRadius;

	private int starCircleBuffId;

	private float starCircleDuration;

	private float starExplodeRatio;

	private float starExplodeRadius;

	private int starCircleMaxCount;

	private float starCircleCDTime;

	private float preCastStarCircleTime;

	private int curCanCastStarCircleCount;

	private int starExplodeBulletId;

	private WeightRandomCount weightSkillLearn;

	private Dictionary<int, EntityBase> allEntitiesInAura;

	private const string SyncSkill1729_LearnStarSkill = "SyncSkill1729_LearnStarSkill";

	private const string SyncSkill1729_StarCircle = "SyncSkill1729_StarCircle";

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	[IteratorStateMachine(typeof(_003CLearnRandomSkill_003Ed__18))]
	private IEnumerator LearnRandomSkill()
	{
		return null;
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void CreatStarArea(Vector3 pos)
	{
	}

	public BulletBase CreateExplodeHit(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncLearnStarSkill(int skillId, int guid)
	{
	}

	private void SyncStarCircle(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
