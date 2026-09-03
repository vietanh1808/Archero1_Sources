using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class GameOverCooperationCtrl : GameOverModeCtrlBase
{
	public class GameOverData
	{
		public int dailyLevel;

		public int dailyScore;

		public int dailyLayer;

		public bool allLive;

		public int reborn_type;

		public int reborn_count;
	}

	public Image Image_Title;

	public RectTransform Title_Left;

	public RectTransform Title_Right;

	public Image Image_BG;

	public GameObject stageparent;

	public GameObject goldparent;

	public GameObject bestparent;

	public GameObject getparent;

	public GameObject getparents;

	public RectTransform topnode;

	public DxxText Text_ReachLevel;

	public DxxText Text_Stage;

	public DxxText Text_Layer;

	public DxxText Text_GoldName;

	public DxxText Text_Get;

	public DxxText Text_Beat;

	public DxxText Text_Close;

	public Image Image_NewBest;

	public GoldTextCtrl mScoreCtrl;

	public ScrollRectBase mScrollRect;

	public Image viewpoint;

	public ButtonCtrl Button_Close;

	public GameOver_NoNetCtrl mNoNetCtrl;

	public GameOverChallengeCtrl mChallengeCtrl;

	public MainUIBattleLevelCtrl mLevelCtrl;

	public DxxText mGameModeTitle;

	public GameOverScoreCtl scoreCtl;

	private const float TextStartScale = 1.5f;

	private const float playTime = 0.15f;

	private const float DropWidth = 130f;

	private const float DropHeight = 130f;

	private const float DropTop = 10f;

	private const float DropTime = 0.12f;

	private const int LineCount = 5;

	private const float EquipScale = 0.9f;

	private int gochapter;

	private int gostage;

	private int alllayer;

	private bool bNewBest;

	private int getgold;

	private int getexp;

	private int getDiamond;

	private float imagebgy;

	private float imagetitlex;

	private GameObject copyitem;

	private LocalUnityObjctPool mPool;

	private List<PropOneEquip> mDropList;

	private List<Drop_DropModel.DropData> list;

	private float startscale;

	private int mNetBackState;

	private bool bShowGot;

	private uint killMonster;

	private bool ifWin;

	private Sequence sequence;

	private bool isWiner;

	private float winderPart;

	private void InitItem()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	private int get_all_layer()
	{
		return 0;
	}

	private void SendGameOver()
	{
	}

	private void UpdateUI()
	{
	}

	private void update_stage()
	{
	}

	private void UpdateImageTitleLeftRight()
	{
	}

	private void InitGet()
	{
	}

	private void AddEquipOne(Sequence s, int index, int pos)
	{
	}

	private void PlayGetInternal()
	{
	}

	private void PlayGet()
	{
	}

	private void AnimationEnd()
	{
	}

	private void OnClickClose()
	{
	}

	public void PlayRewards()
	{
	}

	private bool HaveReward()
	{
		return false;
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void SetTitleText()
	{
	}

	private void queryitmes()
	{
	}
}
