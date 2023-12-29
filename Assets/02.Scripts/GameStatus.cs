using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStatus
{
    public static int currentCombo
    {
        get => _currentCombo;
        set
        {
            maxCombo = maxCombo > value ? maxCombo : value;
            _currentCombo = value;
        }
    }
    public static int maxCombo { get; set; }
    public static int score { get; set; }

    public static int perfectCount;
    public static int greatCount;
    public static int goodCount;
    public static int missCount;
    public static int badCount;
    private static int _currentCombo;

    public static void IncreasePerfectCount()
    {
        perfectCount++;
        currentCombo++;
        score += PlaySettings.SCORE_PERFECT;
    }
    public static void IncreaseGreatCount()
    {
        greatCount++;
        currentCombo++;
        score += PlaySettings.SCORE_GREAT;
    }
    public static void IncreaseGoodCount()
    {
        goodCount++;
        currentCombo++;
        score += PlaySettings.SCORE_GOOD;
    }
    public static void IncreaseMissCount()
    {
        missCount++;
        currentCombo = 0;
    }
    public static void IncreaseBadCount()
    {
        badCount++;
        currentCombo = 0;
    }
}

    
