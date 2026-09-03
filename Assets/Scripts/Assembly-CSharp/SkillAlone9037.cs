using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone9037 : SkillAloneBase
{
	public class SkillEffect9037_SyncBulletsVO : CustomJsonActionVO
	{
		public Vector3 StartPos;

		public Vector3 EndPos;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone9037 _003C_003E4__this;

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
		public _003CDelayCall_003Ed__9(int _003C_003E1__state)
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

	private float callRuiRuiRise;

	private float callDragonRate;

	private float dragonRadius;

	private float dragonHitRatio;

	private float callRateHitted;

	private const int DragonBulletId = 8926;

	private const string SyncSkill9037_SyncSlopeDragon = "SyncSkill9037_SyncSlopeDragon";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCall_003Ed__9))]
	private IEnumerator DelayCall()
	{
		return null;
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void CreatSlopeDragon(Vector3 startPos, Vector3 endPos)
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	private void SyncSlopeDragon(Vector3 startPos, Vector3 endPos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
