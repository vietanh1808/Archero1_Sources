using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class DragonUICtrl : MediatorCtrlBase, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public Image img_combineRedDot;

	public DragonChangeEffectCtrl changeEffectCtrl;

	public DxxText txt_attr_title;

	public Image image_standard;

	public Canvas bgCanvas;

	public Canvas profileContainerCanvas;

	public Canvas imgCanvas;

	public Canvas attrCanvas;

	public Canvas bottomContainerCanvas;

	public DragonSortCtrl sortCtrl;

	public GameObject attr_comp;

	public Transform attributes_container;

	public ButtonCtrl btn_prev;

	public ButtonCtrl btn_combine;

	public DxxText txt_combine;

	public ButtonCtrl btn_sort;

	public DxxText txt_sort;

	public ButtonCtrl btn_levelup;

	public DxxText txt_levelup;

	public DxxText txt_myCollection;

	public DragonProfileUI profileUI_0;

	public DragonProfileUI profileUI_1;

	public DragonProfileUI profileUI_2;

	private DragonUICtrlVO vo;

	private List<DragonProfileUI> profileUIList;

	private LocalSave.EquipOne newDragonOne;

	private List<ulong> chooseList;

	private SelfAttributeData selfAttributeShow;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private DragonMagicEquipItem cellItem;

	private List<LocalSave.EquipOne> equipList;

	public override void OnLanguageChange()
	{
	}

	protected override void OnInit()
	{
	}

	private void onSort(List<LocalSave.EquipOne> list)
	{
	}

	private void onClickBtnLevelUp()
	{
	}

	private void refreshBtnLevelUp()
	{
	}

	private LocalSave.EquipOne getDragonInSlot()
	{
		return null;
	}

	private void onClickBtnCombie()
	{
	}

	private void onClickBtnPre()
	{
	}

	private void onButtonCombine()
	{
	}

	protected override void OnSetArgs(object o)
	{
	}

	protected override void OnOpen()
	{
	}

	private void refreshCombineRedDot()
	{
	}

	private void setCanvasSortingOrder(Canvas canvas, int deltaDepth)
	{
	}

	private void refreshAll()
	{
	}

	protected override void OnClose()
	{
	}

	private void initProfileUIList()
	{
	}

	private void android_escape()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onSwitchEquipDragon(int dragonSlotIndex)
	{
	}

	private void onUnEquipDragon(int slotIndex)
	{
	}

	private void onEquipDragon(LocalSave.EquipOne dragonOne)
	{
	}

	private void OnDragonChanged(int slotIndex, LocalSave.EquipOne dragonOne)
	{
	}

	private void setNewEquipOne(LocalSave.EquipOne dragonOne)
	{
	}

	private LocalSave.EquipOne checkIfHaveSameDragon(DragonType dragonType)
	{
		return null;
	}

	private int getAvailableSlotIndex()
	{
		return 0;
	}

	private void refreshDragonProfiles(bool init = false)
	{
	}

	private void refreshAttributeInfo()
	{
	}

	private List<AttrCompVO> getAttrCompList(SelfAttributeData selfAttributeData)
	{
		return null;
	}

	private void refreshDragonList(List<LocalSave.EquipOne> list, bool scroll = false)
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
