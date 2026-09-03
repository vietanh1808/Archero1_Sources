using UnityEngine;

public class SkillAlone1765EffectCtrl : MonoBehaviour
{
	private EntityBase m_Entity;

	private float CONFIG_HIT_RATIO;

	private float CONFIG_CRIT_RATE_RATIO;

	[SerializeField]
	private CapsuleCollider m_Collider;

	[SerializeField]
	private Transform m_Effect;

	public void Init(EntityBase entity, float scale, float ratio, float rotateY, float critRateRatio)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
