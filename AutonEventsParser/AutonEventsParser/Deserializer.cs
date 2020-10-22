using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private int AOBJECT_SIZE = System.Runtime.InteropServices.Marshal.SizeOf(typeof(AObject));

        private const UInt16 EVENT_START = 19007;

        //3f4ae725c34c

        public UInt32 GetByteArrayLength(String input, InputDataFormats inputDataFormat)
        {
            try
            {
                var bytes = StringToByteArray(input, inputDataFormat);
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

            
            if (length < AOBJECT_SIZE)
            {
                return "At least 2 bytes required";
            }

            var bytes = StringToByteArray(input, inputDataFormat);
            return "";
        }

        public UInt16 GetClassId(String input, InputDataFormats inputDataFormat)
        {
            if (GetByteArrayLength(input, inputDataFormat) < AOBJECT_SIZE)
                return 0;

            var bytes = StringToByteArray(input, inputDataFormat);
            return 0;
        }

        public byte[] StringToByteArray(String hex, InputDataFormats inputDataFormat)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];

            int fromBase = inputDataFormat == InputDataFormats.Hex ?
                16 : 10;
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), fromBase);
            return bytes;
        }
    }
}
