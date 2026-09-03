using UnityEngine;

public class ThunderLineCtrl : MonoBehaviour
{
	protected Transform child;

	private EntityBase from;

	private EntityBase to;

	protected Vector3 frompos;

	protected Vector3 topos;

	private MeshRenderer[] meshes;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	protected virtual void UpdateEntity()
	{
	}

	protected virtual void updateByPos()
	{
	}

	public void UpdateEntity(EntityBase from, EntityBase to)
	{
	}
}
