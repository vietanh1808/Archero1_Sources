using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1735 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CCreateBullet_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1735 _003C_003E4__this;

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
		public _003CCreateBullet_003Ed__17(int _003C_003E1__state)
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

	private float CONFIG_DISTANCE;

	private float CONFIG_RATE;

	private int CONFIG_CNT;

	protected int CONFIG_BULLET_ID;

	protected float CONFIG_HIT_RATIO;

	private float CONFIG_WAIT_TIME;

	private float CONFIG_BULLET_ROTATE_OFFSET;

	private float m_fMoveDistance;

	private bool m_bMoveFlag;

	private Vector3? m_lastPos;

	private float m_fDistance;

	private Coroutine m_coroutine;

	private WaitForSeconds m_wait;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnMoving(bool move)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateBullet_003Ed__17))]
	private IEnumerator CreateBullet()
	{
		return null;
	}

	protected virtual void DoCreateBullet()
	{
	}
}
