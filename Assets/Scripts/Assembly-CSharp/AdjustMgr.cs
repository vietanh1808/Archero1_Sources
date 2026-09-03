using System.Collections.Generic;
using OneStore;
using UnityEngine.Purchasing;
using com.adjust.sdk;

public class AdjustMgr : CInstance<AdjustMgr>
{
	public static string appToken;

	private Dictionary<string, string> mEvents;

	public new void Init()
	{
	}

	private string GetEventID(string event_name)
	{
		return null;
	}

	private AdjustEvent GetEvent(string event_name)
	{
		return null;
	}

	private void track(string event_name)
	{
	}

	public void track_iap(string productId, string localizedPrice, string isoCode)
	{
	}

	public void track_iap(Product product)
	{
	}

	public void track_iap(PurchaseData product, string price, string currency = "")
	{
	}

	public void track_ad()
	{
	}

	public void track_ad_key()
	{
	}

	public void track_ad_harvest()
	{
	}

	public void track_ad_smallchest()
	{
	}

	public void track_ad_gameturn()
	{
	}

	public void track_ad_blackad()
	{
	}

	public void track_revival()
	{
	}

	public void track_normalbox(bool free)
	{
	}

	public void track_daily_ad()
	{
	}

	public void track_themeBox_ad()
	{
	}

	public void track_FreeCoin_ad()
	{
	}

	public void track_reborn_ad()
	{
	}

	public void track_FarmVisit_ad()
	{
	}

	public void track_largebox(bool free)
	{
	}

	public void track_retention_1()
	{
	}

	public void track_retention_7()
	{
	}

	public void track_retention_14()
	{
	}

	public void track_retention_30()
	{
	}

	public void track_chapter(int stage)
	{
	}

	public void track_Level(int level)
	{
	}

	public void check_retention()
	{
	}

	public void track_smallchest()
	{
	}

	public void track_bigchest()
	{
	}

	public void track_videochest()
	{
	}

	public void track_iapchest()
	{
	}

	public void track_allchest()
	{
	}

	private int getregisterday()
	{
		return 0;
	}

	public void track_new24hiap()
	{
	}

	public void track_new48hiap()
	{
	}

	public void track_equipsystemopen()
	{
	}

	public void track_gameend()
	{
	}

	public void track_talent(int talentlevel)
	{
	}

	public void track_normal_mode()
	{
	}

	public void track_hero_mode()
	{
	}

	public void track_hell_mode()
	{
	}

	public void track_register()
	{
	}

	public void track_christmas_event_2019()
	{
	}

	public void track_10box()
	{
	}

	public void track_Promo_Pack_Xmas2019()
	{
	}

	public void track_new_character(int charid)
	{
	}

	public void track_gameend3()
	{
	}
}
