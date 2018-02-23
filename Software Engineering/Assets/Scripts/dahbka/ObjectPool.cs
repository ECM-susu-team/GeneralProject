using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objpull : MonoBehaviour
{

    private GameObject[] objprefabs;
    public GameObject Getobj(string name)
    {
        for (int i = 0; i < objprefabs.Length; i++)
        {
            if (objprefabs[i].name == name)
            {
                GameObject newObject = Instantiate(objprefabs[i]);
                newObject.name = name;
                return newObject;
            }
        }
        return null;
    }
}