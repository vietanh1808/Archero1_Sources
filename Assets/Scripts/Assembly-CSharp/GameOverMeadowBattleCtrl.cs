using Cooperation.NetEvent;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMeadowBattleCtrl : GameOverModeCtrlBase
{
	public DxxText txt_zeroTip;

	public DxxText txt_oldScore;

	public DxxText txt_newScore;

	public DxxText txt_bonusDesc;

	public DxxText txt_bonusScore;

	public DxxText txt_deltaScore;

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

	private int getgold;

	private int getDiamond;

	private int getscore;

	private int matchScore;

	private Sequence sequence;

	private SCBattleOverEvent tdata;

	private CooperationData cpdata;

	protected override void OnInit()
	{
	}

	private void SendBattleEndEvent()
	{
	}

	protected override void OnOpen()
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

	private void AnimOpen()
	{
	}
}
