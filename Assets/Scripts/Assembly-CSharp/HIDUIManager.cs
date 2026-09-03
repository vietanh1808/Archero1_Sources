using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LiquidState.Synchronous.Core;
using UnityEngine;

public class HIDUIManager : MonoBehaviour
{
	[CompilerGenerated]
	private static Action m_OnUIAllHide;

	private Dictionary<eHIDUI, HIDUIBase> uiDict;

	private List<eHIDUI> openingUiList;

	public RectTransform panelHolder;

	public RectTransform hidLogo_Static;

	public HID_AnimHolder H;

	private UIState lastState;

	private IStateMachine<UIState, UICommands> UIFSM;

	private int cacheLayer;

	private float timer;

	private int openLayer;

	public GameObject TransparentMask;

	public RectTransform hidLogo_Dynamic => null;

	public UIState CurrentState => UIState.DefaultState;

	public static event Action OnUIAllHide
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

	private void Awake()
	{
	}

	public HIDUIBase GetUi(eHIDUI eHIDUI)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public void ShowToast(bool isGreen, string desc)
	{
	}

	public void OpenDialogueBox(int descTextId, int backTextId, int confirmTextId, Action backAction, Action confirmAction, bool blackColorRight)
	{
	}

	public void UIFSMFire(UICommands command)
	{
	}

	public HID_IconAnim GetIconAnim()
	{
		return null;
	}

	public void Testtt()
	{
	}

	private void InitFSM()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void OpenTransparentMask()
	{
	}

	public void HideTransparentMask()
	{
	}

	private void ImeWorkaroundForAndroid()
	{
	}
}
