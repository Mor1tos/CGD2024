public class Playerstats
{
    public float maxHealth = 100;
    public float maxMana = 50;
    public float movementSpeed = 5.0f;
    public float castingTime = 1.5f;
    public float manaRegeneration = 2;

    public int experiencePoints = 0;
    public int level = 1;

    public void GetXp(int xpAmount)
    {
        experiencePoints += xpAmount;
        if (experiencePoints >= 100) // Beispiel: Bei 100 XP erhöht sich das Level
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        level++;
        // Hier könntest du die Attribute verbessern oder Skillpunkte vergeben
        // Zum Beispiel: castingTime -= 0.1f; // Casting-Zeit wird um 0.1 Sekunde reduziert
    }
}
