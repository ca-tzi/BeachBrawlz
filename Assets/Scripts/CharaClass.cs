using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface CharaClass 
{
    // Start is called before the first frame update
    bool didMoveHit {get; set;}
    int Hp {get; set;}    
    int Sp {get; set;}
    int atk {get; set;}
    int def {get; set;}
    int acc {get; set;}
    string Name {get; set;}
    string ClassName {get; set;}
    string ClassDesc {get; set;}
    bool hasMoved {get; set;}
    bool hasAttacked {get; set;}
    int Lvl {get; set;}
    int exp {get; set;}
    List<Skill> skillList {get; set;}
    //playertransform for player position when implementing moving mechanics

    
}
