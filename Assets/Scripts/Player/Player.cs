using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kryz.CharacterStats;

[RequireComponent(typeof(IInputController))]
public class Player : MonoBehaviour {
    
    private IInputController _input;
    [SerializeField]
    public LevelSystem levelSystem = new LevelSystem();
    [SerializeField]
    public CharacterStat moveSpeed = new CharacterStat();
    public CharacterState characterState = new IdleState();
    public void Start()
    {
        _input=GetComponent<IInputController>();
    }
    public void Update()
    {
       characterState.handleInput(this,_input);

    }


}
