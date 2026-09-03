using UnityEngine;

public class AI1826Move : AIMovePathFinding
{
	public EntityBase m_HatredTarget;

	private const float SQR_DECISION_RADIUS = 25f;

	private const float SQR_SLASH_RADIUS = 9f;

	private const float SQR_WAVING_RARIUS = 4f;

	private Vector3 originalPos;

	private AI1826 aiBase;

	public AI1826Move(EntityBase entity)
		: base(null)
	{
	}

	protected override bool canInterrupt()
	{
		return false;
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	private bool CanTriggerSlashAttack()
	{
		return false;
	}
}
