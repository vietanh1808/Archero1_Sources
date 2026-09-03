using System;
using Org.BouncyCastle.Bcpg.Sig;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpSignatureSubpacketVector
	{
		private readonly SignatureSubpacket[] packets;

		[Obsolete("Use 'Count' property instead")]
		public int Size => 0;

		public int Count => 0;

		internal PgpSignatureSubpacketVector(SignatureSubpacket[] packets)
		{
		}

		public SignatureSubpacket GetSubpacket(SignatureSubpacketTag type)
		{
			return null;
		}

		public bool HasSubpacket(SignatureSubpacketTag type)
		{
			return false;
		}

		public SignatureSubpacket[] GetSubpackets(SignatureSubpacketTag type)
		{
			return null;
		}

		public NotationData[] GetNotationDataOccurrences()
		{
			return null;
		}

		[Obsolete("Use 'GetNotationDataOccurrences' instead")]
		public NotationData[] GetNotationDataOccurences()
		{
			return null;
		}

		public long GetIssuerKeyId()
		{
			return 0L;
		}

		public bool HasSignatureCreationTime()
		{
			return false;
		}

		public DateTime GetSignatureCreationTime()
		{
			return default;
		}

		public long GetSignatureExpirationTime()
		{
			return 0L;
		}

		public long GetKeyExpirationTime()
		{
			return 0L;
		}

		public int[] GetPreferredHashAlgorithms()
		{
			return null;
		}

		public int[] GetPreferredSymmetricAlgorithms()
		{
			return null;
		}

		public int[] GetPreferredCompressionAlgorithms()
		{
			return null;
		}

		public int GetKeyFlags()
		{
			return 0;
		}

		public string GetSignerUserId()
		{
			return null;
		}

		public bool IsPrimaryUserId()
		{
			return false;
		}

		public SignatureSubpacketTag[] GetCriticalTags()
		{
			return null;
		}

		public Features GetFeatures()
		{
			return null;
		}

		internal SignatureSubpacket[] ToSubpacketArray()
		{
			return null;
		}
	}
}
