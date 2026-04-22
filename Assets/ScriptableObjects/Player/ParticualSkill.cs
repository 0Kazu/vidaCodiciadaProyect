using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(fileName = "PlayerSkills", menuName = "Scriptable Objects/Particular Skill")]
public class ParticualSkill : ScriptableObject
{
    [Header("Skill name")]
    public string nombreDeHabilidad;

    public bool puedeAumentarVelocidad;
    [ShowIf("puedeAumentarVelocidad")]
    public float aumentoDeVelocidad;

    public bool puedeAumentarResistencia;
    [ShowIf("puedeAumentarResistencia")]
    public float aumentoDeResistencia;
    
}
