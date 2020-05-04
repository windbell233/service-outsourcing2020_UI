using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MusicControl : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip music;
    public AudioSource back;
    public Slider slider;

    void Start()
    {
        //back = this.GetComponent<AudioSource>();
        //back.loop = true; //设置循环播放  
        //back.volume = 0.8f;//设置音量最大，区间在0-1之间
        back.clip = music;
        //back.Play(); //播放背景音乐

    }

    // Update is called once per frame
    void Update()
    {
        back.volume = slider.value;
       
    }
}
