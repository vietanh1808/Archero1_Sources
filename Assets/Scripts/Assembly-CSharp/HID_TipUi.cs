using System;
using HabbyUtils.UI;
using UnityEngine;
using UnityEngine.UI;

public class HID_TipUi : HIDUIBase
{
	public RectTransform tipsRect;

	public ButtonBase bgButton;

	public ButtonBase closeButton;

	public Text titleText;

	public Text descText;

	private Action callBack;

	private void Start()
	{
	}

	public void SetData(string title, string desc, Action callBack)
	{
	}

	private void PlayShow()
	{
	}

	private void PlayHide()
	{
	}
}
