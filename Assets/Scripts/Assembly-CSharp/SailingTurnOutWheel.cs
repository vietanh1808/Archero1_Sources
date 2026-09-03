using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SailingTurnOutWheel : SailingTurnWheel
{
	[CompilerGenerated]
	private sealed class _003CRefresh_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingTurnOutWheel _003C_003E4__this;

		private List<SailingTurnItemData> _003Cdatas_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CRefresh_003Ed__5(int _003C_003E1__state)
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

	public SailingTurnRewardItem copyOne;

	private SailingTurnRewardItem[] items;

	private int[][] group;

	public override void Init()
	{
	}

	public override void Open(int wheelIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CRefresh_003Ed__5))]
	public IEnumerator Refresh()
	{
		return null;
	}
}
