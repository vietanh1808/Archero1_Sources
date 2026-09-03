public class SailingMonsterMCannonDamageData
{
	public bool isShooted;

	public SailingMCannonType MCannonType { get; set; }

	public bool IsCriticalDmg { get; set; }

	public int Damage { get; set; }

	public static SailingMonsterMCannonDamageData Create(SailingMCannonType arrowType, bool isCriticalDmg, int damage)
	{
		return null;
	}
}
