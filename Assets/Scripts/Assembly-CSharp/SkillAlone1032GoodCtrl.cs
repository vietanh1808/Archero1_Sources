using UnityEngine;

public class SkillAlone1032GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform skillObj;

	[SerializeField]
	private SphereCollider collider;

	private float originRadius;

	private int sendTargetBuffID;

	private float PerScaleUnit => 0f;

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	protected override void OnInit()
	{
	}

	private void InitRadius()
	{
	}

	public void SetRadius(float radius)
	{
	}

	public void SetSkillData(float radius, int sendTargetBuffID)
	{
	}
}
