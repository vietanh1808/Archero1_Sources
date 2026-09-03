using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorBagItem : MonoBehaviour
{
	[SerializeField]
	private Slider fragment;

	[SerializeField]
	private ManorStarsShow starsShow;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private GameObject starParent;

	[SerializeField]
	private DxxText txt_slider;

	[SerializeField]
	private DxxImage Img_Fragment;

	[SerializeField]
	private Image Img_FrgComplete;

	[SerializeField]
	private DxxImage img_Build;

	[SerializeField]
	private RedNodeCtrl redNodeCtrl;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_SetWorkerData;

	private static DelegateBridge __Hotfix0_SetPropData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void SetWorkerData(ManorWorkerData data, int fragmentCount)
	{
	}

	public void SetPropData(LocalSave.EquipOne propData)
	{
	}
}
