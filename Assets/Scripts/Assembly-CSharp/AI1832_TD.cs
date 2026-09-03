using UnityEngine;

public class AI1832_TD : AIDizzyBase
{
	private const int BULLET_ID = 1901;

	private const string ATTACK_UP = "AttackUp";

	private const string ATTACK_DOWN = "AttackDown";

	private GameObject hitObj;

	private TD1832HitCtrl hitCtrl;

	private bool isAttacking;

	private float attackUpTime;

	private float attackDownTime;

	private ActionBasic atkActions;

	private BulletBase bulletBase;

	private float customStayTime;

	protected override void OnInitOnce()
	{
	}

	protected override void PopulateActions()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	protected void UpdateAnimSpeedWrapper()
	{
	}

	public void UpdateAnimSpeed(float delta)
	{
	}

	private void onTriggerEnter(Collider collider)
	{
	}

	private void onTriggerStay(Collider collider)
	{
	}

	private void AttackWrapper(Collider collider)
	{
	}

	private void Attack()
	{
	}
}
