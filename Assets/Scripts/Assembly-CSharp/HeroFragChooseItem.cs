using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class HeroFragChooseItem : UITableViewCell
{
	public Image Image_Face;

	public GameObject Mask;

	public GameObject Choosed;

	public bool canClick;

	public GameObject Star_Slider;

	public Slider slider;

	public DxxText Text_Star;

	public DxxText Text_Progress;

	private HeroFragChooseData data;

	public void init(HeroFragChooseData data)
	{
	}

	public void onButtonClick()
	{
	}
}
