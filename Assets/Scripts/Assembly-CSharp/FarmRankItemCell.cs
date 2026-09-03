using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class FarmRankItemCell : UITableViewCell
{
	public Image BG_Focus;

	public Image BG_Rank1;

	public Image BG_Rank2;

	public Image BG_Rank3;

	public Image BG_Normal;

	public DxxText Text_Rank;

	public DxxText Text_Name;

	public DxxText Text_Score;

	public HeadItem headItem;

	public Image Image_Reward;

	public GameObject rank1;

	public GameObject rank2;

	public GameObject rank3;

	public Color color1;

	public Color color2;

	public Color color3;

	public MedalItem medalItem;

	private FarmRankData data;

	private int season;

	public void init(FarmRankData data, int area, int season)
	{
	}

	public void onClockItem()
	{
	}

	public void setBottomStyle()
	{
	}

	public void onClickBox()
	{
	}
}
