using System.Collections.Generic;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PVEExcOutPanel : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public DxxText Text_SubTitle;

	public DxxText Text_RightCount;

	public DxxText Text_Choose;

	public EquipOneCtrl equipOne;

	public ButtonCtrl Button_Get;

	public DxxText Text_Recycle;

	[SerializeField]
	private Slider slider;

	private int chooseIndex;

	private int chooseCount;

	private int chooseCanMax;

	private int oneGive;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private PVEExcOutItem cellItem;

	private List<LocalSave.ExcOutData> excList;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	private void initTop()
	{
	}

	private void chooseItemOne(int index)
	{
	}

	private void calcuteChooseCount(int offset)
	{
	}

	public void OnClose()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void onNoteHandle(string key, object value)
	{
	}

	private void initList()
	{
	}

	public void onButtonClick(bool add)
	{
	}

	public void onButtonDoubleClick()
	{
	}

	public void onButtonLongPress(bool add)
	{
	}

	public void onButtonLongPressCancel(bool add)
	{
	}

	public void onButtonGet()
	{
	}

	public void onSliderValueChanged()
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
}
