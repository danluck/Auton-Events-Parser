﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonEventsParser
{
    public class Deserializer
    {
        public UInt32 GetByteArrayLength(String input)
        {
            try
            {
                var bytes = StringToByteArray(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception = '{e}'");
                return 0;
            }
            UInt32 length = (uint)(input.Length / 2);
            return length;
        }

        public String FindEventClassId(String input)
        {
            if (GetByteArrayLength(input) == 0)
                return "No hex data";

            return "";
        }

        public byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}
