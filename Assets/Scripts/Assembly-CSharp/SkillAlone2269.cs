using System.Collections.Generic;

public class SkillAlone2269 : SkillAloneBase
{
	private int divinityValueLimit;

	private int divinityValuePerHit;

	private int divinityValueFullHp;

	private float moveTimePerDivinityValue;

	private float awakeDivinityValue;

	private int blessValue1;

	private int blessValue2;

	private int blessValue3;

	private float blessCdTime;

	private int blessBuff1;

	private int blessBuff2;

	private int blessBuff3;

	private int divinityReducePS;

	private Dictionary<int, int> tridentWeaponDict;

	private Dictionary<int, int> doubleDaggerWeaponDict;

	private TridentSuperSkill superSkillVO;

	private int initialWeaponId;

	private bool isUsingDagger;

	private int tridentAtkCounter;

	private int daggerAtkCounter;

	private int blessLevel;

	private float preAddBlessTime;

	private const int initTridentId = 1210402;

	private const int sweepTridentId = 1210403;

	private const int initDaggerId = 1210404;

	private bool needChangeToInit;

	private float preEnterMoveTime;

	private float m_fTime;

	private float cumulativeTime;

	private LocalSave.TridentDivinityV0 tridentDivinityV0 => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnMove(bool isMoving)
	{
	}

	private void CheckWeapon()
	{
	}

	private void ChangeDagger()
	{
	}

	private void ChangeTrident()
	{
	}

	private void ResetOldWeapon()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnAttack()
	{
	}

	private void OnAttackPrePre()
	{
	}

	private void OnAttackEndEndEvent()
	{
	}

	private void DecDivinity(float delta)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void CheckBlessLevel(float curValue, float limit)
	{
	}

	private void OnTridentChangeState(bool isUsingDagger)
	{
	}

	private bool IsSuperSkillWorking()
	{
		return false;
	}

	private void InitSuperSkill()
	{
	}

	private void OnSuperSkillStart()
	{
	}

	private void OnSuperSkillEnd()
	{
	}

	private void UpdateState()
	{
	}
}
