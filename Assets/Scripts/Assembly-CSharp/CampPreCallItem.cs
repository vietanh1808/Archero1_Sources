using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampPreCallItem : MonoBehaviour
{
	public DxxText Text_Level;

	public CampPrePropItem[] items;

	public Button Button_Get;

	private CampPreCallData data;

	private int currentLevel;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(CampPreCallData data, int level)
	{
	}

	public void onButtonClick()
	{
	}
}
