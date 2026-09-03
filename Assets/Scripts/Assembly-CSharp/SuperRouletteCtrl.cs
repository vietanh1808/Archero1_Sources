using System;
using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class SuperRouletteCtrl : MonoBehaviour
{
	public ButtonCtrl Play_Button;

	public ButtonCtrl Buy_Button;

	public ButtonCtrl Limit_Button;

	public ButtonCtrl Give_Button;

	public ButtonCtrl Back_Button;

	public GameObject Play_Button_dis;

	public GameObject Buy_Button_dis;

	public GameObject Back_Button_dis;

	public DxxText TitleText;

	public DxxText FreeText;

	public DxxText PlayText;

	public DxxText AgainText;

	public DxxText LimitText;

	public DxxText CostText;

	public DxxText GiveupText;

	public List<SuperTurnTableOneCtrl> mList;

	public SpinWheel spineTableCtrl;

	public Action TurnEnd;

	public ParticleSystem rotEff;

	public ParticleSystem getEff;

	public GameObject clothBG;

	public GameObject equipmentBG;

	public GameObject puzzleBG;

	public PropOneEquip copyPropOneEquip;

	public Button maskBtn;

	private bool isSkip;

	private bool isLost;

	private SequencePool mSeqPool;

	private LocalUnityObjctPool mPool;

	private List<PropOneEquip> propList;

	public static readonly HashSet<int> showBgTypes;

	public void Init()
	{
	}

	public void giveUpHandler()
	{
	}

	public void Open()
	{
	}

	private void UpdateButton()
	{
	}

	public void InitGood()
	{
	}

	public void RotTable()
	{
	}

	public void setButtonEnable(bool value)
	{
	}

	public void CheckResult()
	{
	}

	public void DeInit()
	{
	}

	public void updateBG()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void showLostTimes()
	{
	}
}
