using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class RelicsElevateUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public RectTransform Window;

	public ButtonCtrl Button_Left;

	public DxxText Text_Left;

	public GameObject Foucs_Left;

	public ButtonCtrl Button_Right;

	public DxxText Text_Right;

	public GameObject Focus_Right;

	public RelicsItem relicsItem;

	public ButtonCtrl Button_ArrowLeft;

	public ButtonCtrl Button_ArrowRight;

	public ButtonCtrl Button_Back;

	public PropOneEquip LeftProp;

	public PropOneEquip rightProp;

	public PropOneEquip midProp;

	public ButtonCtrl Button_Level;

	public ButtonCtrl Button_Star;

	public DxxText Text_ButtonLevel;

	public DxxText Text_ButtonStar;

	public PageView pageView;

	public RectTransform Container_Relics;

	public GameObject cpEquipItem;

	public DxxText Text_AttrTitle;

	public GameObject AttrNumObj;

	public GameObject StarNumObj;

	private Tween fadeTween;

	public DxxText Text_AttrPre;

	public DxxText Text_AttrNext;

	public DxxText Text_AttrTips;

	public DxxText Text_BottomTips;

	private List<int> relicsList;

	private int currentTab;

	private int currentIndex;

	private int haveMat;

	private int needMatId;

	private int needMat;

	private int needCoin;

	private int needStar;

	private int StarMax;

	private int LevelMax;

	private int haveFragment;

	private int needFragment;

	private bool needUpAltar;

	public UITableView tableView;

	public RelicsTextCell cellItem;

	private List<RelicsTextData> textList;

	public DxxText _textSizeCalculator;

	private const float defaultTextWidth = 600f;

	private const int defaultFontSize = 22;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnEscape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void onPageChanged(int index)
	{
	}

	private void switchItem(int page)
	{
	}

	private void showAttrList_Level(int reid, int star, int level)
	{
	}

	private void showAttrList_Star(int reid, int star, int level)
	{
	}

	private void showBottomStar(int next, int max)
	{
	}

	private void successLevelUp()
	{
	}

	private void showTab(int tab)
	{
	}

	public void onButtonBack()
	{
	}

	public void onButtonTabLeft()
	{
	}

	public void onButtonTabRight()
	{
	}

	public void onButtonArrowLeft()
	{
	}

	public void onButtonArrowRight()
	{
	}

	public void onButtonLevel()
	{
	}

	public void onButtonStar()
	{
	}

	private void TempSetTextFontSize(DxxText dxxText)
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

	private float CalculateTextHeight(string text, float textWidth = 600f, int fontSize = 22)
	{
		return 0f;
	}
}
