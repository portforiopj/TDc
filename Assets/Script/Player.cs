using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public string P_name;
    
    public static int P_hp = 50;
    public bool[] P_state = new bool[2];

    
    public void DiePlayer()
    {
        if (P_hp <= 0)
        {
            GameSystem.Instatce.G_state = GameSystem.GameState.Gameover;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
