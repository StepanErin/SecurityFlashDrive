using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFlashDrive
{
    static public class Serialization
    {
        /// <summary>
        /// Начать сериализацию
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="Object_output">Объект</param>
        static public (bool, byte[]) StartSerialize<T>(T Object_output)
        {
            try
            {
                //Объект для конвертации
                BinaryFormatter formatter = new BinaryFormatter();

                //байтовое представление объекта
                byte[] result = null;

                //Открытие потока для информации
                using (MemoryStream ms = new MemoryStream())
                {
                    formatter.Serialize(ms, Object_output);//Сереализация
                    result = ms.ToArray();//перевод в массив
                }

                return (true, result);
            }
            catch (Exception e)
            {
                return (false, null);
            }

        }
        /// <summary>
        /// Начать дисереализацию
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="inputData">Строка данных для дисереализации</param>
        /// <param name="Object_input">Объект</param>
        static public (bool, T) StartDeserialize<T>(byte[] inputData) where T : new()
        {
            try
            {
                //Объект для конвертации
                BinaryFormatter formatter = new BinaryFormatter();

                T object_input;
                //Открытие потока для информации
                using (MemoryStream ms = new MemoryStream(inputData))
                {
                    object_input = (T)formatter.Deserialize(ms);//Дисереализация
                }
                return (true, object_input);
            }
            catch (Exception e)
            {
                T www = new T();
                return (false, www);
            }
        }
    }
}