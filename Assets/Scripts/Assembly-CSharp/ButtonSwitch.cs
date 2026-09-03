using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSwitch : ButtonCtrl
{
	private GraphicRaycaster RaycastInCanvas;

	public Transform ignore;

	private bool isCheck;

	private EventSystem eventSystem;

	private Action ClickOutAction;

	private bool bStartFromSelfOrIgnore;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Check()
	{
	}

	public void Init(Action OnClickOut)
	{
	}
}
