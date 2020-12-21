using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public int ammo;
    // Start is called before the first frame update

    public void SpawnArea()
    {

    }

    public void Despawn()
    {

    }
    public void SetAmmo(int a)
    {
        ammo = a;
    }
    void Start()
    {
        ammo = 10;
    }

    // Update is called once per frame
    void Update()
    {
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
            if(ammo > 0)
            {
                GameObject b = (GameObject)(Instantiate(bullet, transform.position + transform.up * 1.5f, Quaternion.identity));

                b.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);
                ammo--;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SetAmmo(10);
        }
    }
}
