using UnityEngine;
using XLua;

public class CampTalentTip : MonoBehaviour
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText baseTitle;

	[SerializeField]
	private DxxText baseContent;

	[SerializeField]
	private GameObject specialObj;

	[SerializeField]
	private DxxText specialTitle;

	[SerializeField]
	private DxxText specialContent;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl closeMask;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_get_BaseKey;

	private static DelegateBridge __Hotfix0_get_SpecialKey;

	private static DelegateBridge __Hotfix0_Hide;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected virtual string BaseKey => null;

	protected virtual string SpecialKey => null;

	public void Show(string titleStr, string baseContentStr, string specialContentStr)
	{
	}

	public void Hide()
	{
	}
}
