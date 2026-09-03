using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1496 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CTimer_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1496 _003C_003E4__this;

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
		public _003CTimer_003Ed__10(int _003C_003E1__state)
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

	protected float RADIUS;

	private float INTERVAL;

	private float DISTANCE;

	protected int DEBUFF_ID;

	private Coroutine m_Coroutine;

	private WaitForSeconds m_wait;

	protected List<EntityBase> m_listMarkedEnemies;

	private List<BulletBase> m_listBullets;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	[IteratorStateMachine(typeof(_003CTimer_003Ed__10))]
	private IEnumerator Timer()
	{
		return null;
	}

	protected virtual IEnumerable<EntityBase> GetEnemies()
	{
		return null;
	}

	protected virtual void SendBuff(EntityBase target)
	{
	}

	private void OnEenmyDead(EntityBase entity)
	{
	}

	private void OnCreateForwardBullet(BulletBase bullet)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}
}
