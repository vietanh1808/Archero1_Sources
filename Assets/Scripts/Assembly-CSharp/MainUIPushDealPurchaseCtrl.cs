using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MainUIPushDealPurchaseCtrl : MainUIButtonBase
{
	public GameObject Child;

	public ButtonCtrl ShowPopBtn;

	public DxxText Text_Time;

	public Image IconEquip;

	public Image IconQuality;

	private DateTime lastDateTime;

	private string showTimeStr;

	private bool ifUpdate;

	private CleverOnceItemItemData[] onceDataArr;

	private int curIndex => 0;

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

	private void SetSprite(Drop_DropModel.DropData dropData)
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
