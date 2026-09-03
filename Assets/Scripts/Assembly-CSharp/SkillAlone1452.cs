using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;

public class SkillAlone1452 : SkillAloneBraceletBase
{
	[CompilerGenerated]
	private sealed class _003CSendHit_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1452 _003C_003E4__this;

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
		public _003CSendHit_003Ed__5(int _003C_003E1__state)
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

	private float hitRate;

	private float attackRatio;

	private float bossAttackRatio;

	protected override void ParseArgs()
	{
	}

	protected override void onTrigger(Equip_equip bracelet, Action<EntityBase> onTrigger)
	{
	}

	[IteratorStateMachine(typeof(_003CSendHit_003Ed__5))]
	private IEnumerator SendHit()
	{
		return null;
	}
}
