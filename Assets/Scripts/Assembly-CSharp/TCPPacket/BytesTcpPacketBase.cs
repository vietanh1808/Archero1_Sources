using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TCPPacket
{
	public abstract class BytesTcpPacketBase : TcpPacketBase
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct Converter
		{
			[FieldOffset(0)]
			public byte byte_0;

			[FieldOffset(1)]
			public byte byte_1;

			[FieldOffset(2)]
			public byte byte_2;

			[FieldOffset(3)]
			public byte byte_3;

			[FieldOffset(4)]
			public byte byte_4;

			[FieldOffset(5)]
			public byte byte_5;

			[FieldOffset(6)]
			public byte byte_6;

			[FieldOffset(7)]
			public byte byte_7;

			[FieldOffset(0)]
			public uint uInt_Value;

			[FieldOffset(0)]
			public ushort uShort_Value;

			[FieldOffset(0)]
			public ulong ulong_Value;

			[FieldOffset(0)]
			public long long_Value;

			[FieldOffset(0)]
			public int Int_Value;

			[FieldOffset(0)]
			public bool Bool_Value;

			[FieldOffset(0)]
			public short Short_Value;
		}

		protected static Converter m_Converter;

		private static byte[] Write_CacheArray;

		private static int Write_Pos;

		private static byte[] Read_Array;

		private static int Read_Pos;

		protected static Dictionary<ushort, ushort> sizeDic;

		protected void WriteLong(long value)
		{
		}

		protected long ReadLong()
		{
			return 0L;
		}

		protected void WriteUShort(ushort value)
		{
		}

		protected ushort ReadUShort()
		{
			return 0;
		}

		protected void WriteShort(short value)
		{
		}

		protected short ReadShort()
		{
			return 0;
		}

		protected void WriteUInt(uint value)
		{
		}

		protected uint ReadUInt()
		{
			return 0u;
		}

		protected void WriteInt(int value)
		{
		}

		protected int ReadInt()
		{
			return 0;
		}

		protected string ReadString()
		{
			return null;
		}

		protected void WriteString(string str)
		{
		}

		protected ulong ReadULong()
		{
			return 0uL;
		}

		protected void WriteULong(ulong value)
		{
		}

		protected int[] ReadIntArray()
		{
			return null;
		}

		protected void WriteIntArray(int[] array)
		{
		}

		protected T[] ReadArray<T>() where T : BytesTcpPacketBase, new()
		{
			return null;
		}

		protected void WriteArray<T>(T[] array) where T : BytesTcpPacketBase, new()
		{
		}

		protected void WritePacket<T>(T p) where T : BytesTcpPacketBase, new()
		{
		}

		protected T ReadPacket<T>() where T : BytesTcpPacketBase, new()
		{
			return null;
		}

		protected void WriteBool(bool value)
		{
		}

		protected bool ReadBool()
		{
			return false;
		}

		public abstract void Read();

		public abstract void Write();

		public override byte[] ToByteArray()
		{
			return null;
		}

		public override void Serialize(byte[] array)
		{
		}
	}
}
