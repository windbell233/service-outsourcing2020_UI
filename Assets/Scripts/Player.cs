using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator ani;
    Ray ray;
    RaycastHit hit;
    GameObject obj;
    public GameObject Mind;
    public AudioSource back;

    void Start()
    {

    }
    //动画触发方法：Test（）；

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("点击鼠标左键");
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                obj = hit.collider.gameObject;
                //通过名字
                if (obj.name.Equals("Mao"))
                {
                   Debug.Log("点中" + obj.name);
                    Test();
                    
                }
              
                //通过标签
                //if (obj.tag == "Archer")
               // {
                  //  Debug.Log("点中" + obj.name);
               // }
            }
        }
    }
    public void Test()
    {
        this.ani.SetTrigger("Test");
        Instantiate(Mind, transform.position, Quaternion.identity);
        back.Play(); //播放背景音乐
    }
  
}
