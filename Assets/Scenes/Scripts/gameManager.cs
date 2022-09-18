using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour

{
    public GameObject Square;
    public Text scoreText;
    public GameObject Circle;
    public GameObject panel;

    float start = 0.00f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0, 0.5f);
    }

    void makeSquare()
    {
        Instantiate(Square);
    }

    // Update is called once per frame
    void Update()
    {
        start += Time.deltaTime;
        scoreText.text = start.ToString();
    }


}