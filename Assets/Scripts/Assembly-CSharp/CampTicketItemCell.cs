using UIKit;
using UnityEngine;

public class CampTicketItemCell : UITableViewCell
{
	public GameObject BG_Focus;

	public HeadItem headItem;

	public MedalItem medalItem;

	public GameObject BoxObj;

	public GameObject BoxOpen;

	public GameObject BoxClose;

	public ButtonCtrl Button_Head;

	public ButtonCtrl Button_Ticket;

	public ButtonCtrl Button_Box;

	public DxxText Text_Name;

	public DxxText Text_Score;

	public DxxText Text_Peerage;

	private CampTicketItemData data;

	public new void Awake()
	{
	}

	public void init(CampTicketItemData data)
	{
	}

	private void onButtonTicket()
	{
	}

	private void onButtonBox()
	{
	}

	private void onButtonHead()
	{
	}
}
