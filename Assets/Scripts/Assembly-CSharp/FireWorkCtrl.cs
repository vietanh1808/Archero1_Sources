using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FireWorkCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayFireworkEffect_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FireWorkCtrl _003C_003E4__this;

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
		public _003CPlayFireworkEffect_003Ed__13(int _003C_003E1__state)
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

	public GameObject FireworkNode;

	public RectTransform FireLeft;

	public RectTransform FireRight;

	public float RandFireworkTimeMax;

	public float RandFireworkTimeMin;

	public float LeftRange;

	public float RightRange;

	private Vector3 LeftPos;

	private Vector3 RightPos;

	private Vector3 targetLeft;

	private Vector3 targetRight;

	private void OnEnable()
	{
	}

	public void PlayFireworks()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayFireworkEffect_003Ed__13))]
	private IEnumerator PlayFireworkEffect()
	{
		return null;
	}

	public void EnableFirework(bool ifActive)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
