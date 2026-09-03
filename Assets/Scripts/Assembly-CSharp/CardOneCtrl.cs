using System;
using System.Collections.Generic;
using DG.Tweening;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class CardOneCtrl : MonoBehaviour
{
	public ButtonCtrl button;

	public DxxText buttonText;

	public Image Image_Icon;

	public Image Image_Quality;

	public DxxText Text_Level;

	public DxxText Text_Name;

	public Image Image_Unknow;

	public CanvasGroup mCanvas;

	private Skill_slotout mData;

	public Action<CardOneCtrl> Event_Click;

	private static Dictionary<int, Color> mLevelContentColors;

	public static Dictionary<int, Color> mLevelColors;

	private int cardid;

	public LocalSave.CardOne carddata { get; private set; }

	private void Awake()
	{
	}

	public void InitCard(LocalSave.CardOne carddata)
	{
	}

	public void OnClick()
	{
	}

	public void SetButtonEnable(bool value)
	{
	}

	public void SetTextShow(bool value)
	{
	}

	public void UpdateUI()
	{
	}

	public Tweener PlayCanvas(float startalpha, float endalpha, float time)
	{
		return null;
	}

	public void SetAlpha(float alpha)
	{
	}

	public void SetNameShow(bool value)
	{
	}
}
