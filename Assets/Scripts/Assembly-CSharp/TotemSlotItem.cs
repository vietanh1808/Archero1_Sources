using UnityEngine;

public class TotemSlotItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage typeIcon;

	[SerializeField]
	private ButtonCtrl btnClick;

	[SerializeField]
	private DxxText txtTotemLevel;

	[SerializeField]
	private GameObject goLock;

	[SerializeField]
	private TotemItem totemItem;

	[SerializeField]
	private Animator unlockAni;

	[SerializeField]
	private GameObject goEmptyEffect;

	[SerializeField]
	private GameObject goEquipEffect;

	[SerializeField]
	private RedNodeCtrl redNode;

	private TotemSlotItemData _slotData;

	private TotemManager Mgr => null;

	public void Init(TotemSlotItemData data, bool isShowBg = false)
	{
	}

	private void CheckSlotAni()
	{
	}

	public void PlayEquipTotemEffect()
	{
	}

	private void OnBtnCLicked()
	{
	}
}
