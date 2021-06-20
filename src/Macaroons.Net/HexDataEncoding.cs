using System;


namespace Macaroons
{
  /// <summary>
  /// Represents an encoding for converting to and from hexadecimal strings.
  /// </summary>
  public class HexDataEncoding : DataEncoding
  {
    public override string GetString(byte[] d)
    {
      return BitConverter.ToString(d).Replace("-","");
    }


    public override byte[] GetBytes(string s)
    {
      throw new NotImplementedException();
    }
  }
}
