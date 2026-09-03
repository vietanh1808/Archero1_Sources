using UnityEngine;
using UnityEngine.UI;

public class SailingShipWarningItem : MonoBehaviour
{
	[SerializeField]
	private DxxText selfPlayerName;

	[SerializeField]
	private HeadItem selfHeadItem;

	[SerializeField]
	private DxxText enemyPlayerName;

	[SerializeField]
	private HeadItem enemyHeadItem;

	[SerializeField]
	private GameObject selfStatus;

	[SerializeField]
	private GameObject enemyStatus;

	[SerializeField]
	private Image selfMonsterHead;

	[SerializeField]
	private Image enemyMonsterHead;

	private SailingShipWarningItemData itemData;

	public void Refresh(SailingShipWarningItemData itemData)
	{
	}

	private void RefreshPlayer()
	{
	}

	private void RefreshStatus()
	{
	}
}
