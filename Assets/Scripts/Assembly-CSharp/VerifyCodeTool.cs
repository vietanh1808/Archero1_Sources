using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class VerifyCodeTool : MonoBehaviour
{
	public delegate void OnInputValueChanged(string character);

	[CompilerGenerated]
	private sealed class _003CDeactivateInputField_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VerifyCodeTool _003C_003E4__this;

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
		public _003CDeactivateInputField_003Ed__22(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CFocusInputField_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VerifyCodeTool _003C_003E4__this;

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
		public _003CFocusInputField_003Ed__17(int _003C_003E1__state)
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

	public const int VERIFY_CODE_LENGTH = 6;

	public GameObject[] VCodes;

	[SerializeField]
	private InputField VCodeInput;

	private Text[] VCodesText;

	private Image[] VCodesFrame;

	private int m_lastVcodeLength;

	private bool isFocused;

	private bool isFullInput;

	[CompilerGenerated]
	private OnInputValueChanged m_OnInputValueChangedEvent;

	public string Text { get; set; }

	public event OnInputValueChanged OnInputValueChangedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetFocusToInputField()
	{
	}

	[IteratorStateMachine(typeof(_003CFocusInputField_003Ed__17))]
	private IEnumerator FocusInputField()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnVCodeValueChanged(string value)
	{
	}

	[IteratorStateMachine(typeof(_003CDeactivateInputField_003Ed__22))]
	private IEnumerator DeactivateInputField()
	{
		return null;
	}

	private void OnMoveCursor(bool next, int which, string character)
	{
	}

	private void OnFocusInput()
	{
	}

	private void RefreshFrame(int which)
	{
	}

	private void CheckShowSelectBar()
	{
	}

	private void CheckHideSelectBar()
	{
	}
}
