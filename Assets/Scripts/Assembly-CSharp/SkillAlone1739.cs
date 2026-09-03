using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1739 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CCreateBullets_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1739 _003C_003E4__this;

		private int _003Ccnt_003E5__2;

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
		public _003CCreateBullets_003Ed__14(int _003C_003E1__state)
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

	private float CONFIG_HP_PERCENT;

	private int CONFIG_BULLET_ID;

	private int CONFIG_DEBUFF_ID;

	private int CONFIG_CNT_MIN;

	private int CONFIG_CNT_MAX;

	private int CONFIG_EFFECT_ID;

	private float CONFIG_RADIUS;

	private float m_fTotal;

	private float m_fLastHpPercent;

	private Coroutine m_coroutine;

	private WaitForSeconds m_wait;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHpChanged(long currentHP, long maxHP, float percent, long change)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateBullets_003Ed__14))]
	private IEnumerator CreateBullets()
	{
		return null;
	}
}
