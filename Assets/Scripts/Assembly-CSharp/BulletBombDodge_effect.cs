using UnityEngine;

public class BulletBombDodge_effect : MonoBehaviour
{
	public ParticleSystem effect01;

	public ParticleSystem effect02;

	public ParticleSystem effect03;

	public ParticleSystem effect04;

	private Renderer[] renderers;

	private short[] counts01;

	private ParticleSystem.MinMaxCurve curve02_init;

	private ParticleSystem.MinMaxCurve curve02;

	private ParticleSystem.MinMaxCurve curve04_init;

	private ParticleSystem.MinMaxCurve curve04;

	private void Awake()
	{
	}

	public void SetScale(float value)
	{
	}

	private void setcount(ParticleSystem.EmissionModule emission, short[] counts, float scale)
	{
	}
}
