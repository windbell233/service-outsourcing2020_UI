using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Startup()
    {
        gameObject.SetActive(false);
    }
    public void Help()
    {
        gameObject.SetActive(true);
    }
}