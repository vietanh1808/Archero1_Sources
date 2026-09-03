using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class CampKingRankItemCell : UITableViewCell
{
	[SerializeField]
	private bool isBottomMe;

	public GameObject BG_Focus;

	public Image Image_Cup;

	public Image Image_Flag;

	public DxxText Text_Rank;

	public DxxText Text_Name;

	public DxxText Text_Peerage;

	public DxxText Text_Score;

	public HeadItem headItem;

	public ButtonCtrl headClick;

	public RectTransform Content;

	public GameObject cpItem;

	public ScrollRect scrollRect;

	public CampKingBoxItem boxItem;

	private CampRankItemData data;

	public void init(CampRankItemData data)
	{
	}
}
