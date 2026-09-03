public class BlockData
{
	public int posX;

	public int posY;

	public BlockType B_Type;

	public MiningRewardType RewardType;

	public int hp;

	public int maxHp;

	public int RewardCount;

	public bool IsPass;

	public bool isLight;

	public int posIndex;

	public void UpdateIsPass(bool isPass)
	{
	}

	public void UpdateBlockState(int crtHp, int crtMaxHp, bool crtIsPass, MiningRewardType type)
	{
	}

	public void UpdateLightState(bool crtIsLight)
	{
	}
}
