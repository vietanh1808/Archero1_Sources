using UnityEngine;
using UnityEngine.UI;

public class SailingShipGameResultItem : MonoBehaviour
{
	[SerializeField]
	private DxxText playerName;

	[SerializeField]
	private HeadItem headItem;

	[SerializeField]
	private DxxText battlePower;

	[SerializeField]
	private GameObject winnerIcon;

	[SerializeField]
	private GameObject winnerLight;

	[SerializeField]
	private Image monsterHeadIcon;

	private SailingShipWarningItemData itemData;

	private SailingShipBattleFighter winner;

	private SailingShipManager SailingShipManager => null;

	private SailingShipGameData SailingShipGameData => null;

	private SailingShipBattleResultData SailingShipBattleResultData => null;

	public void Refresh(SailingShipBattleFighter winner, SailingShipWarningItemData itemData)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshInfo()
	{
	}

	private void RefreshStatus()
	{
	}
}
