using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Drawing.Inspector.PropertyDrawers;
using UnityEngine;

public class TimeandDynamicWeather : MonoBehaviour
{
    float hours, minutes;
    float weatherChanger = 40f;
    public Material shine;
    public Material storm;
    public AudioClip[] clips;

    // Start is called before the
    // first frame update
    void Start()
    {
        RenderSettings.skybox = shine;
        hours = 12;
        minutes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            WeatherChange();
        }
        WeathChange();
        
    }
    void FixedUpdate()
    {
        TimeChange();
        //Debug.Log(hours);
        //Debug.Log(minutes);
    }
    void TimeChange()
    {
        minutes += Time.deltaTime;
        if (minutes >= 59)
        {
            minutes = 0;
            if (hours == 23)
            {
                hours = 0;
            }
            else
            {
                hours++;
            }
            minutes = 0;
        }
    }  
    void WeatherChange()
    {
        if (RenderSettings.skybox == shine)
        {
            Stormy();
        }
            else
        {
            Sunny();
        }
    }
    public void Stormy()
    {
        //clips[0].Stop();
        //clips[1].Play();
        RenderSettings.skybox = storm;
        RenderSettings.fog = true;

    }
    public void Sunny()
    {
        //m_MyAudioSource[1].Stop();
        //m_MyAudioSource[2].Play();
        RenderSettings.skybox = shine;
        RenderSettings.fog = false;
    }
    void WeathChange()
    {
        if (weatherChanger > 0)
        {
            weatherChanger-= Time.deltaTime;
        }
        else
        {
            weatherChanger = 40f;
            WeatherChange();
        }
        //Debug.Log(weatherChanger);
    }
} 