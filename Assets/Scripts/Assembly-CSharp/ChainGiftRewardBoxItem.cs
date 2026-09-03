using UnityEngine;
using UnityEngine.UI;

public class ChainGiftRewardBoxItem : MonoBehaviour
{
	[SerializeField]
	private Image boxIcon;

	[SerializeField]
	private ButtonCtrl clickBtn;

	private ChainGiftRewardItemData itemData;

	private int index;

	public void RefreshItem(int index, ChainGiftRewardItemData itemData)
	{
	}

	private void Click()
	{
	}

	private BattlePassChestInformation.TipPosition GetRewardShowItemTipPos()
	{
		return BattlePassChestInformation.TipPosition.LEFT;
	}

	private bool IsLeft()
	{
		return false;
	}
}
