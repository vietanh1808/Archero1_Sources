using System;
using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class DragonCombineCtrl : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public class PreviewData
	{
		public int type;

		public int id;

		public int Rare;

		public int quality;

		public bool IsMatch(LocalSave.EquipOne e)
		{
			return false;
		}
	}

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Combine;

	public DxxText Text_Combine;

	public GameObject mMaskparent;

	public EquipOneCtrl mPlayOne;

	private SequencePool mSeqPool;

	private ulong[] chooseIds;

	public EquipOneCtrl[] topItems;

	public GameObject[] topNode;

	public GameObject[] topMask;

	public DxxText descText;

	public DxxText Text_NoEquip;

	public GameObject Effect_Fire;

	public DragonCombineKeyAll combineKeyAll;

	public ButtonCtrl oneKeyCombineBtn;

	public DxxText oneKeyCombineText;

	private Dictionary<string, int> choosedHaveDict;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private DragonEquipItem cellItem;

	private List<DragonCombineData> equipList;

	public void OnInit()
	{
	}

	public void initUI()
	{
	}

	private void GiveRedPointFlag(List<DragonCombineData> list, int equipid, bool red)
	{
	}

	private void sort(List<DragonCombineData> list)
	{
	}

	private void show_combine_button(bool value)
	{
	}

	public void OnButtonTopIcon(int index)
	{
	}

	private void OnClickOne(DragonEquipItem item)
	{
	}

	private void checkTopState()
	{
	}

	private string GetRareString(int rare)
	{
		return null;
	}

	private void checkBottomState()
	{
	}

	private void checkBottomState(DragonCombineData one)
	{
	}

	private void checkBottomStateOne(DragonCombineData one)
	{
	}

	private bool canJoinDragonCombine(int mainid, Dictionary<string, int> dict, LocalSave.EquipOne me)
	{
		return false;
	}

	private void checkButtonCombine()
	{
	}

	private void android_escape()
	{
	}

	public void OnClose()
	{
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void PlayMove(int index, DragonEquipItem item, Action callback)
	{
	}

	public void onButtonCombine()
	{
	}

	private bool haveChooseMax(int mainid)
	{
		return false;
	}

	public int IsInChoose(ulong meid)
	{
		return 0;
	}

	public int findEmptyPos(LocalSave.EquipOne e, int mainid)
	{
		return 0;
	}

	public List<PreviewData> GetPreview(int equipid)
	{
		return null;
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

	private void OneKeyCombine(int chooses)
	{
	}
}
