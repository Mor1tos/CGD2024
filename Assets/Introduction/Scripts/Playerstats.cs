using System;
using System.Dynamic;
using UnityEngine;

public class Playerstats
{
    public int maxHealth = 100;
    public int maxMana = 50;
    public float movementSpeed = 5.0f;
    public float castingTime = 1.5f;

    // Instanz des Spielerstatistikobjekts
    private static Playerstats instance;

    // Eigenschaft, um auf die Instanz zuzugreifen
public static Playerstats Instance
    {
        get
        {
            if (instance == null)
            {
                instance = CreateInstance<Playerstats>();
                instance.maxHealth = 100;
                instance.maxMana = 50;
                instance.movementSpeed = 5.0f;
                instance.castingTime = 1.5f;
            }
            return instance;
        }
    }
}