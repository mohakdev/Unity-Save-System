using UnityEngine;

namespace RadiantTools.SaveSystem
{
    public class SaveManager : MonoBehaviour
    {
        public static SaveInfo saveInfo;

        //Loads all Data before the game starts
        void Awake()
        {
            saveInfo = FileSaver.LoadData();
            DontDestroyOnLoad(gameObject);
        }

        public static SaveInfo GetSavedData()
        {
            return saveInfo;
        }
        //Returns all the Default Values
        public static SaveInfo GetDefaultData()
        {
            SaveInfo defaultSaveInfo = new SaveInfo("",0);
            return defaultSaveInfo;
        } 

        //Saves all Data before the game exits
        void OnApplicationQuit()
        {
            FileSaver.SaveData(saveInfo);    
        }
    }
}
