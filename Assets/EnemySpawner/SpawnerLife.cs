using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLife : MonoBehaviour
{
    public int life;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        life--;
        Destroy(collision.gameObject);
        if(life<=0)
        {
            Destroy(gameObject);

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
