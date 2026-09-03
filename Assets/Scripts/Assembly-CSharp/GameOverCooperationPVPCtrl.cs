using Cooperation.NetEvent;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GameOverCooperationPVPCtrl : GameOverModeCtrlBase
{
	public RectTransform Rect_left;

	public RectTransform Rect_right;

	public Text Text_left;

	public Text Text_right;

	public Text Text_left_ID;

	public Text Text_right_ID;

	public HeadItem Head_left;

	public HeadItem Head_right;

	public DxxImage Image_vs;

	public DxxText Text_vs;

	public DxxImage Image_fail;

	public DxxText Text_fail;

	public Transform Rect_down;

	public UILineCtrlOne line;

	public Image[] Image_Icons;

	public DxxText[] Text_Icons;

	public DxxText Text_Time;

	public DxxText Text_Close;

	public DxxText Text_Report;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Report;

	public ParticleSystem WinEff;

	public GameObject go_Process;

	public GameObject go_Diamond;

	public Slider piggy_Slider;

	public DxxText text_Progress;

	public DxxText text_Completed;

	public DxxText text_Min;

	public DxxText Text_Max;

	public DxxImage img_Piggy;

	[SerializeField]
	private DxxText _textTopShowdown;

	[SerializeField]
	private GameObject _goTopShowdownReward;

	[SerializeField]
	private DxxText _textTopShowdownRewardTitle;

	[SerializeField]
	private DxxText _textTopShowdownReward;

	private int getgold;

	private int getDiamond;

	private int getscore;

	private int matchScore;

	private Sequence sequence;

	private SCBattleOverEvent tdata;

	private CooperationData cpdata;

	private bool IsTopShowdown => false;

	protected override void OnInit()
	{
	}

	private void SendBattleEndEvent()
	{
	}

	protected override void OnOpen()
	{
	}

	private void CheckTopShowdown()
	{
	}

	private void updateHead()
	{
	}

	private void OnClickClose()
	{
	}

	public void PlayRewards()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void sendEvent()
	{
	}

	private void queryitmes()
	{
	}

	private void AnimOpen()
	{
	}

	private void InitPiggy()
	{
	}

	private void RefreshPiggy(int value)
	{
	}
}
