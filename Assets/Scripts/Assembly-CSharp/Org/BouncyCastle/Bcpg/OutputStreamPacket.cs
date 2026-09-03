namespace Org.BouncyCastle.Bcpg
{
	public abstract class OutputStreamPacket
	{
		private readonly BcpgOutputStream bcpgOut;

		internal OutputStreamPacket(BcpgOutputStream bcpgOut)
		{
		}

		public abstract BcpgOutputStream Open();

		public abstract void Close();
	}
}
