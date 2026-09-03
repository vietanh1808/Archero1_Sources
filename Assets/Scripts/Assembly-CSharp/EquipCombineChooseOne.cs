using System;
using UnityEngine;

public class EquipCombineChooseOne : MonoBehaviour
{
	public ButtonCtrl mButton;

	public GameObject child;

	public GameObject mMask;

	[SerializeField]
	private DxxText mBreakNeed2TextNum;

	public Action<int> OnButtonClick;

	[SerializeField]
	private GameObject Flag;

	private bool bMask;

	private EquipOneCtrl mEquip;

	public EquipCombineOne mEquipChoose { get; private set; }

	public LocalSave.EquipOne mEquipData { get; private set; }

	public int mIndex { get; private set; }

	private void Awake()
	{
	}

	public void Init(int index)
	{
	}

	public void init_TipsEquipId(int index, int breakid)
	{
	}

	public void init_TipsQuality(int index, int type, int quality, int breakS = 0)
	{
	}

	public void Set_Choose_Equip(LocalSave.EquipOne one)
	{
	}

	public void Clear()
	{
	}

	public void Down()
	{
	}

	public void ShowMask(bool show)
	{
	}

	public void ShowNum(string str)
	{
	}
}
