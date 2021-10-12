using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private Button joinPlayerOne;
    [SerializeField]
    private Button addPlayerTwo;
    Text text1;
    Text text2;
    bool Player1Joined;
    bool Player2Joined;


    //TODO: Add PlayerTwoButton reference

    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;
    // Start is called before the first frame update
    void Start()
    {
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());
        addPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());
        //TODO Listen for player two click event
    }

    private void JoinPlayerOne()
    {
        playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
        
        text1 = joinPlayerOne.GetComponentInChildren<Text>();
        text1.text = "Leave Player One";
        //joinPlayerOne.onClick.AddListener(() => 
        //TODO flip text to say "Leave Player One"
        //TODO on click after player has joined, remove player
    }

    private void JoinPlayerTwo()
    {
        playerInputManager.JoinPlayer(1, "PlayerTwo");
        text2 = addPlayerTwo.GetComponentInChildren<Text>();
        text2.text = "Leave Player Two";
    }

    //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme
    //TODO flip text after player has joined to say "Leave Player Two"
    //TODO on click after player has joined, remove player
}
