using System;
using System.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpEncryptedDataList : PgpObject
	{
		private IList list;

		private InputStreamPacket data;

		public PgpEncryptedData this[int index] => null;

		[Obsolete("Use 'Count' property instead")]
		public int Size => 0;

		public int Count => 0;

		public bool IsEmpty => false;

		public PgpEncryptedDataList(BcpgInputStream bcpgInput)
		{
		}

		[Obsolete("Use 'object[index]' syntax instead")]
		public object Get(int index)
		{
			return null;
		}

		public IEnumerable GetEncryptedDataObjects()
		{
			return null;
		}
	}
}
