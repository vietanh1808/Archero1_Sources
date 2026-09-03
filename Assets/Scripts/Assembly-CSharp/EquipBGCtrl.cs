using System;
using UnityEngine;
using UnityEngine.UI;
using XLua;
using homepage;

public class EquipBGCtrl : MonoBehaviour
{
	private LocalSave.EquipOne _equipdata;

	protected int index;

	private GameObject addparent;

	private Animation addani;

	private DxxText Text_Add;

	protected Image Image_BG;

	protected GameObject equipparent;

	protected EquipOneCtrl _ctrl;

	private ShowTab tab;

	[SerializeField]
	protected GameObject carvingEffect;

	private GameObject buttonObj;

	private ButtonCtrl button;

	private DxxText buttonText;

	private Action<int> mClick;

	private bool bInit;

	protected Image Image_GemBG;

	protected Image Image_Gem;

	[SerializeField]
	protected CarvingSlotsCtrl slotsCtrl;

	protected Image Image_Fg;

	private static DelegateBridge __Hotfix0_get_equipdata;

	private static DelegateBridge __Hotfix0_set_equipdata;

	private static DelegateBridge __Hotfix0_get_ctrl;

	private static DelegateBridge __Hotfix0_GetEquipBGPath;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_SetFromTab;

	private static DelegateBridge __Hotfix0_updateGemInfo;

	private static DelegateBridge __Hotfix0_updateCarvingInfo;

	private static DelegateBridge __Hotfix0_ScaleIcon;

	private static DelegateBridge __Hotfix0_Start;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_updateCarvingEffect;

	private static DelegateBridge __Hotfix0_UpdateBGShow;

	private static DelegateBridge __Hotfix0_UpdateRedNode;

	private static DelegateBridge __Hotfix0_SetClick;

	private static DelegateBridge __Hotfix0_PlayRotate;

	private static DelegateBridge __Hotfix0_StopRotate;

	private static DelegateBridge __Hotfix0_DoWear;

	private static DelegateBridge __Hotfix0_WearOver;

	private static DelegateBridge __Hotfix0_MissAdd;

	private static DelegateBridge __Hotfix0_ShowAdd;

	private static DelegateBridge __Hotfix0_OnClick;

	private static DelegateBridge __Hotfix0_GetIsWear;

	private static DelegateBridge __Hotfix0_SetButtonEnable;

	private static DelegateBridge __Hotfix0_UpdateButtonEnable;

	private static DelegateBridge __Hotfix0_Unwear;

	private static DelegateBridge __Hotfix0_OnDestroy;

	private static DelegateBridge _c__Hotfix0_ctor;

	public LocalSave.EquipOne equipdata
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual EquipOneCtrl ctrl => null;

	public virtual string GetEquipBGPath()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void SetFromTab(ShowTab fromTab)
	{
	}

	public virtual void updateGemInfo()
	{
	}

	public virtual void updateCarvingInfo()
	{
	}

	public void ScaleIcon()
	{
	}

	private void Start()
	{
	}

	public void Init(LocalSave.EquipOne equipdata, int weaponSkinId = 0, int weaponColorID = 0)
	{
	}

	protected virtual void updateCarvingEffect()
	{
	}

	private void UpdateBGShow()
	{
	}

	public virtual void UpdateRedNode()
	{
	}

	public void SetClick(Action<int> click)
	{
	}

	private void PlayRotate()
	{
	}

	private void StopRotate()
	{
	}

	public void DoWear()
	{
	}

	public void WearOver()
	{
	}

	public void MissAdd()
	{
	}

	private void ShowAdd(bool value)
	{
	}

	private void OnClick()
	{
	}

	public bool GetIsWear()
	{
		return false;
	}

	public void SetButtonEnable(bool value)
	{
	}

	public void UpdateButtonEnable()
	{
	}

	public void Unwear(Vector3 endpos, Action<LocalSave.EquipOne> onFinish = null)
	{
	}

	private void OnDestroy()
	{
	}
}
