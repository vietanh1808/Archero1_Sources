using System.IO;

namespace Org.BouncyCastle.Apache.Bzip2
{
	public class CBZip2InputStream : Stream
	{
		private int last;

		private int origPtr;

		private int blockSize100k;

		private bool blockRandomised;

		private int bsBuff;

		private int bsLive;

		private CRC mCrc;

		private bool[] inUse;

		private int nInUse;

		private char[] seqToUnseq;

		private char[] unseqToSeq;

		private char[] selector;

		private char[] selectorMtf;

		private int[] tt;

		private char[] ll8;

		private int[] unzftab;

		private int[][] limit;

		private int[][] basev;

		private int[][] perm;

		private int[] minLens;

		private Stream bsStream;

		private bool streamEnd;

		private int currentChar;

		private const int START_BLOCK_STATE = 1;

		private const int RAND_PART_A_STATE = 2;

		private const int RAND_PART_B_STATE = 3;

		private const int RAND_PART_C_STATE = 4;

		private const int NO_RAND_PART_A_STATE = 5;

		private const int NO_RAND_PART_B_STATE = 6;

		private const int NO_RAND_PART_C_STATE = 7;

		private int currentState;

		private int storedBlockCRC;

		private int storedCombinedCRC;

		private int computedBlockCRC;

		private int computedCombinedCRC;

		private int i2;

		private int count;

		private int chPrev;

		private int ch2;

		private int i;

		private int tPos;

		private int rNToGo;

		private int rTPos;

		private int j2;

		private char z;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		private static void Cadvise()
		{
		}

		private static void CompressedStreamEOF()
		{
		}

		private void MakeMaps()
		{
		}

		public CBZip2InputStream(Stream zStream)
		{
		}

		internal static int[][] InitIntArray(int n1, int n2)
		{
			return null;
		}

		internal static char[][] InitCharArray(int n1, int n2)
		{
			return null;
		}

		public override int ReadByte()
		{
			return 0;
		}

		private void Initialize()
		{
		}

		private void InitBlock()
		{
		}

		private void EndBlock()
		{
		}

		private void Complete()
		{
		}

		private static void BlockOverrun()
		{
		}

		private static void BadBlockHeader()
		{
		}

		private static void CrcError()
		{
		}

		private void BsFinishedWithStream()
		{
		}

		private void BsSetStream(Stream f)
		{
		}

		private int BsR(int n)
		{
			return 0;
		}

		private char BsGetUChar()
		{
			return '\0';
		}

		private int BsGetint()
		{
			return 0;
		}

		private int BsGetIntVS(int numBits)
		{
			return 0;
		}

		private int BsGetInt32()
		{
			return 0;
		}

		private void HbCreateDecodeTables(int[] limit, int[] basev, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
		}

		private void RecvDecodingTables()
		{
		}

		private void GetAndMoveToFrontDecode()
		{
		}

		private void SetupBlock()
		{
		}

		private void SetupRandPartA()
		{
		}

		private void SetupNoRandPartA()
		{
		}

		private void SetupRandPartB()
		{
		}

		private void SetupRandPartC()
		{
		}

		private void SetupNoRandPartB()
		{
		}

		private void SetupNoRandPartC()
		{
		}

		private void SetDecompressStructureSizes(int newSize100k)
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
