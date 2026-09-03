using System;
using UnityEngine;

public class EquipStorageShowItemOne : MonoBehaviour
{
	[SerializeField]
	private DxxImage itemBg;

	[SerializeField]
	private DxxImage itemIcon;

	[SerializeField]
	private DxxImage itemRareIcon;

	[SerializeField]
	private ButtonCtrl itemBtn;

	public void Init(ulong id, Sprite iconBg, Sprite icon, bool isShowIconBg = true, bool isShowRare = false, Action<ulong, Vector2> clickCallback = null)
	{
	}

	public void SetIconShow(bool isShow)
	{
	}

	public void SetRarityIcon(Sprite icon)
	{
	}
}
