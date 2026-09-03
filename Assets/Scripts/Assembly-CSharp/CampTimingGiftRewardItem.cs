using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTimingGiftRewardItem : MonoBehaviour
{
	[SerializeField]
	private Image bg;

	[SerializeField]
	private PropOneEquip prop;

	private Drop_DropModel.DropData reward;

	private CampTimingGiftThemeType themeType;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(Drop_DropModel.DropData reward, CampTimingGiftThemeType themeType)
	{
	}
}
