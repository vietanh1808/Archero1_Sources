using UnityEngine;

public class SkillAlone1722GoodCtrl : MonoBehaviour
{
	[SerializeField]
	private Animator ani;

	[SerializeField]
	private Transform child;

	private EntityBase triggerEntity;

	private Vector3 pos;

	private float triggerRadius;

	private float flySpeed;

	private float stayTime;

	private bool onlyShow;

	private bool allowCumulativeTime;

	private float cumulativeTime;

	private float cumulativeIntervalTime;

	private float cumulativeFlyTime;

	private float checkInterval;

	private bool haveEat;

	public void Init(EntityBase triggerEntity, float triggerRadius, float flySpeed, float stayTime, Vector3 pos, bool onlyShow)
	{
	}

	private void TriggerEntity()
	{
	}

	private void StartAni()
	{
	}

	private void Complete()
	{
	}

	public void Clear()
	{
	}

	private void Update()
	{
	}
}
