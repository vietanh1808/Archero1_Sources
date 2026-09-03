using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class AltarReclicsUpUICtrl : MediatorCtrlBase, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public AltarBG altarBG;

	public DxxText Text_Title;

	public DxxText Text_Level;

	public DxxText Text_Tips;

	public DxxText Equip_Title;

	public Slider slider;

	public DxxText Text_Slider;

	public DxxText Slider_Title;

	public Slider slider2;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Altar;

	public DxxText Text_ButtonAltar;

	public DxxText Text_LevelMax;

	public EquipOneCtrl equipOne;

	private int needStone;

	private int tempBreakId;

	private int needEquipBar;

	private int giveEquipBar;

	private int maxLevel;

	private AltarData altarData;

	public UISliderTween Tween1;

	public UISliderTween Tween2;

	public AltarReclicsChooseWindow RelicsWindow;

	private Dictionary<int, int> RelicsDict;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private AltarReclicsItem cellItem;

	private List<LocalSave.EquipOne> equipList;

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

	private void chooseOne(int equipid)
	{
	}

	public void freshItemNum(int equipid, int num)
	{
	}

	private int GetRelicsListIndex(int eid)
	{
		return 0;
	}

	private void calcuteStoneNum()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonAltar()
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

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView tableView)
	{
		return 0;
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public void setSlider(int adder)
	{
	}

	private List<uint> RelicsDict_List()
	{
		return null;
	}
}
