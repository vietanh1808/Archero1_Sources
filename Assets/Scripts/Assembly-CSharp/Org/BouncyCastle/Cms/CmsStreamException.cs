using System;
using System.IO;

namespace Org.BouncyCastle.Cms
{
	[Serializable]
	public class CmsStreamException : IOException
	{
		public CmsStreamException()
		{
		}

		public CmsStreamException(string name)
		{
		}

		public CmsStreamException(string name, Exception e)
		{
		}
	}
}
