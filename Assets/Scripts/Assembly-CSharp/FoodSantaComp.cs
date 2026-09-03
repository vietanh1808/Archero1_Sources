using UnityEngine;

public class FoodSantaComp : FoodEquipStyleBase
{
	public DIYEquipVO diyEquipVO;

	protected override bool IsForceCloseEffect => false;

	protected override void ForceCastData()
	{
	}

	protected override int GetQuality()
	{
		return 0;
	}

	protected override Sprite GetIcon()
	{
		return null;
	}

	protected override Color GetQualityColor()
	{
		return default;
	}

	protected override string GetName()
	{
		return null;
	}

	protected override int GetCount()
	{
		return 0;
	}
}
