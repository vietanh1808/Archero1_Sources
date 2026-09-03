using UnityEngine;

public class TD1846HitCtrl : TD2023HitCtrlBase
{
	private AI1846_TD ai;

	private Animation anim;

	private float aliveTime;

	private Vector2Int XY;

	private bool isAlive;

	private float time;

	public void Init(EntityBase entity, Vector2Int _XY)
	{
	}

	public override void DeInit()
	{
	}

	protected override void UpdateProcess()
	{
	}

	private void selfDestruct()
	{
	}

	protected override void OnTriggerEnter(Collider other)
	{
	}

	protected override void OnTriggerStay(Collider other)
	{
	}

	protected override void OnTriggerExit(Collider other)
	{
	}

	private void checkIfCreateBullet(Collider collider)
	{
	}
}
