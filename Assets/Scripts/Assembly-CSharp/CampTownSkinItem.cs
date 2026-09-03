using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTownSkinItem : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private GameObject selectStatus;

	[SerializeField]
	private GameObject timeLimit;

	private CampTownSkinItemData data;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CampTownSkinItemData data, bool isSelect)
	{
	}

	private void Click()
	{
	}
}
