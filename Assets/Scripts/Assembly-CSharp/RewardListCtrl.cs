using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class RewardListCtrl : MonoBehaviour
{
	private class ItemDisplayData
	{
		public bool isEquip;

		public LocalSave.EquipOne equipOne;

		public Drop_DropModel.DropData dropData;
	}

	public int MAX_ITEMS_PER_LINE;

	public int ITEM_SIZE_X;

	public int ITEM_SIZE_Y;

	public EquipOneCtrl Equip_One;

	private List<EquipOneCtrl> Equips;

	public PropOneEquip Prop_One_Equip;

	private List<PropOneEquip> Props;

	public RectTransform Reward_Parent;

	public void InitIcons(List<Drop_DropModel.DropData> items)
	{
	}
}
