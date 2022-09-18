using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timegogo : MonoBehaviour
{
    // Start is called before the first frame update

    public float LimitTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        LimitTime += Time.deltaTime;
        
    }
}
