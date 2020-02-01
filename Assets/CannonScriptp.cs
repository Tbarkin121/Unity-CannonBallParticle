using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScriptp : MonoBehaviour
{
    public GameObject cannonBall;
    public float shootForce = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = (GameObject)Instantiate(cannonBall, transform.position, transform.rotation);
            projectile.GetComponent<Rigidbody>().AddForce(new Vector3(0f,1f,0f)*shootForce);
        }
    }
}
