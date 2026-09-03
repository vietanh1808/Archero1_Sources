using System.Collections.Generic;
using UnityEngine;

public class AdHarvestBoost : MonoBehaviour
{
	protected enum PopupType
	{
		COIN = 0,
		BATTLEPASS = 1,
		BIGBATTLEPASS = 2,
		TOWER = 3,
		IDFA = 4,
		HERO = 5,
		VIP = 6,
		Level = 7
	}

	public ScrollRectBase mScrollRect1;

	public RectTransform content1;

	[SerializeField]
	private AdHarvestBoostHeroInfinity mInfinityVip;

	public ScrollRectBase mScrollRect2;

	public RectTransform content2;

	[SerializeField]
	private AdHarvestBoostHeroInfinity mInfinityHero;

	public AdHarvestBoostPopup popup;

	public AdHarvestBoostIcon iconLevel;

	public AdHarvestBoostIcon iconCoin;

	public AdHarvestBoostIcon iconBattlePass;

	public AdHarvestBoostIcon iconBigBattlePass;

	public AdHarvestBoostIcon iconTower;

	public AdHarvestBoostIcon iconIdfa;

	public AdHarvestBoostIcon[] vipIcon;

	public AdHarvestBoostIcon iconHeroCopy;

	protected Dictionary<int, AdHarvestBoostIcon> iconHeroes;

	private int[] enabledBoostHeros;

	private int[] disabledBoostHeros;

	private int[] boostHeroIds;

	private List<int> vipIds;

	private bool haveShowLevelIcon;

	protected PopupType popupType;

	protected int popupHero;

	protected int popupVIPId;

	public void OnInit()
	{
	}

	private void InitVips()
	{
	}

	private void InitHeros()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	protected void OnIconLevelClicked()
	{
	}

	protected void OnIconCoinClicked()
	{
	}

	protected void OnIconBattlepassClicked()
	{
	}

	protected void OnIconBigBattlepassClicked()
	{
	}

	protected void OnIconTowerClicked()
	{
	}

	protected void OnIconIdfaClicked()
	{
	}

	protected void OnIconHeroClicked(int heroId)
	{
	}

	protected void OnIconClicked(RectTransform icon)
	{
	}

	protected void OnLoadedIcon(bool success)
	{
	}

	protected void RefreshPopup()
	{
	}

	public static bool IsBattlePassEnabled()
	{
		return false;
	}

	protected static bool IsBattlePassActivated()
	{
		return false;
	}

	protected static bool IsBattlePassPremiumActivated()
	{
		return false;
	}

	protected static bool IsHeroActivated(int heroId)
	{
		return false;
	}

	protected static bool IsTowerEnabled()
	{
		return false;
	}

	protected static bool IsIdfaActivated()
	{
		return false;
	}

	protected static bool IsIdfaEnabled()
	{
		return false;
	}

	protected static string GetStarLevelString(int level)
	{
		return null;
	}

	public void OnLanguageChange()
	{
	}

	private void UpdateVipChildCallBack(int index, AdHarvestBoostIcon one)
	{
	}

	private void UpdateChildCallBack(int index, AdHarvestBoostIcon one)
	{
	}
}
