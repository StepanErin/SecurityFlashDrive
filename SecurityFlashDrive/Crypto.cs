using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFlashDrive
{
    internal class Crypto
    {
        public static byte[] ToAes256_Byte(byte[] input, string aeskey)
        {
            string data = "";
            foreach (var item in input) data += Convert.ToChar((int)item);
            return ToAes256(data, aeskey);
        }
        public static byte[] FromAes256_Byte(byte[] input, string aeskey)
        {
            var encryptedData = FromAes256(input, aeskey);
            List<byte> data = new List<byte>();
            foreach (var item in encryptedData) data.Add(Convert.ToByte((int)item));
            return data.ToArray();
        }
        /*
        public static string TTT_IN(byte[] input)
        {
            string data = "";
            foreach (var item in input)
                //MessageBox.Show().ToString());// item.ToString());
                data += Convert.ToChar((int)item);
            return data;
        }
        public static byte[] TTT_OUT(string input)
        {
            List<byte> data = new List<byte>();
            foreach (var item in input)
                //MessageBox.Show().ToString());// item.ToString());
                data.Add(Convert.ToByte((int)item));
            return data.ToArray();
        }
        */
        /// <summary>
        /// Шифрует исходное сообщение AES ключом (добавляет соль)
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static byte[] ToAes256(string src, string aeskey)
        {
            //Объявляем объект класса AES
            Aes aes = Aes.Create();
            //Генерируем соль
            aes.GenerateIV();
            //Присваиваем ключ. aeskey - переменная (массив байт), сгенерированная методом GenerateKey() класса AES
            aes.Key = ComputeSHA256(aeskey);
            byte[] encrypted;
            ICryptoTransform crypt = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(src);
                    }
                }
                //Записываем в переменную encrypted зашиврованный поток байтов
                encrypted = ms.ToArray();
            }
            //Возвращаем поток байт + крепим соль
            return encrypted.Concat(aes.IV).ToArray();
        }
        /// <summary>
        /// Расшифровывает криптованного сообщения
        /// </summary>
        /// <param name="shifr">Шифротекст в байтах</param>
        /// <returns>Возвращает исходную строку</returns>
        public static string FromAes256(byte[] shifr, string aeskey)
        {
            byte[] bytesIv = new byte[16];
            byte[] mess = new byte[shifr.Length - 16];
            //Списываем соль
            for (int i = shifr.Length - 16, j = 0; i < shifr.Length; i++, j++)
                bytesIv[j] = shifr[i];
            //Списываем оставшуюся часть сообщения
            for (int i = 0; i < shifr.Length - 16; i++)
                mess[i] = shifr[i];
            //Объект класса Aes
            Aes aes = Aes.Create();
            //Задаем тот же ключ, что и для шифрования
            aes.Key = ComputeSHA256(aeskey);
            //Задаем соль
            aes.IV = bytesIv;
            //Строковая переменная для результата
            string text = "";
            byte[] data = mess;
            ICryptoTransform crypt = aes.CreateDecryptor(aes.Key, aes.IV);
            try
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            //Результат записываем в переменную text в вие исходной строки
                            text = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("ERROR"); }
            return text;
        }
        static byte[] ComputeSHA256(string s)
        {
            // Инициализировать хеш-объект SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Вычислить хэш заданной строки
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

            }
        }
    }
}
