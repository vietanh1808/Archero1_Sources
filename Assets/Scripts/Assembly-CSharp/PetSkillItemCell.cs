using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PetSkillItemCell : UITableViewCell
{
	public Image Ski_BG;

	public Image Ski_Icon;

	public Image Ski_OwnerBG;

	public Image Ski_OwnerIcon;

	public Image Img_Flag;

	public DxxText Text_Name;

	public DxxText Text_Desc;

	public ScrollRect scrollRect;

	public RectTransform ContentDesc;

	public DxxText Text_Tips;

	public ButtonCtrl Button_Choose;

	public DxxText Text_Choose;

	public DxxText Text_Level;

	private int skiId;

	private int skiLv;

	public new void Awake()
	{
	}

	public void init(int skill)
	{
	}

	private void onButtonChoose()
	{
	}
}
