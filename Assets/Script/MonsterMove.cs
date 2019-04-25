using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public TilePass M_tilePass;
    int M_count = 0;
    void Awake()
    {
        M_tilePass = GameObject.Find("TilePass").GetComponent<TilePass>();
    }
 
    void Update()
    {
        Move();        
    }
    void Move() // 길찾기 함수
    {
        transform.position = Vector3.MoveTowards(transform.position,
         M_tilePass.Get_T_tile_tr(M_count).position, Time.deltaTime * 3);
        if (Vector3.Distance(transform.position, M_tilePass.Get_T_tile_tr(M_count).position) < 0.2f)
        {
           M_count++;
            if (M_count == M_tilePass.T_tile_tr.Length)
            {
                Player.P_hp -= 3;
                Destroy(gameObject);
            }
        }
    }
}
