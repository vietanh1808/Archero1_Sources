using System;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpKeyPair
	{
		private readonly PgpPublicKey pub;

		private readonly PgpPrivateKey priv;

		public long KeyId => 0L;

		public PgpPublicKey PublicKey => null;

		public PgpPrivateKey PrivateKey => null;

		public PgpKeyPair(PublicKeyAlgorithmTag algorithm, AsymmetricCipherKeyPair keyPair, DateTime time)
		{
		}

		public PgpKeyPair(PublicKeyAlgorithmTag algorithm, AsymmetricKeyParameter pubKey, AsymmetricKeyParameter privKey, DateTime time)
		{
		}

		public PgpKeyPair(PgpPublicKey pub, PgpPrivateKey priv)
		{
		}
	}
}
