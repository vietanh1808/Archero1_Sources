using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpSecretKeyRing : PgpKeyRing
	{
		private readonly IList keys;

		private readonly IList extraPubKeys;

		internal PgpSecretKeyRing(IList keys)
		{
		}

		private PgpSecretKeyRing(IList keys, IList extraPubKeys)
		{
		}

		public PgpSecretKeyRing(byte[] encoding)
		{
		}

		public PgpSecretKeyRing(Stream inputStream)
		{
		}

		public PgpPublicKey GetPublicKey()
		{
			return null;
		}

		public PgpSecretKey GetSecretKey()
		{
			return null;
		}

		public IEnumerable GetSecretKeys()
		{
			return null;
		}

		public PgpSecretKey GetSecretKey(long keyId)
		{
			return null;
		}

		public IEnumerable GetExtraPublicKeys()
		{
			return null;
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		public void Encode(Stream outStr)
		{
		}

		public static PgpSecretKeyRing ReplacePublicKeys(PgpSecretKeyRing secretRing, PgpPublicKeyRing publicRing)
		{
			return null;
		}

		public static PgpSecretKeyRing CopyWithNewPassword(PgpSecretKeyRing ring, char[] oldPassPhrase, char[] newPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
		{
			return null;
		}

		public static PgpSecretKeyRing InsertSecretKey(PgpSecretKeyRing secRing, PgpSecretKey secKey)
		{
			return null;
		}

		public static PgpSecretKeyRing RemoveSecretKey(PgpSecretKeyRing secRing, PgpSecretKey secKey)
		{
			return null;
		}
	}
}
