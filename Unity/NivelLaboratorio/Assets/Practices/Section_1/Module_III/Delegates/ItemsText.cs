using UnityEngine;
using UnityEngine.UI;

public class ItemsText : MonoBehaviour
{
    [SerializeField] private Text spadesText;
    [SerializeField] private Text potionText;
    [SerializeField] private Text collectablesText;

    private void ChangeItemText( string type, int quantity )
    {
        switch(type)
        {
            case "Spade":
                spadesText.text = quantity.ToString();
                break;
            case "Potion":
                potionText.text = quantity.ToString();
                break;
            case "Collectable":
                collectablesText.text = quantity.ToString();
                break;
            default:
                Debug.Log("No reconozco este objeto");
                break;
        }
    }

    private void OnEnable() 
    {
        ItemSpawner.OnItemSpawn += ChangeItemText;
    }

    private void OnDisable() 
    {
        ItemSpawner.OnItemSpawn -= ChangeItemText;
    }
}
