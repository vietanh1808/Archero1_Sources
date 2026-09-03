using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act6thDrillTreasureDeepItem : UITableViewCell
{
	public ButtonCtrl Btn_Box;

	public Slider slider_Height;

	public Animation ani_Box;

	public GameObject go_BoxOpen;

	public GameObject go_BoxClosed;

	public DxxText text_Height;

	public PropOneEquip prop;

	private Act6thDrillTreasureAchievementData _data;

	private int crtIndex;

	private Act6thDrillTreasureMgr DMgr => null;

	public void Init(Act6thDrillTreasureAchievementData data, int index)
	{
	}

	public void RefreshHeight()
	{
	}

	public void OnBtnBoxClick()
	{
	}
}
