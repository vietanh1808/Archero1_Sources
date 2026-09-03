using System;
using TableTool;
using UnityEngine;

public class MazeCombineItemCtl : MonoBehaviour
{
	private const string cFristBuy = "Maze_FirstBuy_Equip";

	public int index;

	public GameObject equipItemPfb;

	public DxxText equipName;

	public DxxText buyMoney;

	public ButtonCtrl buttonBuy;

	protected Action<MazeCombineItemCtl> buyCallBack;

	protected EquipOneCtrl equipItem;

	protected GameObject equipObject;

	public LocalSave.EquipOne equipOnedata { get; private set; }

	public Daily_Maze_SmithyShop shopItemData { get; private set; }

	public void Init(Action<MazeCombineItemCtl> call)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void OnClickEquip(object sender)
	{
	}

	private void OnActionBuy(object sender)
	{
	}

	private void OnClickBuy()
	{
	}

	private void BuyEquipEnd()
	{
	}

	private void FirstBuy()
	{
	}

	private void NormalBuy()
	{
	}

	private void BuyEquip()
	{
	}

	private bool IsFirstBuy()
	{
		return false;
	}

	public void SetData(Daily_Maze_SmithyShop pData)
	{
	}

	private void RefText()
	{
	}
}
