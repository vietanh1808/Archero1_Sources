using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2200 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CChangeBoxingGloveEffectId_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CChangeBoxingGloveEffectId_003Ed__13(int _003C_003E1__state)
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

	private float CONFIG_CD;

	private int CONFIG_BUFF_ID;

	private float CONFIG_BUFF_TIME;

	private float CONFIG_BULLET_RATE;

	private int CONFIG_BULLET_ID;

	private float CONFIG_HIT_RATIO;

	private const int superSkillEffectId = 3411662;

	private float m_fLastTime;

	private int angleLimit;

	private Coroutine _coroutine;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeBoxingGloveEffectId_003Ed__13))]
	private IEnumerator ChangeBoxingGloveEffectId(EntityHero hero, int id)
	{
		return null;
	}

	private void OnHitted(EntityBase entity, long value, HitStruct hs)
	{
	}

	private void OnCrit(EntityBase entity, long value)
	{
	}

	public virtual BulletBase CreateFlySword(int bulletId, Vector3 startpos, float angle, float hitRatio, EntityBase target)
	{
		return null;
	}

	private void SyncFlySword(Vector3 startPos, float angle, int uid)
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}
}
