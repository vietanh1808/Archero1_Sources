using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class MountainHeightItem : UITableViewCell
{
	public ButtonCtrl Btn_Box;

	public Slider slider_Height;

	public Animation ani_Box;

	public GameObject go_BoxOpen;

	public GameObject go_BoxClosed;

	public DxxText text_Height;

	public PropOneEquip prop;

	private MountainAchievementData _data;

	private int crtIndex;

	private ActMountaineeringMgr m_Mgr => null;

	public void Init(MountainAchievementData data, int index)
	{
	}

	public void RefreshHeight()
	{
	}

	public void OnBtnBoxClick()
	{
	}
}
