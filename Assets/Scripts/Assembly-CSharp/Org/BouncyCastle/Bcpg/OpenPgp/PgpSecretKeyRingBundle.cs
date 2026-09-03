using System;
using System.Collections;
using System.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpSecretKeyRingBundle
	{
		private readonly IDictionary secretRings;

		private readonly IList order;

		[Obsolete("Use 'Count' property instead")]
		public int Size => 0;

		public int Count => 0;

		private PgpSecretKeyRingBundle(IDictionary secretRings, IList order)
		{
		}

		public PgpSecretKeyRingBundle(byte[] encoding)
		{
		}

		public PgpSecretKeyRingBundle(Stream inputStream)
		{
		}

		public PgpSecretKeyRingBundle(IEnumerable e)
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

		public PgpSecretKey GetSecretKey(long keyId)
		{
			return null;
		}

		public PgpSecretKeyRing GetSecretKeyRing(long keyId)
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

		public static PgpSecretKeyRingBundle AddSecretKeyRing(PgpSecretKeyRingBundle bundle, PgpSecretKeyRing secretKeyRing)
		{
			return null;
		}

		public static PgpSecretKeyRingBundle RemoveSecretKeyRing(PgpSecretKeyRingBundle bundle, PgpSecretKeyRing secretKeyRing)
		{
			return null;
		}
	}
}
