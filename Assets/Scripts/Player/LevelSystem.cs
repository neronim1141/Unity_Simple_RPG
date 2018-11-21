using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelSystem  {
   public int level;
   public float exp;
   public float[] expToLevel;

    public void AddExp(float value)
    {
        exp+=value;
        if (level<expToLevel.Length && exp >= expToLevel[level])
        {   
            exp-=expToLevel[level];
            level++;
        }
    }
}
