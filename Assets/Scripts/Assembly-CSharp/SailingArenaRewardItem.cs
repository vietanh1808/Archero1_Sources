using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingArenaRewardItem : UITableViewCell
{
	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	private int minShow;

	public Image Image_Left;

	public Image Image_Flower;

	public GameObject CupObj;

	public GameObject CupNoObj;

	public DxxText Text_Rank;

	public DxxText Text_RankCup;

	public Image Image_Cup;

	private SailingArenaRewardItemData itemData;

	public void init(SailingArenaRewardItemData data, int index, int total)
	{
	}

	private Color GetColor(int rankingNum)
	{
		return default;
	}
}
