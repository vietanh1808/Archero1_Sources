using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	[Serializable]
	public class PgpException : Exception
	{
		[Obsolete("Use InnerException property")]
		public Exception UnderlyingException => null;

		public PgpException()
		{
		}

		public PgpException(string message)
		{
		}

		public PgpException(string message, Exception exception)
		{
		}
	}
}
