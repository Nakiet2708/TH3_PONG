using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(18f, 18f);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 35f)
        {
            this.transform.position = new Vector2(0f, 0f);
        }
        if (this.transform.position.x <= -35f)
        {
            this.transform.position = new Vector2(0f, 0f);
        }


    }
}
