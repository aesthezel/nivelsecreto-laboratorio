using System;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public static Action<string, int> OnItemSpawn;

    public string[] typeItems = new string[3];
    public int[] quantityItems = new int[3];

    public void SpawnItem()
    {
        int randomItem = UnityEngine.Random.Range(0, typeItems.Length);
        int incrementItem = ++quantityItems[randomItem];

        OnItemSpawn(typeItems[randomItem], incrementItem);
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
            SpawnItem();
    }
}
