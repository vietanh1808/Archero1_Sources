using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PlinkoBottomBoxItem : UITableViewCell
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

	public Slider slider;

	public Image Image_SliderBG;

	private PlinkoBoxItemData boxData;

	public new void Awake()
	{
	}

	public void init(PlinkoBoxItemData data)
	{
	}

	public void onButtonGet()
	{
	}

	public void onClickItem(PropOneBase item, object param)
	{
	}

	private bool checkCanGet()
	{
		return false;
	}
}
