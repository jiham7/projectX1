using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int orientation;    //This has to inherit the character's orientation (set it from 0-3 going in order of U R D L)
    public string id;          // Unique ID assigned to each weapon
    public int positionx;      //Will be called upon spawn
    public int positiony;      //"                         "
    public string wName;        //Name of the weapon class
    public int damage;         //Damage of the weapon class
    public int ammo;           //Initialize the ammo by weapon class
    public bool range = true;  //TBD whether we will implement melee weapons
    public int speed;          //Speed of the bullet that will spawn
    public GameObject projectile;
    public bool CanUse()
    {
        return ammo > 0;
    }
    public void SpawnArea(int x, int y)
    {
        positionx = x;
        positiony = y;
    }
    public void Use()      //shoot out something
    {
        if (CanUse())
        {
            SetAmmo(ammo - 1);         //define reduction as just 1 per shot (could have multi shooting weapons/power ups for implementation in the future)
        }
    }
    public void SetAmmo(int temp) //reduces the ammo by whatever int is passed in
    {
        ammo = temp;              //rename temp
    }
    public void Reload()
    {
        ammo = 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        ammo = 10;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
        if (Input.GetKey(KeyCode.LeftArrow))

        {

            gameObject.transform.Translate(Vector3.left * 0.1f);

        }

        if (Input.GetKey(KeyCode.RightArrow))

        {

            gameObject.transform.Translate(Vector3.right * 0.1f);

        }

        if (Input.GetKey(KeyCode.UpArrow))

        {

            gameObject.transform.Translate(Vector3.up * 0.1f);

        }

        if (Input.GetKey(KeyCode.DownArrow))

        {

            gameObject.transform.Translate(Vector3.down * 0.1f);

        }

        if (Input.GetKeyDown(KeyCode.Space))

        {
            if (CanUse())
            {
                Use();
                GameObject b = (GameObject)(Instantiate(projectile, transform.position + transform.up * 1.5f, Quaternion.identity));

                b.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);

            }

        }
    }
}
