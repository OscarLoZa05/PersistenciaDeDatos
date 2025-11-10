using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    //public static PlayerData Instance;
    public string playerName;
    public Vector3 playerPosition;
    public int playerMaxHealth;
    public int playerMaxMana;
    public int playerExp;

    /*void Awake()
    {
        //Patron de diseño: Singelton
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }*/

    public void SaveData()
    {
        /*UserData.playerName = playerName;
        UserData.playerMaxHealth = playerMaxHealth;
        UserData.playerMaxMana = playerMaxMana;
        UserData.playerExp = playerExp;

        UserData.playerPosition = playerPosition;
        Debug.Log("Data Saved");*/

        Stats.userStats.playerName = playerName;
        Stats.userStats.playerPosition = playerPosition;
        Stats.userStats.playerMaxHealth = playerMaxHealth;
        Stats.userStats.playerExp = playerExp;

        SavingDataSystem.Save();
    }

    public void LoadData()
    {
        /*playerName = UserData.playerName;
        playerMaxHealth = UserData.playerMaxHealth;
        playerMaxMana = UserData.playerMaxMana;
        playerExp = UserData.playerExp;

        playerPosition = UserData.playerPosition;
        Debug.Log("Data Loaded");*/

        SavingDataSystem.Load();

        playerName = Stats.userStats.playerName;
        playerPosition = Stats.userStats.playerPosition;
        playerMaxHealth = Stats.userStats.playerMaxHealth;
        playerExp = Stats.userStats.playerExp;

        
    }

    public void SavePrefs()
    {
        PlayerPrefs.SetString("Player Name", playerName);
        PlayerPrefs.SetInt("Player Health", playerMaxHealth);
        PlayerPrefs.SetInt("Player Mana", playerMaxMana);
        PlayerPrefs.SetInt("Player Exp", playerExp);

        PlayerPrefs.SetFloat("Player PositionX", playerPosition.x);
        PlayerPrefs.SetFloat("Player PositionY", playerPosition.y);
        PlayerPrefs.SetFloat("Player PositionZ", playerPosition.z);
    }
    
    public void LoadPrefs()
    {
        playerName = PlayerPrefs.GetString("Player Name", "No name");
        playerMaxHealth = PlayerPrefs.GetInt("Player Health", 1);
        playerMaxMana = PlayerPrefs.GetInt("Player Mana", 1);
        playerExp = PlayerPrefs.GetInt("Player Exp", 1);

        /*playerPosition.x = PlayerPrefs.GetFloat("Player PositionX", 1);
        playerPosition.y = PlayerPrefs.GetFloat("Player PositionY", 1);
        playerPosition.z = PlayerPrefs.GetFloat("Player PositionZ", 1);*/

        playerPosition = new Vector3(PlayerPrefs.GetFloat("Player PositionX", 1), PlayerPrefs.GetFloat("Player PositionY", 1), PlayerPrefs.GetFloat("Player PositionZ", 1));
    }
}