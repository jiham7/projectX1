using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
// Start is called before the first frame update
    int positionx;
    int positiony;
    int damage;
    int orientation;
    int speed;
    int timeToLive;
    public Projectile(int x, int y, int dmg, int orient, int spd)
    {
        positionx = x;
        positiony = y;
        damage = dmg;
        orientation = orient;
        speed = spd;
    }

    void Start()
    {
            timeToLive = 2;
    }

        // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, timeToLive);
    }
}
