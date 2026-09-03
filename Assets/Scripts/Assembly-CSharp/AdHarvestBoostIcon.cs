using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class AdHarvestBoostIcon : MonoBehaviour
{
	public enum VIP_BASE
	{
		VIP_BASE_Level = 1000,
		VIP_BASE_Coin = 1001,
		VIP_BASE_BattlePass = 1002,
		VIP_BASE_BigBattlePass = 1003,
		VIP_BASE_Tower = 1004,
		VIP_BASE_Idfa = 1005
	}

	public ButtonCtrl button;

	public Image imageLock;

	public Image iconHero;

	[SerializeField]
	private Image imageBg;

	public void SetHeroIcon(int heroId)
	{
	}

	public void SetHeroIcon(PlayerCharacter_Character pc)
	{
	}

	public void OnClick()
	{
	}

	public void SetEnabled(bool enabled)
	{
	}

	public void setVIPIcon(int abid)
	{
	}

	public void SetColor(Color color)
	{
	}
}
