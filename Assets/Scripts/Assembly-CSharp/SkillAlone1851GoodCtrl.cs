using UnityEngine;

public class SkillAlone1851GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private GameObject skillObj;

	[SerializeField]
	private Transform allParent;

	[SerializeField]
	private BoxCollider collider;

	private float dmgScale;

	private float dmgInterval;

	private float lastDmgTime;

	public void Refresh(float width, float height)
	{
	}

	public void Refresh(float dmgScale, float dmgInterval, float width, float height)
	{
	}

	public void SetColliderStatus(bool isActive)
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	protected override void TriggerStay(EntityBase entity)
	{
	}

	private void AttackTarget(EntityBase entity)
	{
	}

	public void RecycleEffect()
	{
	}
}
