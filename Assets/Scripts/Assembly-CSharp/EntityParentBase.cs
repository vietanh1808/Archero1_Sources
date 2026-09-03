using UnityEngine;

public class EntityParentBase : MonoBehaviour
{
	protected EntityBase m_Entity;

	public virtual void SetEntityParent(EntityBase entity)
	{
	}

	public EntityBase GetEntityParent()
	{
		return null;
	}

	public bool IsSelf(EntityBase entity)
	{
		return false;
	}
}
