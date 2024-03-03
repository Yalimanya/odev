using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    public int speed = 10;
    public GameObject helloText;
    void Start()
    {
        print("Hello World");
        helloText.GetComponent<TextMeshPro>().text = "Hello World";
    }

    void Update()
    {
        print("Hiii");
        transform.Translate(new Vector3 (0, 0, 1) * Time.deltaTime * speed);
    }
}