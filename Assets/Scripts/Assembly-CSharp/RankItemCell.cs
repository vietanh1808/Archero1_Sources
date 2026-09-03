using UnityEngine;
using UnityEngine.UI;

public class RankItemCell : MonoBehaviour
{
	public Image BG_Focus;

	public Image BG_Rank1;

	public Image BG_Rank2;

	public Image BG_Rank3;

	public Image BG_Normal;

	public DxxText Text_Rank;

	public Text Text_Name;

	public DxxText Text_Score;

	public HeadItem headItem;

	public PropOneEquip[] prop;

	public PVPPropBoxItem boxItem;

	private PVPRankData data;

	public GameObject rank1;

	public GameObject rank2;

	public GameObject rank3;

	public Color color1;

	public Color color2;

	public Color color3;

	public MedalItem medalItem;

	public void init(PVPRankData data, int area, int season)
	{
	}

	public void onClockItem()
	{
	}

	public void setBottomStyle()
	{
	}

	public PVPRankData getRankData()
	{
		return null;
	}
}
