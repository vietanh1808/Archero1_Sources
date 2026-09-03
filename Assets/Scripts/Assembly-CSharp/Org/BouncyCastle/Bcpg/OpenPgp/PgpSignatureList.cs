using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpSignatureList : PgpObject
	{
		private PgpSignature[] sigs;

		public PgpSignature this[int index] => null;

		[Obsolete("Use 'Count' property instead")]
		public int Size => 0;

		public int Count => 0;

		public bool IsEmpty => false;

		public PgpSignatureList(PgpSignature[] sigs)
		{
		}

		public PgpSignatureList(PgpSignature sig)
		{
		}

		[Obsolete("Use 'object[index]' syntax instead")]
		public PgpSignature Get(int index)
		{
			return null;
		}
	}
}
