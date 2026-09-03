using UnityEngine;

public class EntityEmeraldHit : MonoBehaviour
{
	private EntityBase m_Entity;

	private void OnTriggerEnter(Collider o)
	{
	}

	protected virtual void TriggerEnter(EntityBase entity)
	{
	}

	public void SetEntity(EntityBase entity)
	{
	}
}
