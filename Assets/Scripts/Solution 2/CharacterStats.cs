using UnityEngine;

//used to make scripts easier to handle
[System.Serializable]
public struct CharacterStats
    {
        //Inspector
        [Header("Your Character, Use all caps for race and class!")]
        public int constitution;//use
        public int level;//use
        public string race;//key
        public string Name;//for printing, class reserved
        public string Class; //key, class reserved

        [Header("Feats")] //use in final calculations
        public bool stout;
        public bool tough;

        [Header("Health")] //use to determine final calculation method
        public bool averaged;
        public bool rolled;
    }
