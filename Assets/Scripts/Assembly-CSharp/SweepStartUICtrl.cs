using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class SweepStartUICtrl : MediatorCtrlBase
{
	public DxxText Text_Desc;

	public ButtonCtrl Button_sweep;

	public ButtonCtrl Button_start;

	public ButtonCtrl Button_close;

	public GameObject ButtonSweepMask;

	public GameObject ButtonStartMask;

	public ScrollRectBase mScrollRect;

	public DxxText Text_sweep;

	public DxxText Text_start;

	public DxxText Text_time;

	public RedNodeCtrl RedCtrl;

	public DxxText Text_num;

	[SerializeField]
	private GameObject _IntroNodes;

	[SerializeField]
	private DxxText _IntroTxts;

	public GameObject Go_DiamondCard;

	public DxxText Text_DiamondCard;

	public GameObject HeroDropObj;

	public RectTransform HeroContent;

	public GameObject cpHeroItem;

	public SweepHeroPopItem heroPopItem;

	public BattlePass_ChestPropOne propTemplate;

	private SweepProxy.Transfer mTransfer;

	private LocalUnityObjctPool mPool;

	private SequencePool mSeqPool;

	private const int LineCount = 5;

	private const float WidthOne = 142f;

	private const float HeightOne = 142f;

	private int CurrentStage;

	private bool _isUIBusy;

	private bool isUIBusy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void OnInit()
	{
	}

	private void showResult()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void Update()
	{
	}

	private void updateSweepCnt()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void onButtonHeroItem(HeroTrainLevelDropData htData, Vector3 position)
	{
	}
}
