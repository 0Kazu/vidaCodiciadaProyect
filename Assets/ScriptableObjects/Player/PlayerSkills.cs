using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSkills", menuName = "Scriptable Objects/Player Skills")]
public class PlayerSkills : ScriptableObject
{
    [Header("Player Skills")]
    public string[] skills;
}
