using System;
using System.IO;

class BinaryExperiment
{
    const string BinaryFile = "C:\\Users\\home\\Desktop\\BinaryFile.bin";

    static void Main()
    {
        // Пишем
        WriteValues();
        // Считываем
        ReadValues();
    }

    static void ReadValues()
    {
        string StringValue;

        if (File.Exists(BinaryFile))
        {
            // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
            using (BinaryReader reader = new BinaryReader(File.Open(BinaryFile, FileMode.Open)))
            {
                // Применяем специализированные методы Read для считывания соответствующего типа данных.
                StringValue = reader.ReadString();
            }

            Console.WriteLine("Из файла считано:");

            Console.WriteLine("Строка: " + StringValue);
        }
    }

    static void WriteValues()
    {
        // Создаем объект BinaryWriter и указываем, куда будет направлен поток данных
        using (BinaryWriter writer = new BinaryWriter(File.Open(BinaryFile, FileMode.Open)))
        {
            // записываем данные в разном формате
            writer.Write("Файл изменен 02.11 14:53 на компьютере Windows 11");
        }
    }
}
