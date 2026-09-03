using System;
using UnityEngine;

public class FoodEquipBase : FoodClearnessBase
{
	public Transform effectparent;

	public Transform meshparent;

	public SpriteRenderer sprite;

	private GameObject effect;

	private EquipNameCtrl mNameCtrl;

	private Func<bool> ShowNameCondition;

	public LocalSave.EquipOne equipone { get; private set; }

	protected override void OnAwakeInit()
	{
	}

	private GameObject getparent()
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	protected override void OnAbsorbStart()
	{
	}

	protected override void SetPropClearness(BattlePropClearness clearness)
	{
	}

	private void EffectShow(bool value)
	{
	}

	private void CreateName()
	{
	}

	protected override void OnDropEnd()
	{
	}

	private void SetNameShow(bool value)
	{
	}

	protected override void OnGetGoodsEnd()
	{
	}

	protected override void OnDeInit()
	{
	}

	public void SetShowNameCondition(Func<bool> condition)
	{
	}

	public void UpdateNameState()
	{
	}
}
