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
        if (experiencePoints >= 100)
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        level++;

        movementSpeed += 0.25f;
        castingTime -= 0.5f;
        maxMana += 2;
        maxHealth += 10;
    }
}

