using UnityEngine;

public class SeagullFollowController : MonoBehaviour
{
	public float speed;

	public float dampTime;

	public Transform targetTransform;

	public float scatter;

	public float scatterSpeed;

	public float orthoCamScale;

	public bool isUseOffset;

	public Vector3 offset;

	private Animator animator;

	private int animFacingParam;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
