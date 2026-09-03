using System.Collections.Generic;
using UnityEngine;

public class TotemPanel : MonoBehaviour
{
	[SerializeField]
	private DxxText txt_TotemAttTile;

	[SerializeField]
	private DxxText noAttShowTipsTxt;

	[SerializeField]
	private ButtonCtrl btn_Resolve;

	[SerializeField]
	private TotemSlotItem slotTemplate;

	[SerializeField]
	private TotemAttTxtItem totemAttTxtTemplate;

	[SerializeField]
	private TotemAttItem totemAttTemplate;

	[SerializeField]
	private RectTransform coreSlotParent;

	[SerializeField]
	private RectTransform subSlotParent;

	[SerializeField]
	private RectTransform skillDescParent;

	[SerializeField]
	private RectTransform attrParent;

	[SerializeField]
	private GameObject goNoAttShow;

	private List<TotemSlotItem> _slots;

	private LocalUnityObjctPool _pool;

	private int _lastEquipSlotID;

	private TotemManager Mgr => null;

	private List<TotemSlotItemData> SlotDataList => null;

	private float CoreCircleRadius => 0f;

	private float OutCircleRadius => 0f;

	public void Init()
	{
	}

	public void OnOpen()
	{
	}

	public void OnLanguage()
	{
	}

	public void RefreshUI()
	{
	}

	public void SetNewEquipSlotID(int slotID)
	{
	}

	public void ClearNewEquipSlotID()
	{
	}

	private void RefreshSlot()
	{
	}

	private void RefreshAllAtt()
	{
	}

	public void OnBtnResolveClicked()
	{
	}

	public void Closed()
	{
	}
}
