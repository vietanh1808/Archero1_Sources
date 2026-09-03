using UnityEngine;

public class RealTimeParticle : MonoBehaviour
{
	[SerializeField]
	private bool withChildren;

	private ParticleSystem _particle;

	private ParticleSystem[] _particles;

	private int _particles_count;

	private float _deltaTime;

	private float _timeAtLastFrame;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
