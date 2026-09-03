using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class BadgeCardItem : UITableViewCell
{
	public int UILocation;

	[SerializeField]
	private DxxText Text_Name;

	[SerializeField]
	private DxxText Text_CardNo;

	[SerializeField]
	private DxxText Text_Count;

	[SerializeField]
	private Image Image_Card;

	[SerializeField]
	private Image Image_Quality;

	[SerializeField]
	private Image Image_Circle;

	[SerializeField]
	private Image Image_NameBG;

	[SerializeField]
	private ButtonCtrl Button_Card;

	[SerializeField]
	private GameObject MaskObj;

	[SerializeField]
	private GameObject RedDot;

	private BadgeCardItemData _cardItemData;

	public void Init(BadgeCardItemData itemData)
	{
	}

	public void OnClickCard()
	{
	}

	public void showMask(bool show)
	{
	}
}
