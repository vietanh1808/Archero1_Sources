using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class TimeMachineUIPanel : MediatorCtrlBase
{
	public RectTransform Window;

	public HeadItem headItem;

	public DxxText Text_Name;

	public DxxText Text_ID;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public RectTransform Container;

	public GameObject Hand;

	public PageView pageView;

	public GameObject[] Icons;

	[Header("第一页")]
	public DxxText P1Text1;

	public DxxText P1Text2;

	public DxxText P1Text3;

	public UINumberItem P1Number4;

	public DxxText P1Text5;

	[Header("第二页")]
	public DxxText P2Text1;

	public UINumberItem P2Number2;

	public DxxText P2Text3;

	[Header("第三页")]
	public DxxText P3Text1;

	public UINumberItem P3Number2;

	public DxxText P3Text3;

	public UINumberItem P3Number4;

	public DxxText P3Text5;

	public DxxText P3Text6;

	public Image Image_Char;

	[Header("第四页")]
	public DxxText P4Text1;

	public UINumberItem P4Number2;

	public DxxText P4Text3;

	[Header("第五页")]
	public Image[] P5TextBG;

	public DxxText[] P5Text;

	public DxxText P5Text2;

	public GameObject[] P5Mask;

	[Header("第六页")]
	public DxxText P6Text1;

	public ButtonCtrl P6ButtonGet;

	public DxxText P6TextGet;

	public ScrollRect P6Scroller;

	public RectTransform P6Content;

	public GameObject cpItem;

	private int currentIndex;

	private int totalPage;

	private Sequence handSequence;

	private float handDelayTime;

	private float handStartX;

	private bool handStartXCached;

	private Sequence textAppearSequence;

	private float textAppearInterval;

	private bool isRequestingReward;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
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

	private void Esc()
	{
	}

	private void initUI()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	public void onPageChanged(int index)
	{
	}

	public void GotoPage(int index)
	{
	}

	private void initPages()
	{
	}

	private void freshRewards()
	{
	}

	private void freshIcons()
	{
	}

	private void freshNumberAni()
	{
	}

	private void freshButton()
	{
	}

	private void freshHand()
	{
	}

	private void stopHand()
	{
	}

	private void freshTextAppear()
	{
	}

	private void playNumberAniFor(UINumberItem numItem)
	{
	}

	private GameObject[] getPageTextObjects(int page)
	{
		return null;
	}

	private CanvasGroup getOrAddCanvasGroup(GameObject go)
	{
		return null;
	}

	private string formatPercent(int percent)
	{
		return null;
	}

	private void onButtonRewardGet()
	{
	}
}
