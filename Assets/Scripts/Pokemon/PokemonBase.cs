using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Pokemon", menuName ="Pokemon/Create New Pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField]string name;
    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    //Base Stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    public string Name {  get { return name; } }
    public string Description { get { return description; } }
    public Sprite FrontSprite { get { return frontSprite; }  }
    public Sprite BackSprite { get { return backSprite; } }
    public PokemonType Type1 { get {  return type1; } }
    public PokemonType Type2 { get { return type2; } }
    public int MaxHp { get { return maxHp; } }
    public int Attack { get { return attack;} }
    public int Defense { get {  return defense;} }
    public int SpAttack { get {  return spAttack;} }
    public int SpDefense { get { return spDefense; } }
    public int Speed { get { return speed;} }   

}


public enum PokemonType
{
    None,
    Normal,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost
}
