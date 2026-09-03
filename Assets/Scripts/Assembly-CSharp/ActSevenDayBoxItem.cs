using UnityEngine;
using XLua;

public class ActSevenDayBoxItem : MonoBehaviour
{
	public GameObject BoxOpen;

	public GameObject BoxClose;

	public DxxText Text_Need;

	public ButtonCtrl Button_Box;

	public GameObject Single;

	public GameObject Many;

	public PropOneEquip propItem;

	public GameObject Complete;

	public Animation BoxAni;

	private SevenDayBoxData boxData;

	private bool isChallenge;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonGet;

	private static DelegateBridge __Hotfix0_onClickItem;

	private static DelegateBridge __Hotfix0_Lua_Hotfix;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Awake()
	{
	}

	public void init(SevenDayBoxData data, bool ischallenge = false)
	{
	}

	public void onButtonGet()
	{
	}

	public void onClickItem(PropOneBase item, object param)
	{
	}

	public void Lua_Hotfix()
	{
	}
}
