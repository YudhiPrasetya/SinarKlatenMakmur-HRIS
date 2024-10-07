using System.Security.Cryptography;
using System.Text;

namespace SKM.Shared.Helpers {
	public static class EncryptDecryptString {

		// This method can not be used in blazor webassembly
		public static string EncryptString(string key, string plainText) {
			byte[] iv = new byte[16];
			byte[] array;

			using(Aes aes = Aes.Create()) {
				aes.Key = Encoding.UTF8.GetBytes(key);
				aes.IV = iv;

				ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
				using MemoryStream ms = new();
				using CryptoStream cryptoStream = new((Stream)ms, encryptor, CryptoStreamMode.Write);
				using (StreamWriter streamWriter = new((Stream)cryptoStream)) {
					streamWriter.Write(plainText);
				}
				array = ms.ToArray();
			}
			return Convert.ToBase64String(array);
		}

		// This method can not be used in blazor webassembly
		public static string DecryptString(string key, string chiperText) {
			byte[] iv = new byte[16];
			byte[] buffer = Convert.FromBase64String(chiperText);

			using(Aes aes = Aes.Create()) {
				aes.Key = Encoding.UTF8.GetBytes(key);
				aes.IV = iv;
				ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
				using MemoryStream ms = new(buffer);
				using CryptoStream cryptoStream = new((Stream)ms, decryptor, CryptoStreamMode.Read);
				using StreamReader streamReader = new((Stream)cryptoStream);
				return streamReader.ReadToEnd();
			}
		}

		public static string EncryptSHA256Hash(string? plainText) {
			using(SHA256 sha256 = SHA256.Create()) {
				byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));

				StringBuilder builder = new();
				for(int x = 0; x < bytes.Length; x++) {
					builder.Append(bytes[x].ToString("x2"));
				}
				return builder.ToString();
			}
		}
	}
}
