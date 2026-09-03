using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampBPItemCell : UITableViewCell
{
	public PropOneEquip[] propItem;

	public GameObject[] Locker;

	public GameObject[] Choosed;

	public GameObject[] GetTween;

	public DxxText[] Tween_Text;

	public Button[] Button_GetItem;

	public GameObject Line_Yellow;

	public GameObject Line_Dark;

	public GameObject LvBG_Yellow;

	public GameObject LvBG_Dark;

	public DxxText Text_Level;

	public GameObject Mask;

	public GameObject Shine;

	public GameObject ShineFree;

	public CampBPData BPData;

	private int currentLevel;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonGet;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(CampBPData data, int level)
	{
	}

	public void onButtonGet(int index)
	{
	}
}
