using UnityEngine;

public class SkillAlone1016GoodCtrl01 : SkillAloneAttrGoodBase
{
	[SerializeField]
	private GameObject normalObj;

	[SerializeField]
	private GameObject specialObj;

	[SerializeField]
	protected EElementType _eElementType;

	protected int? newEnemyBuffID;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void RefreshBall()
	{
	}

	public void SetNewEnemyBuffID(int buff)
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	protected virtual float CalcHitExtraDmg(float hit)
	{
		return 0f;
	}
}
