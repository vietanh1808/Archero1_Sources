using System.Collections;
using System.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpPublicKeyRing : PgpKeyRing
	{
		private readonly IList keys;

		public PgpPublicKeyRing(byte[] encoding)
		{
		}

		internal PgpPublicKeyRing(IList pubKeys)
		{
		}

		public PgpPublicKeyRing(Stream inputStream)
		{
		}

		public virtual PgpPublicKey GetPublicKey()
		{
			return null;
		}

		public virtual PgpPublicKey GetPublicKey(long keyId)
		{
			return null;
		}

		public virtual IEnumerable GetPublicKeys()
		{
			return null;
		}

		public virtual byte[] GetEncoded()
		{
			return null;
		}

		public virtual void Encode(Stream outStr)
		{
		}

		public static PgpPublicKeyRing InsertPublicKey(PgpPublicKeyRing pubRing, PgpPublicKey pubKey)
		{
			return null;
		}

		public static PgpPublicKeyRing RemovePublicKey(PgpPublicKeyRing pubRing, PgpPublicKey pubKey)
		{
			return null;
		}

		internal static PgpPublicKey ReadSubkey(BcpgInputStream bcpgInput)
		{
			return null;
		}
	}
}
