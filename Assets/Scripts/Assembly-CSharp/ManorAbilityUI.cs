using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorAbilityUI : MonoBehaviour
{
	public ManorAbilityPopWindow popWindow;

	public GameObject[] AbilityObj;

	public Image[] Image_AbilityBG;

	public DxxText[] Text_AbilityNum;

	private int buildId;

	private List<int> abilityList;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(int buildId, List<int> list)
	{
	}

	public void onButtonClick(int index)
	{
	}
}
