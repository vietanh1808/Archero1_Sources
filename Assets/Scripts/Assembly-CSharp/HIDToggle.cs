using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HIDToggle : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForLoading_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HIDToggle _003C_003E4__this;

		public Action loadCompleteCallback;

		private float _003CcurrentWaitTime_003E5__2;

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
		public _003CWaitForLoading_003Ed__15(int _003C_003E1__state)
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

	public Button clickButton;

	public Image normalBg;

	public Image normalPoint;

	public Image selectBg;

	public Image selectPoint;

	private bool currentValue;

	private bool isAniming;

	public GameObject habbyLoading;

	public float MinWaitTime;

	private Action<bool, Text> completeCallback;

	private Func<bool> loadingCondition;

	private Text callBackText;

	private void Start()
	{
	}

	private void ResetState()
	{
	}

	public void SetDefaultState(bool isShow)
	{
	}

	private void ResetAnimState(bool isShow)
	{
	}

	private void KillAnim()
	{
	}

	private void OnClick()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForLoading_003Ed__15))]
	private IEnumerator WaitForLoading(Action loadCompleteCallback)
	{
		return null;
	}

	public void SetCallback(Action<bool, Text> completeCallback, Func<bool> loadingComplete, Text callBackText)
	{
	}
}
