using UIKit;
using UnityEngine;

public class SailingAchievementBoxItem : UITableViewCell
{
	public DxxText Text_Level;

	public PropOneEquip[] propItems;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public GameObject Mask;

	private SailingAchievementBoxItemData itemData;

	public new void Awake()
	{
	}

	public void init(SailingAchievementBoxItemData data)
	{
	}

	private void onButtonGet()
	{
	}
}
