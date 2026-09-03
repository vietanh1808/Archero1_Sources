using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1711GoodCtrl : SkillAloneAttrGoodBase
{
	[CompilerGenerated]
	private sealed class _003COnWait_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1711GoodCtrl _003C_003E4__this;

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
		public _003COnWait_003Ed__12(int _003C_003E1__state)
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

	private Transform m_parent;

	private int CONFIG_DIVIDE_SWORD_ID;

	private float CONFIG_DIVIDE_SWORD_DEGREE;

	private float CONFIG_DIVIDE_SWORD_RATE;

	private float CONFIG_ROTATE_SWORD_SPEED;

	private float CONFIG_SECTOR_ANGLE;

	private float CONFIG_DIVIDE_SWORD_HIT_RATIO;

	private WaitForSeconds m_wait;

	private Coroutine m_Coroutine;

	public void Init(EntityBase entity, Transform parent, params float[] args)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	[IteratorStateMachine(typeof(_003COnWait_003Ed__12))]
	private IEnumerator OnWait()
	{
		return null;
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}
}
