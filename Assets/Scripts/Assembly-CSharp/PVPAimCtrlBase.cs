using UnityEngine;

public class PVPAimCtrlBase : MonoBehaviour
{
	protected EntityBase m_Entity;

	public virtual void Init(EntityBase entity)
	{
	}

	public virtual void DeInit()
	{
	}

	public virtual void OnUpdate()
	{
	}

	public virtual void SetCurrentAngle(float angle)
	{
	}

	public virtual float GetCurrentAngle()
	{
		return 0f;
	}

	public virtual float GetCurrentAttackAngle()
	{
		return 0f;
	}

	public virtual Quaternion GetLineDir()
	{
		return default;
	}

	public virtual void SetLineDir(Quaternion rot)
	{
	}

	public virtual void StartAttack()
	{
	}

	public virtual void StopAttack()
	{
	}

	public void SetSortingOrder(bool isInPvpGrass)
	{
	}
}
