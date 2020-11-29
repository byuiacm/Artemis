using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private Rigidbody rb;
    private float changeX;
    private float changeY;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        getVelocity();
    }

    private void getVelocity()
    {   
        // In game camera is looking at x and z axis (z is y in this case)
        float x = transform.position.x;
        float y = transform.position.z;

        changeX = -x / 1200;
        changeY = -y / 1200;

    }


    public void kill()
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.z;
        transform.position = new Vector3(x + changeX, 0, y + changeY);

        if (transform.position.x < 10 && transform.position.x > -10)
        {
            //Change the if statement
            kill();
        }
    }
}
