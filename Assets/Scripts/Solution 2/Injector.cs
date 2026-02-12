using UnityEngine;

public class Injector : MonoBehaviour //used to properly create a character with stats
{
    //containers for injected information
    public CharacterStats stats;
    public int MaxHP;
    

    //intializes the character with the given stats
    public void InitializeCharacter(CharacterStats Stats, int MAXHP)
    {
        stats = Stats;
        MaxHP = MAXHP;
        gameObject.name = stats.Name;
    }

}
