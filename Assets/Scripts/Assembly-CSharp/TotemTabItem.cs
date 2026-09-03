using System;
using UnityEngine;

public class TotemTabItem : MonoBehaviour
{
	[SerializeField]
	private GameObject goSelected;

	[SerializeField]
	private DxxImage tabIcon;

	[SerializeField]
	private ButtonCtrl btnClick;

	private Color _unselectedColor;

	private Color _selectedColor;

	private TotemSlotItemData _slotData;

	public void Init(TotemSlotItemData data, Action<TotemType> onClick)
	{
	}

	public void RefreshSelected(TotemType slotType)
	{
	}
}
