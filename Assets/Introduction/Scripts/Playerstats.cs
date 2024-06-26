using UnityEngine;

public class Playerstats : MonoBehaviour
{
    public static Playerstats Instance;

    public float movementSpeed = 2;
    public float maxMana = 50;
    public float maxHealth = 100;
    public float castingTime = 1.5f;
    public float manaRegeneration = 2;

    public int level = 1;
    public float xp = 0;
    public int skillPoints = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GetXp(float newXp)
    {
        xp += newXp;

        if (xp >= level * 2f)
        {
            xp -= level * 2f;
            LevelUp();
        }
    }

    public void LevelUp()
    {
        level++;
        /*skillPoints++;
        AssignSkillPoint();*/

        movementSpeed += 0.25f;
        maxHealth += 10;
        maxMana += 5;
        castingTime -= 0.1f;
        manaRegeneration += 0.1f;
    }

    public void AssignSkillPoint()
    {
        switch ((int)(Random.value * 3))
        {
            case 0:
                skillPoints--;
                movementSpeed += 0.25f;
                break;
            case 1:
                skillPoints--;
                castingTime -= 0.1f;
                break;
            case 2:
                skillPoints--;
                maxMana += 5;
                break;
        }
    }

    // Method to reset player stats
    public void ResetStats()
    {
        movementSpeed = 2;
        maxMana = 50;
        maxHealth = 100;
        castingTime = 1.5f;
        manaRegeneration = 2;

        level = 1;
        xp = 0;
        skillPoints = 0;
    }
}
