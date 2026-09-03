using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PlinkoActUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_CountDown;

	[SerializeField]
	private DxxText Text_Round;

	[SerializeField]
	private ButtonCtrl Button_Close;

	[SerializeField]
	private ButtonCtrl Button_Info;

	[SerializeField]
	private DxxText Text_PropDNum;

	public Image Image_ShopPropD;

	private long ShowNum_PropD;

	[SerializeField]
	private DxxText Text_PropANum;

	[SerializeField]
	private Image Image_ShopPropA;

	private int ShowNum_PropA;

	[SerializeField]
	private DxxText Text_PropBNum;

	[SerializeField]
	private Image Image_ShopPropB;

	private int ShowNum_PropB;

	[SerializeField]
	private ButtonCtrl Button_PropBall;

	[SerializeField]
	private GameObject go_PropBuy;

	[SerializeField]
	private DxxText Text_PropBallNum;

	private int ShowNum_PropBall;

	[SerializeField]
	private ButtonCtrl Button_Shop;

	[SerializeField]
	private DxxText Text_Shop;

	[SerializeField]
	private ButtonCtrl Button_Gift;

	[SerializeField]
	private DxxText Text_Gift;

	[SerializeField]
	private ButtonCtrl Button_Task;

	[SerializeField]
	private DxxText Text_Task;

	[SerializeField]
	private PlinkoPlayUI playUI;

	[SerializeField]
	private Image Image_Prop;

	public PlinkoButtonBall buttonBall;

	public PlinkoBottomBoxUI depthBoxUI;

	public GameObject PopRewardWindow;

	public RectTransform PopContainer;

	public GameObject cpPopItem;

	public GameObject RedPoint_Task;

	public GameObject RedPoint_Gift;

	public GameObject RedPoint_Shop;

	public GameObject go_Guide;

	public ParticleSystem Effect_Circle;

	public Vector3 DiamondPos => default;

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

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClickBall()
	{
	}

	private void onButtonShop()
	{
	}

	private void onButtonGift()
	{
	}

	private void onButtonTask()
	{
	}

	private void initUI()
	{
	}

	private void freshRound()
	{
	}

	private void freshTime()
	{
	}

	private void freshItems()
	{
	}

	private void freshItemOne(PlinkoFreshItemData pfid)
	{
	}

	private void freshItemD()
	{
	}

	private void freshItemA()
	{
	}

	private void freshItemB()
	{
	}

	private void freshItemBall()
	{
	}

	private void freshRedPoint()
	{
	}

	public void showPopReward(PlinkoProgressBoxShowData mdbsd)
	{
	}
}
