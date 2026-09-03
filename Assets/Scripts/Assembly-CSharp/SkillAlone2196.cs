using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2196 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CFlySword_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2196 _003C_003E4__this;

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
		public _003CFlySword_003Ed__15(int _003C_003E1__state)
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

	private float CONFIG_INTERVAL;

	private int CONFIG_FLY_SWORD_ID;

	private int CONFIG_BUFF_ID;

	private int CONFIG_FLY_SWORD_MAX;

	private float CONFIG_FLY_SWORD_TIME;

	private float CONFIG_DECREASE_RATIO;

	private float CONFIG_MIN_RATIO;

	private float CONFIG_ANGULAR_VELOCITY;

	private float CONFIG_FLY_SWORD_HIT_RATIO;

	private float m_fLastTime;

	private Coroutine m_Coroutine;

	private WaitForSeconds m_wait;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnKnightWarrior(bool start)
	{
	}

	[IteratorStateMachine(typeof(_003CFlySword_003Ed__15))]
	private IEnumerator FlySword()
	{
		return null;
	}

	private void CreateFlySword()
	{
	}
}
