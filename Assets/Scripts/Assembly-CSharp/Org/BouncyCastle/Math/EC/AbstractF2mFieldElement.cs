namespace Org.BouncyCastle.Math.EC
{
	public abstract class AbstractF2mFieldElement : ECFieldElement
	{
		public virtual ECFieldElement HalfTrace()
		{
			return null;
		}

		public virtual int Trace()
		{
			return 0;
		}
	}
}
