public class XRandom
{
	private long seed;

	private const long multiplier = 25214903917L;

	private const long addend = 11L;

	private const long mask = 281474976710655L;

	private const double DOUBLE_UNIT = 1.1102230246251565E-16;

	private const string BadBound = "bound must be positive";

	private static long _seedUniquifier;

	private double nextNextGaussian;

	private bool haveNextNextGaussian;

	public static long nanoTime()
	{
		return 0L;
	}

	public XRandom()
	{
	}

	private static long seedUniquifier()
	{
		return 0L;
	}

	public XRandom(long seed)
	{
	}

	private static long initialScramble(long seed)
	{
		return 0L;
	}

	public void setSeed(long seed)
	{
	}

	protected int next(int bits)
	{
		return 0;
	}

	public void nextBytes(byte[] bytes)
	{
	}

	public int nextInt()
	{
		return 0;
	}

	public int nextInt(int bound)
	{
		return 0;
	}

	public int nextInt(int min, int max)
	{
		return 0;
	}

	public long nextLong()
	{
		return 0L;
	}

	public bool nextBoolean()
	{
		return false;
	}

	public float nextFloat()
	{
		return 0f;
	}

	public double nextDouble()
	{
		return 0.0;
	}

	public double nextGaussian()
	{
		return 0.0;
	}

	public static long move_fill_0(long value, int bits)
	{
		return 0L;
	}
}
