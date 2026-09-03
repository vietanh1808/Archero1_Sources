using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ContractDebuffTips : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_Show_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ContractDebuffTips _003C_003E4__this;

		public Vector3 pos;

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
		public _003C_Show_003Ed__5(int _003C_003E1__state)
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
	private DxxText m_textTips;

	[SerializeField]
	private Image m_imgArrow;

	private void Awake()
	{
	}

	public void Init(string value)
	{
	}

	public void Show(Vector3 pos)
	{
	}

	[IteratorStateMachine(typeof(_003C_Show_003Ed__5))]
	private IEnumerator _Show(Vector3 pos)
	{
		return null;
	}

	public void Hide()
	{
	}
}
