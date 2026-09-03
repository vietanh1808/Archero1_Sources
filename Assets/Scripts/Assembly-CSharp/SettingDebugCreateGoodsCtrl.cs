using UnityEngine;

public class SettingDebugCreateGoodsCtrl : MonoBehaviour
{
	public ButtonCtrl Button_BlackShop;

	public ButtonCtrl Button_BlackShopAd;

	public ButtonCtrl Button_Strength;

	public ButtonCtrl Button_GameTurn;

	public ButtonCtrl Button_Angel;

	public ButtonCtrl Button_Demon;

	public ButtonCtrl Button_SwitchAdTurn;

	public ButtonCtrl Button_HeroSkill;

	public ButtonCtrl Button_MazeEvent;

	public ButtonCtrl Button_MazeTreasuresEvent;

	public DxxText Text_SwitchAdTurn;

	public ButtonSwitchCtrl Button_MustShowAdTurn;

	public ButtonSwitchCtrl Button_AutoGotoNextRoom;

	public ButtonCtrl Button_RoomInfo;

	public ButtonCtrl Button_Magician;

	[SerializeField]
	private ButtonCtrl mBtnPartner;

	[SerializeField]
	private ButtonCtrl BtnNPC120;

	[SerializeField]
	private ButtonCtrl Button_AngelOfJudgment;

	[SerializeField]
	private ButtonCtrl Button_Create_Event;

	[SerializeField]
	private DxxInput mInput_Event_ID;

	private int x;

	private int y;

	private void Awake()
	{
	}

	private void update_switchadturn()
	{
	}

	private string get_switchadturn_text()
	{
		return null;
	}

	private void update_mustshowadturn()
	{
	}

	private void update_autogotonextroom()
	{
	}
}
