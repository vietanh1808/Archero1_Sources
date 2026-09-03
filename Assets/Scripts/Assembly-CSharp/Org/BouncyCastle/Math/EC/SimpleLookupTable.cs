namespace Org.BouncyCastle.Math.EC
{
	public class SimpleLookupTable : ECLookupTable
	{
		private readonly ECPoint[] points;

		public virtual int Size => 0;

		private static ECPoint[] Copy(ECPoint[] points, int off, int len)
		{
			return null;
		}

		public SimpleLookupTable(ECPoint[] points, int off, int len)
		{
		}

		public virtual ECPoint Lookup(int index)
		{
			return null;
		}
	}
}
