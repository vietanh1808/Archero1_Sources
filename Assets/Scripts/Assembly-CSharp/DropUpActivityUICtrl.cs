using PureMVC.Interfaces;
using UnityEngine;

public class DropUpActivityUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private GameObject buttonGroup;

	[SerializeField]
	private DxxText EquipDropText;

	[SerializeField]
	private DxxText RelicsDropText;

	[SerializeField]
	private DxxText GemDropText;

	[SerializeField]
	private GameObject EquipDropBtn;

	[SerializeField]
	private GameObject RelicsDropBtn;

	[SerializeField]
	private GameObject GemDropBtn;

	[SerializeField]
	private GameObject HarvestBtn;

	[SerializeField]
	private GameObject Focus_EquipDrop;

	[SerializeField]
	private GameObject Focus_RelicsDrop;

	[SerializeField]
	private GameObject Focus_GemDrop;

	[SerializeField]
	private RedNodeCtrl equipRedCtrl;

	[SerializeField]
	private RedNodeCtrl relicsRedCtrl;

	[SerializeField]
	private RedNodeCtrl gemRedCtrl;

	public DxxText Text_Harvest;

	public GameObject Focus_Harvest;

	public DropUpUI uiDrop;

	public HarvestUI uiHarvest;

	public int currentTab;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshRed()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
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

	public void onButtonHarvest()
	{
	}

	public void onButtonEquipDrop()
	{
	}

	public void onButtonRelicsDrop()
	{
	}

	public void onButtonGemDrop()
	{
	}

	private void showUI(int tab)
	{
	}
}
