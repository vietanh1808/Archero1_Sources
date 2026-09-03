public class MiningBlockShowData
{
	private BlockData BlockData { get; set; }

	public int PosX => 0;

	public int PosY => 0;

	public BlockType B_Type => (BlockType)0;

	public MiningRewardType RewardType => MiningRewardType.None;

	public string IconName => null;

	public int Hp => 0;

	public int MaxHp => 0;

	public int RewardCount => 0;

	public bool IsPass => false;

	public bool IsLight => false;

	public int PosIndex => 0;

	public static MiningBlockShowData Create(BlockData mData)
	{
		return null;
	}

	public void UpdateBlockState(int crtHp, int crtMaxHp, bool crtIsPass, MiningRewardType type)
	{
	}

	public void UpdateLightState(bool crtIsLight)
	{
	}

	public void UpdateIsPass(bool isPass)
	{
	}

	private string GetIconName()
	{
		return null;
	}
}
