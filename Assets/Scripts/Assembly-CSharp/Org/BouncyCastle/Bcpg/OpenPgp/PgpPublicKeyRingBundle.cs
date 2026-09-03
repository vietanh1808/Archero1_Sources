using System;
using System.Collections;
using System.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpPublicKeyRingBundle
	{
		private readonly IDictionary pubRings;

		private readonly IList order;

		[Obsolete("Use 'Count' property instead")]
		public int Size => 0;

		public int Count => 0;

		private PgpPublicKeyRingBundle(IDictionary pubRings, IList order)
		{
		}

		public PgpPublicKeyRingBundle(byte[] encoding)
		{
		}

		public PgpPublicKeyRingBundle(Stream inputStream)
		{
		}

		public PgpPublicKeyRingBundle(IEnumerable e)
		{
		}

		public IEnumerable GetKeyRings()
		{
			return null;
		}

		public IEnumerable GetKeyRings(string userId)
		{
			return null;
		}

		public IEnumerable GetKeyRings(string userId, bool matchPartial)
		{
			return null;
		}

		public IEnumerable GetKeyRings(string userId, bool matchPartial, bool ignoreCase)
		{
			return null;
		}

		public PgpPublicKey GetPublicKey(long keyId)
		{
			return null;
		}

		public PgpPublicKeyRing GetPublicKeyRing(long keyId)
		{
			return null;
		}

		public bool Contains(long keyID)
		{
			return false;
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		public void Encode(Stream outStr)
		{
		}

		public static PgpPublicKeyRingBundle AddPublicKeyRing(PgpPublicKeyRingBundle bundle, PgpPublicKeyRing publicKeyRing)
		{
			return null;
		}

		public static PgpPublicKeyRingBundle RemovePublicKeyRing(PgpPublicKeyRingBundle bundle, PgpPublicKeyRing publicKeyRing)
		{
			return null;
		}
	}
}
