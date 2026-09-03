using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1292 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CLoop_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1292 _003C_003E4__this;

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
		public _003CLoop_003Ed__10(int _003C_003E1__state)
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

	private float m_fAttackBase;

	private float m_fDistanceRatio;

	private float m_fNumRatio;

	private float m_fRange;

	private float m_fNumMax;

	private int m_nBuffId;

	private Coroutine m_Coroutine;

	private WaitForSeconds m_wait;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	[IteratorStateMachine(typeof(_003CLoop_003Ed__10))]
	private IEnumerator Loop()
	{
		return null;
	}
}
