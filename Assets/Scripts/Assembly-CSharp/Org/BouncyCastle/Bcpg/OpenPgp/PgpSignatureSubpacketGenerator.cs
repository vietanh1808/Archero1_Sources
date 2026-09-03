using System;
using System.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpSignatureSubpacketGenerator
	{
		private IList list;

		public void SetRevocable(bool isCritical, bool isRevocable)
		{
		}

		public void SetExportable(bool isCritical, bool isExportable)
		{
		}

		public void SetFeature(bool isCritical, byte feature)
		{
		}

		public void SetTrust(bool isCritical, int depth, int trustAmount)
		{
		}

		public void SetKeyExpirationTime(bool isCritical, long seconds)
		{
		}

		public void SetSignatureExpirationTime(bool isCritical, long seconds)
		{
		}

		public void SetSignatureCreationTime(bool isCritical, DateTime date)
		{
		}

		public void SetPreferredHashAlgorithms(bool isCritical, int[] algorithms)
		{
		}

		public void SetPreferredSymmetricAlgorithms(bool isCritical, int[] algorithms)
		{
		}

		public void SetPreferredCompressionAlgorithms(bool isCritical, int[] algorithms)
		{
		}

		public void SetKeyFlags(bool isCritical, int flags)
		{
		}

		public void SetSignerUserId(bool isCritical, string userId)
		{
		}

		public void SetSignerUserId(bool isCritical, byte[] rawUserId)
		{
		}

		public void SetEmbeddedSignature(bool isCritical, PgpSignature pgpSignature)
		{
		}

		public void SetPrimaryUserId(bool isCritical, bool isPrimaryUserId)
		{
		}

		public void SetNotationData(bool isCritical, bool isHumanReadable, string notationName, string notationValue)
		{
		}

		public void SetRevocationReason(bool isCritical, RevocationReasonTag reason, string description)
		{
		}

		public void SetRevocationKey(bool isCritical, PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint)
		{
		}

		public void SetIssuerKeyID(bool isCritical, long keyID)
		{
		}

		public PgpSignatureSubpacketVector Generate()
		{
			return null;
		}
	}
}
