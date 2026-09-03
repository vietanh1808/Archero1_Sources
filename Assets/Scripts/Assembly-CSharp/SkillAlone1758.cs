using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1758 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003Cwait2_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1758 _003C_003E4__this;

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
		public _003Cwait2_003Ed__33(int _003C_003E1__state)
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

	private float CONFIG_HIT_RATIO;

	private float CONFIG_INTERVAL;

	private float CONFIG_DURATION;

	private int CONFIG_DEBUFF_ID;

	private int CONFIG_WEAPON_EFFECT_ID;

	private int CONFIG_DRAGON_EFFECT_ID;

	private float CONFIG_DRAGON_EFFECT_RATE;

	private float CONFIG_DRAGON_RADIUS;

	private int CONFIG_DRAGON_DEAD_EFF;

	private float CONFIG_AOE_HIT_RATIO;

	private int CONFIG_SUPER_SKILL_EFFECT_ID;

	private float CONFIG_DRAGON_CD;

	private int[] BULLETIDS;

	private WaitForSeconds m_wait1;

	private WaitForSeconds m_wait2;

	private Coroutine m_coroutine1;

	private Coroutine m_coroutine2;

	private float m_fTime_1;

	private float m_fTime_2;

	private List<GameObject> m_listWeaponEffects;

	private List<GameObject> m_listDeadEffects;

	private bool m_bDragonMode;

	private bool? m_bPause;

	private float m_fDragonStartTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void onHit(EntityBase target, HitStruct hs, HittedData hd)
	{
	}

	protected virtual void CreateDragonEffect(EntityBase target)
	{
	}

	protected void DoCreateDragonEffect(EntityBase target)
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void cacheDeadEffect()
	{
	}

	[IteratorStateMachine(typeof(_003Cwait2_003Ed__33))]
	private IEnumerator wait2()
	{
		return null;
	}

	protected virtual void CreateWeaponEffect()
	{
	}

	protected void DoCreateWeaponEffect()
	{
	}

	protected virtual void CacheWeaponEffects()
	{
	}

	protected void DoCacheWeaponEffects()
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}
}
