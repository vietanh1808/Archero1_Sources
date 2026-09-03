using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1291 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CAttack_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1291 _003C_003E4__this;

		public int cnt;

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
		public _003CAttack_003Ed__21(int _003C_003E1__state)
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

	private long m_nHpMax;

	private int m_nBulletMin;

	private float m_fHpPercent;

	private int m_nAdd;

	private int m_nMax;

	private int m_nBulletId;

	private float m_fInterval;

	private float m_fHitPercent;

	private float m_fRate;

	private float m_fHitExtraRatio;

	private float m_fBuffRate;

	private int m_nBuffId;

	private bool IsTriggerDouble;

	private int m_nBulletCnt;

	private Dictionary<EntityBase, long> m_dicEntityHitTime;

	private WaitForSeconds m_wait;

	private WaitForSeconds m_waitDouble;

	private int UsingBulletId => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackEnd()
	{
	}

	private int GetBarrageCount()
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CAttack_003Ed__21))]
	private IEnumerator Attack(int cnt)
	{
		return null;
	}

	private void MakeBarrage(int cnt, EntityBase taget = null)
	{
	}

	private void MakeBarrageExternal(EntityBase target)
	{
	}

	private void SetTriggerDouble(bool value)
	{
	}

	private void onHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}
}
