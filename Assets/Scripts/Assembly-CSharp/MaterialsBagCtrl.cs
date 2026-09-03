using System;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsBagCtrl : MonoBehaviour
{
	public float Bottom_Height;

	private float m_fHeight;

	private int m_nColumnCount;

	private const int m_nEquipWidth = 120;

	private const int m_nEquipHeight = 120;

	public float LeftPadding;

	public float RightPadding;

	public float Horizontal_Space;

	public float Vertical_Space;

	public UILineCtrl lineCtrl;

	private MutiCachePool<EquipOneCtrl> mCachePool;

	private Action<EquipOneCtrl> OnClickEvent;

	private List<LocalSave.EquipOne> datas;

	private CharUIScrollView.BagType bagType;

	public void Init(CharUIScrollView.BagType type, List<LocalSave.EquipOne> datas, MutiCachePool<EquipOneCtrl> cachePool, Action<EquipOneCtrl> onClickEvent)
	{
	}

	public float GetHeight()
	{
		return 0f;
	}

	public void Refresh()
	{
	}

	private void onClick(object o)
	{
	}

	public void Clear()
	{
	}

	public void Show(bool pShow)
	{
	}
}
