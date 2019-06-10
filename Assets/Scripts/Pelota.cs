using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pelota : MonoBehaviour
{
    public Rigidbody2D body;
    public float Vel = 5f;
    public GameObject floor;
    public GameObject gameover;

    // Start is called before the first frame update
    void Start()
    {
        body.velocity = Vector2.down * Vel;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == floor)
        {
            body.velocity = Vector2.zero * Vel;
            gameover.SetActive(true);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
