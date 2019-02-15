using System.Text.RegularExpressions;
using System.Globalization;

public class Solution {
    public string ValidIPAddress(string IP) {
        string[] ip = IP.Split('.');
        if (ip.Length == 4)
        {
             for (int i = 0; i < 4; i++)
                {
                    byte num;
                    bool success = byte.TryParse(ip[i], out num);
                    int len = ip[i].Length;
                    if (!success || (len > 1 && ip[i][0] == '0') || !ip[i].All(char.IsDigit))
                        return "Neither";
                }   
                return "IPv4";
        }
        else
        {
            ip = IP.Split(':');

                if (ip.Length == 8)
                {
                    
                    Regex regex = new Regex("^[0-9A-Fa-f]+$");
                    for (int i = 0; i < 8; i++)
                    {
                        uint number;
                        bool result = UInt32.TryParse(ip[i], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out number);
                        int len = ip[i].Length;
                        if (len < 0 || len > 4 || !result)
                            return "Neither";
                    }
                    return "IPv6";
                }
        }
        return "Neither";
    }
}
