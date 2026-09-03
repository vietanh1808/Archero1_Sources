using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1754 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CDoCreateFlySword_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1754 _003C_003E4__this;

		public int bulletId;

		public float ratio;

		private int _003Ccnt_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CDoCreateFlySword_003Ed__9(int _003C_003E1__state)
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

	private float CONFIG_RATE;

	private int CONFIG_MIN;

	private int CONFIG_MAX;

	private float CONFIG_INTERVAL;

	private WaitForSeconds m_wait;

	private List<Coroutine> m_coroutines;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnCreateFlySword(BulletBase bullet, float ratio)
	{
	}

	[IteratorStateMachine(typeof(_003CDoCreateFlySword_003Ed__9))]
	private IEnumerator DoCreateFlySword(int bulletId, float ratio)
	{
		return null;
	}
}
