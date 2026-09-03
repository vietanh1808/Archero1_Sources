using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1741 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CCreateBullets_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1741 _003C_003E4__this;

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

	private float CONFIG_RATE;

	private int CONFIG_MIN;

	private int CONFIG_MAX;

	private int CONFIG_BulletId;

	private float CONFIG_DropRadius;

	private float CONFIG_InnerRadius;

	private float CONFIG_InnerHitRatio;

	private float CONFIG_OutRadius;

	private float CONFIG_OutHitRatio;

	private WaitForSeconds m_wait;

	private Coroutine m_coroutine;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateBullets_003Ed__14))]
	private IEnumerator CreateBullets()
	{
		return null;
	}
}
