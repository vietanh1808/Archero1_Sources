using System;
using System.Collections.Generic;
using Dxx.Util;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class NormalRouletteCtrl : MonoBehaviour
{
	public SuperRouletteTaskItemOne taskItem;

	public ButtonCtrl Play_Button;

	public ButtonCtrl Buy_Button;

	public ButtonCtrl Limit_Button;

	public ButtonCtrl Tip_Button;

	public GameObject Play_Button_dis;

	public GameObject Buy_Button_dis;

	public GameObject Task_Button_dis1;

	public GameObject Task_Button_dis2;

	public GameObject Tip_Button_dis;

	public GameObject SuperRward_dis;

	public ButtonCtrl Task_Button;

	public RedNodeCtrl TaskRedCtrl;

	public ButtonCtrl TaskBack_Button;

	public ButtonCtrl TaskBGBack_Button;

	public RectTransform content;

	public DxxText TitleText;

	public DxxText TimeText;

	public DxxText FreeText;

	public DxxText TaskDescText;

	public DxxText PlayText;

	public DxxText AgainText;

	public DxxText LimitText;

	public DxxText CostText;

	public DxxText SuperText;

	public DxxText SuperRewardText;

	public DxxText FreeTimesText1;

	public DxxText FreeTimesText2;

	public List<SuperTurnTableOneCtrl> mList;

	public SpinWheel spineTableCtrl;

	public Action TurnEnd;

	public ParticleSystem rotEff;

	public ParticleSystem getEff;

	public Transform trangleEff;

	public UILineCtrlOne lineCtrl;

	public GameObject Task;

	public RectTransform TaskFrame;

	public SuperRewardCtrl SRewardCtrl;

	public SuperRouletteTipCtrl TipCtrl;

	public GameObject clothBG;

	public GameObject equipmentBG;

	public GameObject puzzleBG;

	public PropOneEquip copyPropOneEquip;

	public Button maskBtn;

	private bool isSkip;

	private LocalUnityObjctPool mPool;

	private List<SuperRouletteTaskItemOne> tlist;

	private List<CActivitySuperRouletteTask> RouletteTask;

	private List<PropOneEquip> propList;

	private int RandIndex;

	private SequencePool mSeqPool;

	private float height;

	private float itemheight;

	private float countdown;

	private float refreshcountdown;

	private float taskframeend;

	private float taskframestart;

	public static bool haveChange;

	public void Init()
	{
	}

	private void TaskBack()
	{
	}

	public void Open()
	{
	}

	private void ShowTask()
	{
	}

	private void Update()
	{
	}

	public void InitGood()
	{
	}

	private void UpdateButton()
	{
	}

	public void RotTable()
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
}
