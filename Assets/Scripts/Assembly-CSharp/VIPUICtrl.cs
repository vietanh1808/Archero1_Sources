using System.Collections.Generic;
using GameProtocol;
using PureMVC.Interfaces;
using TableTool;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class VIPUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public Image Image_VIPBG;

	public ButtonCtrl Button_Info;

	public DxxText Text_Title;

	public DxxText Text_Lv;

	public DxxText Text_TitleLv;

	public DxxText Text_Count;

	public Slider slider;

	public RectTransform Window;

	public ButtonCtrl ButtonBox;

	public GameObject BoxState_Open;

	public GameObject BoxState_Closed;

	public DxxText Text_TopTitle;

	public DxxText Text_TimeTop;

	public Animation BoxAni;

	public Button Button_Add;

	public DxxText L_Title;

	public Button L_Box;

	public ButtonCtrl L_Get;

	public DxxText L_GetTxt;

	public GameObject L_Choosed;

	public DxxText Text_LockL;

	public DxxText M_Title;

	public Button M_Box;

	public ButtonCtrl M_Get;

	public DxxText M_GetTxt;

	public DxxText Text_TimeM;

	public DxxText Text_LockM;

	public DxxText R_Title;

	public Button R_Box;

	public ButtonCtrl R_Get;

	public DxxText R_GetTxt;

	public GameObject R_Choosed;

	public DxxText R_SubTitle;

	public DxxText Text_LockR;

	public ButtonCtrl Button_Back;

	[SerializeField]
	private GridLayoutGroup groupLayoutGroup;

	[SerializeField]
	private RectTransform bubbleRect;

	public StarDiamondItem starItem;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private int currentIndex;

	private int readMax;

	public UITableView tableView;

	public VIPRightItemCell cellItem;

	private List<VIPItemData> rightList;

	public GameObject PopWindow;

	public GameObject PopArrow;

	public GameObject BG1;

	public GameObject BG2;

	public GameObject Pop_Reward;

	public DxxText Text_Reward;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void android_escape()
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

	private void init()
	{
	}

	private void initTop()
	{
	}

	private void initBottom(int lv)
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonBack()
	{
	}

	public void onButtonBox()
	{
	}

	public void onButtonBoxLeft()
	{
	}

	public void onButtonBoxMiddle()
	{
	}

	public void onButtonBoxRight()
	{
	}

	public void onButtonBoxLeftGet()
	{
	}

	public void onButtonBoxMiddleGet()
	{
	}

	public void onButtonBoxRightGet()
	{
	}

	private void onButtonStar()
	{
	}

	private void purchaseSuccess(Privilege_level pl, CRespInAppPurchase data)
	{
	}

	public void onButtonAdd()
	{
	}

	public void onButtonLeft()
	{
	}

	public void onButtonRight()
	{
	}

	private void initTableView()
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public void openPopWindow(int lv, int direction, Vector3 position)
	{
	}
}
