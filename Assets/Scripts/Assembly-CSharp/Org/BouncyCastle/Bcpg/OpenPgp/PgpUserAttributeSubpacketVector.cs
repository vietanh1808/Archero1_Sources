using Org.BouncyCastle.Bcpg.Attr;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpUserAttributeSubpacketVector
	{
		private readonly UserAttributeSubpacket[] packets;

		internal PgpUserAttributeSubpacketVector(UserAttributeSubpacket[] packets)
		{
		}

		public UserAttributeSubpacket GetSubpacket(UserAttributeSubpacketTag type)
		{
			return null;
		}

		public ImageAttrib GetImageAttribute()
		{
			return null;
		}

		internal UserAttributeSubpacket[] ToSubpacketArray()
		{
			return null;
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
