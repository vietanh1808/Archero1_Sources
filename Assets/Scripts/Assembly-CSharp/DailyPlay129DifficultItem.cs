using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class DailyPlay129DifficultItem : UITableViewCell
{
	public GameObject BG1;

	public GameObject BG2;

	public Image Image_LevelBG;

	public DxxText Text_Level;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Choose;

	public DxxText Text_Choose;

	public DxxText Text_Choosed;

	public GameObject Mask;

	public RectTransform RTF_Mask;

	public DxxText Text_Mask;

	private DailyPlay129DifficultItemData itemData;

	public new void Awake()
	{
	}

	public void init(DailyPlay129DifficultItemData data)
	{
	}

	public void onButtonChoose()
	{
	}
}
