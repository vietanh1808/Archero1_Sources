using System;
using System.IO;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public abstract class LocalBean
	{
		private short messageLength;

		private int position;

		private static readonly long t19700101;

		private static readonly int time_factor;

		private static readonly Encoding encoding;

		private FileStream file;

		private byte[] raws;

		private byte[] datas_short;

		private byte[] datas_int;

		private int datas_int_i;

		private byte[] datas_long;

		private byte[] datas_float;

		private int datas_float_i;

		private float datas_float_f;

		private short count_obscured_arraystring;

		private short count_obscured_arraybool;

		private short coun_obscured_arrayfloat;

		private short count_arraystring;

		private short count_arraybool;

		private short count_arrayfloat;

		public LocalBean()
		{
		}

		public int readFromBytes(byte[] raws, int startPos)
		{
			return 0;
		}

		public int getLength()
		{
			return 0;
		}

		protected void readBytes(byte[] datas, int buffLength)
		{
		}

		protected short readShort()
		{
			return 0;
		}

		protected bool readBool()
		{
			return false;
		}

		protected int readInt()
		{
			return 0;
		}

		protected long readLong()
		{
			return 0L;
		}

		protected DateTime readDate()
		{
			return default;
		}

		protected float readFloat()
		{
			return 0f;
		}

		protected double readDouble()
		{
			return 0.0;
		}

		protected ObscuredInt[] readObscuredArrayint()
		{
			return null;
		}

		protected ObscuredString[] readObscuredArraystring()
		{
			return null;
		}

		protected ObscuredDouble[] readObscuredArraydouble()
		{
			return null;
		}

		protected ObscuredBool[] readObscuredArraybool()
		{
			return null;
		}

		protected ObscuredFloat[] readObscuredArrayfloat()
		{
			return null;
		}

		protected ObscuredShort[] readObscuredArrayshort()
		{
			return null;
		}

		protected ObscuredLong[] readObscuredArraylong()
		{
			return null;
		}

		protected int[] readArrayint()
		{
			return null;
		}

		protected string[] readArraystring()
		{
			return null;
		}

		protected double[] readArraydouble()
		{
			return null;
		}

		protected bool[] readArraybool()
		{
			return null;
		}

		protected float[] readArrayfloat()
		{
			return null;
		}

		protected short[] readArrayshort()
		{
			return null;
		}

		protected long[] readArraylong()
		{
			return null;
		}

		protected string readLocalString()
		{
			return null;
		}

		protected string readCommonString()
		{
			return null;
		}

		protected string toCommonString(string key)
		{
			return null;
		}

		protected abstract bool ReadImpl();
	}
}
