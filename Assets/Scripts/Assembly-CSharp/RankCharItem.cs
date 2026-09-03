using UnityEngine;
using UnityEngine.UI;

public class RankCharItem : MonoBehaviour
{
	private HeroShow heroShow;

	public RawImage img_heroShow;

	public Text Text_Name;

	public Image Image_Icon;

	public DxxText Text_Cup;

	public HeadItem headItem;

	public GameObject container;

	public Color color1;

	public Color color2;

	public Color color3;

	public MedalItem medalItem;

	private LocalSave.GuildRankItemUIData data;

	public void init(int type, LocalSave.GuildRankItemUIData data)
	{
	}

	private void createHeroModel(GameObject o2)
	{
	}

	private GameObject createHeroShow(GameObject o2, int nSkinId, int nWingId, int nWingStar)
	{
		return null;
	}

	public void onClickItem()
	{
	}

	public void closeItem()
	{
	}
}
