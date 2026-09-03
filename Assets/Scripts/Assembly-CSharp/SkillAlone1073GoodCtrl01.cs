using UnityEngine;

public class SkillAlone1073GoodCtrl01 : SkillAloneAttrGoodBase
{
	[SerializeField]
	protected EElementType _eElementType;

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	protected virtual float CalcHitExtraDmg(float hit)
	{
		return 0f;
	}
}
