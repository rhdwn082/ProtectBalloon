using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    int type;
    float size;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.3f, 2.3f);
        float y = Random.Range(4.0f, 4.0f);
        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 4);

        if (type == 1)
        {
        size = 1.8f;
        }
        else if (type == 2)
        {
        size = 1.5f;
        }
        else if (type == 3)
        {
        size = 1.0f;
        }
        else
        {
        size = 0.8f;
        }

         transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -4.5f)
        {
            Destroy(gameObject);

        }

    }
}
