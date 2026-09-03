using System;
using UnityEngine;

public class MainUIAchievementCtrl : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public GameObject effect;

	public DxxText txt_Name;

	private bool canclick;

	private void Awake()
	{
	}

	public void DoRequest(Action callback)
	{
	}

	public void Open()
	{
	}

	private void Show(bool value)
	{
	}

	public new void UpdateUI()
	{
	}

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

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override bool isRed()
	{
		return false;
	}

	public void onButtonIcon()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
