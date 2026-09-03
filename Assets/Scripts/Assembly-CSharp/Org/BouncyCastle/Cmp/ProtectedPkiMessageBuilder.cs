using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cmp
{
	public class ProtectedPkiMessageBuilder
	{
		private PkiHeaderBuilder hdrBuilBuilder;

		private PkiBody body;

		private IList generalInfos;

		private IList extraCerts;

		public ProtectedPkiMessageBuilder(GeneralName sender, GeneralName recipient)
		{
		}

		public ProtectedPkiMessageBuilder(int pvno, GeneralName sender, GeneralName recipient)
		{
		}

		public ProtectedPkiMessageBuilder SetTransactionId(byte[] tid)
		{
			return null;
		}

		public ProtectedPkiMessageBuilder SetFreeText(PkiFreeText freeText)
		{
			return null;
		}

		public ProtectedPkiMessageBuilder AddGeneralInfo(InfoTypeAndValue genInfo)
		{
			return null;
		}

		public ProtectedPkiMessageBuilder SetMessageTime(DerGeneralizedTime generalizedTime)
		{
			return null;
		}

		public ProtectedPkiMessageBuilder SetRecipKID(byte[] id)
		{
			return null;
		}

		public ProtectedPkiMessageBuilder SetRecipNonce(byte[] nonce)
		{
			return null;
		}

		public ProtectedPkiMessageBuilder SetSenderKID(byte[] id)
		{
			return null;
		}

		public ProtectedPkiMessageBuilder SetSenderNonce(byte[] nonce)
		{
			return null;
		}

		public ProtectedPkiMessageBuilder SetBody(PkiBody body)
		{
			return null;
		}

		public ProtectedPkiMessageBuilder AddCmpCertificate(X509Certificate certificate)
		{
			return null;
		}

		public ProtectedPkiMessage Build(ISignatureFactory signatureFactory)
		{
			return null;
		}

		public ProtectedPkiMessage Build(IMacFactory factory)
		{
			return null;
		}

		private void FinalizeHeader(AlgorithmIdentifier algorithmIdentifier)
		{
		}

		private ProtectedPkiMessage FinalizeMessage(PkiHeader header, DerBitString protection)
		{
			return null;
		}

		private byte[] CalculateSignature(IStreamCalculator signer, PkiHeader header, PkiBody body)
		{
			return null;
		}
	}
}
