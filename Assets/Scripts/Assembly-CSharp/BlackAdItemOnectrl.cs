using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class BlackAdItemOnectrl : MonoBehaviour
{
	public GameObject equipparent;

	public Image Image_Buy;

	public DxxText Text_Name;

	public GameObject buyparent;

	public GameObject notbuyparent;

	public Shop_MysticShop mData;

	private PropOneEquip mItem;

	private Equip_equip equipdata;

	private LocalSave.EquipOne mEquipOne;

	[NonSerialized]
	public int mIndex;

	private bool bBuy;

	public void Init(int index, Shop_MysticShop data)
	{
	}

	private void SetBuy(bool buy)
	{
	}

	public void Buy()
	{
	}
}
