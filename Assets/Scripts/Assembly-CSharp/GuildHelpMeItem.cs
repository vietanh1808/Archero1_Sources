using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class GuildHelpMeItem : UITableViewCell
{
	public HeadItem headItem;

	public DxxText Text_Name;

	public DxxText Text_Time;

	public EquipOneCtrl equipOne;

	public Button Button_Like;

	public GameObject Liked;

	private HelpMeData data;

	public void init(HelpMeData data)
	{
	}

	public void onButtonLike()
	{
	}

	public void freshLike()
	{
	}
}
