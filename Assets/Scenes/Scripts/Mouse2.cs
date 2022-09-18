using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse2 : MonoBehaviour
{
    public GameObject panel;
    public GameObject Square;
    public GameObject Bum;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Square")
        { 
            panel.SetActive(true);
            Bum.SetActive(true);
            Square.SetActive(false);
            Invoke("Dead",0.5f);

        }
    }

    void Dead()
    {
        Time.timeScale = 0.0f;
        Destroy(gameObject);
    }
}

