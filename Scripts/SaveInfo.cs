namespace RadiantTools.SaveSystem
{
    [System.Serializable]
    public class SaveInfo
    {
        public string name;
        public int age;

        public SaveInfo(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
