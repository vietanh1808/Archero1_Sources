using System;
using System.Collections.Generic;
using UnityEngine;

public class CharUIScrollView : LoopScrollView
{
	public enum BagType
	{
		Unknown = 0,
		Material = 1,
		Fragment = 2,
		Gems = 3,
		Relics = 4
	}

	public float Bottom_Height;

	public MaterialsBagCtrl mMaterialsBagCtrl;

	[Header("碎片包 可以当做材料 但是单独列出 配表PropType=8")]
	public MaterialsBagCtrl fragmentBagCtrl;

	public MaterialsBagCtrl GemsBagCtrl;

	public MaterialsBagCtrl relicsBagCtrl;

	private Action<EquipOneCtrl> OnClickEvent;

	private MutiCachePool<EquipOneCtrl> mCachePool;

	[SerializeField]
	private UILineCtrlOne Segment;

	private List<UILineCtrlOne> m_listLines;

	public void Init(List<LocalSave.EquipOne> equips, List<LocalSave.EquipOne> materials, List<LocalSave.EquipOne> fragments, List<LocalSave.EquipOne> gems, List<LocalSave.EquipOne> relics, List<LocalSave.EquipOne> commons, List<LocalSave.EquipOne> boxs, MutiCachePool<EquipOneCtrl> cachePool, Action<EquipOneCtrl> onClickEvent, Action<int, RectTransform> onCreateItem)
	{
	}

	private void onClickItem(object item)
	{
	}

	protected override GameObject CreateNewItem()
	{
		return null;
	}

	protected override void ClearItems()
	{
	}

	protected override void calculateMaskSize()
	{
	}

	public void OnLanguageChanged()
	{
	}

	public override void OnClose()
	{
	}

	private GameObject CreateSegment(int index, string key)
	{
		return null;
	}
}
