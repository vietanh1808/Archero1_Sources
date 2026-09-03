using System;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSkinSelectPart : MonoBehaviour
{
	public GameObject tabObj;

	public GameObject skinObjs;

	public Action<int, int> SelectCallBack;

	private Dictionary<int, WeaponSkinTabItem> tabs;

	private List<WeaponSkinIconItem> skinIcons;

	private int CurTab;

	private int CurSkinId;

	public void InitTabs()
	{
	}

	public void ClickTab(int tab, bool isForce = false)
	{
	}

	public void ClickSkinIcon(int skinId, bool isForce)
	{
	}

	private WeaponSkinIconItem GetItemBySkinId(int skinId)
	{
		return null;
	}

	public void SetToTab(int type)
	{
	}

	private int GetTabIndex(int type)
	{
		return 0;
	}

	public void RefreshIconState(int skinId)
	{
	}

	public Vector2 GetSkinItemPos(int skinID)
	{
		return default;
	}

	public void RefreshItemRed()
	{
	}

	public void RefreshItemLv()
	{
	}

	public Vector2 GetCurSelectSkinPos()
	{
		return default;
	}
}
