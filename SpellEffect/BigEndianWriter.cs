﻿using System;
using System.IO;
using System.Text;

namespace SpellEffect
{
    public class BigEndianWriter : IDisposable, IDataWriter
    {
        private BinaryWriter m_writer;
        public Stream BaseStream
        {
            get
            {
                return this.m_writer.BaseStream;
            }
        }
        public long BytesAvailable
        {
            get
            {
                return this.m_writer.BaseStream.Length - this.m_writer.BaseStream.Position;
            }
        }
        public long Position
        {
            get
            {
                return this.m_writer.BaseStream.Position;
            }
            set
            {
                this.m_writer.BaseStream.Position = value;
            }
        }
        public byte[] Data
        {
            get
            {
                long position = this.m_writer.BaseStream.Position;
                byte[] array = new byte[this.m_writer.BaseStream.Length];
                this.m_writer.BaseStream.Position = 0L;
                this.m_writer.BaseStream.Read(array, 0, (int)this.m_writer.BaseStream.Length);
                this.m_writer.BaseStream.Position = position;
                return array;
            }
        }

        public BigEndianWriter()
        {
            this.m_writer = new BinaryWriter(new MemoryStream(), Encoding.UTF8);
        }

        public BigEndianWriter(Stream stream)
        {
            this.m_writer = new BinaryWriter(stream, Encoding.UTF8);
        }

        private void WriteBigEndianBytes(byte[] endianBytes)
        {
            /*for (int i = endianBytes.Length - 1; i >= 0; i--)
            {
                this.m_writer.Write(endianBytes[i]);
            }*/
            for (int i = 0; i< endianBytes.Length; i++)
            {
                this.m_writer.Write(endianBytes[i]);
            }
        }

        private void WriteBigEndianReversBytes(byte[] endianBytes)
        {
            for (int i = endianBytes.Length - 1; i >= 0; i--)
            {
                this.m_writer.Write(endianBytes[i]);
            }
            /*for (int i = 0; i < endianBytes.Length; i++)
            {
                this.m_writer.Write(endianBytes[i]);
            }*/
        }

        public void WriteShort(short @short)
        {
            this.WriteBigEndianBytes(BitConverter.GetBytes(@short));
        }

        public void WriteInt(int @int)
        {
            this.WriteBigEndianBytes(BitConverter.GetBytes(@int));
        }

        public void WriteLong(long @long)
        {
            this.WriteBigEndianBytes(BitConverter.GetBytes(@long));
        }

        public void WriteUShort(ushort @ushort)
        {
            this.WriteBigEndianBytes(BitConverter.GetBytes(@ushort));
        }

        public void WriteReversUShort(ushort @ushort)
        {
            this.WriteBigEndianReversBytes(BitConverter.GetBytes(@ushort));
        }

        public void WriteUInt(uint @uint)
        {
            this.WriteBigEndianBytes(BitConverter.GetBytes(@uint));
        }

        public void WriteULong(ulong @ulong)
        {
            this.WriteBigEndianBytes(BitConverter.GetBytes(@ulong));
        }

        public void WriteByte(byte @byte)
        {
            this.m_writer.Write(@byte);
        }

        public void WriteSByte(sbyte @byte)
        {
            this.m_writer.Write(@byte);
        }

        public void WriteFloat(float @float)
        {
            this.m_writer.Write(@float);
        }

        public void WriteBoolean(bool @bool)
        {
            if (@bool)
            {
                this.m_writer.Write((byte)1);
            }
            else
            {
                this.m_writer.Write((byte)0);
            }
        }

        public void WriteChar(char @char)
        {
            this.WriteBigEndianBytes(BitConverter.GetBytes(@char));
        }

        public void WriteDouble(double @double)
        {
            this.WriteBigEndianBytes(BitConverter.GetBytes(@double));
        }

        public void WriteSingle(float single)
        {
            this.WriteBigEndianBytes(BitConverter.GetBytes(single));
        }

        public void WriteUTF(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            Byte num = (Byte)bytes.Length;
            //this.WriteReversUShort(num);
            this.WriteByte(num);
            for (int i = 0; i < (int)num; i++)
            {
                this.m_writer.Write(bytes[i]);
            }
        }

        public void WriteUTFBytes(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            int num = bytes.Length;
            for (int i = 0; i < num; i++)
            {
                this.m_writer.Write(bytes[i]);
            }
        }

        public void WriteBytes(byte[] data)
        {
            this.m_writer.Write(data);
        }

        public void Seek(int offset)
        {
            this.Seek(offset, SeekOrigin.Begin);
        }

        public void Seek(int offset, SeekOrigin seekOrigin)
        {
            this.m_writer.BaseStream.Seek((long)offset, seekOrigin);
        }

        public void Clear()
        {
            this.m_writer = new BinaryWriter(new MemoryStream(), Encoding.UTF8);
        }

        public void Dispose()
        {
            this.m_writer.Flush();
            this.m_writer.Dispose();
            this.m_writer = null;
        }
    }
    public interface IDataWriter
    {
        byte[] Data
        {
            get;
        }
        long Position
        {
            get;
        }

        void WriteShort(short @short);

        void WriteInt(int @int);

        void WriteLong(long @long);

        void WriteUShort(ushort @ushort);

        void WriteUInt(uint @uint);

        void WriteULong(ulong @ulong);

        void WriteByte(byte @byte);

        void WriteSByte(sbyte @byte);

        void WriteFloat(float @float);

        void WriteBoolean(bool @bool);

        void WriteChar(char @char);

        void WriteDouble(double @double);

        void WriteSingle(float single);

        void WriteUTF(string str);

        void WriteUTFBytes(string str);

        void WriteBytes(byte[] data);

        void Clear();

        void Seek(int offset);
    }

}