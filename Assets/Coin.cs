using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public int HP = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.transform.name);
        if (other.transform.name == "head")
        {
            //這一段要注意 是招喚在playerHead裡面地定義的Atk指令
            HP -= other.transform.GetComponent<playerHead>().Atk;
            if (HP <= 0)
            {
                Destroy(gameObject);
            }

        }
    }
}
