using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class GameOverDailyCtrl : GameOverModeCtrlBase
{
	public class MustDrop
	{
		public int equipId;

		public int equipNum;
	}

	public class GameOverData
	{
		public int dailyLevel;

		public int dailyScore;

		public int dailyMode;

		public int dailyLayer;

		public int[] rewardAdds;

		public int must_drop_type;

		public MustDrop[] must_drops;

		public bool online;

		public int difficult;

		public int reborn_type;

		public int reborn_count;

		public int mon_score;

		public int result_type;

		public int max_round;
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

	public Text Text_NewBest;

	public GoldTextCtrl mScoreCtrl;

	public ScrollRectBase mScrollRect;

	public Image viewpoint;

	public ButtonCtrl Button_Close;

	public GameOver_NoNetCtrl mNoNetCtrl;

	public GameOverChallengeCtrl mChallengeCtrl;

	public MainUIBattleLevelCtrl mLevelCtrl;

	public DxxText mGameModeTitle;

	public DxxText mTextDebug;

	public ButtonCtrl Button_Close2;

	public BattleStatisticUICtrl mBattleStatisticUICtrl;

	public ButtonSwitch mButtonSwitch;

	public DxxText mTextSwitch;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private DxxText maskTip;

	public GameObject go_Process;

	public GameObject go_Diamond;

	public Slider piggy_Slider;

	public DxxText text_Progress;

	public DxxText text_Completed;

	public DxxText text_Min;

	public DxxText Text_Max;

	public DxxImage img_Piggy;

	private int costKey;

	private const float TextStartScale = 1.5f;

	private const float playTime = 0.15f;

	protected const float DropWidth = 130f;

	private const float DropHeight = 130f;

	private const float DropTop = 10f;

	protected const float DropTime = 0.12f;

	private const int LineCount = 5;

	private const float EquipScale = 0.9f;

	protected int gochapter;

	private int gostage;

	private int alllayer;

	private bool bNewBest;

	protected int getgold;

	protected int getexp;

	private float imagebgy;

	private float imagetitlex;

	private GameObject copyitem;

	private LocalUnityObjctPool mPool;

	private List<PropOneEquip> mDropList;

	protected List<LocalSave.EquipOne> mEquipDatas;

	private float startscale;

	private int mNetBackState;

	private bool bShowGot;

	private bool ifBattlePassOpen;

	private uint killMonster;

	protected bool ifWin;

	private Sequence sequence;

	protected Sequence equipSequence;

	protected Sequence equipItemSequence;

	protected Sequence animationEndSequence;

	private Transform cheatOne;

	private int ActivityPropID => 0;

	private int ActivityPropID2 => 0;

	private void InitItem()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected virtual void send_event_game_end_daily()
	{
	}

	protected virtual void OnAfterGetExp()
	{
	}

	protected virtual void OnAfterGetGold()
	{
	}

	protected virtual int SaveDailyScore(int dailyId, int layer)
	{
		return 0;
	}

	protected virtual void CheckEquips(float fEquipRatio)
	{
	}

	private void excute_reward()
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

	protected virtual void SendGameOver()
	{
	}

	public void CheckDaily129(GameOverData data)
	{
	}

	private void CheckDaily128(GameOverData data)
	{
	}

	protected virtual int GetFinishedWaveId()
	{
		return 0;
	}

	protected virtual void onAfterLanguageChange()
	{
	}

	private void UpdateUITitleImageStatus()
	{
	}

	private void UpdateUIBackgroundImgStatus()
	{
	}

	private void UpdateGameModeTitleStatus()
	{
	}

	private void UpdateUITextReachLevelStatus()
	{
	}

	private void UpdateUIStageParentStatus()
	{
	}

	protected virtual void UpdateUILevelCtrlStatus()
	{
	}

	private void UpdateBestParentStatus()
	{
	}

	protected virtual void UpdateUI()
	{
	}

	protected virtual bool CanShowPiggy()
	{
		return false;
	}

	private void update_stage()
	{
	}

	private void UpdateImageTitleLeftRight()
	{
	}

	protected virtual void AddOtherCurrency(Sequence s, ref int index)
	{
	}

	protected virtual void AddOtherCurrencyImmediatly(ref int index)
	{
	}

	protected virtual void CheckOtherCurrency(ref int index)
	{
	}

	private void InitGet()
	{
	}

	private void AddLevelExpOne(Sequence s, out float xPos)
	{
		xPos = default;
	}

	private void AddGoldOne(Sequence s, ref float xPos)
	{
	}

	private void AddEquipOne(Sequence s, int index, LocalSave.EquipOne equipOne)
	{
	}

	protected virtual void UpdateUIGetParentStatus()
	{
	}

	protected virtual void UpdateUIGetParentsStatus()
	{
	}

	protected void AddCurrencyItem(CurrencyType currencyType, int index)
	{
	}

	protected virtual int GetCurrencyCount(CurrencyType currencyType)
	{
		return 0;
	}

	private void AddEquipOneItem(int index, LocalSave.EquipOne equipOne, bool needAddAni)
	{
	}

	protected virtual void OnAddEquipOneItem(PropOneEquip one)
	{
	}

	protected virtual void PlayGetInternal()
	{
	}

	protected virtual void PlayGet()
	{
	}

	protected void show_close(bool value)
	{
	}

	private void UpdateAnimationEndStatus()
	{
	}

	protected virtual bool CanShowButtonSwitch()
	{
		return false;
	}

	private void AnimationEnd(bool needAni)
	{
	}

	protected virtual void OnAnimationEnd()
	{
	}

	protected virtual void OnClickClose()
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

	private void SetTitleText()
	{
	}

	protected virtual void UpdateTxtLayer()
	{
	}

	protected virtual void UpdateTxtReachLevel()
	{
	}

	protected virtual void CheckWinOrFail()
	{
	}

	private void ClickMaskBtn()
	{
	}

	protected virtual void CompleteAllAni()
	{
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
