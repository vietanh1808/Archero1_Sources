using UnityEngine;
using UnityEngine.UI;
using XLua;

public class LuckyWheelRewardItem : MonoBehaviour
{
	[SerializeField]
	private Image bg;

	[SerializeField]
	private RectTransform rectTrans;

	[SerializeField]
	private PropOneEquip prop;

	private LuckyWheelRewardItemData itemData;

	private static DelegateBridge __Hotfix0_get_LuckyWheelManager;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshImg;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelManager LuckyWheelManager => null;

	public void Refresh(LuckyWheelRewardItemData itemData)
	{
	}

	private void RefreshImg()
	{
	}

	private void RefreshStatus()
	{
	}
}
