using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : CharacterState
{
    public override void handleInput(Player character, IInputController input)
    {
        if (input.InputVector.y > 0.5f){
            character.characterState = new JumpState();
        }
        if (input.InputVector.x > 0.5f){
            character.characterState = new WalkState();
        }

        if (input.InputVector.x < -0.5f){
            character.characterState = new WalkState();
        }
    }
    public override void Update(Player character)
    {

    }
}