using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class ZagruzkaAudio : MonoBehaviour
{
    public List<NumAudio> numberAudio;
    public string directory;// = "https://www.tzargor.ru/Sprites/Location/1/Music/" + numberAudio[0].txtmusicClip[i];

         void Start()
    {
        StartCoroutine(GetAudioClip());
    }

    IEnumerator GetAudioClip()
    {
        for (int i = 0; i < numberAudio[0].txtmusicClip.Length; i++)
        {
            using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip("https://www.tzargor.ru/Sprites/Location/1/Music/" + numberAudio[0].txtmusicClip[i], AudioType.OGGVORBIS))
            {
                yield return www.SendWebRequest();

                if (www.result == UnityWebRequest.Result.ConnectionError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    numberAudio[0].musicClip[i] = DownloadHandlerAudioClip.GetContent(www);

                    //  AudioClip myClip = DownloadHandlerAudioClip.GetContent(www);
                }
            }
            numberAudio[0].audioSource[i] = gameObject.AddComponent<AudioSource>();
        }
       // numberAudio[0].audioSource[0].clip = numberAudio[0].musicClip[0];
    }

    public void playMusic(int a)
    {
       
       numberAudio[0].audioSource[a].clip = numberAudio[0].musicClip[a];
        numberAudio[0].audioSource[a].Play();
    }
}
[System.Serializable]
public struct NumAudio
{


    public AudioClip[] musicClip;
    public AudioSource[] audioSource;
    public string[] txtmusicClip;
}

