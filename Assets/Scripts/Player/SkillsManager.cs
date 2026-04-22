using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class SkillsManager : MonoBehaviour
{
    public PlayerSkills playerSkillsSO;

    public ScriptableObject[] skills;

    public String[] mySkills;
    public void AddSkills(string skill)
    {
        if (playerSkillsSO == null) return;

        List<String> temporalSkillsList =  mySkills.ToList<String>();

        if (playerSkillsSO.skills.Contains<String>(skill) && !mySkills.Contains<String>(skill))
        {
            temporalSkillsList.Add(skill);

            mySkills = temporalSkillsList.ToArray<String>();
        }

        /*
        playerSkillsSO.skills.Contains<String>(skill);

        foreach (string ParticularSkill in mySkills)
        {
            if (playerSkillsSO.skills.Contains<String>(ParticularSkill))
            {
                temporalSkillsList.Add(ParticularSkill);

                mySkills = temporalSkillsList.ToArray<String>();
            }
        }
        */
    }
}
