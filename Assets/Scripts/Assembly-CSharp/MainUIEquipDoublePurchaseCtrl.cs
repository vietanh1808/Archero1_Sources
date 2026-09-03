using System;
using UnityEngine;
using UnityEngine.UI;

public class MainUIEquipDoublePurchaseCtrl : MainUIButtonBase
{
	public GameObject Child;

	public ButtonCtrl ShowPopBtn;

	public DxxText Text_Time;

	public Image IconEquip;

	public Image IconQuality;

	public GameObject EquipOneParent;

	private PropOneEquip _propOne;

	private DateTime lastDateTime;

	private long lastSeen;

	private bool ifUpdate;

	private PropOneEquip PropOne => null;

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override bool IsShow()
	{
		return false;
	}

	public override void OnLanguageChange()
	{
	}

	public new void UpdateUI()
	{
	}

	private void Awake()
	{
	}

	public void OnBtnClick()
	{
	}

	private void ShowChild(bool value)
	{
	}

	private long UpdateCountDownTime()
	{
		return 0L;
	}

	private void Update()
	{
	}

	public void OnOpen()
	{
	}

	public new void OnClose()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
