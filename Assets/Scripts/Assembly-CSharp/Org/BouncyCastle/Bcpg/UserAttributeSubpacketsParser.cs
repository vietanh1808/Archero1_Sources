using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	public class UserAttributeSubpacketsParser
	{
		private readonly Stream input;

		public UserAttributeSubpacketsParser(Stream input)
		{
		}

		public virtual UserAttributeSubpacket ReadPacket()
		{
			return null;
		}
	}
}
