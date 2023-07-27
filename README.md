# Unity Save System

##  Features
 - Easy to use
 - Simple
 - Hassle free Installation
 - Secured as it uses Binary files to save rather than a easily modifiable file type like Json.

##  Installation
1. Open your terminal
2. Write command `cd 'Directory to wanna open'`
3. Type `git clone https://github.com/mohakdev/Unity-Save-System.git` 
4. Great Now open unity.
5. Drag the Save Manager prefab to Inspector
![Drag the prefab to Inspector](https://i.imgur.com/7iX06f7.gif)
6. Now open the scripts folder and simply open SaveInfo script.
7. Declare all the fields you want to be able to save and load.
8. Also remove these fields from the constructor and add your own custom fields in the constructor.
![Add custom fields](https://i.imgur.com/JDg8tfR.png)
9. Go to `GetDefaultData()` in the SaveManager script.
![Set Default values](https://i.imgur.com/9n7swXs.png) 
11. Set the default values to load if no save file is ever found or the player plays the game for the first time.
  
That's it now lets move on to how to use this save system.
##  How to use
### Load Data
To load any field simply call
`SaveManager.GetSavedData().fieldName`
### Save Data
To Save any field simply call
`SaveManager.GetSavedData().fieldName = whatever you want`
**Pro Tip: To edit all the fields together you can  do**
```cs
SaveInfo newData = new SaveInfo("Elon Musk",52);
SaveManager.saveInfo = newData;
``` 
