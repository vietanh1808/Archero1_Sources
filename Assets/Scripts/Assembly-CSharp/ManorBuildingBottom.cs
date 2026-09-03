using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorBuildingBottom : MonoBehaviour
{
	private int buildingId;

	public ManorStarsShow Stars;

	public GameObject Arrow;

	public DxxText Text_Level;

	public DxxText Text_Name;

	public GameObject RedPoint;

	public GameObject LevelObj;

	public GameObject UpObj;

	public Image NameBg;

	private const int BUILD_PASTURE_ID = 13;

	private ManorBuildingData mbData;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_freshRedPoint;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(int buildingId)
	{
	}

	public void freshRedPoint()
	{
	}
}
