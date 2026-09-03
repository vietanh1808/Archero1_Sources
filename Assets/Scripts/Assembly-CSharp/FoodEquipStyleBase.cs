using System;
using UnityEngine;

public class FoodEquipStyleBase : FoodClearnessBase
{
	public Transform effectparent;

	public Transform meshparent;

	public SpriteRenderer sprite;

	private GameObject effect;

	private EquipStyleNameCtrl mNameCtrl;

	private Func<bool> ShowNameCondition;

	protected virtual bool IsForceCloseEffect => false;

	protected virtual int GetQuality()
	{
		return 0;
	}

	protected virtual Sprite GetIcon()
	{
		return null;
	}

	protected virtual Color GetQualityColor()
	{
		return default;
	}

	protected virtual string GetName()
	{
		return null;
	}

	protected virtual int GetCount()
	{
		return 0;
	}

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
