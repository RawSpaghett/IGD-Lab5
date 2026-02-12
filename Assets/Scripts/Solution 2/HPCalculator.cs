using UnityEngine;
using System.Collections.Generic;
using UnityEditor; //for the editor quit application logic

//changed this to a static so it can be called without being attatched to anything
public static class HPCalculator 
{
    
    //dictionary of dictionaries
    private static readonly Dictionary <string,Dictionary<string,int>> Data = new Dictionary < string,Dictionary<string,int>> //changed to static
    {
        {
            "Races", new Dictionary<string,int>
                {
                    {"DRAGONBORN", 0},
                    {"DWARF",      2},
                    {"ELF",        0},
                    {"GNOME",      0},
                    {"GOLIATH",    1},
                    {"HALFLING",   0},
                    {"HUMAN",      0},
                    {"ORC",        1},
                    {"TIEFLING",   0}
                }
        },
        {
            "Classes", new Dictionary<string,int>
                {
                    {"ARTIFICER",  8},
                    {"BARBARIAN", 12},
                    {"BARD",       8},
                    {"CLERIC",     8},
                    {"DRUID",      8},
                    {"FIGHTER",   10},
                    {"MONK",       8},
                    {"RANGER",    10},
                    {"ROGUE",      8},
                    {"PALADIN",   10},
                    {"SORCERER",   6},
                    {"WIZARD",     6},
                    {"WARLOCK",    8}
                }
        }
    };

 //Data["key1"]["key2"]

    private static int ConstitutionCalc(int constitution) //changed to static
    {
        if(constitution < 12)
        {
            return 0;
        }
        else if(constitution <= 13)
        {
            return 1;
        }
        else if(constitution <= 15)
        {
            return 2;
        }
        else if(constitution <= 17)
        {
            return 3;
        }
        else 
        {
            return 4;
        }
    }

    public static int Calculator(bool Averaged,bool Stout, bool Tough, string Class, string Race, int Level, int constitution) //calculator function, Changed to static
    {
        //intializing values for calculation
        int stoutnum = 0;
        int toughnum = 0;
        int hp;

        if(Tough) //if true
        {
            toughnum = 2; //add to calculations
        }
        if(Stout) //if true
        {
            stoutnum = 1; //add to calculations
        }

        if (Averaged)
        {
            return hp = (Data["Classes"][Class]/2 + 1) + (Data["Races"][Race]*Level) + Level + (toughnum*Level)+ (stoutnum*Level) + ConstitutionCalc(constitution); 
            //averaged and all other stuff is added, uses +1 instead of 0.5 because DND rounds up anyways
        }

        else //rolled
        {
            return hp = Random.Range(1,Data["Classes"][Class]) + (Data["Races"][Race]*Level) + Level + (toughnum*Level)+ (stoutnum*Level)+ConstitutionCalc(constitution); 
            //randomized and added
        }
    }

    //removed start() because static classes cannot have a start function

}
