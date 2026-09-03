using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class GameOverLevelCtrl : GameOverModeCtrlBase
{
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

	public DxxText Text_Info;

	public DxxText Text_NewBest;

	public GoldTextCtrl mScoreCtrl;

	public ScrollRectBase mScrollRect;

	public Image viewpoint;

	public ButtonCtrl Button_Close;

	public GameOver_NoNetCtrl mNoNetCtrl;

	public GameOverChallengeCtrl mChallengeCtrl;

	public MainUIBattleLevelCtrl mLevelCtrl;

	public GameObject NewBestEff;

	public GameObject CompleteEff;

	public BattleStatisticUICtrl mBattleStatisticUICtrl;

	public ButtonSwitch mButtonSwitch;

	public DxxText mTextSwitch;

	public RectTransform bg;

	private const float TextStartScale = 1.5f;

	private const float playTime = 0.15f;

	private const float DropWidth = 130f;

	private const float DropHeight = 130f;

	private const float DropTop = 10f;

	private const float DropTime = 0.12f;

	private const int LineCount = 5;

	private const float EquipScale = 0.9f;

	private const bool autoScroll = true;

	private int gochapter;

	protected int gostage;

	private int alllayer;

	private bool bNewBest;

	protected int getgold;

	protected int getdiamond;

	protected int largediamonditem;

	protected int normaldiamonditem;

	protected int m_nDragonBoxItem;

	protected int getexp;

	protected int getSLGTalent;

	protected int getSLGCampTalent;

	protected int getSLGHonor;

	protected int m_nSoulPoint;

	protected int m_nRelicsBoxKey;

	private float imagebgy;

	private float imagetitlex;

	private GameObject copyitem;

	private LocalUnityObjctPool mPool;

	private List<PropOneEquip> mDropList;

	protected List<LocalSave.EquipOne> mEquipDatas;

	private float startscale;

	protected int mNetBackState;

	private bool bShowGot;

	private bool bBattlePassOpen;

	private uint killMonster;

	protected Sequence sequence;

	protected Sequence equipSequence;

	protected Sequence equipItemSequence;

	protected Sequence animationEndSequence;

	protected bool ifStageComplete;

	private bool m_bUnlockNextChapter;

	public GameObject go_Bottom;

	public ButtonCtrl btn_Exit;

	public ButtonCtrl btn_Play;

	public DxxText text_Exit;

	public DxxText text_Play;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private DxxText maskTip;

	private Transform cheatOne;

	public GameObject go_Process;

	public GameObject go_Diamond;

	public Slider piggy_Slider;

	public DxxText text_Progress;

	public DxxText text_Completed;

	public DxxText text_Min;

	public DxxText Text_Max;

	public DxxImage img_Piggy;

	private int costKey;

	private int ActivityPropID => 0;

	private int ActivityPropID2 => 0;

	private float OriginXPos => 0f;

	private void InitItem()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected virtual void OnAfterGetExp()
	{
	}

	protected virtual void OnAfterGetGold()
	{
	}

	protected virtual void InitSLGHonor(bool _ifStageComplete)
	{
	}

	protected virtual void SendGameEndCompleteFirst(int oldChapter, int curChapter)
	{
	}

	protected virtual void TgaTrackGameEnd()
	{
	}

	protected void TgaTrackGameEndInternal()
	{
	}

	protected virtual int GetSoulPoint()
	{
		return 0;
	}

	protected virtual int GetRelicsBosKey()
	{
		return 0;
	}

	protected virtual int GetExp()
	{
		return 0;
	}

	protected virtual int GetGold()
	{
		return 0;
	}

	protected virtual int GetSLGTalent()
	{
		return 0;
	}

	protected virtual int GetSLGCampTalent()
	{
		return 0;
	}

	protected virtual int GetDiamond()
	{
		return 0;
	}

	protected virtual int GetLargeDiamondItem()
	{
		return 0;
	}

	protected virtual int GetDragonBoxItem()
	{
		return 0;
	}

	protected virtual int GetNormalDiamondItem()
	{
		return 0;
	}

	protected virtual List<LocalSave.EquipOne> GetEquips()
	{
		return null;
	}

	protected virtual void CheckInvalidEquip()
	{
	}

	protected virtual void CheckWinOrFail()
	{
	}

	protected virtual void excute_reward()
	{
	}

	protected virtual float EquipLevelDropRatio(SelfAttributeData attributeData, LocalSave.EquipOne one)
	{
		return 0f;
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	protected virtual int get_all_layer()
	{
		return 0;
	}

	protected int get_max_layer()
	{
		return 0;
	}

	protected virtual void OnAfterEquipReady()
	{
	}

	protected virtual void SendGameOver()
	{
	}

	protected virtual void UpdateNewBestUI()
	{
	}

	protected virtual bool IsShowNewBestUI()
	{
		return false;
	}

	private void UpdateUINewBestStatus()
	{
	}

	private void UpdateUITrueNewBestStatus()
	{
	}

	private void UpdateUITitleImageStatus()
	{
	}

	private void UpdateUIBackgroundImgStatus()
	{
	}

	private void UpdateUITextInfoImageStatus()
	{
	}

	private void UpdateUITextReachLevelStatus()
	{
	}

	private void UpdateUIStageParentStatus()
	{
	}

	private void UpdateUILevelCtrlStatus()
	{
	}

	private void UpdateUITowerBtnStatus()
	{
	}

	private void UpdateUINormalBtnStatus()
	{
	}

	private void UpdateUI()
	{
	}

	protected virtual void ShowBest()
	{
	}

	protected virtual void update_stage()
	{
	}

	protected virtual void UpdateTxtLayer()
	{
	}

	private void UpdateImageTitleLeftRight()
	{
	}

	private void InitGet()
	{
	}

	private void AddCurrencyItem(CurrencyType currencyType, float xPos)
	{
	}

	private int GetCurrencyCount(CurrencyType currencyType)
	{
		return 0;
	}

	private void AddLevelExpOne(Sequence s, ref float xPos)
	{
	}

	private void AddGoldOne(Sequence s, ref float xPos)
	{
	}

	private void AddSLGTalentOne(Sequence s, ref float xPos)
	{
	}

	private void AddSLGCampTalentOne(Sequence s, ref float xPos)
	{
	}

	private void AddSLGHonorOne(Sequence s, ref float xPos)
	{
	}

	private void AddSoulPointOne(Sequence s, ref float xPos)
	{
	}

	private void AddDragonItemOne(Sequence s, ref float xPos)
	{
	}

	private void AddRelicsBoxKeyItemOne(Sequence s, ref float xPos)
	{
	}

	private void AddDiamondOne(Sequence s, ref float xPos)
	{
	}

	private void AddLargeDiamondOne(Sequence s, ref float xPos)
	{
	}

	private void AddNormalDiamondOne(Sequence s, ref float xPos)
	{
	}

	private void AddEquipOne(Sequence s, int index)
	{
	}

	private void AddEquipOneItem(int index, bool needScaleAni)
	{
	}

	private void UpdateUIGetParentStatus()
	{
	}

	private void UpdateUIGetParentsStatus()
	{
	}

	private void PlayGetInternal()
	{
	}

	private void PlayGet()
	{
	}

	private void AnimationEnd(bool needAni)
	{
	}

	private void OnClickClose()
	{
	}

	protected virtual void OnClickCloseInternal()
	{
	}

	protected virtual void OnLoading()
	{
	}

	public virtual void PlayRewards()
	{
	}

	protected virtual bool HaveReward()
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

	protected virtual void onAfterLanguageChange()
	{
	}

	protected virtual void UpdateTxtReachLevel()
	{
	}

	private void ClickMaskBtn()
	{
	}

	protected virtual void CompleteAllAni()
	{
	}

	private int GetCurChapter()
	{
		return 0;
	}

	private void InitPiggy()
	{
	}

	private void RefreshPiggy(int value, bool isPlayAni = true)
	{
	}

	private void UpdatePiggyStatus()
	{
	}
}
