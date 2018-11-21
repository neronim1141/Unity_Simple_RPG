using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterState {

    public CharacterState(){ 
        Debug.Log(this);
        }
    public virtual void enter(Player _character)
    {
         throw new NotImplementedException();
    }
    public virtual void exit(Player _character)
    {
         throw new NotImplementedException();
    }
    public virtual void handleInput(Player _character, IInputController input)
    {
        throw new NotImplementedException();
    }
    public virtual void Update(Player _character)
    {
        throw new NotImplementedException();
    }
	 
}

