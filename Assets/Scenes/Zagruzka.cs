using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Zagruzka : MonoBehaviour
{
    public List<NumLevel2> numberLevel;
    public Sprite sp;
    public SpriteRenderer sr;
    string directory;
    public Text txt;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;
    }
    public void publicToGetFile()
    {
        StartCoroutine(this.GetFileBg());
    }

    IEnumerator GetFileBg()
    {
        //   Debug.Log(numberLevel[0].nameLevelLocation.Length);
        for (int i = 0; i < numberLevel[0].nameLevelLocation.Length; i++)
        //  {
      //  foreach (string spMy in numberLevel[0].nameLevelLocation)
        {
            txt.text = a.ToString();
            // ссылка откуда качаем
            //var wwwRequest = new UnityWebRequest("https://www.tzargor.ru/Sprites/Location/0/Location/" + spMy);
            var wwwRequest = new UnityWebRequest("https://www.tzargor.ru/Sprites/Location/0/Location/" + numberLevel[0].nameLevelLocation[i]); 
            wwwRequest.method = UnityWebRequest.kHttpVerbGET;
            // тут куда качаем наш файл в системе, обязательно использовать Application.persistentDataPath
            var dh = new DownloadHandlerFile(Application.persistentDataPath + "/0/Location/" + numberLevel[0].nameLevelLocation[i]);
            dh.removeFileOnAbort = true;
           wwwRequest.downloadHandler = dh;
         /*   if (wwwRequest.isDone != true)
            {
              //  Debug.Log(wwwRequest.downloadProgress);
               // Debug.Log(wwwRequest.isDone);
            }//*/
            yield return wwwRequest.SendWebRequest();
           /* if (wwwRequest.isNetworkError || wwwRequest.isHttpError)
            {
              //  Debug.Log(wwwRequest.error);
            }
            else
            {*/
              /*  directory = Application.persistentDataPath + "/0/Location/" + spMy.ToString();
                byte[] data = File.ReadAllBytes(directory);
                Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
                texture.LoadImage(data);
                texture.name = Path.GetFileNameWithoutExtension(directory);
                var mySprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);*/
                //numberLevel[0].spriteLevelLocation = mySprite;

                a = a + 1;
              //  Debug.Log("success" + Application.persistentDataPath + "/0/Location/" + spMy);
         //   }

            yield return wwwRequest;
        }
        Debug.Log("Gotovo");
        // }
        //StartCoroutine(this.GetFilePlayers());
    }

    IEnumerator GetFilePlayers()
    {
        //   Debug.Log(numberLevel[0].nameLevelLocation.Length);
        for (int i = 0; i < numberLevel[0].namePlayers.Length; i++)
        {
            txt.text = a.ToString();
            // ссылка откуда качаем
            var wwwRequest = new UnityWebRequest("https://www.tzargor.ru/Sprites/Location/0/Players/" + numberLevel[0].namePlayers[i]);
           // Debug.Log("aaa");
            wwwRequest.method = UnityWebRequest.kHttpVerbGET;
            // тут куда качаем наш файл в системе, обязательно использовать Application.persistentDataPath
            var dh = new DownloadHandlerFile(Application.persistentDataPath + "/0/Players/" + numberLevel[0].namePlayers[i]);
            dh.removeFileOnAbort = true;
         /*   wwwRequest.downloadHandler = dh;
            if (wwwRequest.isDone != true)
            {
            //    Debug.Log(wwwRequest.downloadProgress);
              //  Debug.Log(wwwRequest.isDone);
            }
            yield return wwwRequest.SendWebRequest();
            if (wwwRequest.isNetworkError || wwwRequest.isHttpError)
            {
            //    Debug.Log(wwwRequest.error);
            }
            else
            {
              
                a = a + 1;
                Debug.Log("success");
            }*/

            yield return wwwRequest;

        }
        Getpicture();
    }
    //}

    public void Getpicture()
    {
        for (int i = 0; i < numberLevel[0].nameLevelLocation.Length; i++)
        {
            directory = Application.persistentDataPath + "/0/Location/" + numberLevel[0].nameLevelLocation[i].ToString();
            byte[] data = File.ReadAllBytes(directory);
            Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
            texture.LoadImage(data);
            texture.name = Path.GetFileNameWithoutExtension(directory);
            var mySprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
            numberLevel[0].spriteLevelLocation[i] = mySprite;
        }
        getPlayers();
    }
    public void getPlayers()
    {
        for (int i = 0; i < numberLevel[0].nameLevelLocation.Length; i++)
        {
            directory = Application.persistentDataPath + "/0/Players/" + numberLevel[0].namePlayers[i].ToString();
            byte[] data = File.ReadAllBytes(directory);
            Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
            texture.LoadImage(data);
            texture.name = Path.GetFileNameWithoutExtension(directory);
            var mySprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
            numberLevel[0].spritePlayers[i] = mySprite;

        }
        txt.text = "Готово";
    }
}
[System.Serializable]
public struct NumLevel2
{

    public Sprite[] spriteLevelLocation;
    public string[] nameLevelLocation;
    public Sprite[] spritePlayers;
    public string[] namePlayers;
    public AudioClip[] musicClip;
    public AudioSource[] audioSource;
    public string[] txtmusicClip;
}
