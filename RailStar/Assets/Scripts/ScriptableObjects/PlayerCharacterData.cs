using UnityEngine;

[CreateAssetMenu(fileName = "PlayerCharacterData", menuName = "Scriptable Objects/PlayerCharacterData")]
public class PlayerCharacterData : ScriptableObject
{
    private GameObject[] playerCharacters;
    public GameObject[] PlayerCharacters
    {
        get
        {
            return playerCharacters;
        }
        set
        {
            playerCharacters = value;
        }
    }
}
