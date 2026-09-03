using UnityEngine;

public class LightingLineCtrl : MonoBehaviour
{
	private LineRenderer child;

	private Transform endeffect;

	private ParticleSystem[] ps;

	private const float textureLengthScale = 3f;

	private const float textureScrollSpeed = 8f;

	private Transform ball_child;

	private EntityBase target;

	private void Awake()
	{
	}

	public void Init(Transform child, EntityBase target)
	{
	}

	private void Update()
	{
	}

	private void UpdateLine(Vector3 startpos, Vector3 endpos)
	{
	}
}
