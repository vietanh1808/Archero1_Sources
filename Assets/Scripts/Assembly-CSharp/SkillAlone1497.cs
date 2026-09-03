using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1497 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CTimer_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1497 _003C_003E4__this;

		private float _003CfAngle_003E5__2;

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
		public _003CTimer_003Ed__12(int _003C_003E1__state)
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

	private float INTERVAL;

	private Dictionary<int, int> m_dicMappingWeapons;

	private Coroutine m_Coroutine;

	private WaitForSeconds m_wait;

	private float m_fInterval;

	private Dictionary<BulletBase, BulletBase> m_dicBullets;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackSpeedChanged(float oldValue, float newValue)
	{
	}

	private void OnSuperSkill(bool value)
	{
	}

	private void OnSuperSkillEnd()
	{
	}

	private void RemoveTimer()
	{
	}

	[IteratorStateMachine(typeof(_003CTimer_003Ed__12))]
	private IEnumerator Timer()
	{
		return null;
	}

	private bool OnHitShield(GameObject go, BulletBase bullet)
	{
		return false;
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}

	private bool OnWhirlWindCanReboundBullet()
	{
		return false;
	}
}
