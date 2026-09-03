using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1965 : SkillAloneBase
{
	public class SkillEffect965_2_IgniteVO : CustomJsonActionVO
	{
		public long shield;
	}

	[CompilerGenerated]
	private sealed class _003CChangeBoxingGloveEffectId_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityHero hero;

		public int id;

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
		public _003CChangeBoxingGloveEffectId_003Ed__14(int _003C_003E1__state)
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

	private float damageHPRate;

	private float extraDamageRate;

	private float gainShieldRate;

	private float baseShieldRate;

	private float lostHPRate;

	private float maxHPRate;

	private float shieldDurationTime;

	private float shieldCDTime;

	private int superSkillEffectId;

	private float preBuffEffectTime;

	private long shieldAdd;

	private GameObject shieldFx;

	private const int EFFECT_ID = 3100030;

	protected override void OnInstall()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeBoxingGloveEffectId_003Ed__14))]
	private IEnumerator ChangeBoxingGloveEffectId(EntityHero hero, int id)
	{
		return null;
	}

	protected override void OnUninstall()
	{
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}

	protected void onCrit(EntityBase entity, long realhit, HitStruct hs)
	{
	}

	private void DispatchEff()
	{
	}

	private void AddShieldFx()
	{
	}

	private void RemoveShieldFx()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void SyncSkillEffectMsg2(long shield)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
