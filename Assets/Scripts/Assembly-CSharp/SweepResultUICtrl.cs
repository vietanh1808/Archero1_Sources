using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class SweepResultUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_close;

	public ScrollRectBase mScrollRect;

	public DxxText Text_Title;

	public SweepResultOneCtrl OneItem;

	public DxxText Text_tap;

	public GameObject go_Process;

	public GameObject go_Diamond;

	public Slider piggy_Slider;

	public DxxText text_Progress;

	public DxxText text_Completed;

	public DxxText text_Min;

	public DxxText Text_Max;

	public DxxImage img_Piggy;

	private LocalUnityObjctPool mPool;

	private SequencePool mSeqPool;

	private Color COLOR_1;

	private Color COLOR_2;

	private bool isDrag;

	protected override void OnInit()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ShowItems()
	{
	}

	private void InitPiggy()
	{
	}

	private void RefreshPiggy(int value)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
