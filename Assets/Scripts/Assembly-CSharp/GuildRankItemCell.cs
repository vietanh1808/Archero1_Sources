using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class GuildRankItemCell : UITableViewCell
{
	public Image Image_BG;

	public DxxText Text_Rank;

	public HeadItem headItem;

	public Image Image_Flower;

	public Color colorCommon;

	public Color colorMe;

	public Text Text_Name;

	public DxxText Text_Job;

	public Image Image_Icon;

	public DxxText Text_Score;

	public MedalItem medalItem;

	private LocalSave.GuildRankItemUIData data;

	private RectTransform _scrollViewRect;

	public void init(int type, LocalSave.GuildRankItemUIData data, RectTransform scrollViewRect)
	{
	}

	public void onClickItem()
	{
	}

	private void Update()
	{
	}
}
