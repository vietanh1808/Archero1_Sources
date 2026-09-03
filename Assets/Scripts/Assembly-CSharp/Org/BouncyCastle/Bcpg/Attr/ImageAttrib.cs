namespace Org.BouncyCastle.Bcpg.Attr
{
	public class ImageAttrib : UserAttributeSubpacket
	{
		public enum Format : byte
		{
			Jpeg = 1
		}

		private static readonly byte[] Zeroes;

		private int hdrLength;

		private int _version;

		private int _encoding;

		private byte[] imageData;

		public virtual int Version => 0;

		public virtual int Encoding => 0;

		public ImageAttrib(byte[] data)
			: base((UserAttributeSubpacketTag)0, null)
		{
		}

		public ImageAttrib(bool forceLongLength, byte[] data)
			: base((UserAttributeSubpacketTag)0, null)
		{
		}

		public ImageAttrib(Format imageType, byte[] imageData)
			: base((UserAttributeSubpacketTag)0, null)
		{
		}

		private static byte[] ToByteArray(Format imageType, byte[] imageData)
		{
			return null;
		}

		public virtual byte[] GetImageData()
		{
			return null;
		}
	}
}
