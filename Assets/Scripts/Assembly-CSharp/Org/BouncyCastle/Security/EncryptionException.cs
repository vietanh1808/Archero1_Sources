using System;
using System.IO;

namespace Org.BouncyCastle.Security
{
	[Serializable]
	public class EncryptionException : IOException
	{
		public EncryptionException(string message)
		{
		}

		public EncryptionException(string message, Exception exception)
		{
		}
	}
}
