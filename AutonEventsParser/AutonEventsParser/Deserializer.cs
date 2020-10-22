using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonEventsParser
{
    public enum InputDataFormats
    {
        Hex,
        Decimal
    }

    public class Deserializer
    {
        private struct AObject
        {
            UInt16 ClassId;
        };

        private const UInt16 EVENT_START = 19007;

        public UInt32 GetByteArrayLength(String input, InputDataFormats inputDataFormat)
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

        public String FindEventClassId(String input, InputDataFormats inputDataFormat)
        {
            var length = GetByteArrayLength(input, inputDataFormat);
            if (length == 0)
                return "No hex data";

            int minSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(AObject));
            if (length < minSize)
            {
                return "At least 2 bytes required";
            }

            var bytes = StringToByteArray(input);
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
