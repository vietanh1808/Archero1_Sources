using UnityEngine;
using UnityEngine.UI;

public class HID_HomeUi : HIDUIBase
{
	public Text hiDText;

	public Button copyIdButton;

	public Text emailText;

	public Text gameiDText;

	public Button copygameIdButton;

	public Button teamsOfServiceButton;

	public Button privacyPolicyButton;

	public Color showColor;

	public Color hideColor;

	public HIDToggle Game_Update_And_News_Toggle;

	private bool Game_Update_And_News;

	private int gameUpdatesAndNews;

	public Text gameUpdatesAndNewsText;

	public HIDToggle Events_And_Bonus_Toggle;

	private bool Events_And_Bonus;

	private int eventsAndBonus;

	public Text eventsAndBonusText;

	public HIDToggle Community_Interaction_Toggle;

	private bool Community_Interaction;

	private int communityInteraction;

	public Text communityInteractionText;

	public HIDToggle Shop_Special_Offer_Toggle;

	private bool Shop_Special_Offer;

	private int shopSpecialOffer;

	public Text shopSpecialOfferText;

	public HIDToggle News_For_Habby_Toggle;

	private bool News_For_Habby;

	private int newsForHabby;

	public Text newsForHabbyText;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void InitToggles()
	{
	}

	private void OnModifySucceed(bool result, Text changeText)
	{
	}

	public void InitData(string objHabbyId, string objEmail, string custom, int? gameUpdatesAndNews, int? eventsAndBonus, int? communityInteraction, int? shopSpecialOffer, int? newsForHabby)
	{
	}

	public override void NormalShow()
	{
	}
}
