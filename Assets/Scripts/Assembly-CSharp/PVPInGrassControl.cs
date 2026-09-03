using System.Collections.Generic;

public class PVPInGrassControl
{
	public class InGrassShowTimeConfig
	{
		public static float FromOutside;

		public static float AttackEnemy;

		public static float DropHP;

		public static float InEnemyRadar;
	}

	public enum InGrassShowType
	{
		FromOutside = 0,
		AttackEnemy = 1,
		DropHP = 2,
		InEnemyRadar = 3
	}

	public class InGrassShowVO
	{
		public InGrassShowType ShowType;

		public float ShowTime;
	}

	private const string UPDATE_NAME = "PVPInGrassControl_UPDATE";

	public EntityNetHero m_Entity;

	public Dictionary<int, InGrassShowVO> InGrassVODic;

	public Dictionary<InGrassShowType, float> ShowTimeDic;

	private string updateName;

	public PVPInGrassControl(EntityNetHero entity)
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void initCallbacks()
	{
	}

	private void deinitCallbacks()
	{
	}

	protected void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void OnAttackStart(JoyData obj)
	{
	}

	private void OnHPChangedInPVP(long deltaHP)
	{
	}

	private void insidePVPGrass(bool inside)
	{
	}

	private void insideEnemyRadar(bool inside)
	{
	}

	public void Update(float deltaTime)
	{
	}

	private void PrintAll()
	{
	}

	public bool CheckIfShowTimeZero()
	{
		return false;
	}

	private void initShowTimeDic()
	{
	}

	private void resetShowTimeDic()
	{
	}

	private void resetShowTimeDic(int key)
	{
	}

	public void UpdateShowTime(int showType)
	{
	}

	private void syncShowTime(int showType)
	{
	}

	private int GetDropHpKey()
	{
		return 0;
	}

	private bool isForbiddenKey(int generatedKey)
	{
		return false;
	}
}
