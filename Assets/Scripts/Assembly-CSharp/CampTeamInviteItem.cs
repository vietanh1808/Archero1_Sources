using Habby.Guild.Data;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class CampTeamInviteItem : UITableViewCell
{
	public HeadItem headItem;

	public Image Image_Head;

	public ButtonCtrl Button_Head;

	public ButtonCtrl Button_Invite;

	public DxxText Text_Invite;

	public DxxText Text_Name;

	public DxxText Text_Grade;

	public DxxText Text_Score;

	public GameObject SendedObj;

	private GuildMemberInfo itemData;

	private ulong userid;

	public new void Awake()
	{
	}

	public void init(GuildMemberInfo data)
	{
	}

	private void onButtonHead()
	{
	}

	private void onButtonOK()
	{
	}
}
