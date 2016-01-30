using System;

class IntegerNumbers
{
    static void Main()
    {
        sbyte signedByte = -100;
        byte unsignedByte = 128;
        short signedShort = -3540;
        ushort unsignedShort = 64876;
        uint unsignedInteger = 2147483648;
        int signedInteger = -1141583228;
        long signedLong = -1223372036854775808;

        Console.WriteLine("Signed Byte: {0}\nUnsigned Byte: {1}\nSigned Short: {2}\nUnsigned Short: {3}\nUnsigned Integer: {4}\nSigned Integer: {5}\nSigned Long: {6}", 
            signedByte, unsignedByte, signedShort, unsignedShort, unsignedInteger, signedInteger, signedLong);
    }
}
