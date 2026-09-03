using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay127DiffSelectItemCell : UITableViewCell
{
	public GameObject PassObj;

	public Image Image_Diff;

	public GameObject StarObj;

	public GameObject[] Stars;

	public DxxText Text_Title;

	public DxxText Text_Add;

	public GameObject Selected;

	public ButtonCtrl Button_Select;

	public DxxText Text_Select;

	public GameObject Mask;

	public DxxText Text_Mask;

	public RectTransform RTF_Mask;

	public Image Image_Icon;

	private NewPlay127DiffItemData itemData;

	public new void Awake()
	{
	}

	public void init(NewPlay127DiffItemData data)
	{
	}

	public void onButtonSelect()
	{
	}
}
