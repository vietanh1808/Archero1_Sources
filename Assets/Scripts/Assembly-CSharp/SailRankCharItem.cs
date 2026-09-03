using UnityEngine;
using UnityEngine.UI;

public class SailRankCharItem : MonoBehaviour
{
	public Image Image_Flag;

	public DxxText Text_Name;

	public DxxText Text_MilitaryRank;

	public DxxText Text_Power;

	public MedalItem medalItem;

	public GameObject Container;

	protected SailingRankingItemData data;

	private HeroShow heroShow;

	public RawImage img_heroShow;

	public Image military;

	public Image powerImg;

	public ButtonCtrl PlayerMainBtn;

	public void Init(SailingRankingItemData data, RankType type)
	{
	}

	protected virtual void OnClickPlayerMainBtn()
	{
	}

	private void LoadPowerImg(RankType type)
	{
	}

	private void createHeroModel(GameObject o2)
	{
	}

	private GameObject createHeroShow(GameObject o2, int nSkinId, int nWingId, int nWingStar)
	{
		return null;
	}

	public void closeItem()
	{
	}
}
