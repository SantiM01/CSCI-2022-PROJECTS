using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collison c)
    {
        if (Equals(c.GetComponent<Collider>().tag, "wall"))
        {
            //we hit a wall... what should we do?
            //player takes damage
            //restart the level

        }
    }
}
