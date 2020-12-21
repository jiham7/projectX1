using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : Weapon
{
    public Projectile shot;
    new public void Use()
    {
        if (CanUse())
        {
            SetAmmo(ammo - 1);         //define reduction as just 1 per shot (could have multi shooting weapons/power ups for implementation in the future
            Projectile b = (Projectile)(Instantiate(shot, transform.position + transform.up * 1.5f, Quaternion.identity));
            b.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
