using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class RelicAttrInfoCtrl : MonoBehaviour
{
	public enum AttrType
	{
		basic = 0,
		star = 1,
		special = 2,
		set = 3,
		lockSkill = 4
	}

	private AttrType curAttrType;

	private LocalSave.EquipOne mRelicOne;

	private LocalUnityObjctPool mPool;

	public Transform infoParent;

	public DxxText txt_title;

	public void Init(LocalUnityObjctPool _Pool)
	{
	}

	public void RefreshUI(AttrType _curAttrType, LocalSave.EquipOne one)
	{
	}

	private void refreshTxtTitle()
	{
	}

	private void refreshTxtInfos()
	{
	}

	private void refreshByAttrBasic()
	{
	}

	private void refreshByAttrStar()
	{
	}

	private void refreshByAttrSpecial()
	{
	}

	private void refreshByAttrSet()
	{
	}

	private Dictionary<string, Goods_goods.GoodData> getDictByAttrBasic()
	{
		return null;
	}

	private Dictionary<string, Goods_goods.GoodData> getDictByAttrStar()
	{
		return null;
	}
}
