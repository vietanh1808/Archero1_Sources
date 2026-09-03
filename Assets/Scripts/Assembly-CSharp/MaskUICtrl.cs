using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MaskUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CPlayRotate_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaskUICtrl _003C_003E4__this;

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
		public _003CPlayRotate_003Ed__6(int _003C_003E1__state)
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

	public GameObject EmptyRoot;

	public GameObject LoadingRoot;

	public Transform RotateTrans;

	private bool ifShow;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayRotate_003Ed__6))]
	private IEnumerator PlayRotate()
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
