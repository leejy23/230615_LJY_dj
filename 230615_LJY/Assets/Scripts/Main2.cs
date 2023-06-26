using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
    List<Character> characterList = new List<Character>();
    void Start()
    {
        CreateCharacter(new Character("Jaeyoung", "Warrior", 100, 20));
        CreateCharacter(new Character("Jaehwan", "Mage", 80, 30));
        PrintAllCharacters();
    }
    
    void CreateCharacter(Character character)
    {
        characterList.Add(character);
    }

    void RemoveCharacter(int index)
    {
        if (index >= 0 && index < characterList.Count)
        {
            characterList.RemoveAt(index);
        }
    }

    void PrintAllCharacters()
    {
        int index = 0;
        while (index < characterList.Count)
        {
            characterList[index].GetInfo();
            index++;
        }

        if (characterList.Count == 0)
        {
            Debug.Log("리스트가 비어있습니다.");
            return;
        }
    }
    
}
