using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadEmicii : MonoBehaviour
{
	public int LVL;
	public int numFace;
	public InkScript inkScript;
	public InventoryScrypt inbentoryScript;
    // Start is called before the first frame update
    void Start()
    {
		LVL = inkScript.LVL;
		numFace = inbentoryScript.numFace;
		StartCoroutine(GetEmocii());
	}


	IEnumerator GetEmocii()
	{
		for (int j = 0; j < 4; j++)
		{
			for (int i = 0; i < 14; i++)
			{
				//using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("https://www.tzargor.ru/Sprites/Location/" + LVL + "/Emocii/" + numberLevel[LVL].emociinameEn[i]))
				using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("https://www.tzargor.ru/Sprites/Location/" + LVL + "/Emocii/" + j + "/" + inkScript.numberLevel[LVL].emociinameEn[i]))
				{
					yield return uwr.SendWebRequest();

					if (uwr.result == UnityWebRequest.Result.ConnectionError)
					{
						Debug.Log(uwr.error);
					}
					else
					{
						var texture = DownloadHandlerTexture.GetContent(uwr);
						//numberLevel[LVL].emociiSpritefromServer[i].name = texture.name;
						inkScript.numberLevel[LVL].numberLevelEmocii[j].emociiSpritefromServer[i] = Sprite.Create((Texture2D)texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
						//	Debug.Log(texture.width + "   " + texture.height);
						inkScript.numberLevel[LVL].numberLevelEmocii[j].emociiSpritefromServer[i].name = inkScript.numberLevel[LVL].emociinameEn[i];

					}

					//numberLevel[LVL].audioSource[i] = GameObject.FindGameObjectWithTag("ForAudio").AddComponent<AudioSource>();
				}

			}

		}
	}
		// Update is called once per frame
		void Update()
    {
        
    }
}
