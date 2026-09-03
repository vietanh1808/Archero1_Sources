using UnityEngine;

public class AI1891 : AIBase
{
	public const int BULLET_ID = 1221;

	private const float RUN_SPEED = 1f;

	public const float SPEED_PERCENT = 0.15f;

	public const float MAX_SPEED = 6f;

	public const float CLOSE_DISTANCE = 1f;

	public const float CLOSE_DISTANCE_BOSS = 0.2f;

	private const string APPEAR_ANIM = "Skill02_Appear";

	private const string RUN_ANIM = "Skill02_Run";

	public const string ATTACK_BOSS_ANIM = "Skill02_AtkBoss";

	public const string ATTACK_SOLDIER_ANIM = "Skill02_AtkSoldier";

	private const string RUN_BACK_ANIM = "Skill02_RunBack";

	private const string DISAPPEAR_ANIM = "Skill02_Disappear";

	private bool hasSetCustomTarget;

	public Vector3 BirthPos;

	private bool _bEnd;

	private float appearTime;

	private float disappearTime;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void initAnimSpeed()
	{
	}

	private ActionBase GetAtkAction()
	{
		return null;
	}

	private ActionBase GetRunBackAction()
	{
		return null;
	}
}
