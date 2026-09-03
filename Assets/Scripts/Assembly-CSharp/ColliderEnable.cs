using UnityEngine;

public class ColliderEnable : MonoBehaviour
{
	private float mTime;

	private float starttime;

	private bool bExcute;

	private BoxCollider mBox;

	private SphereCollider mSphere;

	private CapsuleCollider mCapsule;

	public float DelayTime;

	[Tooltip("延迟后可否碰撞")]
	public bool bDelayEnable;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void SetColliderEnable(bool enable)
	{
	}
}
