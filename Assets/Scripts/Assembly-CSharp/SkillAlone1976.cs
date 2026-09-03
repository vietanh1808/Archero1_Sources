using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1976 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CCreateBullets_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1976 _003C_003E4__this;

		private int _003CbulletCount_003E5__2;

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
		public _003CCreateBullets_003Ed__16(int _003C_003E1__state)
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

	private int callMeteoroliteProb;

	private int bulletID;

	private int callMeteoroliteMinCount;

	private int callMeteoroliteMaxCount;

	private float callMeteoroliteInterval;

	private float callRadius;

	private float innerRadius;

	private float innerHitRatio;

	private float outRadius;

	private float outHitRatio;

	private Coroutine callMeteoroliteCoroutine;

	private WaitForSeconds wait;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnKillEnemy(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	private void CreateMeteorolite()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateBullets_003Ed__16))]
	private IEnumerator CreateBullets()
	{
		return null;
	}
}
