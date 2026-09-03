using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1220 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CCreateSubBullet_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityBase entity;

		public SkillAlone1220 _003C_003E4__this;

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
		public _003CCreateSubBullet_003Ed__13(int _003C_003E1__state)
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

	private int m_nBulletId;

	private float m_fThroughRatio;

	private int m_nMeleeBulletId;

	private float m_fAttackRatio;

	private Dictionary<EntityBase, int> m_dicDivideButtltCnts;

	private float fPerAngle;

	private float fMaxAngle;

	protected override void OnInstall()
	{
	}

	private void parseArgs(int id)
	{
	}

	private void synArgs(int id)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateSubBullet_003Ed__13))]
	private IEnumerator CreateSubBullet(EntityBase entity)
	{
		return null;
	}

	private void CreateBullets(float offset, float fTotalAngle, int cnt, float angle, Vector3 startPos)
	{
	}

	private void SyncBullets(float offset, float fTotalAngle, int cnt, float angle, Vector3 startPos)
	{
	}
}
