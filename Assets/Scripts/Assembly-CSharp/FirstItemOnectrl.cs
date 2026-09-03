using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class FirstItemOnectrl : MonoBehaviour
{
	public ButtonGoldCtrl Button_Buy;

	public GameObject alreadybuy;

	public Image Image_Icon;

	public DxxText Text_Content;

	public DxxText Text_Value;

	public Action<FirstItemOnectrl> OnClickButton;

	public Shop_ReadyShop mData;

	private bool bBuy;

	public int mIndex { get; private set; }

	private void Awake()
	{
	}

	public void Init(int index, Shop_ReadyShop data, bool buy)
	{
	}

	public void SetBuy(bool buy)
	{
	}

	public void Buy()
	{
	}

	private void GetOneItem(Shop_item item)
	{
	}

	public static void GetOnePotion(Shop_item item)
	{
	}
}
