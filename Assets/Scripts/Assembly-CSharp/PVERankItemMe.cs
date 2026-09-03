using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PVERankItemMe : UITableViewCell
{
	public Image Image_BoxBG;

	public DxxText Text_Rank;

	public DxxText Text_Name;

	public DxxText Text_Value;

	public HeadItem headItem;

	public GameObject Icon1;

	public GameObject Icon2;

	public GameObject Icon3;

	public DxxText Text_Talent;

	public Image Image_Reward;

	public MedalItem medalItem;

	private PVERankItemData data;

	private int currentTab;

	public void init(PVERankItemData data)
	{
	}

	public void SetCurrentTab(int currentTab)
	{
	}

	public void onClickBox()
	{
	}
}
