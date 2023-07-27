using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RadiantTools.SaveSystem
{
    public class Test : MonoBehaviour
    {
        [SerializeField] Text nameLabel;
        [SerializeField] Text ageLabel;

        // Start is called before the first frame update
        void Start()
        {
            Invoke(nameof(ChangeLabel), 3f);
        }
        void ChangeLabel()
        {
            nameLabel.text = SaveManager.GetSavedData().name;
            ageLabel.text = SaveManager.GetSavedData().age.ToString();
        }
        public void TestSave()
        {
            SaveManager.GetSavedData().name = nameLabel.text;
            SaveManager.GetSavedData().age = int.Parse(ageLabel.text);

            
        }
    }
}
