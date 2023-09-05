using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Character
{
    knight, penguin
}

public class DataManager : MonoBehaviour
{
    public static DataManager i;
    public Character currentCharacter;
    // Start is called before the first frame update
    void Start()
    {
        i = this;
        DontDestroyOnLoad(gameObject);
    }

}
