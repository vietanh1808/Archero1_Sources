using TableTool;
using UnityEngine;

public class GuildShopItemCtrl : MonoBehaviour
{
	private class RewardData
	{
		public int id;

		public int num;

		public int type;
	}

	[SerializeField]
	private Transform child;

	[SerializeField]
	private DxxText txtCost;

	[SerializeField]
	private DxxText txtLeft;

	[SerializeField]
	private DxxText titleName;

	[SerializeField]
	private ButtonCtrl btnBuy;

	[SerializeField]
	private DxxImage image_Top;

	[SerializeField]
	private DxxImage image_Middle;

	[SerializeField]
	private DxxImage Image_bottom;

	private PropOneEquip equip;

	private string itemId;

	private string purchaseId;

	private Guild_Shop data;

	private int availableCount;

	public void Set(string purchaseId, string itemId, Guild_Shop shopItemData, int availableCount)
	{
	}

	private void SetShopItemBg()
	{
	}

	private void SetDynamicUI()
	{
	}

	private bool checkCanExchange()
	{
		return false;
	}

	private void OnBtnBuyClick()
	{
	}

	private void InitEquipment(string data)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGuildFakeDataChanged(object o)
	{
	}
}
