using UnityEngine;

public class CharacterInstantiator : MonoBehaviour
{
    //Inspector, drag and drop the prefab and the stats struct
    public GameObject characterBase;
    public CharacterStats stats;
    
    private void CreateCharacter()
    {
        int HP = HPCalculator.Calculator(
            stats.averaged,
            stats.stout,
            stats.tough,
            stats.Class,
            stats.race,
            stats.level,
            stats.constitution
        ); //because of the way I had set up my HPCalculator intitally, i called each of these individually

        GameObject NewCharacter = Instantiate(characterBase,Vector3.zero,Quaternion.identity); //create the actual game object at 0.0
        Injector PrefabScript = NewCharacter.GetComponent<Injector>(); //grab the prefab script from the new object to adjust
        PrefabScript.InitializeCharacter(stats,HP); //call the character script using all of the inputted stats
    }

    void Start()
    {
        CreateCharacter();
    }



}
