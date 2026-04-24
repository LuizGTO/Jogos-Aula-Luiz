using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        this.transform.position += new Vector3(horizontalInput*velocity,0,0);
        this.transform.position += new Vector3(0,verticalInput*velocity,0);
        if(this.transform.position.x>10)
        {
            this.transform.position = new Vector3 (10, this.transform.position.y, this.transform.position.z);
        } else if (this.transform.position.x<-10) {
            this.transform.position = new Vector3 (-10, this.transform.position.y, this.transform.position.z);
        }
    }
}
