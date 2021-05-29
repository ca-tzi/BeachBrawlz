using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, CharaClass
{
    public bool didMoveHit {get; set;}
    public int Hp {get; set;}    
    public int Sp {get; set;}
    public int atk {get; set;}
    public int def {get; set;}
    public int acc {get; set;}
    public string Name {get; set;}
    public string ClassName {get; set;}
    public string ClassDesc {get; set;}
    public bool hasMoved {get; set;}
    public bool hasAttacked {get; set;}
    public int Lvl {get; set;}
    public int exp {get; set;}
    public List<Skill> skillList {get; set;}
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
