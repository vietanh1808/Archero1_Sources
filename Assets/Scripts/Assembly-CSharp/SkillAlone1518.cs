using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1518 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CCreateSubBullet_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityBase entity;

		public SkillAlone1518 _003C_003E4__this;

		public int nBulletId;

		public Vector3 scale;

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
		public _003CCreateSubBullet_003Ed__10(int _003C_003E1__state)
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

	private float m_fRate;

	private float m_fReduce;

	private float m_fScale;

	private float m_fTotalAngle;

	private int m_nBulletCnt;

	private bool m_bInitialized;

	private Dictionary<BulletBase, float> m_dicSubBullets;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateSubBullet_003Ed__10))]
	private IEnumerator CreateSubBullet(EntityBase entity, int nBulletId, Vector3 scale)
	{
		return null;
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}
}
