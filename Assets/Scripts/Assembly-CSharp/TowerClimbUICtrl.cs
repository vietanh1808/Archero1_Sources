using UnityEngine;
using UnityEngine.UI;

public class TowerClimbUICtrl : MediatorCtrlBase
{
	public Image Bg;

	public Image BgLight;

	public UILoopScrollList floorList;

	public ButtonCtrl Button_Start;

	public ButtonCtrl Button_Mode;

	public DxxText Text_ChangeMode;

	public DxxImage Image_Button;

	public DxxImage Image_Icon;

	public DxxText Text_ButtonContent;

	public DxxText Text_Floor;

	public ButtonCtrl Button_Close;

	public DxxText Text_Addition;

	public DxxText Text_LastChance;

	public Slider lastChanceSlider;

	public DxxText Text_Title;

	[SerializeField]
	private ButtonCtrl mBtnLastChance;

	public RectTransform timeReward;

	public RectTransform bottomBack;

	public ButtonCtrl ButtonTimeRewardIcon;

	public Animation timeRewardInfoAnim;

	public DxxText Text_TimeRewardTips;

	public DxxText Text_CountDown;

	public GameObject animMask;

	public GameObject RuneRewardParent;

	public ButtonCtrl ButtonruneReward;

	public GameObject tips;

	public DxxText TextTips;

	public DxxText TextRuneReward;

	public ButtonCtrl buttonTips;

	public DxxText Text_Tips;

	private bool isGuide;

	private bool isPlayingAnim;

	public const int TOWERCLIMB_PLAYANIM_BOOL_INDEX = 10;

	public const int TOWERCLIMB_ANIMDATA_INDEX = 11;

	private const float COUNTDOWN_INTERVAL = 5f;

	private float tickTime;

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

	private void Update()
	{
	}

	private void UpdateCountDown()
	{
	}

	private void Refresh()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
