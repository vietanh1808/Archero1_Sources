using CodeStage.AntiCheat.ObscuredTypes;
using TableTool;

public class EntityMonsterAttribute_MB
{
	public EntityAttributeBase.ValueBase DeltaAttack;

	public EntityAttributeBase.ValueFloatBase DeltaAttackPercent;

	public EntityAttributeBase.ValueBase DeltaLife;

	public EntityAttributeBase.ValueFloatBase DeltaLifePercent;

	public EntityAttributeBase.ValueBase DeltaLifeMax;

	public EntityAttributeBase.ValueFloatBase DeltaLifeMaxPercent;

	public EntityAttributeBase.ValueFloatBase DeltaMoveSpeedPercent;

	public EntityAttributeBase.ValueFloatBase DeltaModelScalePercent;

	public EntityAttributeBase.ValueBase DeltaSearchWidth;

	public EntityAttributeBase.ValueBase DeltaSearchHeight;

	public EntityAttributeBase.ValueBase DeltaEvolutionTime;

	public EntityAttributeBase.ValueBase DeltaWanderWeight;

	public EntityAttributeBase.ValueFloatBase DeltaWanderWeightPercent;

	public ObscuredInt[] CustomAttackWeights;

	public EntityMonsterBase m_Entity;

	public ObscuredLong Attack { get; private set; }

	public ObscuredLong LifeMax { get; private set; }

	public ObscuredInt SearchWidth { get; private set; }

	public ObscuredInt SearchHeight { get; private set; }

	public ObscuredFloat EvolutionTime { get; private set; }

	public float ModeScale { get; private set; }

	public float MoveSpeed { get; private set; }

	public int WanderWeight { get; private set; }

	public Farm_BattleMonster BattleMonsterMeta => null;

	public void SetEntity(EntityBase entity)
	{
	}

	public void Init()
	{
	}

	public void Execute(string atr)
	{
	}

	public void Execute(string type, long value)
	{
	}

	public string getPersistentAtrInfo()
	{
		return null;
	}

	public void RecaculateProperties()
	{
	}

	private void updateAttack()
	{
	}

	private void updateLifeMax()
	{
	}

	private void updateHp()
	{
	}

	private void updateSearchArea()
	{
	}

	private void updateModelScale()
	{
	}

	public string getPropertiesInfo()
	{
		return null;
	}

	public void SetAttack(long value)
	{
	}

	public void SetEvolutionTime(float value)
	{
	}

	public void SetModelScale(float value)
	{
	}

	public void SetMoveSpeed(float value)
	{
	}

	public void SetSearchWidth(int value)
	{
	}

	public void SetSearchHeight(int value)
	{
	}
}
