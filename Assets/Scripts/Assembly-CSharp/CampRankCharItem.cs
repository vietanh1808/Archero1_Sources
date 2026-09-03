using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampRankCharItem : MonoBehaviour
{
	public Image Image_Flag;

	public DxxText Text_Name;

	public GameObject Container;

	private CampRankItemData data;

	private HeroShow heroShow;

	public RawImage img_heroShow;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_createHeroModel;

	private static DelegateBridge __Hotfix0_createHeroShow;

	private static DelegateBridge __Hotfix0_closeItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(CampRankItemData data)
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
