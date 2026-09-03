using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1
{
	public class Asn1EncodableVector : IEnumerable
	{
		private IList v;

		public Asn1Encodable this[int index] => null;

		[Obsolete("Use 'Count' property instead")]
		public int Size => 0;

		public int Count => 0;

		public static Asn1EncodableVector FromEnumerable(IEnumerable e)
		{
			return null;
		}

		public Asn1EncodableVector(params Asn1Encodable[] v)
		{
		}

		public void Add(params Asn1Encodable[] objs)
		{
		}

		public void AddOptional(params Asn1Encodable[] objs)
		{
		}

		[Obsolete("Use 'object[index]' syntax instead")]
		public Asn1Encodable Get(int index)
		{
			return null;
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
