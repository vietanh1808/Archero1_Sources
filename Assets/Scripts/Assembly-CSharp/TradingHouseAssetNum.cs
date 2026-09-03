using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradingHouseAssetNum : MonoBehaviour
{
	public enum ValueType
	{
		Assets = 0,
		Profit = 1
	}

	public DxxText nameText;

	public DxxText numText;

	public ButtonCtrl infoBtn;

	public GameObject tipsObj;

	public GameObject valueCopyOne;

	public RectTransform valueParent;

	public Button tipsBgBtn;

	public ValueType type;

	public Image iconImg;

	private List<GameObject> valueItems;

	private Action OnOpenTips;

	public void Init(Action callBack)
	{
	}

	public void Refresh()
	{
	}

	public void OpenTips()
	{
	}

	public void CloseTips()
	{
	}
}
