using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class ShopItemEquipExp : MonoBehaviour
{
	public static Dictionary<int, int> mRewards;

	public DxxText Text_Title;

	public ButtonCtrl Button_Get;

	public Transform itemparent;

	public GoldTextCtrl mGoldCtrl;

	public Action<int, ShopItemEquipExp> OnClickButton;

	private EquipOneCtrl mEquipItem;

	private Shop_Shop shopdata;

	private int mIndex;

	private void Awake()
	{
	}

	public void Init(int index)
	{
	}

	public int GetGold()
	{
		return 0;
	}

	public int GetDiamond()
	{
		return 0;
	}

	public void OnLanguageChange()
	{
	}

	public void UpdateNet()
	{
	}
}
