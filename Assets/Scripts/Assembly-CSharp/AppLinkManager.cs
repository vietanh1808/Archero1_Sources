using System.Collections.Generic;
using Habby.AppLink;
using Habby.Webview;

public class AppLinkManager : CInstance<AppLinkManager>
{
	private enum AppLinkTarget
	{
		NONE = 0,
		COME_BACK = 1,
		HOME = 2,
		HOME_CHAPTER = 3,
		HOME_NEWEST = 4,
		GUILD_HOME = 5,
		GUILD_MAIN = 6,
		GUILD_CHAT = 7,
		GUILD_SHOP = 8,
		GUILD_ACTIVITY = 9,
		ACTIVITY_DROP = 10,
		ACTIVITY_EXCHANGE = 11,
		DAILY = 12,
		SHOP = 13,
		BATTLE_PASS = 14,
		FARM = 15,
		PVP_ENERGY = 16,
		DAILY_CHRISTMAS = 17,
		DAILY_NEWYEAR = 18,
		DAILY_VALENTINEDAY = 19,
		DAILY_AprilFoolDay = 20,
		DAILY_Anniversary = 21,
		HOME_equipAltar = 22,
		HOME_HeroEquip = 23,
		HOME_heroAltar = 24,
		HOME_Dragon = 25,
		HOME_PVESeason = 26,
		HOME_MonsterDispatch = 27
	}

	private AppLinkTarget targetPage;

	private string giftCode;

	private int chapterId;

	private MainUIPageBattleCtrl mainPage;

	private Dictionary<AppLinkTarget, IHandleObject> loginHandleMap;

	private Dictionary<AppLinkTarget, IHandleObject> guildHandleMap;

	public new void Init()
	{
	}

	private void OnSpecifiedDaily(AppLinkResult result)
	{
	}

	private void OnComeback(AppLinkResult result)
	{
	}

	private void CheckRewards()
	{
	}

	private void GoToChapter(int chapter)
	{
	}

	private void OpenDaily()
	{
	}

	private void OpenShop()
	{
	}

	private void OpenEquipAltar()
	{
	}

	private void OpenHeroAltar()
	{
	}

	private void OpenHeroEquip()
	{
	}

	private void OpenDragonUI()
	{
	}

	private void OpenPVESeason()
	{
	}

	private void OpenMonsterDispatch()
	{
	}

	public void SetMainPage(MainUIPageBattleCtrl mainPage)
	{
	}

	private void OpenBattlePass()
	{
	}

	private void OpenGuild(int tab = 0)
	{
	}

	private void OpenActivityDrop()
	{
	}

	private void OpenActivityExchange()
	{
	}

	private void OpenFarm()
	{
	}

	private void OpenChristmas()
	{
	}

	private void OpenAnniversary()
	{
	}

	private void OpenNewYear()
	{
	}

	private void OpenValentineDay()
	{
	}

	private void OpenAprilFoolDay()
	{
	}

	private void InitHandleMap()
	{
	}

	private void SendHandleEvent(Dictionary<AppLinkTarget, IHandleObject> pMap)
	{
	}

	public void HandleLogin()
	{
	}

	public void HandleBattlePass()
	{
	}

	public void HandleGuild()
	{
	}

	public void HandleActivityYear()
	{
	}

	public void HandleActivityExchange()
	{
	}

	private void OnHome(AppLinkResult result)
	{
	}

	private void OnGuild(AppLinkResult result)
	{
	}

	private void OnActivity(AppLinkResult result)
	{
	}

	private void OnPvp(AppLinkResult result)
	{
	}

	private void OnDaily(AppLinkResult result)
	{
	}

	private void OnBattlePass(AppLinkResult result)
	{
	}

	private void OnFarm(AppLinkResult result)
	{
	}

	private void OnShop(AppLinkResult result)
	{
	}

	private void ShowMessage(string msg)
	{
	}

	private void ShowMessage(string msg, string title)
	{
	}

	private void ShowGenericMessage()
	{
	}
}
