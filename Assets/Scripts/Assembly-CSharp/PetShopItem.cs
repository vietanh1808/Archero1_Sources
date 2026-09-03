using System;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class PetShopItem : MonoBehaviour
{
	public Transform child;

	private PropOneEquip mEquip;

	public DxxText nameTex;

	public DxxText limitTex;

	public DxxText priceTex;

	public Image priceImg;

	public GameObject maskObj;

	public GameObject notfreeObj;

	public GameObject freeObj;

	public ButtonCtrl clickBtn;

	public GameObject critObj;

	public DxxText critText;

	public DxxText critValue;

	public DxxText freeTex;

	private CPetExchangeData mData;

	private Action BuyBackDo;

	public void InitEquip(Drop_DropModel.DropData data)
	{
	}

	public void Init(CPetExchangeData data, Action callBack)
	{
	}

	public void RefreshData()
	{
	}

	private void Click(int count)
	{
	}
}
