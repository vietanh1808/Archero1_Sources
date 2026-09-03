using UnityEngine;
using UnityEngine.UI;

public class CampTeamCharItem : MonoBehaviour
{
	public ButtonCtrl Button_Head;

	public HeadItem headItem;

	public DxxText Text_Name;

	public RawImage Raw_HeroShow;

	private CampTeamItemData itemData;

	private HeroShow heroShow;

	public void Awake()
	{
	}

	public void init(CampTeamItemData data)
	{
	}

	private GameObject createHeroShow(GameObject o2, int nSkinId, int nWingId, int nWingStar)
	{
		return null;
	}

	private void onButtonHead()
	{
	}
}
