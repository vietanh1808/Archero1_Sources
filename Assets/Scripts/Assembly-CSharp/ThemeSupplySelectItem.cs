using System;
using TableTool;
using UnityEngine;

public class ThemeSupplySelectItem : MonoBehaviour
{
	public PropOneEquip PropOne;

	public GameObject SelectionBorder;

	public ButtonCtrl Btn;

	public Drop_DropModel.DropData itemData;

	private Action<Drop_DropModel.DropData> clickHandler;

	private bool bEnabled;

	private bool bSelected;

	public void Init(Drop_DropModel.DropData data, Action<Drop_DropModel.DropData> onClick)
	{
	}

	public void SetEnabled(bool enabled)
	{
	}

	public void SetSelected(bool selected)
	{
	}
}
