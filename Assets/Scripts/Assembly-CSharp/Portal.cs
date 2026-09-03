using UnityEngine;

public class Portal : MonoBehaviour
{
	public enum Portal_Type
	{
		Portal_Type_None = 0,
		Portal_Type_Green = 1,
		Portal_Type_Blue = 2,
		Portal_Type_Purple = 3,
		Portal_Type_Yellow = 4,
		Portal_Type_Guild_Blue = 1001,
		Portal_Type_Guild_Purple = 1002
	}

	private BoxCollider _collider;

	public ParticleSystem particle_1;

	public ParticleSystem particle_2;

	public Portal_Type type;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider o)
	{
	}

	private void TriggerDoor(GameObject o)
	{
	}
}
