using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTownResItem : MonoBehaviour
{
	public Image Image_Icon;

	public DxxText Text_Desc;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_initLevel;

	private static DelegateBridge __Hotfix0_initAttrs;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(CurrencyType type, int count, CampTownAtt att = CampTownAtt.None)
	{
	}

	public void initLevel(CurrencyType type, int count, int next, CampTownAtt att = CampTownAtt.None)
	{
	}

	public void initAttrs(string attrs, int showLevel, int curLevel, string snext)
	{
	}
}
