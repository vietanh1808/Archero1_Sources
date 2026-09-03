using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpOnePassSignatureList : PgpObject
	{
		private readonly PgpOnePassSignature[] sigs;

		public PgpOnePassSignature this[int index] => null;

		[Obsolete("Use 'Count' property instead")]
		public int Size => 0;

		public int Count => 0;

		public bool IsEmpty => false;

		public PgpOnePassSignatureList(PgpOnePassSignature[] sigs)
		{
		}

		public PgpOnePassSignatureList(PgpOnePassSignature sig)
		{
		}

		[Obsolete("Use 'object[index]' syntax instead")]
		public PgpOnePassSignature Get(int index)
		{
			return null;
		}
	}
}
