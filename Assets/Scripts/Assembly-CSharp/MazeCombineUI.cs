using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class MazeCombineUI : MediatorCtrlBase
{
	public DxxText texttitle;

	public DxxText texttitle2;

	public DxxText uicontext;

	public DxxText info_Money;

	public ButtonCtrl buttonBack;

	public Transform equips;

	public int itemCount;

	public GameObject copyItem;

	public RectTransform itemParent;

	protected MazeCombineItemCtl[] equipItems;

	private int mLoseid;

	private int mGetid;

	private int mFormid;

	private LocalSave.EquipOne coinItem;

	private MazeSmithyShopProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RestUI()
	{
	}

	private void RefUIData()
	{
	}

	private int GetCoin()
	{
		return 0;
	}

	private List<Daily_Maze_SmithyShop> GetRandomList()
	{
		return null;
	}

	private int GetWeight(Daily_Maze_SmithyShop sender)
	{
		return 0;
	}

	private IList<Daily_Maze_SmithyShop> GetNeedEquips()
	{
		return null;
	}

	public void SetMoney(string pToken)
	{
	}

	private void OnClickBack()
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

	private void OnBuyEnd(MazeCombineItemCtl sender)
	{
	}
}
