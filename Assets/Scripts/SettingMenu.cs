using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class SettingMenu : MonoBehaviour
{
    
    [Tooltip("Main menu Gameobjects")]
    public GameObject[] menuObjects;
    [Tooltip("Option menu Gameobjects")]
    public GameObject[] optionsObjects;
    [Tooltip("About menu Gameobjects")]
    public GameObject[] aboutObjects;

    [Tooltip("The Master control mixer")]
    public AudioMixer mixer;

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void ToggleOptions(bool value)
    {
        foreach (GameObject o in optionsObjects)
        {
            o.SetActive(value);
        }
    }
    public void ToggleMenu(bool value)
    {
        foreach (GameObject o in menuObjects)
        {
            o.SetActive(value);
        }
    }
    public void ToggleAbout(bool value)
    {
        foreach (GameObject o in aboutObjects)
        {
            o.SetActive(value);
        }
    }

    public void SetMusicVolume(float volume)
    {
        mixer.SetFloat("musicVolume", volume);
    }
    public void SetSFXVolume(float volume)
    {
        mixer.SetFloat("sfxVolume", volume);
    }
    public void ToggleMusic(bool value)
    {
        if (value){
            mixer.SetFloat("musicToggle", 20f);
        }
        else if(!value){
            mixer.SetFloat("musicToggle", -80f);
        }
    }
   
    public void ToggleSfx(bool value)
    {
        if (value){
            mixer.SetFloat("sfxToggle", 20f);
        }
        else if (!value){
            mixer.SetFloat("sfxToggle", -80f);
        }

    }


   
}
