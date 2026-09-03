using TableTool;

public class TetrisUnitConfig
{
	public int ID { get; private set; }

	public int Quality { get; private set; }

	public int Type { get; private set; }

	public int Icon { get; private set; }

	public int WeaponId { get; private set; }

	public int[] Combine { get; private set; }

	public int BagType { get; private set; }

	public string[] Attributes { get; private set; }

	public float AttackDistance { get; private set; }

	public int[] InitSkills { get; private set; }

	public int Time { get; private set; }

	public int FirstRate { get; private set; }

	public int FreshRate { get; private set; }

	public int AddRatePerWave { get; private set; }

	public int RecyclePrice { get; private set; }

	public TetrisUnitConfig(Daily_BagWeaponConfig config)
	{
	}

	public TetrisUnitConfig(ShipStage_BagWeapon config)
	{
	}
}
