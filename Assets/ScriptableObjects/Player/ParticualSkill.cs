using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(fileName = "PlayerSkills", menuName = "Scriptable Objects/Player Skills")]
public class ParticualSkill : ScriptableObject
{
    [Header("Skill name")]
    public string nombreDeHabilidad;

    public bool puedeAumentarVelocidad;
    
}
