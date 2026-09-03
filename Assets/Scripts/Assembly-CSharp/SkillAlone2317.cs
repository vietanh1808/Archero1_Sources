using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SkillAlone2317 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2317 _003C_003E4__this;

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
		public _003CDelayCall_003Ed__3(int _003C_003E1__state)
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

	private float newEnterTime;

	private int buffId;

	protected override void OnInstall()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCall_003Ed__3))]
	private IEnumerator DelayCall()
	{
		return null;
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnEnterKnightKing(bool isEnter)
	{
	}
}
