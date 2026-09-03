using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	public class Iso9796d2PssSigner : ISignerWithRecovery, ISigner
	{
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerImplicit = 188;

		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerRipeMD160 = 12748;

		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerRipeMD128 = 13004;

		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha1 = 13260;

		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha256 = 13516;

		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha512 = 13772;

		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha384 = 14028;

		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerWhirlpool = 14284;

		private IDigest digest;

		private IAsymmetricBlockCipher cipher;

		private SecureRandom random;

		private byte[] standardSalt;

		private int hLen;

		private int trailer;

		private int keyBits;

		private byte[] block;

		private byte[] mBuf;

		private int messageLength;

		private readonly int saltLength;

		private bool fullMessage;

		private byte[] recoveredMessage;

		private byte[] preSig;

		private byte[] preBlock;

		private int preMStart;

		private int preTLength;

		public virtual string AlgorithmName => null;

		public byte[] GetRecoveredMessage()
		{
			return null;
		}

		public Iso9796d2PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, int saltLength, bool isImplicit)
		{
		}

		public Iso9796d2PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, int saltLength)
		{
		}

		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		private bool IsSameAs(byte[] a, byte[] b)
		{
			return false;
		}

		private void ClearBlock(byte[] block)
		{
		}

		public virtual void UpdateWithRecoveredMessage(byte[] signature)
		{
		}

		public virtual void Update(byte input)
		{
		}

		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		public virtual void Reset()
		{
		}

		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		public virtual bool VerifySignature(byte[] signature)
		{
			return false;
		}

		public virtual bool HasFullMessage()
		{
			return false;
		}

		private void ItoOSP(int i, byte[] sp)
		{
		}

		private void LtoOSP(long l, byte[] sp)
		{
		}

		private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
		{
			return null;
		}
	}
}
