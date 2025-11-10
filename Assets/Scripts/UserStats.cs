using UnityEngine;

public class UserStats
{
    public string playerName;
    public int playerMaxHealth;
    public int playerMaxMana;
    public int playerExp;
    public Vector3 playerPosition;
}

public static class Stats
{
    public static UserStats userStats = new UserStats();
}