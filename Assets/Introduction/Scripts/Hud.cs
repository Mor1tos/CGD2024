using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hud : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text healthText;
    public TMP_Text manaText;
    public TMP_Text levelText;
    public TMP_Text xpText;
    public static int score = 0;

    // Update is called once per frame
    void Update()
    {
        Wizard player = Wizard.Instance;
        int health = player.health;
        float mana = player.mana;
        Playerstats playerstats = player.stats;

        int level = playerstats.level;
        int xp = playerstats.experiencePoints;
        float maxHealth = playerstats.maxHealth;
        float maxMana = playerstats.maxMana;

        // Aktualisiere die Anzeige
        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + health + "/" + maxHealth;
        manaText.text = "Mana: " + mana.ToString("F0") + "/" + maxMana; // Auf 0 Dezimalstellen gerundet
        levelText.text = "Level: " + level;
        xpText.text = "XP: " + xp;
    }
}
