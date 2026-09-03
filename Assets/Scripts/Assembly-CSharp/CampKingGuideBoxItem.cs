using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class CampKingGuideBoxItem : UITableViewCell
{
	public GameObject BoxOpen;

	public GameObject BoxClose;

	public DxxText Text_Need;

	public ButtonCtrl Button_Box;

	public GameObject Single;

	public GameObject Many;

	public PropOneEquip propItem;

	public GameObject Complete;

	public Animation BoxAni;

	public Image Image_BoxOpen;

	public Image Image_BoxClose;

	public new void Awake()
	{
	}

	public void init()
	{
	}

	public void onButtonGet()
	{
	}

	public void onClickItem(PropOneBase item, object param)
	{
	}
}
