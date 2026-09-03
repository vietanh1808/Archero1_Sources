using Dxx.Util;
using UnityEngine;

public class SkillAlone2160GoodCtrl : MonoBehaviour
{
	private int CONFIG_FLY_SWORD_ID;

	private float CONFIG_HIT_RATIO;

	private float CONFIG_SPEAR_TIME;

	private int CONFIG_DEBUFF_ID;

	[SerializeField]
	private CapsuleCollider m_Collider;

	[SerializeField]
	private Transform m_Model;

	private SequencePool m_SeqPool;

	private const float height = 20f;

	private EntityBase m_Entity;

	public void Init(EntityBase entity, EntityBase target, params float[] args)
	{
	}

	public void DeInit()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
