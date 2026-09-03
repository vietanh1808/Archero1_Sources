using System;
using UnityEngine;

public class TradingHouseCommondityItem : MonoBehaviour
{
	public PropOneEquip propOne;

	public DxxText priceTex;

	public ButtonCtrl clickBtn;

	public GameObject selectObj;

	private Action<TradingHouseCommodity> onSelect;

	private TradingHouseCommodity mCommondity;

	private string red;

	private string green;

	private string plus;

	private string reduce;

	public void Init(Action<TradingHouseCommodity> callBack, TradingHouseCommodity commodity)
	{
	}

	public void Refresh()
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}
}
