using UnityEngine;

public class SkillAlone1756GoodCtrl : MonoBehaviour
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

	private const int IDLE_STATE = 0;

	private const int TRACK_STATE = 1;

	private const int COMPLETE_STATE = 2;

	private const float RADIUS = 0.3f;

	private const float INITIAL_SPEED = 2.5f;

	private int state;

	private float Speed;

	private float DeltaSpeed;

	private float MaxSpeed;

	public void Init(EntityBase triggerEntity, float triggerRadius, float flySpeed, float stayTime, Vector3 pos, bool onlyShow)
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

	private void trackEntity()
	{
	}
}
