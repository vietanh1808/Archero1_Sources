public class DragonVO
{
	public ulong ServerId;

	public int SkillId;

	public int CharId;

	public DragonType dragonType;

	public LocalSave.EquipOne DragonOne;

	public bool IsCalReleaseAgainFlag;

	public DragonVO Clone()
	{
		return null;
	}
}
