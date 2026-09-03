using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone9053 : SkillAloneBase
{
	public class Skill9053_WaterBullet : CustomJsonActionVO
	{
		public Vector3 Pos;

		public float Angle;
	}

	[CompilerGenerated]
	private sealed class _003CCastWaterBullets_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<EntityBase> list;

		public SkillAlone9053 _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CCastWaterBullets_003Ed__16(int _003C_003E1__state)
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

	private float checkRadius;

	private int waterBulletNum;

	private float waterBulletInterval;

	private float CDTime;

	private float hitRatio;

	private float preCastBulletsTime;

	private float preCheckTime;

	private float checkInterval;

	private int waterBulletId;

	private Coroutine creatBulletsCo;

	private List<EntityBase> enermylist;

	private const string SyncSkill9053_WaterBullet = "SyncSkill9053_WaterBullet";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void CheckEnermy()
	{
	}

	[IteratorStateMachine(typeof(_003CCastWaterBullets_003Ed__16))]
	private IEnumerator CastWaterBullets(List<EntityBase> list)
	{
		return null;
	}

	private void CreateWaterBullet(EntityBase target)
	{
	}

	protected BulletBase CreateBullet(int bulletId, Vector3 bulletPos, float rota, float atkPercent)
	{
		return null;
	}

	private void SyncShockExplode(Vector3 pos, float angle)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
