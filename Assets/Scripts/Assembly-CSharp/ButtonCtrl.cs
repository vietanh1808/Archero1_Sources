using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonCtrl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
	public enum ButtonType
	{
		ButtonCtrl_Scale = 0,
		ButtonCtrl_Down20 = 11,
		ButtonCtrl_Down15 = 12,
		ButtonCtrl_Down10 = 13,
		ButtonCtrl_Static = 100,
		ButtonCtrl_ScaleDown20 = 51,
		ButtonCtrl_ScaleDown15 = 52,
		ButtonCtrl_ScaleDown10 = 53
	}

	[CompilerGenerated]
	private sealed class _003CstartI2_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<ButtonCtrl> action;

		public ButtonCtrl _003C_003E4__this;

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
		public _003CstartI2_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CstartI_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ButtonCtrl _003C_003E4__this;

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
		public _003CstartI_003Ed__52(int _003C_003E1__state)
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

	private static Material _gray;

	private static Material _uiMask;

	private string ButtonCtrl_DownString;

	private string ButtonCtrl_UpString;

	private string ButtonCtrl_DisableString;

	[SerializeField]
	private ButtonType mType;

	public Action onClick;

	public Action onDown;

	public Action onDisable;

	public Action onUp;

	public Action onLongPress;

	private bool bDown;

	private bool bEnter;

	private long scrollCount;

	private Animator ani;

	[SerializeField]
	protected SoundButtonType Button_ClickSound;

	protected bool bEnable;

	private Image[] mImages;

	private Text[] mTexts;

	private Color[] mTextsColor;

	private bool bDepondNet;

	private string disable_tips;

	private float mClickTime;

	[NonSerialized]
	public float ButtonClickInterval;

	private float _pressedTime;

	private float LongPressDuration;

	public static Material GrayMaterial => null;

	public static Material MaskMaterial => null;

	public bool IsEnabled => false;

	private bool is_click_valid()
	{
		return false;
	}

	private void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}

	private void OnEnable()
	{
	}

	public virtual void SetEnable(bool value)
	{
	}

	public virtual void SetEnableWithoutGray(bool value)
	{
	}

	public void SetGray(bool gray)
	{
	}

	public void SetDepondNet(bool value)
	{
	}

	public void SetImageMaterial(Material mat)
	{
	}

	private void UpdateTextsColor()
	{
	}

	private void SetTextsColor(bool disable)
	{
	}

	public void SetDisableTips(string tips)
	{
	}

	public void SetDisableTips(ETips type)
	{
	}

	private void AddClip()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	protected virtual bool CheckOnClick()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CstartI_003Ed__52))]
	private IEnumerator startI()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CstartI2_003Ed__53))]
	private IEnumerator startI2(Action<ButtonCtrl> action)
	{
		return null;
	}

	private void PlayDown()
	{
	}

	private void PlayUp()
	{
	}

	protected virtual void OnClick()
	{
	}

	protected virtual void OnLongPress()
	{
	}

	protected virtual void OnDownVirtual()
	{
	}

	protected virtual void OnUpVirtual()
	{
	}

	private void EnableReset()
	{
	}

	protected void Log(string msg)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
