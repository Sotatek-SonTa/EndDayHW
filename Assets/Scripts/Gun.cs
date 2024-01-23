using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    float fireRate = 0.5f;
    float nextFire = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Time.time > nextFire)
        {
            nextFire = Time.time+fireRate;
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
