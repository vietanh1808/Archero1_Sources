using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class HeroFragExCell : UITableViewCell
{
	public Image Image_Need;

	public DxxText Text_Need;

	public GameObject Diamond_Need;

	public DxxText Text_Diamond;

	public Image Image_Give;

	public DxxText Text_Give;

	public ButtonCtrl Button_Exchange;

	public DxxText Text_Exchange;

	public HeroFragExItemData data;

	protected new void Awake()
	{
	}

	public void init(HeroFragExItemData data)
	{
	}

	public void onButtonExchange()
	{
	}
}
