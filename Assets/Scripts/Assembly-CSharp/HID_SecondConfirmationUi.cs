using System;
using HabbySdk.HabbyId;
using UnityEngine;
using UnityEngine.UI;

public class HID_SecondConfirmationUi : HIDUIBase
{
	public new HID_AnimHolder H;

	public RectTransform scaleAnimTransform;

	public new CanvasGroup canvasGroup;

	public Button bgButton;

	public Button backButton;

	public Button confirmButton;

	public LocalizationText descText;

	public LocalizationText backText;

	public LocalizationText confirmText;

	public Sprite blackBgImage;

	public Sprite whiteBgImage;

	public Color blackTextColor;

	public Color whiteTextColor;

	public void SetData(int descTextId, int backTextId, int confirmTextId, Action backAction, Action confirmAction, bool blackColorRight)
	{
	}

	private void SpecialShow()
	{
	}

	private void SpecialHide()
	{
	}
}
