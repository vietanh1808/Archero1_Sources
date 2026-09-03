using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1295 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CAttackAgain_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1295 _003C_003E4__this;

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
		public _003CAttackAgain_003Ed__8(int _003C_003E1__state)
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

	private float m_fDelayTime;

	private float m_fAttakRatio;

	private int m_nWeaponId;

	private WaitForSeconds m_wait;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnMeleeAttackEnd(int nWeaponId)
	{
	}

	[IteratorStateMachine(typeof(_003CAttackAgain_003Ed__8))]
	private IEnumerator AttackAgain()
	{
		return null;
	}
}
