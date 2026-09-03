using UnityEngine;

public class AI1826 : AIBase
{
	public enum AttackState
	{
		none = 0,
		slash = 1,
		wave = 2
	}

	public const float NEAR_DISTANCE = 1.5f;

	public const float SPEED_TIMES = 4f;

	public const int WAVE_WEAPON_ID = 1210;

	public const int SLASH_WEAPON_ID = 1209;

	private const int CallingEffectId = 3100068;

	public const string BORN_ANIM = "Born";

	public AttackState CurAtkState;

	public bool isElite;

	private float bornTime;

	private GameObject effect;

	private bool appeared;

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room obj)
	{
	}

	public void RecreateAIActions()
	{
	}

	public void createAIActions()
	{
	}

	public ActionBase getIdleAction()
	{
		return null;
	}

	public EntityBase GetHatredTarget()
	{
		return null;
	}

	public void SetAttackState(AttackState state)
	{
	}

	private ActionSequence getAppearAction()
	{
		return null;
	}
}
