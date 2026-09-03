using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	public class UserAttributeSubpacket
	{
		internal readonly UserAttributeSubpacketTag type;

		private readonly bool longLength;

		protected readonly byte[] data;

		public virtual UserAttributeSubpacketTag SubpacketType => (UserAttributeSubpacketTag)0;

		protected internal UserAttributeSubpacket(UserAttributeSubpacketTag type, byte[] data)
		{
		}

		protected internal UserAttributeSubpacket(UserAttributeSubpacketTag type, bool forceLongLength, byte[] data)
		{
		}

		public virtual byte[] GetData()
		{
			return null;
		}

		public virtual void Encode(Stream os)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
