using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ArtifactCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COnUpdate_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ArtifactCtrl _003C_003E4__this;

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
		public _003COnUpdate_003Ed__9(int _003C_003E1__state)
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

	[SerializeField]
	private ArtifactItemCtrl _copyOne;

	private LocalUnityObjctPool _pool;

	private float _time;

	private List<ArtifactItemCtrl> _list;

	private const float Interval = 0.1f;

	private WaitForSeconds _wait;

	private Coroutine _coroutine;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	[IteratorStateMachine(typeof(_003COnUpdate_003Ed__9))]
	private IEnumerator OnUpdate()
	{
		return null;
	}
}
