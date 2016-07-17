﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILRuntime.Runtime.Enviorment
{
    static class CLRRedirections
    {
        public unsafe static object InitializeArray(object instance, object[] param)
        {
            object array = param[0];
            byte[] data = param[1] as byte[];
            if (data == null)
                return null;
            fixed (byte* p = data)
            {
                if (array is int[])
                {
                    int[] arr = array as int[];
                    int* ptr = (int*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is byte[])
                {
                    byte[] arr = array as byte[];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = p[i];
                    }
                }
                else if (array is sbyte[])
                {
                    sbyte[] arr = array as sbyte[];
                    sbyte* ptr = (sbyte*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is short[])
                {
                    short[] arr = array as short[];
                    short* ptr = (short*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is ushort[])
                {
                    ushort[] arr = array as ushort[];
                    ushort* ptr = (ushort*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is char[])
                {
                    char[] arr = array as char[];
                    char* ptr = (char*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is uint[])
                {
                    uint[] arr = array as uint[];
                    uint* ptr = (uint*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is Int64[])
                {
                    long[] arr = array as long[];
                    long* ptr = (long*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is UInt64[])
                {
                    ulong[] arr = array as ulong[];
                    ulong* ptr = (ulong*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is float[])
                {
                    float[] arr = array as float[];
                    float* ptr = (float*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is double[])
                {
                    double[] arr = array as double[];
                    double* ptr = (double*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else if (array is bool[])
                {
                    bool[] arr = array as bool[];
                    bool* ptr = (bool*)p;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ptr[i];
                    }
                }
                else
                {
                    throw new NotImplementedException("array=" + array.GetType());
                }
            }

            return null;
        }
    }
}
