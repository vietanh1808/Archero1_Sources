using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1765 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CreverseAttack_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1765 _003C_003E4__this;

		public Vector3[] poses;

		public float[] rotateYs;

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
		public _003CreverseAttack_003Ed__14(int _003C_003E1__state)
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

	private float CONFIG_DELAY;

	private float CONFIG_RATE;

	private float CONFIG_HIT_RATIO;

	private float CONFIG_OFFSET;

	private float CONFIG_SCALE;

	private int CONFIG_FX_ID;

	private float CONFIG_CRIT_RATE_RATIO;

	private EntityHero m_self;

	private List<Vector3> poses;

	private List<float> angles;

	private WaitForSeconds m_wait;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnMeleeAttackEnd()
	{
	}

	[IteratorStateMachine(typeof(_003CreverseAttack_003Ed__14))]
	private IEnumerator reverseAttack(Vector3[] poses, float[] rotateYs)
	{
		return null;
	}

	protected virtual void CreateEffect(Vector3[] poses, float[] rotateYs)
	{
	}
}
