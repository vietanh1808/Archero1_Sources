using System.IO;

namespace Org.BouncyCastle.Apache.Bzip2
{
	public class CBZip2OutputStream : Stream
	{
		internal class StackElem
		{
			internal int ll;

			internal int hh;

			internal int dd;
		}

		protected const int SETMASK = 2097152;

		protected const int CLEARMASK = -2097153;

		protected const int GREATER_ICOST = 15;

		protected const int LESSER_ICOST = 0;

		protected const int SMALL_THRESH = 20;

		protected const int DEPTH_THRESH = 10;

		protected const int QSORT_STACK_SIZE = 1000;

		private bool finished;

		private int last;

		private int origPtr;

		private int blockSize100k;

		private bool blockRandomised;

		private int bytesOut;

		private int bsBuff;

		private int bsLive;

		private CRC mCrc;

		private bool[] inUse;

		private int nInUse;

		private char[] seqToUnseq;

		private char[] unseqToSeq;

		private char[] selector;

		private char[] selectorMtf;

		private char[] block;

		private int[] quadrant;

		private int[] zptr;

		private short[] szptr;

		private int[] ftab;

		private int nMTF;

		private int[] mtfFreq;

		private int workFactor;

		private int workDone;

		private int workLimit;

		private bool firstAttempt;

		private int nBlocksRandomised;

		private int currentChar;

		private int runLength;

		private bool closed;

		private int blockCRC;

		private int combinedCRC;

		private int allowableBlockSize;

		private Stream bsStream;

		private int[] incs;

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

		private static void Panic()
		{
		}

		private void MakeMaps()
		{
		}

		protected static void HbMakeCodeLengths(char[] len, int[] freq, int alphaSize, int maxLen)
		{
		}

		public CBZip2OutputStream(Stream inStream)
		{
		}

		public CBZip2OutputStream(Stream inStream, int inBlockSize)
		{
		}

		public override void WriteByte(byte bv)
		{
		}

		private void WriteRun()
		{
		}

		public override void Close()
		{
		}

		public void Finish()
		{
		}

		public override void Flush()
		{
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

		private void EndCompression()
		{
		}

		private void HbAssignCodes(int[] code, char[] length, int minLen, int maxLen, int alphaSize)
		{
		}

		private void BsSetStream(Stream f)
		{
		}

		private void BsFinishedWithStream()
		{
		}

		private void BsW(int n, int v)
		{
		}

		private void BsPutUChar(int c)
		{
		}

		private void BsPutint(int u)
		{
		}

		private void BsPutIntVS(int numBits, int c)
		{
		}

		private void SendMTFValues()
		{
		}

		private void MoveToFrontCodeAndSend()
		{
		}

		private void SimpleSort(int lo, int hi, int d)
		{
		}

		private void Vswap(int p1, int p2, int n)
		{
		}

		private char Med3(char a, char b, char c)
		{
			return '\0';
		}

		private void QSort3(int loSt, int hiSt, int dSt)
		{
		}

		private void MainSort()
		{
		}

		private void RandomiseBlock()
		{
		}

		private void DoReversibleTransformation()
		{
		}

		private bool FullGtU(int i1, int i2)
		{
			return false;
		}

		private void AllocateCompressStructures()
		{
		}

		private void GenerateMTFValues()
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
