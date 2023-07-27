using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RadiantTools.SaveSystem
{
    public static class FileSaver
    {
        public static void SaveData(SaveInfo saveInfo)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(GetPath(), FileMode.Create);

            formatter.Serialize(fileStream,saveInfo);
            fileStream.Close();
        }
        public static SaveInfo LoadData()
        {
            FileStream fileStream;
            if (!File.Exists(GetPath()))
            {
                Debug.LogWarning("No File Found");
                fileStream = new FileStream(GetPath(), FileMode.Create);
                //All the Default Values
                return SaveManager.GetDefaultData();
            }

            BinaryFormatter formatter = new BinaryFormatter();
            fileStream = new FileStream(GetPath(), FileMode.Open);

            SaveInfo saveInfo = formatter.Deserialize(fileStream) as SaveInfo;
            fileStream.Close();

            return saveInfo;
        }
        public static string GetPath()
        {
            return Application.dataPath + "/GameSaveData.txt";
        }
    }
}
