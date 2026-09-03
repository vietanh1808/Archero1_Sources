using System;

namespace Org.BouncyCastle.Utilities
{
	public abstract class Integers
	{
		public static int RotateLeft(int i, int distance)
		{
			return 0;
		}

		[CLSCompliant(false)]
		public static uint RotateLeft(uint i, int distance)
		{
			return 0u;
		}

		public static int RotateRight(int i, int distance)
		{
			return 0;
		}

		[CLSCompliant(false)]
		public static uint RotateRight(uint i, int distance)
		{
			return 0u;
		}
	}
}
