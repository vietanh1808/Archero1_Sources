public class BuffAloneHellBase : BuffAloneBase
{
	protected virtual int HitEffectID => 0;

	protected override bool ExcuteBuffs(BuffData data)
	{
		return false;
	}
}
