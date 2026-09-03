using System;
using System.Collections;
using System.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpObjectFactory
	{
		private readonly BcpgInputStream bcpgIn;

		public PgpObjectFactory(Stream inputStream)
		{
		}

		public PgpObjectFactory(byte[] bytes)
		{
		}

		public PgpObject NextPgpObject()
		{
			return null;
		}

		[Obsolete("Use NextPgpObject() instead")]
		public object NextObject()
		{
			return null;
		}

		public IList AllPgpObjects()
		{
			return null;
		}
	}
}
