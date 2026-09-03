using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkyScraperGameListView : InfiniteListView
{
	[CompilerGenerated]
	private sealed class _003COpenReward_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkyScraperGameListView _003C_003E4__this;

		public float speedTime;

		private float _003Chight_003E5__2;

		private float _003CshowViewSize_003E5__3;

		private WaitForSeconds _003Cwait_003E5__4;

		private bool _003CisMove_003E5__5;

		private int _003Ci_003E5__6;

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
		public _003COpenReward_003Ed__8(int _003C_003E1__state)
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

	[Range(0.3f, 0.8f)]
	public float towerShowRate;

	public bool isFinal => false;

	public bool isNeedScoll => false;

	public int FirstGetRewardIndex => 0;

	public override float GetCellInterval(ViewCellData data)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003COpenReward_003Ed__8))]
	public IEnumerator OpenReward(float speedTime)
	{
		return null;
	}
}
