using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SkillAlone9041 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CDelayCallPvE_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone9041 _003C_003E4__this;

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
		public _003CDelayCallPvE_003Ed__8(int _003C_003E1__state)
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

	private int partAddNum;

	private float addPerBuff;

	private float addMax;

	private int[] buffIds;

	private EntityHero self;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCallPvE_003Ed__8))]
	private IEnumerator DelayCallPvE()
	{
		return null;
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}

	private void OnCallPartbody(EntityBase partbody)
	{
	}

	protected virtual void OnHitAction(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}
}
