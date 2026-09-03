using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingAchievementProgressItem : UITableViewCell
{
	public DxxText Text_Title;

	public DxxText Text_Progress;

	public Slider slider;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public PropOneEquip[] propItems;

	public GameObject Mask;

	[SerializeField]
	private Color color1;

	[SerializeField]
	private Color color2;

	public Image Image_Itembg;

	public Image Image_Titlebg;

	private SailingAchievementItemData itemData;

	public new void Awake()
	{
	}

	public void init(SailingAchievementItemData data)
	{
	}

	private void onButtonGet()
	{
	}
}
