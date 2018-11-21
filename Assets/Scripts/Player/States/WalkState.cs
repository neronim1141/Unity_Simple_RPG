using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState: CharacterState  {

	 public override void handleInput(Player character, IInputController input)
    {
        float x=input.InputVector.x;
        float y=input.InputVector.y;
        if(x<0.5 && x>-0.5)
        {
            character.characterState = new IdleState();
        }
        character.transform.Translate(new Vector2(x*character.moveSpeed.Value*Time.deltaTime,0));

    }
    public override void Update(Player _character)
    {

    }
}
