using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class WeaponColorSkinPart : MonoBehaviour
{
	[SerializeField]
	private EquipColorItem colorItemTemplate;

	[SerializeField]
	private RectTransform rectParent;

	[SerializeField]
	private ButtonCtrl btnTips;

	[SerializeField]
	private ButtonCtrl btnUnlock;

	[SerializeField]
	private DxxImage unlockPropIcon;

	[SerializeField]
	private DxxText unlockPropTxt;

	[SerializeField]
	private DxxText unLockTips;

	[SerializeField]
	private WeaponColorAttPart colorAttPart;

	[SerializeField]
	private ScrollRect scroll;

	public Action<int, int, int> selectCallBack;

	public Action exchangeCallBack;

	private LocalUnityObjctPool _pool;

	private List<EquipColorItem> _colorItems;

	private int _skinID;

	private int _crtColorID;

	private int _crtWeaponType;

	private int _curSelectID;

	private int _maxHeight;

	private Drop_DropModel.DropData _unlockDrop;

	public void Init()
	{
	}

	public void RefreshCrtUI()
	{
	}

	public void RefreshColorSkin(int weaponType, int skinId)
	{
	}

	private void ForceRebuildLayout()
	{
	}

	private void RefreshSelect(int colorID)
	{
	}

	private void OnBtnTipsClicked()
	{
	}

	private void RefreshUnlockProp(int colorID)
	{
	}

	private void OnBtnExchangeClicked()
	{
	}

	private bool CheckBuyPre()
	{
		return false;
	}

	public void RefreshItemRed()
	{
	}

	public Vector2 GetItemPosByID(int colorID)
	{
		return default;
	}

	public Vector2 GetSelectItemPos()
	{
		return default;
	}
}
