// Sky Morey : BclContrib-ScriptSharp
using System;
using System.Runtime.CompilerServices;
namespace System.TypedArrays
{
    [IgnoreNamespace, Imported]
    public class DataView : ArrayBufferView
    {
        protected DataView() { }

        public byte GetUInt8(int byteOffset) { return 0; }
        [CLSCompliantAttribute(false)]
        public sbyte GetInt8(int byteOffset) { return 0; }
        public short GetInt16(int byteOffset, bool littleEndian) { return 0; }
        [CLSCompliantAttribute(false)]
        public ushort GetUInt16(int byteOffset, bool littleEndian) { return 0; }
        public int GetInt32(int byteOffset, bool littleEndian) { return 0; }
        [CLSCompliantAttribute(false)]
        public uint GetUInt32(int byteOffset, bool littleEndian) { return 0; }
        public float GetFloat(int byteOffset, bool littleEndian) { return 0F; }
        public double GetDouble(int byteOffset, bool littleEndian) { return 0F; }

        public void SetUint8(int byteOffset, byte value, bool littleEndian) { }
        [CLSCompliantAttribute(false)]
        public void SetInt8(int byteOffset, sbyte value, bool littleEndian) { }
        public void SetInt16(int byteOffset, short value, bool littleEndian) { }
        [CLSCompliantAttribute(false)]
        public void SetUint16(int byteOffset, ushort value, bool littleEndian) { }
        public void SetInt32(int byteOffset, int value, bool littleEndian) { }
        [CLSCompliantAttribute(false)]
        public void SetUint32(int byteOffset, uint value, bool littleEndian) { }
        public void SetFloat(int byteOffset, float value, bool littleEndian) { }
        public void SetDouble(int byteOffset, double value, bool littleEndian) { }
    }
}
