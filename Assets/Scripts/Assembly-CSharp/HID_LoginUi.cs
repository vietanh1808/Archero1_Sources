using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using HabbySdk.HabbyId;
using HabbyUtils.UI;
using UnityEngine;
using UnityEngine.UI;

public class HID_LoginUi : HIDUIBase
{
	[CompilerGenerated]
	private sealed class _003CWaitForTypeSet_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HID_LoginUi _003C_003E4__this;

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
		public _003CWaitForTypeSet_003Ed__56(int _003C_003E1__state)
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

	public GameObject GoMultiText;

	public RectTransform hidLogo;

	private List<GameObject> multiTexts;

	private bool _emailInputFieldIsFocused;

	private bool _emailInputFieldGetInput;

	private bool _emailInputFieldValidated;

	public LocalizationText nounText;

	private bool isStateSet;

	public GameObject[] RegisterItems;

	public GameObject[] LoginItems;

	public InputField emailInputField;

	public Toggle receiveEmailToggle;

	public Toggle agreeServiceToggle;

	public Image stateRight;

	public Image stateError;

	public ButtonBase continueButton;

	public ButtonBase backButton;

	public Button toastAcceptButton;

	private int lastEmailState;

	private Sequence inputSequence;

	public HID_ContinueButton HidContinueButton;

	public CanvasGroup cancelButtonCG;

	public CanvasGroup conButtonCG;

	public CanvasGroup descTextCG;

	public CanvasGroup inputFieldCG;

	public Image registerIcon;

	public Image loginIcon;

	public CanvasGroup topIconCG;

	public CanvasGroup writeCircleCG;

	private Vector2? bgStartPosition;

	private Vector2? cancelButtonStartPosition;

	private Vector2? conButtonStartPosition;

	private Vector2? descTextStartPosition;

	private Vector2? inputFieldStartPosition;

	private Vector2? redIconStartPosition;

	private Vector2? topIconStartPosition;

	private float OpenOffestTime;

	private float delayTime;

	public CanvasGroup bgCG => null;

	public CanvasGroup redIconCG => null;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected override void OnStateSet(ProcessType type)
	{
	}

	private void OnEmailInputValueChanged(string arg0)
	{
	}

	public void SetTooMany()
	{
	}

	private void ChangeInputImageState(int newState)
	{
	}

	private void OnClickContinue()
	{
	}

	private void CheckEmailCanBind(bool isBinded, bool isSamePerson)
	{
	}

	private void LoginProcess(ProcessType type)
	{
	}

	private void InitSecondConfirmation()
	{
	}

	private void OnClickBack()
	{
	}

	public void OnClickPrivacyPolicy()
	{
	}

	public void OnClickTermsOfService()
	{
	}

	private void RefreshMultiText()
	{
	}

	public override void NormalShow()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForTypeSet_003Ed__56))]
	private IEnumerator WaitForTypeSet()
	{
		return null;
	}

	private void BoxNormalShow()
	{
	}

	public override void NormalHide()
	{
	}

	public override void NextCancelCauseShow()
	{
	}

	public override void SelfCancelHide()
	{
	}
}
