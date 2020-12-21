using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    public GameObject weapon;
    public GameObject projectile;
    public List<GameObject> liveProjectiles;
    // Start is called before the first frame update
    void Start()
    {
        GameObject w1 = Instantiate(weapon, new Vector3(0,0), Quaternion.identity);
        liveProjectiles.Add(w1);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.P))
        {
            foreach(GameObject g in liveProjectiles)
            {
                Destroy(g);
            }
            Instantiate(weapon, new Vector3(Random.Range(-1, 1), Random.Range(-1, 1)), Quaternion.identity);
        }
    }
}
