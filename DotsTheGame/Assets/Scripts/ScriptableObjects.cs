using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Patron", menuName = "ScriptableObjects/Patron", order = 0)]

public class ScriptablesObjects : ScriptableObject
{
    public int objCount;
    public List<Sprite> sprites = new List<Sprite>();
    public void AddSprite(Sprite spriteToAdd)
    {
        sprites.Add(spriteToAdd);
    }
}

