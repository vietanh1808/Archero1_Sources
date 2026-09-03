using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpPrivateKey
	{
		private readonly long keyID;

		private readonly PublicKeyPacket publicKeyPacket;

		private readonly AsymmetricKeyParameter privateKey;

		public long KeyId => 0L;

		public PublicKeyPacket PublicKeyPacket => null;

		public AsymmetricKeyParameter Key => null;

		public PgpPrivateKey(long keyID, PublicKeyPacket publicKeyPacket, AsymmetricKeyParameter privateKey)
		{
		}
	}
}
