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
            HP -= 3;
            if (HP <= 0)
            { Destroy(gameObject); }

        }
    }
}
