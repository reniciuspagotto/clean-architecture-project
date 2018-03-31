using System.Security.Cryptography;
using System.Text;

namespace ArquiteturaPadrao.Shared.Helper
{
    public static class HashHelper
    {
        public static string EncryptPassword(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var password = (value += "|d11d62e9-0a43-47c5-9ba5-41ae1b7c7adb");
                var data = MD5.Create().ComputeHash(Encoding.Default.GetBytes(password));
                var sbString = new StringBuilder();

                foreach (var t in data)
                    sbString.Append(t.ToString("x2"));

                return sbString.ToString();
            }

            return "";
        }
    }
}
