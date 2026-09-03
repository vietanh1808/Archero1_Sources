namespace Org.BouncyCastle.Bcpg
{
	public abstract class BcpgObject
	{
		public virtual byte[] GetEncoded()
		{
			return null;
		}

		public abstract void Encode(BcpgOutputStream bcpgOut);
	}
}
