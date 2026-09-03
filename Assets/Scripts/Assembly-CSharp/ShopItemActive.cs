using System;
using UnityEngine;

public class ShopItemActive : MonoBehaviour
{
	public DxxText Text_Title;

	public DxxText Text_Purchase;

	public ButtonCtrl Button_Get;

	public Action<string, ShopItemActive> OnClickButton;

	private string data;

	private string itemid;

	private void Awake()
	{
	}

	public void Init(string data)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void UpdateNet()
	{
	}
}
