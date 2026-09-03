using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;
using UnityEngine;

public class AdHarvestBattleCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003Cinitie_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdHarvestBattleCtrl _003C_003E4__this;

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
		public _003Cinitie_003Ed__7(int _003C_003E1__state)
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

	public GameObject child;

	public GameObject entitychild;

	private EntityHero m_Entity;

	private SequencePool mSeqPool;

	private List<Vector3> mPosList;

	private List<int> entityids;

	public void Init()
	{
	}

	[IteratorStateMachine(typeof(_003Cinitie_003Ed__7))]
	public IEnumerator initie()
	{
		return null;
	}

	public void DeInit()
	{
	}
}
