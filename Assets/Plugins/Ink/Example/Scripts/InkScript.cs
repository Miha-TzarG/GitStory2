using UnityEngine;
using UnityEngine.UI;
using System;
using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Networking;
using TMPro;
// This is a super bare bones example of how to play and display a ink story in Unity.
public class InkScript : MonoBehaviour
{

	
	public static event Action<Story> OnCreateStory;
	//public string a;
	//public int b;
	//*********Garderob MAin
	public int LVL;

	public Image BGMaingarderob;
	public Image BGPanelVibor;
	public Image BtBody;
	public Image BtHair;
	public Image BtDress;
	public Image BtmackUp;
	public Image BtGotovo;
	public Image BtStrelkyLeft;
	public Image BtStrelkyRight;
	public Image BtStrelkyUp;
	public Image BtStrelkyDown;
	//**************************


	//******************Garderob OnlyDress

	public Image BGOnlyDress;
	public Image BtGotovoOnlyDress;
	public Image BtStrelkyLeftOnlyDress;
	public Image BtStrelkyRightOnlyDress;
	public Image BtStrelkyUpOnlyDress;
	public Image BtStrelkyDownOnlyDress;
	public Image plashkaOnlyDress;

	//**************************

	//******************Garderob OnlyHair
	public Image BGOnlyHair;
	public Image BtGotovoOnlyHair;
	public Image BtStrelkyLeftOnlyHair;
	public Image BtStrelkyRightOnlyHair;
	public Image BtStrelkyUpOnlyHair;
	public Image BtStrelkyDownOnlyHair;
	public Image plashkaOnlyHair;
	//**************************

	//******************GarderobGame
	public Image BGMaingarderobGarderobGame;
	public Image BGPanelViborGarderobGame;
	public Image BtBodyGarderobGame;
	public Image BtHairGarderobGame;
	public Image BtDressGarderobGame;
	public Image BtmackUpGarderobGame;
	public Image BtGotovoGarderobGame;
	public Image BtStrelkyLeftGarderobGame;
	public Image BtStrelkyRightGarderobGame;
	public Image BtStrelkyUpGarderobGame;
	public Image BtStrelkyDownGarderobGame;
	//**************************

	//******************btnopenSettings and btnGarderob
	public Image btnPause;
	public Image btnMusic;
	public Image BtExit;
	//public Image BtGarderob;
	public Image btnGarderob;
	/*public Image BtStrelkyRightGarderobGame;
	public Image BtStrelkyUpGarderobGame;
	public Image BtStrelkyDownGarderobGame;*/

	//********************

	public Text txtVsplivausheeOkno;
	public Image imgBgVsplivausheeOkno;
	public Image IcoBgVsplivausheeOkno;


	public int ZapuskNewlocation;
	public GameObject Game0;


	public InputField inputName;
	
	public ParticleSystem particleS;
	string directory;
	public string Inknm ;
	public Text test;
	public Slider sliderZagruzka;

	public int numtest;



	public GameObject pers;
	public Camera cam;
	public GameObject garderobMenu;
	public GameObject garderobHairMenu;
	public GameObject garderobDressMenu;
	public GameObject panelInputname;
	public GameObject garderobRoom;

	public bool GarderobSvernut;
	public GameObject PanelGarderob;
	public GameObject btnScernutGarderob;
	public Sprite[] spriteGarderob;

	public GameObject PanelSettings;

	public GameObject personag;

	public string nm = "Mike";
	public Text txt;
	//public Text txtOnImage;
	public float a;
	public bool enableMousebtn;


	//****Staty
	public int modesty;
	public int bravery;
	public int levkippalove;
	public int levkippafriend;
	public int admetlove;
	public int creation;
	public int destruction;
	public string names;
	public string namewindow;
	public int slava;
	public int voinstvennist;
	public int mudrost;

	
	/*modesty;
	bravery;
	levkippalove;
	levkippafriend;
	admetlove;
	creation;
	destruction;*/
	//*********************Zagtuzka image


	public List<NumLevel> numberLevel;


	public string url = "https://www.tzargor.ru/";
	public SpriteRenderer spLocation;
	public Sprite[] sprPersonazh;
	public string[] textPersonazh;
	public Sprite[] sprHeir;
	public string[] textHair;
	public Sprite[] sprDress;
	public string[] textDress;

	public SpriteRenderer spritePlayer;
	public SpriteRenderer spritePlayerHair;
	public SpriteRenderer spritePlayerDress;
	public SpriteRenderer spritePlayerEmicii;
	public SpriteRenderer spriteNPC;

	public string[] folder;

	public string[] texter;
	public Image img;
	public string atxt;
	//  [Obsolete]
	/*[Obsolete]
	WWW www;
	[Obsolete]
	WWW www2;
	[Obsolete]
	WWW www3;*/
	public int zagruzka;

	public Text txtTime;
	//  public Slider slider;
	//  public Text progressText;
	public GameObject[] go;

	public GameObject canvasStartgame;

	public float izmenenieekrana;
	public Image panelZatemnenie;
	public GameObject ActivePanelZatemnenie;
	//public GameObject dwnloadImage;;
	/*mudr;
	voin;
	Jessi;
	Jackman;
	names;
	*/
	
	public Sprite[] btnPauseSprite;


	public Sprite[] btnMusicSprite;
	
	public int kakayMusicaPlayNow;
	public int kakayaMelodiyaPlayNow;
	public GameObject particle;

	public int oldPricheska;
	public int newPricheska;

	public int Lvl0zagruzka;
	//public HistoryScript historyScript;
	void Start()
	{
		

		LVL = PlayerPrefs.GetInt("numLVL");

	Application.runInBackground = true;
		//Lvl0zagruzka = PlayerPrefs.GetInt("Lvl0");
		StartCoroutine(this.GetFileBg());
		
		//StartCoroutine(this.GetAudioClip());
		/*if (Lvl0zagruzka == 0)
		{
			StartCoroutine(this.GetFileBg());
		}
        else
        {
			Getpicture();
		}*/
	}
	public int proverkaZagruzky;
	IEnumerator GetAudioClip()
	{
		for (int i = 0; i < numberLevel[LVL].txtmusicClip.Length; i++)
		{
			using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip("https://www.tzargor.ru/Sprites/Location/" +LVL +"/Music/" + numberLevel[LVL].txtmusicClip[i], AudioType.OGGVORBIS))
			{
				yield return www.SendWebRequest();

				if (www.result == UnityWebRequest.Result.ConnectionError)
				{
					Debug.Log(www.error);
				}
				else
				{
					numberLevel[LVL].audioClip[i] = DownloadHandlerAudioClip.GetContent(www);
					numberLevel[LVL].audioClip[i].name = numberLevel[LVL].txtmusicClip[i];
					//  AudioClip myClip = DownloadHandlerAudioClip.GetContent(www);
				}
				numberLevel[LVL].audioSource[i] = GameObject.FindGameObjectWithTag("ForAudio").AddComponent<AudioSource>();
			}
			
		}
		Getpicture();
		GetGarderob();
		getAudioSource();
		
		// numberAudio[0].audioSource[0].clip = numberAudio[0].musicClip[0];
		//StartCoroutine(this.GetFilePlayers());
	}

	/*IEnumerator GetEmocii()
	{ 
		for (int i = 0; i < numberLevel[LVL].emociinameEn.Length; i++)
		{
			//using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("https://www.tzargor.ru/Sprites/Location/" + LVL + "/Emocii/" + numberLevel[LVL].emociinameEn[i]))
			using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("https://www.tzargor.ru/Sprites/Location/" + LVL + "/Emocii/" + numberLevel[LVL].emociinameEn[i]))
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
					numberLevel[LVL].emociiSpritefromServer[i] = Sprite.Create((Texture2D)texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
				//	Debug.Log(texture.width + "   " + texture.height);
					numberLevel[LVL].emociiSpritefromServer[i].name = numberLevel[LVL].emociinameEn[i];
				
				}

				//numberLevel[LVL].audioSource[i] = GameObject.FindGameObjectWithTag("ForAudio").AddComponent<AudioSource>();
			}

		}
	
		//naznachit();
	}*/
	IEnumerator GetEmocii()
	{
		//	for (int j = 0; j < 4; j++)
		//{
		/*	for (int i = 0; i < 14; i++)
			{
				//using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("https://www.tzargor.ru/Sprites/Location/" + LVL + "/Emocii/" + numberLevel[LVL].emociinameEn[i]))
				using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("https://www.tzargor.ru/Sprites/Location/" + LVL + "/Emocii/" + 0 + "/" + numberLevel[LVL].emociinameEn[i]))
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
						numberLevel[LVL].numberLevelEmocii[0].emociiSpritefromServer[i] = Sprite.Create((Texture2D)texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
						//	Debug.Log(texture.width + "   " + texture.height);
						numberLevel[LVL].numberLevelEmocii[0].emociiSpritefromServer[i].name = numberLevel[LVL].emociinameEn[i];

					}

					//numberLevel[LVL].audioSource[i] = GameObject.FindGameObjectWithTag("ForAudio").AddComponent<AudioSource>();
				}

			}*/

		//}
		for (int j = 0; j < 4; j++) { 
		for (int i = 0; i < numberLevel[LVL].emociinameEn.Length; i++)
		{
			test.text = proverkaZagruzky.ToString() + " %";
			sliderZagruzka.value = proverkaZagruzky;
			// ссылка откуда качаем
			var wwwRequest = new UnityWebRequest("https://www.tzargor.ru/Sprites/Location/" + LVL + "/Emocii/"+j+"/" + numberLevel[LVL].emociinameEn[i]);
			wwwRequest.method = UnityWebRequest.kHttpVerbGET;
			// тут куда качаем наш файл в системе, обязательно использовать Application.persistentDataPath
			var dh = new DownloadHandlerFile(Application.persistentDataPath + "/" + LVL + "/Emocii/"+j+"/" + numberLevel[LVL].emociinameEn[i]);

			wwwRequest.downloadHandler = dh;

			yield return wwwRequest.SendWebRequest();

			proverkaZagruzky = proverkaZagruzky + 4;
			yield return wwwRequest;

		}
		naznachit(j);
	}
	}
	public void naznachit(int j)
    {
		for (int i = 0; i < numberLevel[LVL].emociinameEn.Length; i++)
		{
			test.text = proverkaZagruzky.ToString() + " %";
			sliderZagruzka.value = proverkaZagruzky;
			directory = Application.persistentDataPath + "/" + LVL + "/Emocii/"+j+"/" + numberLevel[LVL].emociinameEn[i];
		byte[] data = File.ReadAllBytes(directory);
			Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
			texture.LoadImage(data);
			texture.name = System.IO.Path.GetFileNameWithoutExtension(directory);
			var mySprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
			numberLevel[LVL].numberLevelEmocii[j].emociiSpritefromServer[i] = mySprite;
			numberLevel[LVL].numberLevelEmocii[j].emociiSpritefromServer[i].name = numberLevel[LVL].emociinameEn[i];
			proverkaZagruzky = proverkaZagruzky + 4;

		}
		/*for (int i = 0; i < numberLevel[LVL].emociinameEn.Length; i++)
		{
			test.text = proverkaZagruzky.ToString() + " %";
			sliderZagruzka.value = proverkaZagruzky;
			directory = Application.persistentDataPath + "/" + LVL + "/Emocii/" + numberLevel[LVL].nameLevelLocation[i].ToString();
			byte[] data = File.ReadAllBytes(directory);
			Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
			texture.LoadImage(data);
			texture.name = System.IO.Path.GetFileNameWithoutExtension(directory);
			var mySprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
			numberLevel[LVL].spriteLevelLocation[i] = mySprite;
			proverkaZagruzky = proverkaZagruzky + 4;

		}*/
		//getPlayers();
		//numberLevel[LVL].emociiSprite.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].emociiSpritefromServer[10];
		//numberLevel[LVL].emociiSprite.GetComponent<SpriteRenderer>().sprite = Sprite.Create((Texture2D)numberLevel[LVL].emociiSpritefromServer[1], new Rect(0, 0, numberLevel[LVL].emociiSpritefromServer[3].width, numberLevel[LVL].emociiSpritefromServer[3].height), Vector2.zero); 
		//numberLevel[LVL].emociiSprite.GetComponent<Sprite>() = numberLevel[LVL].emociiSpritefromServer[1];

	}

	public void getAudioSource()
	{
		for (int i = 0; i < numberLevel[LVL].txtmusicClip.Length; i++)
		{
			numberLevel[LVL].audioSource[i].name = numberLevel[LVL].txtmusicClip[i];
			numberLevel[LVL].audioSource[i].clip = numberLevel[LVL].audioClip[i];
			
			//Debug.Log(i + "numberLevel[LVL].audioClip[i]: " + numberLevel[LVL].audioSource[i].name);
		}
		//StartCoroutine(GetEmocii());
	}
	/*public void playMusic(int a)
	{

		numberAudio[0].audioSource[a].clip = numberAudio[0].musicClip[a];
		numberAudio[0].audioSource[a].Play();
	}*/
	IEnumerator GetFileBg()
	{
		//   Debug.Log(numberLevel[0].nameLevelLocation.Length);
		for (int i = 0; i < numberLevel[LVL].nameLevelLocation.Length; i++)
		{
			test.text = proverkaZagruzky.ToString() + " %";
			sliderZagruzka.value = proverkaZagruzky;
			// ссылка откуда качаем
			var wwwRequest = new UnityWebRequest("https://www.tzargor.ru/Sprites/Location/" + LVL+ "/Location/" + numberLevel[LVL].nameLevelLocation[i]);
			wwwRequest.method = UnityWebRequest.kHttpVerbGET;
			// тут куда качаем наш файл в системе, обязательно использовать Application.persistentDataPath
			var dh = new DownloadHandlerFile(Application.persistentDataPath+ "/" + LVL + "/Location/" + numberLevel[LVL].nameLevelLocation[i]);
			//dh.removeFileOnAbort = true;
			wwwRequest.downloadHandler = dh;
		/*	if (wwwRequest.isDone != true)
			{
				Debug.Log(wwwRequest.downloadProgress);
				Debug.Log(wwwRequest.isDone);
			}*/
			yield return wwwRequest.SendWebRequest();
			/*	if (wwwRequest.isNetworkError || wwwRequest.isHttpError)
				{
					Debug.Log(wwwRequest.error);
				}
				else
				{
					/*directory = Application.persistentDataPath + "/0/Location/" + numberLevel[0].nameLevelLocation[i].ToString();
					byte[] data = File.ReadAllBytes(directory);
					Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
					texture.LoadImage(data);
					texture.name = System.IO.Path.GetFileNameWithoutExtension(directory);
					var mySprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
					numberLevel[0].spriteLevelLocation[i] = mySprite;
					proverkaZagruzky = proverkaZagruzky + 1;
					Debug.Log("success" + wwwRequest.downloadProgress);
				}*/
			proverkaZagruzky = proverkaZagruzky + 4;
			yield return wwwRequest;

		}
		StartCoroutine(this.GetFilePlayers());
	}

	IEnumerator GetFilePlayers()
	{
		//   Debug.Log(numberLevel[0].nameLevelLocation.Length);
		for (int i = 0; i < numberLevel[LVL].nameEn.Length; i++)
		{
			test.text = proverkaZagruzky.ToString() +  " %";
			sliderZagruzka.value = proverkaZagruzky;
			// ссылка откуда качаем
			var wwwRequest = new UnityWebRequest("https://www.tzargor.ru/Sprites/Location/" + LVL+ "/Players/" + numberLevel[LVL].nameEn[i]);
			//Debug.Log("aaa");
			wwwRequest.method = UnityWebRequest.kHttpVerbGET;
			// тут куда качаем наш файл в системе, обязательно использовать Application.persistentDataPath
			var dh = new DownloadHandlerFile(Application.persistentDataPath + "/"+ LVL+ "/Players/" + numberLevel[LVL].nameEn[i]);
		//	dh.removeFileOnAbort = true;
			wwwRequest.downloadHandler = dh;
			/*if (wwwRequest.isDone != true)
			{
				Debug.Log(wwwRequest.downloadProgress);
				Debug.Log(wwwRequest.isDone);
			}*/
			yield return wwwRequest.SendWebRequest();
			/*if (wwwRequest.isNetworkError || wwwRequest.isHttpError)
			{
				Debug.Log(wwwRequest.error);
			}
			else
			{*/
			/*	directory = Application.persistentDataPath + "/0/Players/" + numberLevel[0].nameEn[i].ToString();
				byte[] data = File.ReadAllBytes(directory);
				Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
				texture.LoadImage(data);
				texture.name = System.IO.Path.GetFileNameWithoutExtension(directory);
				var mySprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
				numberLevel[0].npcSpritefromServer[i] = mySprite;*/
				proverkaZagruzky = proverkaZagruzky + 4;
				//a = a + 1;
				/*Debug.Log("success");*/
		//	}
		
			yield return wwwRequest;
			
		}
		//	Lvl0zagruzka = 1;
		StartCoroutine(this.GetAudioClip());
		//PlayerPrefs.SetInt("Lvl0", Lvl0zagruzka);
		
	//	StartCoroutine(Getpicture());
		/*canvasStartgame.SetActive(false);
			particle.SetActive(true);
			RemoveChildren();
			StartStory();
			if (story.canContinue)
			{

				string text = story.Continue();

				CreateContentView(text);


			}
		RefreshView();
		 */



	}


	public void Getpicture()
	{
		for (int i = 0; i < numberLevel[LVL].nameLevelLocation.Length; i++)
		{
			test.text = proverkaZagruzky.ToString() + " %";
			sliderZagruzka.value = proverkaZagruzky;
			directory = Application.persistentDataPath + "/" + LVL+"/Location/" + numberLevel[LVL].nameLevelLocation[i].ToString();
			byte[] data = File.ReadAllBytes(directory);
			Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
			texture.LoadImage(data);
			texture.name = System.IO.Path.GetFileNameWithoutExtension(directory);
			var mySprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
			numberLevel[LVL].spriteLevelLocation[i] = mySprite;
			proverkaZagruzky = proverkaZagruzky + 4;

		}
		getPlayers();
	}
	public void getPlayers()
	{
		for (int i = 0; i < numberLevel[LVL].nameEn.Length; i++)
		{
			test.text = proverkaZagruzky.ToString() + " %";
				sliderZagruzka.value = proverkaZagruzky; 
			directory = Application.persistentDataPath + "/"+LVL+"/Players/" + numberLevel[LVL].nameEn[i].ToString();
			byte[] data = File.ReadAllBytes(directory);
			Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
			texture.LoadImage(data);
			texture.name = System.IO.Path.GetFileNameWithoutExtension(directory);
			var mySprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
			numberLevel[LVL].npcSpritefromServer[i] = mySprite;
			proverkaZagruzky = proverkaZagruzky + 4;
		//	Debug.Log(numberLevel[0].npcSpritefromServer[i].ToString());
		}
		test.text = "100 %";
		sliderZagruzka.value = 100;
		/*canvasStartgame.SetActive(false);

		particle.SetActive(true);
		RemoveChildren();
		StartStory();
		if (story.canContinue)
		{

			string text = story.Continue();

			CreateContentView(text);


		}
		RefreshView();*/
		//StartCoroutine(Firstzapusk());
		
		Sliderstart.SetActive(false);
			txtSliderstart.SetActive(false);
		imgSeria.SetActive(false);
		btnStartHistory.SetActive(true);
		palecTimer.SetActive(true);
	}

	public void GetGarderob()
    {
	BGMaingarderob.GetComponent<Image>().sprite = numberLevel[LVL].BGMaingarderob;
	BGPanelVibor.GetComponent<Image>().sprite = numberLevel[LVL].BGPanelVibor; 
	BtBody.GetComponent<Image>().sprite = numberLevel[LVL].BtBodyOn; 
	BtHair.GetComponent<Image>().sprite = numberLevel[LVL].BtHairOff; 
	BtDress.GetComponent<Image>().sprite = numberLevel[LVL].BtDressOff;
	BtmackUp.GetComponent<Image>().sprite = numberLevel[LVL].BtMackUpOff;
	BtGotovo.GetComponent<Image>().sprite = numberLevel[LVL].BtGotovo;
	BtStrelkyLeft.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyRight.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyUp.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyDown.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;


	BGOnlyDress.GetComponent<Image>().sprite = numberLevel[LVL].BGMaingarderob;
	BtGotovoOnlyDress.GetComponent<Image>().sprite = numberLevel[LVL].BtGotovoBuy;
	BtStrelkyLeftOnlyDress.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyRightOnlyDress.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyUpOnlyDress.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyDownOnlyDress.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	plashkaOnlyDress.GetComponent<Image>().sprite = numberLevel[LVL].plashkaNazvanieGarderob;



	BGOnlyHair.GetComponent<Image>().sprite = numberLevel[LVL].BGMaingarderob;
	BtGotovoOnlyHair.GetComponent<Image>().sprite = numberLevel[LVL].BtGotovoBuy;
	BtStrelkyLeftOnlyHair.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyRightOnlyHair.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyUpOnlyHair.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyDownOnlyHair.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	plashkaOnlyHair.GetComponent<Image>().sprite = numberLevel[LVL].plashkaNazvanieGarderob;


	BGMaingarderobGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BGMaingarderob;
	BGPanelViborGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BGPanelVibor;
	BtBodyGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BtBodyOn;
	BtHairGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BtHairOff;
	BtDressGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BtDressOff;
	BtmackUpGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BtMackUpOff;
	BtGotovoGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BtGotovo;
	BtStrelkyLeftGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyRightGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyUpGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;
	BtStrelkyDownGarderobGame.GetComponent<Image>().sprite = numberLevel[LVL].BtStrelky;

		btnPause.GetComponent<Image>().sprite = numberLevel[LVL].btnSettingsOn;
		btnMusic.GetComponent<Image>().sprite = numberLevel[LVL].btnZvukOn;
	BtExit.GetComponent<Image>().sprite = numberLevel[LVL].btnExit;
		btnGarderob.GetComponent<Image>().sprite = numberLevel[LVL].btnGarderobOn;

		/*btnSettingsOn;
	btnSettingsOff;

	btnZvukOn;
	btnZvukOff;
	btnExit;

	btnGarderobOn;
	btnGarderobOff;
		
		 	btnPause
	btnMusic
		 */

	}

	public void NachatHistory()
    {
		
		palecTimer.SetActive(false);
		StartCoroutine(Firstzapusk());
	}

	IEnumerator Firstzapusk()
    {
		yield return new WaitForSeconds(0.2f);
		numberLevel[LVL].audioSource[0].loop = true;
		numberLevel[LVL].audioSource[0].Play();
		canvasStartgame.SetActive(false);

		particle.SetActive(true);
		RemoveChildren();
		StartStory();
		if (story.canContinue)
		{

			string text = story.Continue();

			CreateContentView(text);


		}
		RefreshView();
		StartCoroutine(ZapuskTimer());
	}
   /* private void OnApplicationQuit()
    {
		Debug.Log("Vihod");
		savedJson = story.state.ToJson();
		Debug.Log(savedJson);
	}*/

  public  string savedJson;// = _inkStory.state.ToJson();
	public int Timer;
	public GameObject palecTimer;
	public bool boolTimer;

	public GameObject Sliderstart;
	public GameObject txtSliderstart;
	public GameObject imgSeria;
	public GameObject btnStartHistory;
	IEnumerator ZapuskTimer()
    {
		yield return new WaitForSeconds(1f);
		if (boolTimer)
		{
			if (Timer == 7)
			{
				palecTimer.SetActive(true);

			}
			if (Timer < 7)
			{
				palecTimer.SetActive(false);
			}
			Timer = Timer + 1;
			StartCoroutine(ZapuskTimer());
		}
		else 
		{ 
			StartCoroutine(ZapuskTimer()); 
		}
	}
	/*	IEnumerator LoadImages()
		{

			for (int k = 0; k < 12; k++)
			{

				url = "https://www.tzargor.ru/Sprites/Location/0/Location/" + numberLevel[0].nameLevelLocation[k];
				// www2 = new WWW(url);
				www2 = new WWW(url);

				// Ожидаем загрузку ресурса
				yield return www2;
				var tex2 = www2.texture;

				// if (!www2.isDone)
				// {
				// Создаем спрайт из текстуры
				var mySprite2 = Sprite.Create(tex2, new Rect(0.0f, 0.0f, tex2.width, tex2.height), new Vector2(0.5f, 0.5f), 100.0f);
				// В подготовленный spriteRenderer вставляем спрайт
				numberLevel[0].spriteLevelLocation[k] = mySprite2;
				zagruzka = zagruzka + 4;
				txtTime.text = zagruzka.ToString();
				//}
			}
			for (int l = 0; l < 12; l++)
			{

				url = "https://www.tzargor.ru/Sprites/Location/0/Players/" + numberLevel[0].nameEn[l];
				// www2 = new WWW(url);
				www3 = new WWW(url);

				// Ожидаем загрузку ресурса
				yield return www3;
				var tex3 = www3.texture;

				// if (!www2.isDone)
				// {
				// Создаем спрайт из текстуры
				var mySprite3 = Sprite.Create(tex3, new Rect(0.0f, 0.0f, tex3.width, tex3.height), new Vector2(0.5f, 0.5f), 100.0f);
				// В подготовленный spriteRenderer вставляем спрайт
				numberLevel[0].npcSpritefromServer[l] = mySprite3;
				zagruzka = zagruzka + 4;
				txtTime.text = zagruzka.ToString();
				//zagruzka = zagruzka + 4;
				//txtTime.text = zagruzka.ToString();
				//}
			}

			//npcSprite
			//nameRu
			//nameEn
			//npcSpritefromServer[j]



			//   }
			//   numberLevel[0].spriteLevelLocation[4]





			canvasStartgame.SetActive(false);
			particle.SetActive(true);
			RemoveChildren();
			StartStory();
			if (story.canContinue)
			{

				string text = story.Continue();

				CreateContentView(text);


			}


			RefreshView();
		}

	*/

	public Image vsolivausheeOkno;
	public Text txtvsolivausheeOkno;
	public Image vsolivausheeOknoZnak;


	public bool vikluchitHistoryText;

	public void Update()
	{

		
		//txt.text = zagruzka.ToString();
		if (enableMousebtn)
		{
			test.text = numtest.ToString();
			if (Input.GetMouseButtonUp(0))

			{
				Timer = 0;
				palecTimer.SetActive(false);

				vikluchitHistoryText = true;
				/*	vsolivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
					txtvsolivausheeOkno.GetComponent<Text>().color = new Color(0f, 0f, 0f, 0f);
					vsolivausheeOknoZnak.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
					*/

				//vsolivausheeOknoZnak
				/*	vikluchitHistoryText = true;
					txtVsplivausheeOkno.GetComponent<Text>().color = new Color(0f, 0f, 0f, 0f);
					imgBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
					IcoBgVsp
				livausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
					*/
				//	savedJson = story.state.ToJson();
				//var savedState = story.state.ToJson();
				//PlayerPrefs.SetString("inkSaveState", savedJson);

				savedJson = story.state.ToJson();
				PlayerPrefs.SetString("inkSaveState", savedJson);

				//savedJson = story.state.ToJson();
				Debug.Log(savedJson);
				//Debug.Log(savedJson);
				enableMousebtn = false;
				StartCoroutine(BackpersnewText());
				
				/*	if (story.currentChoices.Count == 0)
					{

						RemoveChildren();
					}


					if (story.canContinue)
					{


						string text = story.Continue();

						CreateContentView(text);
						//	

					}
					else
					{

					}

					RefreshView();*/
			}
		}
	/*	if (vkluchitTapPoEkranufterSetting)
		{
			if (Input.GetMouseButtonUp(0))

			{
				CloseSettings();
			}
		}*/


	}
	/*private void Start()
	{




	}
	*/
	void StartStory()
	{

		a = 0;


		if (PlayerPrefs.HasKey("inkSaveState"))
		{

			story = new Story(inkJSONAsset.text);
			savedJson = PlayerPrefs.GetString("inkSaveState");
			story.state.LoadJson(savedJson);
			Debug.Log(savedJson);
			//Start();
			// story = new Story(inkJSONAsset.text);
			RefreshView();
		}
		else
		{

			story = new Story(inkJSONAsset.text);

			//if (OnCreateStory != null) OnCreateStory(story);
		}

		


	}

	void RefreshView()
	{
		//enableMousebtn = true;
		a = 0;
		// Remove all the UI on screen
		//RemoveChildren();

		// Read all the content until we can't continue any more


		//	while (story.canContinue)
		/*	 if(story.canContinue)
			{

				string text = story.Continue();
					// This removes any white space from the text.
				//	text = text.Trim();
					// Display the text on screen!
					CreateContentView(text);

				// Continue gets the next line of the story

		}*/
		//Debug.Log(story.currentChoices.Count);
		// Display all the choices, if there are any!

		if (story.currentChoices.Count > 0)
		{

			enableMousebtn = false;
		//	ActivePanelZatemnenie.SetActive(false);
			if (story.variablesState["garderob"].ToString() == "1")
			{
				ActivePanelZatemnenie.SetActive(true);
				Inknm = story.variablesState["Gven"].ToString();
			//	panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(1));
			/*	Vector3 point = cam.WorldToViewportPoint(transform.position);
				pers.transform.position = new Vector3(point.x-0.5f, point.y - 1.75f, pers.transform.position.z);

				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				garderobMenu.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;
				
				RemoveChildren();*/

			}
			else
			{

				/*for (int i = 0; i < story.currentChoices.Count; i++)
				{*/
				/*parentBtn = GameObject.FindGameObjectWithTag("TagPlashkaImgSay");
				
				Debug.Log(parentBtn.GetComponent<RectTransform>().rect.height);*/
				//
				//parentBtn.GetComponent<Transform>();
				StartCoroutine(startbtnChoise());
			//	parentBtn = GameObject.FindGameObjectWithTag("TagPlashkaImgSay");
				//StartCoroutine(AddbtnChoise());
					/*rectPanelWithText.localScale = new Vector2(1f, 1f);
					Choice choice = story.currentChoices[i];
					Button button = CreateChoiceView(choice.text.Trim());

					//	Debug.Log(choice.text.Trim());
					//	RectTransform uitransform = button.GetComponent<RectTransform>();
					//		Rect rectContainer = button.GetComponent<RectTransform>().rect;
					//rectContainer.height = 'the size you want';
					//	new Vector2(65, 0);
					//	uitransform.sizeDelta = new Vector2(, 0);
					//	Debug.Log(rectContainer.height);
				//	plashkaTxt = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>();
					//Debug.Log(plashkaTxt.GetComponent<RectTransform>().rect.height);

					//if (GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>())
                 //   {
						//plashkaTxt = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>();
						//	plashkaTxt.GetComponent<RectTransform>().rect.height = 361;
					//	Debug.Log("tag Plashka ");
					//}
					button.transform.position = new Vector2(0.3f, i - a - 1.4f);
					button.GetComponent<Image>().sprite = numberLevel[LVL].ButtonOtvet;

					a = a + 2.0f;
					boolTimer = false;
					// Tell the button what to do when we press it
					button.onClick.AddListener(delegate
					{
						OnClickChoiceButton(choice);
					});*/

				//}
			}


			if (story.variablesState["garderob"].ToString() == "2")
			{
				ActivePanelZatemnenie.SetActive(true);
				//panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(2));
				/*oldPricheska = int.Parse(story.variablesState["pricheska"].ToString());
				Vector3 point = cam.WorldToViewportPoint(transform.position);
				pers.transform.position = new Vector3(point.x - 0.5f, point.y - 1.75f, pers.transform.position.z);
				
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				garderobHairMenu.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;
			
				RemoveChildren();*/

			}

			if (story.variablesState["garderob"].ToString() == "3")
			{
				ActivePanelZatemnenie.SetActive(true);
				//panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(3));
			/*Vector3 point = cam.WorldToViewportPoint(transform.position);
				pers.transform.position = new Vector3(point.x - 0.5f, point.y - 1.75f, pers.transform.position.z);
				
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				garderobDressMenu.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;
			
				RemoveChildren();*/

			}

			if (story.variablesState["game0"].ToString() == "1")
			{
				
				//oldPricheska = int.Parse(story.variablesState["pricheska"].ToString());
				//Vector3 point = cam.WorldToViewportPoint(transform.position);
				//pers.transform.position = new Vector3(point.x - 0.5f, pers.transform.position.y, pers.transform.position.z);
				Debug.Log("game0: " + story.variablesState["game0"].ToString());
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));

				Game0.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;
				//personag.transform.position = new Vector2(personag.transform.position.x + 1.36f, personag.transform.position.y);
			//	StartCoroutine(ischeznoveniePlashky());
				RemoveChildren();

			}

			if (story.variablesState["showname"].ToString() == "1")
			{
				//inputName.text = story.variablesState["Gven"].ToString();
				ActivePanelZatemnenie.SetActive(true);
				//panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(4));
				/*Vector3 point = cam.WorldToViewportPoint(transform.position);
					pers.transform.position = new Vector3(point.x - 0.5f, point.y - 1.75f, pers.transform.position.z);

					spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
					spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
					spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
					spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
					garderobDressMenu.SetActive(true);
					enableMousebtn = false;
					boolTimer = false;

					RemoveChildren();*/

			}
			if (story.variablesState["Room"].ToString() == "1")
			{

				ActivePanelZatemnenie.SetActive(true);
				//panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(5));
				/*Vector3 point = cam.WorldToViewportPoint(transform.position);
					pers.transform.position = new Vector3(point.x - 0.5f, point.y - 1.75f, pers.transform.position.z);
				*/
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				/*garderobDressMenu.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;

				RemoveChildren();*/

			}
			//panelInputname

			/*else
			{
				for (int i = 0; i < story.currentChoices.Count; i++)
				{

					Choice choice = story.currentChoices[i];
					Button button = CreateChoiceView(choice.text.Trim());
					//	Debug.Log(choice.text.Trim());
					//	RectTransform uitransform = button.GetComponent<RectTransform>();
					//		Rect rectContainer = button.GetComponent<RectTransform>().rect;
					//rectContainer.height = 'the size you want';
					//	new Vector2(65, 0);
					//	uitransform.sizeDelta = new Vector2(, 0);
					//	Debug.Log(rectContainer.height);
					button.transform.position = new Vector2(0, i - a - 2.4f);

					a = a + 1.8f;
					// Tell the button what to do when we press it
					button.onClick.AddListener(delegate
					{
						OnClickChoiceButton(choice);
					});

				}
			}*/
		}
		// If we've read all the content and there's no choices, the story is finished!
		else
		{


			if (story.variablesState["garderob"].ToString() == "1")
			{

				ActivePanelZatemnenie.SetActive(true);
				//Inknm = story.variablesState["Gven"].ToString();
				//panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(1));
				/*Vector3 point = cam.WorldToViewportPoint(transform.position);
				pers.transform.position = new Vector3(point.x - 0.5f, point.y - 1.75f, pers.transform.position.z);
				
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				garderobMenu.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;
			
				RemoveChildren();*/
				
			}

			else
			{
				//enableMousebtn = true;
			//	Debug.Log(enableMousebtn);
				//ActivePanelZatemnenie.SetActive(true);

			}
			if (story.variablesState["garderob"].ToString() == "2")
			{
				ActivePanelZatemnenie.SetActive(true);
				//panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(2));
				/*Vector3 point = cam.WorldToViewportPoint(transform.position);
				pers.transform.position = new Vector3(point.x - 0.5f, point.y - 1.75f, pers.transform.position.z);
				
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				garderobHairMenu.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;
				
				RemoveChildren();*/

			}
			if (story.variablesState["garderob"].ToString() == "3")
			{
				
				ActivePanelZatemnenie.SetActive(true);
			//	panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(3));
				/*Vector3 point = cam.WorldToViewportPoint(transform.position);
				pers.transform.position = new Vector3(point.x - 0.5f, point.y - 1.75f, pers.transform.position.z);
				
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				garderobDressMenu.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;
				
				RemoveChildren();*/
				
			}
			if (story.variablesState["showname"].ToString() == "1")
			{
				
				ActivePanelZatemnenie.SetActive(true);
				//panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(4));
				/*Vector3 point = cam.WorldToViewportPoint(transform.position);
					pers.transform.position = new Vector3(point.x - 0.5f, point.y - 1.75f, pers.transform.position.z);
				*/
					spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
					spritePlayerHair.color = (new Color(255f, 255f, 255f,0f));
					spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
					/*garderobDressMenu.SetActive(true);
					enableMousebtn = false;
					boolTimer = false;

					RemoveChildren();*/

			}
			if (story.variablesState["Room"].ToString() == "1")
			{

				ActivePanelZatemnenie.SetActive(true);
				//panelZatemnenie.GetComponent<Animator>().enabled = true;
				StartCoroutine(showGarderoby(5));
				/*Vector3 point = cam.WorldToViewportPoint(transform.position);
					pers.transform.position = new Vector3(point.x - 0.5f, point.y - 1.75f, pers.transform.position.z);
				*/
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				/*garderobDressMenu.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;

				RemoveChildren();*/

			}
			if (story.variablesState["game0"].ToString() == "1")
			{
				//oldPricheska = int.Parse(story.variablesState["pricheska"].ToString());
				//Vector3 point = cam.WorldToViewportPoint(transform.position);
				//pers.transform.position = new Vector3(point.x - 0.5f, pers.transform.position.y, pers.transform.position.z);
				Debug.Log("game0: " + story.variablesState["game0"].ToString());
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				Game0.SetActive(true);
				enableMousebtn = false;
				boolTimer = false;
				//personag.transform.position = new Vector2(personag.transform.position.x + 1.36f, personag.transform.position.y);
				//StartCoroutine(ischeznoveniePlashky());

				RemoveChildren();

			}
			//else
			//{
			/*	enableMousebtn = true;
				ActivePanelZatemnenie.SetActive(true);*/

			//}
			/*if (story.canContinue)
			{
				//	RemoveChildren();

				string text = story.Continue();
				// This removes any white space from the text.
				//	text = text.Trim();
				// Display the text on screen!
				CreateContentView(text);
				//	

			}*/
			//	Button choice = CreateChoiceView("End of story.\nRestart?");
			//choice.onClick.AddListener(delegate {
			//	StartStory();
			//	});
		}
		/*	int childCount = panel.transform.childCount;
			if (childCount == 0)
			{
				Button choice = CreateChoiceView("End of story.\nRestart?");
				choice.onClick.AddListener(delegate {
					StartStory();
				});
			}*/

		//	Debug.Log("Child: " + panel.transform.childCount);
		
	}
	
	IEnumerator BackpersnewText()
    {
		yield return new WaitForSeconds(0.1f);
		//Debug.Log("Hide pers");
		if (story.variablesState["name"].ToString() != story.variablesState["Gven"].ToString() && story.variablesState["name"].ToString() != "Подсказка" && story.variablesState["name"].ToString() != "..." && numtest != 0)
		{
			//Debug.Log("PanelTXTBTN 1: " + numtest);
			//	PanelTXTBTN.runtimeAnimatorController = Resources.Load("Animator/PanelTXTBTN 2") as RuntimeAnimatorController;
			//PanelTXTBTN.enabled = true;
			if (story.variablesState["heightPers"].ToString() == "2")
			{
				FindeText.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1) 3") as RuntimeAnimatorController;

				FindeText.GetComponent<Animator>().enabled = true; ;
			}
			if (story.variablesState["heightPers"].ToString() == "0")
			{
				FindeText.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1) 1") as RuntimeAnimatorController;

				FindeText.GetComponent<Animator>().enabled = true;
			}
		}
		if (story.variablesState["name"].ToString() != story.variablesState["Gven"].ToString() && story.variablesState["name"].ToString() != "Подсказка" && story.variablesState["name"].ToString() != "..." && numtest == 0)
		{
			//Debug.Log("PanelTXTBTN 2: " + numtest);
			//PanelTXTBTN.runtimeAnimatorController = Resources.Load("Animator/PanelTXTBTN 2") as RuntimeAnimatorController;
			//PanelTXTBTN.enabled = true;

			if (story.variablesState["heightPers"].ToString() == "2")
			{
				FindeText.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1) 3") as RuntimeAnimatorController;

				FindeText.GetComponent<Animator>().enabled = true; ;
			}
			if (story.variablesState["heightPers"].ToString() == "0")
			{
				FindeText.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1) 1") as RuntimeAnimatorController;

				FindeText.GetComponent<Animator>().enabled = true;
			}
		/*	FindeText.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1) 1") as RuntimeAnimatorController;

			FindeText.GetComponent<Animator>().enabled = true;*/
		}
	if (story.variablesState["name"].ToString() == story.variablesState["Gven"].ToString() && story.variablesState["name"].ToString() != "Подсказка" && story.variablesState["name"].ToString() != "...")
		//	if (Inknm != story.variablesState["name"].ToString() && story.variablesState["name"].ToString() != "Подсказка" && story.variablesState["name"].ToString() != "...")
		{
			//Debug.Log("PanelTXTBTN 2: " + numtest);
			//PanelTXTBTN.runtimeAnimatorController = Resources.Load("Animator/PanelTXTBTN 1") as RuntimeAnimatorController;
			//	PanelTXTBTN.enabled = true;
			FindeText.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5) 1") as RuntimeAnimatorController;

			FindeText.GetComponent<Animator>().enabled = true;
		}

		if (story.variablesState["name"].ToString() == "Подсказка" || story.variablesState["name"].ToString() == "...")
		{
			//	Debug.Log("Poskazka");
			FindeText.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (3) 1") as RuntimeAnimatorController;
			//PanelTXTBTN.runtimeAnimatorController = Resources.Load("Animator/PanelTXTBTN 4") as RuntimeAnimatorController;
			//PanelTXTBTN.enabled = true;
			FindeText.GetComponent<Animator>().enabled = true;
		}



		StartCoroutine(startischeznoveniePlashky());
		//	StartCoroutine(ischeznoveniePlashky());
		StartCoroutine(ischeznoveniePersa());
	}
	IEnumerator showGarderoby(int numgard)
    {
		RemoveChildren();
		yield return new WaitForSeconds(1.2f);
		
		
		//Debug.Log("garderob3: " + story.variablesState["garderob"].ToString());
		
		if (numgard == 1)
		{
			canvas.sortingOrder = 4;
			garderobMenu.SetActive(true);
			//Vector3 point = cam.WorldToViewportPoint(transform.position);
			pers.transform.position = new Vector3(0, - 0.85f, 0);
			spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
			enableMousebtn = false;
			boolTimer = false;
		}
		if (numgard == 2)
		{
			canvas.sortingOrder = 4;
			garderobHairMenu.SetActive(true);
			//Vector3 point = cam.WorldToViewportPoint(transform.position);
				pers.transform.position = new Vector3(0, -0.80f, 0);
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
			StartCoroutine(showPersGarderob());
			enableMousebtn = false;
			boolTimer = false;
		}
		if (numgard == 3)
		{
			canvas.sortingOrder = 4;
			garderobDressMenu.SetActive(true);
			//	Vector3 point = cam.WorldToViewportPoint(transform.position);
				pers.transform.position = new Vector3(0, -0.8f, 0);
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
			StartCoroutine(showPersGarderob());
			enableMousebtn = false;
			boolTimer = false;
		}
		if (numgard == 4)
		{
			canvas.sortingOrder = 4;
			panelInputname.SetActive(true);
			spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
			spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
			spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
			spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
			inputName.text = story.variablesState["Gven"].ToString();

			StartCoroutine(hidePersName());
			enableMousebtn = false;
			boolTimer = false;
			Debug.Log("Name");
			//	Vector3 point = cam.WorldToViewportPoint(transform.position);
			//pers.transform.position = new Vector3(0, -0.85f, 0);
		}
		if (numgard == 5)
		{
			canvas.sortingOrder = 4;
			garderobRoom.SetActive(true);
			spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].spriteLevelLocation[8];
			raspolozhenieLocacii.transform.position = new Vector3(0f, 0f, 0f);
			spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
			spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
			spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
			spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
			inputName.text = story.variablesState["Gven"].ToString();
			enableMousebtn = false;
			boolTimer = false;
			//Debug.Log("Name");
			//	Vector3 point = cam.WorldToViewportPoint(transform.position);
			//pers.transform.position = new Vector3(0, -0.85f, 0);
		}


		//enableMousebtn = false;
		//boolTimer = false;
		pers.GetComponent<Animator>().GetComponent<Animator>().runtimeAnimatorController = null;
		//panelZatemnenie.GetComponent<Animator>().enabled = false;
		pers.GetComponent<Animator>().GetComponent<Animator>().enabled = false;
		/*spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
		spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
		spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));*/
		spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
		StartCoroutine(disableActivePanelZatembenie());

		/*Debug.Log(panelZatemnenie.GetComponent<Animator>().recorderStopTime);
		if (panelZatemnenie.GetComponent<Animator>().recorderStopTime == -1)
        {
			panelZatemnenie.GetComponent<Animator>().enabled = false;
		}*/
		//personag.transform.position = new Vector2(personag.transform.position.x + 1.36f, personag.transform.position.y);
		//	StartCoroutine(ischeznoveniePlashky());

	}

	IEnumerator showPersGarderob()
    {
		yield return new WaitForSeconds(0.1f);
		Debug.Log("Back Pers");
		pers.transform.position = new Vector3(0, -0.85f, 0);
		spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
		spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
		spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
		spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 1f));
	}

	IEnumerator hidePersName()
    {
		yield return new WaitForSeconds(0.1f);
		Debug.Log("Hide Pers");
		spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
		spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
		spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
		spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
	}
	IEnumerator disableActivePanelZatembenie()
    {
		yield return new WaitForSeconds(1.5f);
		canvas.sortingOrder = 3;
		ActivePanelZatemnenie.SetActive(false);
	}
	public float heightText;
	IEnumerator startbtnChoise()
    {
		yield return new WaitForSeconds(0.1f);
		parentBtn = GameObject.FindGameObjectWithTag("TagPlashkaImgSay");
		heightText = parentBtn.GetComponent<RectTransform>().rect.height;

		//Debug.Log(heightText);
		StartCoroutine(AddbtnChoise());
    }
	IEnumerator	AddbtnChoise()
    {
		
		for (int i = 0; i < story.currentChoices.Count; i++)
		{
			enableMousebtn = false;
			
			rectPanelWithText.localScale = new Vector2(1f, 1f);
			Choice choice = story.currentChoices[i];
			Button button = CreateChoiceView(choice.text.Trim());

			//	Debug.Log(choice.text.Trim());
			//	RectTransform uitransform = button.GetComponent<RectTransform>();
			//		Rect rectContainer = button.GetComponent<RectTransform>().rect;
			//rectContainer.height = 'the size you want';
			//	new Vector2(65, 0);
			//	uitransform.sizeDelta = new Vector2(, 0);
			//	Debug.Log(rectContainer.height);
			//	plashkaTxt = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>();
			//Debug.Log(plashkaTxt.GetComponent<RectTransform>().rect.height);

			//if (GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>())
			//   {
			//plashkaTxt = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>();
			//	plashkaTxt.GetComponent<RectTransform>().rect.height = 361;
			//	Debug.Log("tag Plashka ");
			//}
			//button.transform.parent = parentBtn.GetComponent<Transform>();

			if (heightText > 300 && heightText < 320)
			{
				button.transform.position = new Vector2(0.3f, i - a - 1.9f);
				button.GetComponent<Image>().sprite = numberLevel[LVL].ButtonOtvet;
			}
			if (heightText > 360 && heightText < 390)
			{
				button.transform.position = new Vector2(0.3f, i - a - 2.1f);
				button.GetComponent<Image>().sprite = numberLevel[LVL].ButtonOtvet;
			}
			if (heightText > 410 && heightText < 440)
			{
				button.transform.position = new Vector2(0.3f, i - a - 2.15f);
				button.GetComponent<Image>().sprite = numberLevel[LVL].ButtonOtvet;
			}
			if (heightText > 450 && heightText < 500)
			{
				button.transform.position = new Vector2(0.3f, i - a - 2.45f);
				button.GetComponent<Image>().sprite = numberLevel[LVL].ButtonOtvet;
			}
			a = a + 2.0f;
			boolTimer = false;

			/*if(i == story.currentChoices.Count - 1)
            {
				StartCoroutine(AfterbtnChoiseVkluchitmouse());
            }*/
			// Tell the button what to do when we press it
			button.onClick.AddListener(delegate
			{
				OnClickChoiceButton(choice);
			});

			
			yield return new WaitForSeconds(0.4f);
		}
		//parentBtn = GameObject.FindGameObjectWithTag("TagPlashkaImgSay");
		//parentBtn.GetComponent<Transform>();

		//Debug.Log(parentBtn.GetComponent<RectTransform>().rect.height);
		btnChoises = new GameObject[story.currentChoices.Count];
		//for(int j =0; j < story.currentChoices.Count; j++)
       // {
			btnChoises = GameObject.FindGameObjectsWithTag("BtnChoise");
		

		for (int j =0; j < story.currentChoices.Count; j++)
        {
			btnChoises[j].GetComponent<Button>().interactable = true;
		
		}

		
		//}
	}
	public GameObject parentBtn;

	// When we click the choice button, tell the story to choose that choice!
	void OnClickChoiceButton(Choice choice)
	{
		boolTimer = false;
		a = 0;
		//enableMousebtn = true;
		story.ChooseChoiceIndex(choice.index);

		//	a = story.variablesState["mudr"].ToString();
		//panelZatemnenie.GetComponent<Animator>().enabled = false;
		//Debug.Log("a:");
		for (int i = 0; i < btnChoises.Length; i++)
		{
			btnChoises[i].GetComponent<Animator>().runtimeAnimatorController = null;
			btnChoises[i].GetComponent<Button>().interactable = false;
		}


		parentBtn = null;

		StartCoroutine(startRefresh(choice));
	}
	public GameObject[] btnChoises;
	IEnumerator startRefresh(Choice choice)
    {
		
		
		
		yield return new WaitForSeconds(0.5f);

		for (int i = 0; i < btnChoises.Length; i++)
		{
			btnChoises[i].GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/BtnChoiseAnim/Button 1") as RuntimeAnimatorController;
			btnChoises[i].GetComponent<Animator>().enabled = true;


		}
	//	BackPers = 1;
		//StartCoroutine(ischeznoveniePersa());
		StartCoroutine(BackpersnewText());


	}
	

	IEnumerator startRefresh()
    {
		yield return new WaitForSeconds(2.5f);
		RefreshView();
	}
	// Creates a textbox showing the the line of text
	public int numLocation;
	public int prevnumLocation;

	public int numMusic;
	public int previousnumMusic;
	public int numMelody;
	public int previousMelody;
	public GameObject FireParticle;

	public GameObject raspolozhenieLocacii;
	public GameObject PanelExit;
	public int numberFace;
	void CreateContentView(string text)
	{
		
		/*if (story.variablesState["name"] == story.variablesState["Gven"])
		{
			Debug.Log(story.variablesState["name"]);
		}*/
		text = text.Remove(text.Length - 1);
		enableMousebtn = false;
		//	Debug.Log(story.variablesState);
		izmenenieekrana = 0;

		if(story.variablesState["Exit"].ToString() == "1")
        {
			PanelExit.SetActive(true);

		}

		numberLevel[LVL].emociiSprite.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].numberLevelEmocii[numberFace].emociiSpritefromServer[int.Parse(story.variablesState["emocii"].ToString())];
		//	modesty = int.Parse(story.variablesState["modesty"].ToString()); 
		//	bravery = int.Parse(story.variablesState["bravery"].ToString()); 
		//levkippalove = int.Parse(story.variablesState["levkippalove"].ToString()); 
		//levkippafriend = int.Parse(story.variablesState["levkippafriend"].ToString()) ;
		//admetlove = int.Parse(story.variablesState["admetlove"].ToString()); 
		//creation = int.Parse(story.variablesState["creation"].ToString());
		//destruction = int.Parse(story.variablesState["destruction"].ToString());
		//namewindow = story.variablesState["namewindow"].ToString();


		for (int j = 0; j < numberLevel[LVL].nameEn.Length; j++)
		{
			if (numberLevel[LVL].nameRu[j] == story.variablesState["name"].ToString())
			{
				//
				if(Inknm != story.variablesState["name"].ToString())
                {
					numberLevel[LVL].npcSprite.GetComponent<SpriteRenderer>().color = (new Color(255f, 255f, 255f, 0f));
				}
                else
                {
					numberLevel[LVL].npcSprite.GetComponent<SpriteRenderer>().color = (new Color(255f, 255f, 255f, 1f));
				}
				numberLevel[LVL].npcSprite.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].npcSpritefromServer[j];
				numberLevel[LVL].npcSprite.transform.localScale = new Vector2(0.34f, 0.34f);
				//numberLevel[0].npcSprite.transform.localScale = 
			}
           
		}
		//story.variablesState["name"] = "Mike";

		//txt.text = story.variablesState["name"].ToString();


		/*mudr = story.variablesState["mudr"].ToString();
		voin = story.variablesState["voin"].ToString();
		Jessi = story.variablesState["Jessi"].ToString();
		Jackman = story.variablesState["Jackman"].ToString();*/
		names = story.variablesState["name"].ToString();

		numLocation = int.Parse(story.variablesState["location"].ToString());
		numMusic = int.Parse(story.variablesState["music"].ToString());
		numMelody = int.Parse(story.variablesState["melodia"].ToString());

		if (story.variablesState["name"].ToString() == "window") {
		//	names = story.variablesState["name"].ToString();
			//story.variablesState["name"] = "Подсказка";
			Debug.Log("window");
			//StartCoroutine(IschezanieVsplivaushegoOkna());

			//Text storyText2 = Instantiate(textPrefab) as Text;
			//txt = GameObject.FindGameObjectWithTag("tagWhoSay").GetComponent<Text>();

			//storyText2.text = text;

			//storyText2.transform.SetParent(panel.transform, false);

			//StartCoroutine(tExtfind());
			//	string text2 = story.Continue();

			//CreateContentView(text2);

		
		}

		/*if (story.variablesState["name"].ToString() == "modesty + 1")
		{
			//story.variablesState["name"] = "Подсказка";
			Debug.Log("window");
			StartCoroutine(IschezanieVsplivaushegoOkna());
		}*/

		if (prevnumLocation != numLocation)
		{
			/*if(numLocation == 3)
            {
				FireParticle.SetActive(true);
			
				//particleS.startColor.r = 252;
			}
			else
            {
				FireParticle.SetActive(false);
			}*/

			/*if(numLocation == 8)
            {
				var main = particleS.main;
				main.startColor = new Color(252, 255, 0, 1f);
			}
			else
			{
				var main = particleS.main;
				main.startColor = new Color(255, 255, 255, 1f);
			}*/
			//
			ActivePanelZatemnenie.SetActive(true);
			ZapuskNewlocation = 0;
			StartCoroutine(ShowEkran());
			StartCoroutine(ShowEkran2(text));
			//	StartCoroutine(ZatemnenieEkrana(text));
			//	raspolozhenieLocacii.transform.position = new Vector3(float.Parse(story.variablesState["position"].ToString()), 0f, 0f);
		}
		else
		{
			if (story.variablesState["zatemnenie"].ToString() == "1")
			{
				canvas.sortingOrder = 5;
				ActivePanelZatemnenie.SetActive(true);
				StartCoroutine(ShowEkran2(text));
				//StartCoroutine(ZatemneniebezsmeniLocacii());
			}
			else if (story.variablesState["zatemnenie"].ToString() == "0")
			{
				spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].spriteLevelLocation[numLocation];
				//	StartCoroutine(TextSoryStart(text));

				TextMeshProUGUI storyText = Instantiate(textPrefab) as TextMeshProUGUI;


				storyText.text = text;

				storyText.transform.SetParent(panel.transform, false);
			}
		//	StartCoroutine(tExtfind());
		}

	
		if (previousnumMusic != numMusic)
		{
			for (int i = 0; i < 4; i++)
			{
				//	numberLevel[0].audioSource[numMusic].enabled = false;
				if (numMusic == i)
				{
					previousnumMusic = numMusic;
					
					numberLevel[LVL].audioSource[i].loop = true;
					numberLevel[LVL].audioSource[i].Play();
					StartCoroutine(Startmusic(i));
					
					//Debug.Log("Music: " + i + "---" + numMusic);

					//numberLevel[0].audioSource[i].enabled = true;
					//previousnumMusic = numMusic;
				}
				if (numMusic != i)
				{
					StartCoroutine(Stopmusic(i));
					
				}
			}

			//numberLevel[0].audioSource[numMusic].enabled = true;

		}


		if (previousMelody != numMelody)
		{
			for (int i = 0; i < 4; i++)
			{
				//	numberLevel[0].audioSource[numMusic].enabled = false;
				if (numMelody == i)
				{
					previousMelody = numMelody;
					numberLevel[0].melodySource[i].Play();
					StartCoroutine(Startmelody(i));

					//Debug.Log("Music: " + i + "---" + numMusic);

					//numberLevel[0].audioSource[i].enabled = true;
					//previousnumMusic = numMusic;
				}
				if (numMelody != i)
				{
					numberLevel[0].melodySource[i].Stop();
					StartCoroutine(Stopmelody(i));

				}
			}
			//numberLevel[0].audioSource[numMusic].enabled = true;

		}

	}

	IEnumerator ZatemneniebezsmeniLocacii()
    {
		yield return new WaitForSeconds(0.2f);
		txtInPlashka = GameObject.FindGameObjectWithTag("TagTextinPlashka").GetComponent<TextMeshProUGUI>();
		plashkaTxt = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>();
		plashkaWhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
		txt = GameObject.FindGameObjectWithTag("tagWhoSay").GetComponent<Text>();

		txtInPlashka.color = new Color(255f, 255f, 255f, 0);
		plashkaTxt.color = new Color(255f, 255f, 255f, 0);
		plashkaWhoSay.color = new Color(255f, 255f, 255f, 0);
		txt.color = new Color(255f, 255f, 255f, 0);
	}
	public void StartTextAfterMotanie(string text)
    {
		StartCoroutine(TextSoryStart(text));
		
	}
	IEnumerator TextSoryStart(string textStory)
    {
		yield return new WaitForSeconds(0.00001f);
		TextMeshProUGUI storyText = Instantiate(textPrefab) as TextMeshProUGUI;


		storyText.text = textStory;

		storyText.transform.SetParent(panel.transform, false);

		StartCoroutine(tExtfind());
	}

	IEnumerator IschezanieVsplivaushegoOkna()
	{
		yield return new WaitForSeconds(3f);

	//	RemoveChildren();
		//StartStory();
		if (story.canContinue)
		{

			string text = story.Continue();

			CreateContentView(text);

			
		}


//		RefreshView();
	}
	IEnumerator Startmusic(int num)
	{
		yield return new WaitForSeconds(0.001f);
		//numberLevel[0].audioSource[numMusic].enabled = false;
	//for (int i = 0; i < 14; i++)
	//	{
		

        if (numberLevel[LVL].audioSource[num].volume < 1)
        {
			numberLevel[LVL].audioSource[num].volume = numberLevel[LVL].audioSource[num].volume + 0.002f;

			StartCoroutine(Startmusic(num));
		}
		if (numberLevel[LVL].audioSource[num].volume >= 1)
		{
			numberLevel[LVL].audioSource[num].volume = 1f;
			//previousnumMusic = numMusic;
			StopCoroutine(Startmusic(num));
			
		}
		
		
	}
	IEnumerator Stopmusic(int num)
	{
		yield return new WaitForSeconds(0.001f);
		//numberLevel[0].audioSource[numMusic].Play();

		if (numberLevel[LVL].audioSource[num].volume >= 0.01)
		{
			numberLevel[LVL].audioSource[num].volume = numberLevel[LVL].audioSource[num].volume - 0.015f;

			StartCoroutine(Stopmusic(num));
		}
		if (numberLevel[LVL].audioSource[num].volume < 0.01)
		{
			numberLevel[LVL].audioSource[num].volume = 0f;
			numberLevel[LVL].audioSource[num].Stop();
			//previousnumMusic = numMusic;
			StopCoroutine(Stopmusic(num));

		}
	}


	IEnumerator Startmelody(int num)
	{
		yield return new WaitForSeconds(0.001f);
		//numberLevel[0].audioSource[numMusic].enabled = false;
		//for (int i = 0; i < 14; i++)
		//	{


		if (numberLevel[0].melodySource[num].volume < 1)
		{
			numberLevel[0].melodySource[num].volume = numberLevel[0].melodySource[num].volume + 0.002f;

			StartCoroutine(Startmelody(num));
		}
		if (numberLevel[0].melodySource[num].volume >= 1)
		{
			numberLevel[0].melodySource[num].volume = 1f;
			//previousnumMusic = numMusic;
			StopCoroutine(Startmelody(num));

		}


	}
	IEnumerator Stopmelody(int num)
	{
		yield return new WaitForSeconds(0.001f);
		//numberLevel[0].audioSource[numMusic].Play();

		if (numberLevel[0].melodySource[num].volume >= 0.01)
		{
			numberLevel[0].melodySource[num].volume = numberLevel[0].melodySource[num].volume - 0.003f;

			StartCoroutine(Stopmelody(num));
		}
		if (numberLevel[0].melodySource[num].volume < 0.01)
		{
			numberLevel[0].melodySource[num].volume = 0f;
			numberLevel[0].melodySource[num].Stop();
			//previousnumMusic = numMusic;
			StopCoroutine(Stopmelody(num));

		}
	}


	IEnumerator ZatemnenieEkrana(string text2)  //**********************Удалить
	{
		//enableMousebtn = false;
		yield return new WaitForSeconds(0.02f);

		if (izmenenieekrana >= 0 && izmenenieekrana < 1)
		{

			panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			izmenenieekrana = izmenenieekrana + 0.02f;
			StartCoroutine(ZatemnenieEkrana(text2));
		}
		else if (izmenenieekrana >= 1)
		{


			panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, 1f);
			//prevnumLocation = numLocation;

			/*prevnumLocation = numLocation;
		
			spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[0].spriteLevelLocation[numLocation];
		*/
			//StartCoroutine(ShowEkran(text2));


			//StopAllCoroutines();
			if (story.variablesState["motanieGolovoi"].ToString() == "0")
			{
				raspolozhenieLocacii.transform.position = new Vector3(float.Parse(story.variablesState["position"].ToString()), 0f, 0f);
			//	Debug.Log(raspolozhenieLocacii.transform.position);
				StartCoroutine(ShowEkran());
				StartCoroutine(ShowEkran2(text2));
				StopCoroutine(ZatemnenieEkrana(text2));
			}
			if (story.variablesState["motanieGolovoi"].ToString() != "0")
			{
				raspolozhenieLocacii.transform.position = new Vector3(float.Parse(story.variablesState["position"].ToString()), 0f, 0f);
			//	Debug.Log(raspolozhenieLocacii.transform.position);
				StartCoroutine(ShowEkran2(text2));
				StartCoroutine(ShowEkran());
				StopCoroutine(ZatemnenieEkrana(text2));

			}
		}
		
	}
	IEnumerator ShowEkran()
	{
		
		yield return new WaitForSeconds(0.7f);
		spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].spriteLevelLocation[numLocation];
		raspolozhenieLocacii.transform.position = new Vector3(float.Parse(story.variablesState["position"].ToString()), 0f, 0f);
		prevnumLocation = numLocation;
		/*spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].spriteLevelLocation[numLocation];


		if (izmenenieekrana > 0 && izmenenieekrana <= 1.5f)
		{

			panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			izmenenieekrana = izmenenieekrana - 0.02f;

		prevnumLocation = numLocation;

			StartCoroutine(ShowEkran());

		}
		else
		{
			panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
			
				//enableMousebtn = true;

			//Debug.Log("ShowEkran");
			//StopAllCoroutines();
			//	StartCoroutine(ShowEkran2(text3));
			ActivePanelZatemnenie.SetActive(false);
			
			StopCoroutine(ShowEkran());
		}*/

	}

	IEnumerator ShowEkran2(string text4)
	{
		yield return new WaitForSeconds(2.5f);
		ActivePanelZatemnenie.SetActive(false);
		story.variablesState["zatemnenie"] = 0;
		//StartCoroutine(TextSoryStart(text4));
		//	Debug.Log("Show Ekran");
		TextMeshProUGUI storyText = Instantiate(textPrefab) as TextMeshProUGUI;
			//txt = GameObject.FindGameObjectWithTag("tagWhoSay").GetComponent<Text>();

			storyText.text = text4;

				storyText.transform.SetParent(panel.transform, false);

			//ZapuskTextFind();
			//StartCoroutine(tExtfind());
		

	}

	public Image plashkaTxt;
	public Image plashkaWhoSay;
	//public Text txtInPlashka;
	public TextMeshProUGUI txtInPlashka;
	public RectTransform rectTxtInPlashka;
	public Text txtInPlashkaWindow;
	public string nameForZatuhanie;
	public RectTransform rectPanelWithText;
	public void ZapuskTextFind()
    {
		boolTimer = true;
		//StartCoroutine(ZapuskTimer());
		//Debug.Log("Show Ekran");
		//Debug.Log("Showwwwwwwwwwwwww");
		StartCoroutine(tExtfind());
	}

	public GameObject FindeText;
	public TextMeshProUGUI mainText;
	IEnumerator tExtfind()
    {
		
		//	Debug.Log("zapust tExtfind" + "garderob #: " + story.variablesState["garderob"].ToString());
		//***************Появление плашек с текстом
		yield return new WaitForSeconds(0.0022f);
		
		if (story.variablesState["garderob"].ToString() == "1" || story.variablesState["garderob"].ToString() == "2")
		{

		}
		else
		{

			//mainText = GameObject.FindGameObjectWithTag("Maintext").GetComponent<TextMeshProUGUI>();

			/*	if (story.variablesState["name"].ToString() == "")
				{
					txtInPlashkaWindow = GameObject.FindGameObjectWithTag("TagtxtInPlashkaWindow").GetComponent<Text>();
					txtInPlashkaWindow.color = new Color(255f, 255f, 255f, 0f);
					StartCoroutine(PoyavlenieplaskaImg());
				}*/
			//Debug.Log("Ne sushestvuet");
			//	rectPanelWithText = GameObject.FindGameObjectWithTag("PanelWithText").GetComponent<RectTransform>();
			//txt = GameObject.FindGameObjectWithTag("tagWhoSay").GetComponent<Text>();
			txtInPlashka = GameObject.FindGameObjectWithTag("TagTextinPlashka").GetComponent<TextMeshProUGUI>();
			/*plashkaTxt = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>();
			plashkaWhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
			txt = GameObject.FindGameObjectWithTag("tagWhoSay").GetComponent<Text>();*/

			//	txt.text = story.variablesState["name"].ToString();
			/*   if (txt.text.Contains("nimfa"))
			   {
				   txt.text = "Левкиппа";

			   }*/
			plashkaTxt = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>();
			plashkaWhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
			rectTxtInPlashka = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<RectTransform>();
			FindeText = GameObject.FindGameObjectWithTag("TagPlashkaImgSay");//.GetComponent<Animator>();
			//	if (nameForZatuhanie != story.variablesState["name"].ToString())
			//{

			//Debug.Log(PanelWithText.transform.Find("Button(Clone)"));
			if (PanelWithText.transform.Find("Button(Clone)"))
            {
				mainText = GameObject.FindGameObjectWithTag("Maintext").GetComponent<TextMeshProUGUI>();
				mainText.text = mainText.text + "\n" + "\n";
				//	txt = GameObject.FindGameObjectWithTag("tagWhoSay").GetComponent<Text>();
				txtInPlashka = GameObject.FindGameObjectWithTag("TagTextinPlashka").GetComponent<TextMeshProUGUI>();
			//	txt.text = story.variablesState["name"].ToString();
				plashkaTxt = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<Image>();
				plashkaWhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
				rectTxtInPlashka = GameObject.FindGameObjectWithTag("TagPlashkaImgSay").GetComponent<RectTransform>();
				//	Debug.Log(rectTxtInPlashka.sizeDelta);
				rectTxtInPlashka.sizeDelta = new Vector2(rectTxtInPlashka.sizeDelta.x, 300);
			}
				
				//txt.color = new Color(numberLevel[LVL].red, numberLevel[LVL].green, numberLevel[LVL].blue, 0f);
				//txtInPlashka.color = new Color(numberLevel[LVL].red, numberLevel[LVL].green, numberLevel[LVL].blue, 0f);
			izmeneniePalshky = 0;
			//	StartCoroutine(PoyavlenieplaskaImg());

		//	}
         //  else
           // {
		
			//	plashkaTxt.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
			//	plashkaWhoSay.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
			//	txt.color = new Color(255f, 255f, 255f, 1f);
			//	txtInPlashka.color = new Color(0f, 0f, 0f, 1f);
				
			//}
			
		}
	}
	public float izmeneniePalshky;
	public float izmenenieScalePanelwithText;



	IEnumerator PoyavlenieplaskaImg()
	{
		yield return new WaitForSeconds(0.000001f);
	
		if (izmeneniePalshky < 1)
			{

		/*	if(txtInPlashkaWindow != null)
            {
				txtInPlashkaWindow.color = new Color(255f, 255f, 255f, izmeneniePalshky);
				izmeneniePalshky = izmeneniePalshky + 0.03f;
				StartCoroutine(PoyavlenieplaskaImg());
			}*/
				plashkaTxt.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmeneniePalshky);
				plashkaWhoSay.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmeneniePalshky);
				txt.color = new Color(255f, 255f, 255f, izmeneniePalshky);
				txtInPlashka.color = new Color(numberLevel[LVL].red, numberLevel[LVL].green, numberLevel[LVL].blue, izmeneniePalshky);
			
			//rectPanelWithText.localScale = new Vector2(izmenenieScalePanelwithText, izmenenieScalePanelwithText );
			//Debug.Log("Rect");
			
			//PanelWithText.GetComponent<RectTransform>().transform.localScale.x = 0.5f;

			izmeneniePalshky = izmeneniePalshky + 0.15f;// было 0.1
			//izmenenieScalePanelwithText = izmenenieScalePanelwithText + 0.25f;
			//if(izmenenieScalePanelwithText > 0.9f)
           // {
			//	izmenenieScalePanelwithText = 1;

			//}
		//	izmenenieScalePanelwithText = izmenenieScalePanelwithText + 0.06f;
			StartCoroutine(PoyavlenieplaskaImg());
		//	rectPanelWithText.anchorMin = new Vector2(1, 0.5f);
		//	rectPanelWithText.anchorMax = new Vector2(1, 0.5f);

		}
			else
			{
			/*if (txtInPlashkaWindow != null)
			{
				txtInPlashkaWindow.color = new Color(255f, 255f, 255f, 1f);
				//izmeneniePalshky = izmeneniePalshky + 0.03f;
				//StartCoroutine(PoyavlenieplaskaImg());
			}*/

			izmeneniePalshky = 1;
			izmenenieScalePanelwithText = 0;
			plashkaTxt.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
				plashkaWhoSay.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
				txt.color = new Color(255f, 255f, 255f, 1f);
				txtInPlashka.color = new Color(numberLevel[LVL].red, numberLevel[LVL].green, numberLevel[LVL].blue, 1f);

			//rectPanelWithText.localScale = new Vector2(1, 1);
			nameForZatuhanie = story.variablesState["name"].ToString();
			//enableMousebtn = true;
			StopCoroutine(PoyavlenieplaskaImg());
			}
		
       
	}

	public float izmeneniePalshky2;
	public float izmenenieScalePanelwithText2;

	public int BackPers;
	public int proverkaBackPers;
	public Animator PanelTXTBTN;
	public void DostupKischeznoveniuPersa()
    {
		StartCoroutine(ischeznoveniePersa());
    }
	IEnumerator ischeznoveniePersa()
    {
		
		yield return new WaitForSeconds(0.1f);

	//	Debug.Log("Pers: " + BackPers + "     persongae polozhenie: " + story.variablesState["personagest"].ToString()  + "   numtest: " + numtest);
	if(story.variablesState["whonext"].ToString() == "1")
		//if(BackPers == 1)
	//	if(story.variablesState["Gven"].ToString() != story.variablesState["whonext"].ToString() && story.variablesState["name"].ToString() != story.variablesState["Gven"].ToString())
		{
	//		Debug.Log(BackPers + " Gven " + proverkaBackPers);
			pers.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 3") as RuntimeAnimatorController;
			pers.GetComponent<Animator>().enabled = true;

		}
		if (story.variablesState["whonext"].ToString() == "2")
			//if (BackPers == 2)
		//	if (story.variablesState["name"].ToString() != story.variablesState["whonext"].ToString() && (story.variablesState["Gven"].ToString() != story.variablesState["whonext"].ToString()))
		//	{
				{
			//Debug.Log(BackPers + " ---- " + proverkaBackPers);
			pers.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 4") as RuntimeAnimatorController;
			pers.GetComponent<Animator>().enabled = true;
		}
		if (story.variablesState["whonext"].ToString() == "3")
		//	if (BackPers == 3)
		{
			//Debug.Log(BackPers + " ---- " + proverkaBackPers);
			pers.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 5") as RuntimeAnimatorController;
			pers.GetComponent<Animator>().enabled = true;
		}
		if (story.variablesState["whonext"].ToString() == "0")
		//	if (BackPers == 0)
        {

			//Debug.Log(BackPers + " ---- " + proverkaBackPers);
		}
		

	}
	
	IEnumerator startischeznoveniePlashky()
    {
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(startNextText());
		//StartCoroutine(ischeznoveniePlashky());
		//
		//PanelTXTBTN.enabled = false;
	}
	IEnumerator ischeznoveniePlashky()
	{
		
		yield return new WaitForSeconds(0.000001f);
		
		if (izmeneniePalshky2 > 0)
		{
			//if (PanelWithText.transform.Find("Button(Clone)") || PanelWithText.transform.Find("Text(Clone)"))
			//{
				//Debug.Log(izmeneniePalshky2);
				plashkaTxt.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmeneniePalshky2);
				plashkaWhoSay.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmeneniePalshky2);
				txt.color = new Color(255f, 255f, 255f, izmeneniePalshky2);
				txtInPlashka.color = new Color(numberLevel[LVL].red, numberLevel[LVL].green, numberLevel[LVL].blue, izmeneniePalshky2);

					//rectPanelWithText.localScale = new Vector2(izmenenieScalePanelwithText2, izmenenieScalePanelwithText2);
				izmeneniePalshky2 = izmeneniePalshky2 - 0.15f;
				//	izmenenieScalePanelwithText2 = izmenenieScalePanelwithText2 - 0.05f;

				///if (izmenenieScalePanelwithText2 < 0.1f)
			//	{
				//	izmenenieScalePanelwithText2 = 0;

				//}
				StartCoroutine(ischeznoveniePlashky());
			//}
			//else 
			//{
			//	PanelTXTBTN.runtimeAnimatorController = null;
				//PanelTXTBTN.enabled = true;
			//	Newtext();
			//	StopCoroutine(ischeznoveniePlashky());
			//}

		}
		else
		{
			//izmenenieScalePanelwithText2 = 1;
			izmeneniePalshky2 = 0;
			plashkaTxt.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
			plashkaWhoSay.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
			txt.color = new Color(255f, 255f, 255f, 0f);
			txtInPlashka.color = new Color(numberLevel[LVL].red, numberLevel[LVL].green, numberLevel[LVL].blue, 0f);
	//	rectPanelWithText.localScale = new Vector2(0, 0);
			nameForZatuhanie = story.variablesState["name"].ToString();
			//Remov();
			//StopAllCoroutines();
			//RemoveChildren();
			

			//Newtext();
			StartCoroutine(startNextText());
			StopCoroutine(ischeznoveniePlashky());
		}

	}

	IEnumerator startNextText()
    {
		yield return new WaitForSeconds(0.1f);
		//izmeneniePalshky2 = 0;=
		FindeText.GetComponent<Animator>().runtimeAnimatorController = null;
		//PanelTXTBTN.runtimeAnimatorController = null;
		izmeneniePalshky2 = 1;
		Newtext();

	}

	public void Newtext()
    {
		//Debug.Log("sasasas");
		
		if (story.currentChoices.Count == 0)
		{

			RemoveChildren();
		}


		if (story.canContinue)
		{


			string text = story.Continue();

			CreateContentView(text);
						
		
			//	

		}
		else
		{

		}

		RefreshView(); 

	}
	/* private void Remov()
	 {
		 int childCount = panel.transform.childCount;

		 for (int i = 0; i < childCount; i++)
		 //	for (int i = childCount-2; i >= 0; --i)
		 {
			 GameObject.Destroy(panel.transform.GetChild(i).gameObject);
		 }
		 txt = null;

	 }*/

	//public Image btnGarderob;
	public GameObject PanelWithText;
	public bool npcBool;
	public bool playerBool;
	public float predidusheeZnachenie;
	public Camera Camera;
	//public Vector3 point;

	//public void OpenGarderob()
	///{
	//	StartCoroutine(garderobishe());

		//yield return new WaitForSeconds(0.5f);
   // }
	public void OpenGarderob()
	//IEnumerator garderobishe()
	{
		//yield return new WaitForSeconds(0.5f);
		//{
		//Debug.Log(point);
		//public Sprite[] spriteGarderob;
		if (btnGarderob.GetComponent<Image>().sprite ==  numberLevel[LVL].btnGarderobOn)
		{
			//Vector3 point = cam.WorldToViewportPoint(transform.position);

			//pers.transform.position = new Vector3(point.x - 0.5f, pers.transform.position.y, pers.transform.position.z);
			//pers.transform.position = new Vector3(1.4f, 0f, 0f);
			//enableMousebtn = false;
			btnGarderob.GetComponent<Image>().sprite =  numberLevel[LVL].btnGarderobOff;

			/*	if (pers.transform.position == new Vector3(0f, -0.85f, 0f))
				{
					pers.transform.position = new Vector3(0f, -0.85f, 0f);
					predidusheeZnachenie = 0f;

				}
				if (pers.transform.position == new Vector3(1.4f, -0.85f, 0f))
				{
					pers.transform.position = new Vector3(1.4f - 1.4f, -0.85f, 0f);
					predidusheeZnachenie = 1.4f;
				}
				if (pers.transform.position == new Vector3(-1.4f, -0.85f, 0f))
				{


					pers.transform.position = new Vector3(-1.4f + 1.4f, -0.85f, 0f);
					predidusheeZnachenie = -1.4f;
				}*/
			//Vector3 point = Camera.ViewportToWorldPoint(new Vector3(.1f, .4f, .5f));

			//if (pers.transform.position == Camera.ViewportToWorldPoint(new Vector3(.5f, .4f, .5f)))
		/*	if (pers.transform.position == new Vector3(0f, -1f, 0))
			{
			//	pers.transform.position = Camera.ViewportToWorldPoint(new Vector3(.5f, .4f, .5f));
				//point = Camera.ViewportToWorldPoint(new Vector3(.5f, .4f, .5f));
				Debug.Log("Pers 0.5");
				//	predidusheeZnachenie = 0f;

			}
			if (pers.transform.position == new Vector3(1.35f, -1f, 0))
			//	if (pers.transform.position == Camera.ViewportToWorldPoint(new Vector3(.8f, .4f, .5f)))
			{
				Debug.Log("Pers 0.8");
				//pers.transform.position = Camera.ViewportToWorldPoint(new Vector3(.5f, .4f, .5f));
				//point = Camera.ViewportToWorldPoint(new Vector3(.8f, .4f, .5f));
				//predidusheeZnachenie = 1.4f;
			}
			 if (pers.transform.position == new Vector3(-1.35f, -1f, 0))
			//	if (pers.transform.position == Camera.ViewportToWorldPoint(new Vector3(.2f, .4f, .5f)))
			{


				//pers.transform.position = Camera.ViewportToWorldPoint(new Vector3(.5f, .4f, .5f));
				//point = Camera.ViewportToWorldPoint(new Vector3(.2f, .4f, .5f));
				Debug.Log("Pers 0.2");
			//	predidusheeZnachenie = -1.4f;
			}*/

			pers.transform.position = new Vector3(0f, -1f, 0);
			//pers.transform.position = Camera.ViewportToWorldPoint(new Vector3(.5f, .4f, .5f));
			/*if(spritePlayer.color == (new Color(255f, 255f, 255f, 0f)))
            {
				playerBool = false;
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
			}
            else
            {
				playerBool = true;
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
			}
				*/

			//	spriteNPC.color = (new Color(255f, 255f, 255f, 0f));

			if (story.variablesState["name"].ToString() == story.variablesState["Gven"].ToString())
			{
				pers.GetComponent<Animator>().GetComponent<Animator>().runtimeAnimatorController = null;
				pers.transform.position = new Vector3(0f, -1f, 0);
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				canvas.sortingOrder = -2;
				//	spritePlayer.sortingLayerID = 4;
				//	spritePlayerHair.sortingLayerID = 7;
				//	spritePlayerDress.sortingLayerID = 5;
				//	spritePlayer.GetComponent<SpriteRenderer>().sortingOrder = 2;
				Debug.Log(npcBool);

			}
			else
            {
				if (spriteNPC.color.a == 0)
				{
					npcBool = false;
					pers.GetComponent<Animator>().GetComponent<Animator>().runtimeAnimatorController = null;
					pers.transform.position = new Vector3(0f, -1f, 0);
					spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
					spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
					spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
					spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
					spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
					canvas.sortingOrder = -2;
					Debug.Log(npcBool + "   " + spriteNPC.color.a);
					//spritePlayer.GetComponent<SpriteRenderer>().sortingLayerID = 4;
					//spritePlayerHair.sortingLayerID = 7;
					//spritePlayerDress.sortingLayerID = 5;
					//pers.transform.position = new Vector3(-1.4f , -0.85f, 0f);
				}
				else 
				
					{
					npcBool = true;
					pers.GetComponent<Animator>().GetComponent<Animator>().runtimeAnimatorController = null;
					pers.transform.position = new Vector3(0f, -1f, 0);
					spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
					spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
					spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
					spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
					spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
					canvas.sortingOrder = -2;
					Debug.Log(npcBool + "   " + spriteNPC.color.a);
					//spritePlayer.sortingLayerID = 4;
					//spritePlayerHair.sortingLayerID = 7;
					//spritePlayerDress.sortingLayerID = 5;
					//	pers.transform.position = new Vector3(predidusheeZnachenie, -0.85f, 0f);
				}

			}
		
			//PanelWithText.SetActive(false);
			garderobGame.SetActive(true);
			//garderobMenu.SetActive(true);
			//garderobHairMenu.SetActive(false);
		
		}
		else if (btnGarderob.GetComponent<Image>().sprite ==  numberLevel[LVL].btnGarderobOff)
		{
			//Vector3 point = cam.WorldToViewportPoint(transform.position);
			
			
			btnGarderob.GetComponent<Image>().sprite = numberLevel[LVL].btnGarderobOn;
			if (story.variablesState["name"].ToString() == story.variablesState["Gven"].ToString())
			{
				Debug.Log("Pers Gven");
				//pers.transform.position = new Vector3(personazhy.transform.position.x, personazhy.transform.position.y, personazhy.transform.position.z);
				spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 1f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				canvas.sortingOrder = 4;
				//spritePlayer.sortingLayerID = 0;
				////spritePlayerHair.sortingLayerID = 3;
				//spritePlayerDress.sortingLayerID = 1;
				pers.transform.position = new Vector3(-1.35f, -1f, 0f);

			}
			else {
				if (npcBool)
				{
					Debug.Log("Pers npc bool");
					spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
					spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
					spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
					spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
					spriteNPC.color = (new Color(255f, 255f, 255f, 1f));
					canvas.sortingOrder = 4;
					//	spritePlayer.sortingLayerID = 0;
					//	spritePlayerHair.sortingLayerID = 3;
					//spritePlayerDress.sortingLayerID = 1;
					pers.transform.position = new Vector3(1.35f, -1f, 0f);
					npcBool = false;
				}
				else
				{
					Debug.Log("Pers no npc bool");
					spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
					spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
					spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
					spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
					spriteNPC.color = (new Color(255f, 255f, 255f, 1f));
					canvas.sortingOrder = 4;
					//spritePlayer.sortingLayerID = 0;
					//	spritePlayerHair.sortingLayerID = 3;
					//spritePlayerDress.sortingLayerID = 1;
					pers.transform.position = new Vector3(1.35f, -1f, 0f);
					npcBool = false;

				}

			}
			bgGarderob.SetActive(false);
			//PanelWithText.SetActive(true);
			garderobGame.SetActive(false);
			//garderobMenu.SetActive(false);
			garderobHairMenu.SetActive(false);
			StartCoroutine(ShowEkranGarderob());
			StartCoroutine(VklenableMousebtn());
		}

	}
	public GameObject personazhy;
	public GameObject bgGarderob;
	public GameObject PanelMainEkran;
	public GameObject garderobGame;

	IEnumerator VklenableMousebtn()
    {
		yield return new WaitForSeconds(0.001f);
		enableMousebtn = true;
		
	}

	public void ZatemneniePriGarderobe()
    {
		//enableMousebtn = false;
		//	panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, 1f);

		ActivePanelZatemnenie.SetActive(true);
		canvas.sortingOrder = 5;
		StartCoroutine(ZatemnenieEkranaGarderob());
		StartCoroutine(disactivZatemnenie());
		enableMousebtn = false;
	}

	IEnumerator disactivZatemnenie()
    {
		yield return new WaitForSeconds(2.2f);
		ActivePanelZatemnenie.SetActive(false);
	}
	IEnumerator ZatemnenieEkranaGarderob()
	{
		//Debug.Log("Zatemnenie");
		//ActivePanelZatemnenie.SetActive(true);
		//enableMousebtn = false;
		yield return new WaitForSeconds(0.5f);

		/*if (izmenenieekrana >= -0.5f && izmenenieekrana < 1)
		{
			PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			//panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			izmenenieekrana = izmenenieekrana + 0.02f;
			StartCoroutine(ZatemnenieEkranaGarderob());
		}
		else if (izmenenieekrana >= 1)
		{*/
		canvas.sortingOrder = 4;
		
		//PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
		//	panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, 1f);
			bgGarderob.SetActive(true);
			
			OpenGarderob();

			
			//prevnumLocation = numLocation;

			/*prevnumLocation = numLocation;
		
			spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[0].spriteLevelLocation[numLocation];
		*/
			//StartCoroutine(ShowEkran(text2));


			//StopAllCoroutines();
			//StartCoroutine(ShowEkran());
			//StartCoroutine(ShowEkran2(text2));
		//	StartCoroutine(ShowEkranGarderob());
			StopCoroutine(ZatemnenieEkranaGarderob());

		//}


	}
	public void ShowEkaranZatuhanie()
    {
		StartCoroutine(ShowEkranGarderob());
    }
	IEnumerator ShowEkranGarderob()
	{
		//Debug.Log("Show ekran");
		yield return new WaitForSeconds(0.01f);

		spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].spriteLevelLocation[numLocation];


		if (izmenenieekrana > 0 && izmenenieekrana <= 1.5f)
		{
			PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
		//	panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			izmenenieekrana = izmenenieekrana - 0.02f;

			prevnumLocation = numLocation;

			StartCoroutine(ShowEkranGarderob());

		}
		else
		{
			PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			izmenenieekrana = 0;
			//panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);

		//	ExitgarderobGame();
			//ActivePanelZatemnenie.SetActive(false);

			StopCoroutine(ShowEkranGarderob());
		}

	}
	public void Exitgarderob()
    {
		StartCoroutine(extitGardCouratina());
		//btnGarderob.GetComponent<Image>().sprite = spriteGarderob[0];
		

	}

	public void Exitgarderob2()
	{
		StartCoroutine(extitGardCouratina2());
		//btnGarderob.GetComponent<Image>().sprite = spriteGarderob[0];


	}

	IEnumerator extitGardCouratina2()
	{
		yield return new WaitForSeconds(0.5f);


	/*	if (Inknm == story.variablesState["Gven"].ToString())
		{
			//pers.transform.position = new Vector3(personazhy.transform.position.x, personazhy.transform.position.y, personazhy.transform.position.z);
			spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
			spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
			pers.transform.position = new Vector3(-1.35f, -0.85f, 0f);
			Debug.Log("proverka" + predidusheeZnachenie);

		}
		else
		{
			if (npcBool)
			{
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 1f));
				pers.transform.position = new Vector3(predidusheeZnachenie, -0.85f, 0f);
				npcBool = false;
			}
			else
			{
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				pers.transform.position = new Vector3(predidusheeZnachenie, -0.85f, 0f);
				npcBool = false;

			}
		}*/
		//Debug.Log("Vkluchit ekran");
		//btnGarderob.GetComponent<Image>().sprite = numberLevel[LVL].btnGarderobOn;
		//bgGarderob.SetActive(false);
		//garderobMenu.SetActive(false);
		//garderobHairMenu.SetActive(false);
		//garderobDressMenu.SetActive(false);
		garderobRoom.SetActive(false);
		//spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].spriteLevelLocation[numLocation];
		//story.variablesState["garderob"] = 0;
		story.variablesState["Room"] = 0;
		PanelWithText.SetActive(true);
		canvas.sortingOrder = 4;
		//StartCoroutine(VklenableMousebtn());
		enableMousebtn = true;
		Newtext();
		//StartCoroutine(ischeznoveniePlashky());
		//Input.GetMouseButtonUp(0);
		//StartCoroutine(VklenableMousebtn());
	}
	public Canvas canvas;
	IEnumerator extitGardCouratina()
    {
		yield return new WaitForSeconds(0.5f);
		

		if (Inknm == story.variablesState["Gven"].ToString())
		{
			//pers.transform.position = new Vector3(personazhy.transform.position.x, personazhy.transform.position.y, personazhy.transform.position.z);
			spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 1f));
			spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
			pers.transform.position = new Vector3(-1.4f, -1f, 0f);
			Debug.Log("proverka" + predidusheeZnachenie);

		}
		else
		{
			if (npcBool)
			{
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 1f));
				pers.transform.position = new Vector3(1.4f, -1f, 0f);
				npcBool = false;
			}
			else
			{
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				pers.transform.position = new Vector3(1.4f, -1f, 0f);
				npcBool = false;

			}
		}
	//Debug.Log("Vkluchit ekran");
		btnGarderob.GetComponent<Image>().sprite = numberLevel[LVL].btnGarderobOn;
		bgGarderob.SetActive(false);
		garderobMenu.SetActive(false);
		garderobHairMenu.SetActive(false);
		garderobDressMenu.SetActive(false);
		garderobRoom.SetActive(false);
		spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[LVL].spriteLevelLocation[numLocation];
		story.variablesState["garderob"] = 0;
		story.variablesState["Room"] = 0;
		//PanelWithText.SetActive(true);
		canvas.sortingOrder = 4;
		//StartCoroutine(VklenableMousebtn());
		enableMousebtn = true;
		Newtext();
		//StartCoroutine(ischeznoveniePlashky());
		//Input.GetMouseButtonUp(0);
		StartCoroutine(VklenableMousebtn());
	}

	/*public void ExitgarderobGame()
	{
		
		if (story.variablesState["name"].ToString() == story.variablesState["Gven"].ToString())
		{
			pers.transform.position = new Vector3(-1.4f, -1f, 0f);
			Debug.Log(pers.transform.position);
		}
		else
		{
			if (npcBool)
			{
			
				pers.transform.position = new Vector3(1.4f, -1f, 0f);
			
			}
			else
			{
			
				pers.transform.position = new Vector3(1.4f, -1f, 0f);
			
			}
		}
		StartCoroutine(proverkaplozheniy());
	}*/
	public void ExitgarderobGame()
		//IEnumerator proverkaplozheniy()
	{
		//yield return new WaitForSeconds(0.2f);

		//btnGarderob.GetComponent<Image>().sprite = spriteGarderob[0];
		if (story.variablesState["name"].ToString() == story.variablesState["Gven"].ToString())
		{
			
			//pers.transform.position = new Vector3(personazhy.transform.position.x, personazhy.transform.position.y, personazhy.transform.position.z);
		/*	spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
			spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 1f));*/
			spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
			//pers.transform.position = point;
			pers.GetComponent<Animator>().GetComponent<Animator>().runtimeAnimatorController = null;
			pers.transform.position = new Vector3(-1.4f, -1f, 0f);
			Debug.Log(pers.transform.position);
			npcBool = false;
			canvas.sortingOrder = 4;
		}
		else
		{
			if (npcBool)
			{
				Debug.Log("Npc Bool");
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 1f));
			//	pers.transform.position = point;
				pers.transform.position = new Vector3(1.35f, -1f, 0f);
				Debug.Log(pers.transform.position);
				npcBool = false;
				canvas.sortingOrder = 4;
			}
			else
			{
				Debug.Log("Npc no Bool"  );
				spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
				spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
				spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
				
				//pers.transform.position = point;
					pers.transform.position = new Vector3(1.35f, -1f, 0f);
				Debug.Log(pers.transform.position);
				npcBool = false;
				canvas.sortingOrder = 4;
			}
		}
		
		btnGarderob.GetComponent<Image>().sprite = numberLevel[LVL].btnGarderobOn;
		//bgGarderob.SetActive(false);
		garderobGame.SetActive(false);

		//garderobMenu.SetActive(false);
		//garderobHairMenu.SetActive(false);
		story.variablesState["garderob"] = 0;
		//	PanelWithText.SetActive(true);

		if (PanelWithText.transform.Find("Button(Clone)"))
		{
		}
		else
		{
		//	enableMousebtn = true;
			StartCoroutine(VklenableMousebtn());
		}

	}

	public GameObject particlAfterGarderob;

	public void garderobMain2()
	{
		ActivePanelZatemnenie.SetActive(true);

		//panelZatemnenie.GetComponent<Animator>().enabled = true;

		StartCoroutine(HideGarderobMain2());
		//StartCoroutine(hideGven());
	}
	IEnumerator HideGarderobMain2()
	{

		yield return new WaitForSeconds(1f);

		/*	if (izmenenieekrana >= -0.5f && izmenenieekrana < 1)
			{
				//PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
				//panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
				izmenenieekrana = izmenenieekrana + 0.02f;
				StartCoroutine(HideGarderobMain());
			}
			else if (izmenenieekrana >= 1)
			{
				//Debug.Log(point);

				//PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, 1f);
				izmenenieekrana = 1;
				//bgGarderob.SetActive(false);
				//OpenGarderob();

				//ExitgarderobGame();
				//ExitgarderobGame();
		*/


		Exitgarderob2();
		//StartCoroutine(ShowGarderobMain());
		//StopCoroutine(HideGarderobMain());

		//}
	}
	public void garderobMain()
    {
		ActivePanelZatemnenie.SetActive(true);
		
		//panelZatemnenie.GetComponent<Animator>().enabled = true;

		StartCoroutine(HideGarderobMain());
		StartCoroutine(hideGven());
	}
	IEnumerator hideGven()
    {
		yield return new WaitForSeconds(0.3f);
		pers.GetComponent<Animator>().GetComponent<Animator>().runtimeAnimatorController = null;
		spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
		spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
		spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
		spritePlayerEmicii.color = (new Color(255f, 255f, 255f, 0f));
	}
	IEnumerator HideGarderobMain()
    {
		
		yield return new WaitForSeconds(1f);
		
		/*	if (izmenenieekrana >= -0.5f && izmenenieekrana < 1)
			{
				//PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
				//panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
				izmenenieekrana = izmenenieekrana + 0.02f;
				StartCoroutine(HideGarderobMain());
			}
			else if (izmenenieekrana >= 1)
			{
				//Debug.Log(point);

				//PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, 1f);
				izmenenieekrana = 1;
				//bgGarderob.SetActive(false);
				//OpenGarderob();

				//ExitgarderobGame();
				//ExitgarderobGame();
		*/


		Exitgarderob();
			StartCoroutine(ShowGarderobMain());
			//StopCoroutine(HideGarderobMain());

		//}
	}

	IEnumerator ShowGarderobMain()
    {
		yield return new WaitForSeconds(1.5f);
		//	Debug.Log("ShowEkranGarderobGame");
		//if (izmenenieekrana > 0.01)
		//{
		//PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
		//panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
		//izmenenieekrana = izmenenieekrana - 0.02f;
		//StartCoroutine(ShowGarderobMain());
		//}
		////else if (izmenenieekrana <= 0.01)
		//{

		//PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
		//izmenenieekrana = 0;
		//bgGarderob.SetActive(false);
		//OpenGarderob();
		//ExitgarderobGame();
		//ExitgarderobGame();
		//StartCoroutine(ShowEkranGarderob());
		//Debug.Log("Vikluchit anim");
		ActivePanelZatemnenie.SetActive(false);
		//panelZatemnenie.GetComponent<Animator>().enabled = false;
		StopCoroutine(ShowGarderobMain());

		//}
	}
	IEnumerator StartZtemnenieExitGarderob()
    {
		yield return new WaitForSeconds(2f);
		ActivePanelZatemnenie.SetActive(true);
		particlAfterGarderob.SetActive(false);
		StartCoroutine(ZtemnenieExitGarderob());
		StartCoroutine(disablaPanelZatemnenieGameGarderob());
	}
	IEnumerator disablaPanelZatemnenieGameGarderob()
    {
		yield return new WaitForSeconds(2.2f);
		ActivePanelZatemnenie.SetActive(false);
	}
	public void gard()
	{
		particlAfterGarderob.SetActive(true);
		StartCoroutine(StartZtemnenieExitGarderob());
	}

	IEnumerator ZtemnenieExitGarderob()
    {
		yield return new WaitForSeconds(0.5f);
	
		/*if (izmenenieekrana >= -0.5f && izmenenieekrana < 1)
		{
			PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			//panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			izmenenieekrana = izmenenieekrana + 0.02f;
			StartCoroutine(ZtemnenieExitGarderob());
		}
		else if (izmenenieekrana >= 1)
		{*/
			//Debug.Log(point);

			//PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, 1f);
			//izmenenieekrana = 1;
			bgGarderob.SetActive(false);
			//OpenGarderob();
			
			ExitgarderobGame();
			//ExitgarderobGame();


			//StartCoroutine(ShowEkranGarderobGame());
		//	StopCoroutine(ZtemnenieExitGarderob());

		//}

	}

	IEnumerator ShowEkranGarderobGame()
    {
		yield return new WaitForSeconds(0.001f);
	//	Debug.Log("ShowEkranGarderobGame");
		if (izmenenieekrana > 0.01)
		{
			PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			//panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			izmenenieekrana = izmenenieekrana - 0.02f;
			StartCoroutine(ShowEkranGarderobGame());
		}
		else if (izmenenieekrana <= 0.01)
		{

			PanelMainEkran.GetComponent<Image>().color = new Color(0f, 0f, 0f,0f);
			izmenenieekrana = 0;
			//bgGarderob.SetActive(false);
			//OpenGarderob();
			//ExitgarderobGame();
			//ExitgarderobGame();
			//StartCoroutine(ShowEkranGarderob());
			StopCoroutine(ShowEkranGarderobGame());

		}
	}
	public void ViborGame()
    {
		story.variablesState["game0"] = "";
		PanelWithText.SetActive(true);
		enableMousebtn = true;
		//StartCoroutine(ischeznoveniePlashky());
		if (story.canContinue)
		{

			string text = story.Continue();

			CreateContentView(text);


		}
	}
	
/*public void SvernutGarderob()
    {
		if (!GarderobSvernut)
		{
			PanelGarderob.transform.position = new Vector2(PanelGarderob.transform.position.x, PanelGarderob.transform.position.y - 1000);
			btnScernutGarderob.transform.position = new Vector2(btnScernutGarderob.transform.position.x, btnScernutGarderob.transform.position.y - 900);
			GarderobSvernut = true;
			btnScernutGarderob.transform.rotation = Quaternion.Euler(0, 0, -90);
			//btnScernutGarderob.transform.Rotate(0f, 0f, -90f);
		}
		else
		{
			PanelGarderob.transform.position = new Vector2(PanelGarderob.transform.position.x, PanelGarderob.transform.position.y + 1000);
			btnScernutGarderob.transform.position = new Vector2(btnScernutGarderob.transform.position.x, btnScernutGarderob.transform.position.y + 900);
			GarderobSvernut = false;
			btnScernutGarderob.transform.rotation = Quaternion.Euler(0, 0, 90);
			//btnScernutGarderob.transform.Rotate(0f, 0f, 90f);
		}
	}*/

	// Creates a button showing the choice text
	Button CreateChoiceView(string text)
	{

		// Creates the button from a prefab
		Button choice = Instantiate(buttonPrefab) as Button;
		choice.transform.SetParent(panel.transform, false);

		// Gets the text from the button prefab
		Text choiceText = choice.GetComponentInChildren<Text>();
		choiceText.text = text;

		// Make the button expand to fit the text
		HorizontalLayoutGroup layoutGroup = choice.GetComponent<HorizontalLayoutGroup>();
		layoutGroup.childForceExpandHeight = false;

		return choice;
	}

	// Destroys all the children of this gameobject (all the UI)
	void RemoveChildren()
	{
	//	panelZatemnenie.GetComponent<Animator>().enabled = false;
		//Debug.Log("RemoveChildren");
		int childCount = panel.transform.childCount;

		for (int i = 0; i < childCount; i++)
		//	for (int i = childCount-2; i >= 0; --i)
		{
			GameObject.Destroy(panel.transform.GetChild(i).gameObject);
		}
		txt = null;

	}

	//***********************IEnumerator 

	/*BtSettings.GetComponent<Image>().sprite = numberLevel[LVL].btnSettingsOn;
	BtZvuk.GetComponent<Image>().sprite = numberLevel[LVL].btnZvukOn;
	BtExit.GetComponent<Image>().sprite = numberLevel[LVL].btnExit;
		BtGarderob.GetComponent<Image>().sprite = numberLevel[LVL].btnGarderobOn;
		*/
	/*btnSettingsOn;
btnSettingsOff;

btnZvukOn;
btnZvukOff;
btnExit;

btnGarderobOn;
btnGarderobOff;*/

	public bool vkluchitTapPoEkranufterSetting;

	public void OpenSettings()
    {
		
		enableMousebtn = false;
		//btnPauseSprite;

		
		if (btnPause.GetComponent<Image>().sprite == numberLevel[LVL].btnSettingsOn)
		{
			Debug.Log("open settings");

			btnPause.GetComponent<Image>().sprite = numberLevel[LVL].btnSettingsOff;
			PanelSettings.SetActive(true);
			btnPause.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
			
			StartCoroutine(VisiblebtnPause());

		}
		else
        {
			CloseSettings();

		}
	


	}

	IEnumerator VisiblebtnPause()
    {
		yield return new WaitForSeconds(0.3f);
		btnPause.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0.5f);
	//	vkluchitTapPoEkranufterSetting = true;
	}
	public void CloseSettings()
	{
		btnPause.GetComponent<Image>().color = new Color(255f,255f,255f, 0.5f);
		PanelSettings.SetActive(false);
		btnPause.GetComponent<Image>().sprite = numberLevel[LVL].btnSettingsOn;
		StartCoroutine(EnableMousebtnCouratina());
	//	enableMousebtn = true;
	//	vkluchitTapPoEkranufterSetting = false;
	}

	IEnumerator EnableMousebtnCouratina()
    {
		yield return new WaitForSeconds(0.1f);
		enableMousebtn = true;
	}

	public void VklViklMusic()
	{

		//btnMusicSprite
		if (btnMusic.GetComponent<Image>().sprite == numberLevel[LVL].btnZvukOn)
		{
			btnMusic.GetComponent<Image>().sprite = numberLevel[LVL].btnZvukOff;
			//for (int i = 0; i < 14; i++)
			//{
			numberLevel[0].audioSource[numMusic].Pause();
			//numberLevel[0].audioSource[i].enabled = false;

			//}
		}
		else if (btnMusic.GetComponent<Image>().sprite == numberLevel[LVL].btnZvukOff)
		{
			btnMusic.GetComponent<Image>().sprite = numberLevel[LVL].btnZvukOn;
			numberLevel[0].audioSource[numMusic].Play();
			//kakayMusicaPlayNow
			//numMusic
			//for (int i = 0; i < 14; i++)
			//{
			//	btnMusic.GetComponent<Image>().sprite = btnMusicSprite[0];
			//	numberLevel[0].audioSource[i].Play();
			//numberLevel[0].audioSource[i].enabled = true;

			//}
		}

	}
	public GameObject activPanelZatemnenie;
       public void startShowRoom()
        {
		activPanelZatemnenie.SetActive(true);
		StartCoroutine(naznachitSpriteRoom());
		}
	IEnumerator naznachitSpriteRoom()
    {
		yield return new WaitForSeconds(1f);
		

	}
	IEnumerator dvizhenievPravo()
    {
		yield return new WaitForSeconds(1f);
		activPanelZatemnenie.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Room/Location") as RuntimeAnimatorController;
		activPanelZatemnenie.GetComponent<Animator>().enabled = true;
	}

	IEnumerator dvizhenieVlevo()
    {
		yield return new WaitForSeconds(1f);
		activPanelZatemnenie.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Room/Location 1") as RuntimeAnimatorController;
		activPanelZatemnenie.GetComponent<Animator>().enabled = true;
	}
	IEnumerator dvizhenievPravo2()
	{
		yield return new WaitForSeconds(1f);
		activPanelZatemnenie.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Room/Location") as RuntimeAnimatorController;
		activPanelZatemnenie.GetComponent<Animator>().enabled = true;
	}



	//[SerializeField]
	public TextAsset inkJSONAsset;// = null;
	public Story story;

	//[SerializeField]
	//private panel panel = null;
	[SerializeField]
	private GameObject panel = null;

	// UI Prefabs
	[SerializeField]
	//private Text textPrefab = null;
	private TextMeshProUGUI textPrefab = null;
	[SerializeField]
	private Button buttonPrefab = null;

	//[SerializeField]
	//	public DwnLoadpict dwn;
	

}

[System.Serializable]
public struct NumLevel
{

	public Sprite[] spriteLevelLocation;
	public string[] nameLevelLocation;
	public AudioSource[] audioSource;
	public AudioClip[] audioClip;
	public string[] txtmusicClip;
	public AudioSource[] melodySource;
	public AudioClip[] melodyClip;
	//melodySource

	public SpriteRenderer npcSprite;
	public Sprite[] npcSpritefromServer;
	public string[] nameRu;
	public string[] nameEn;

	public GameObject emociiSprite;
	public List<NumLevelEmocii> numberLevelEmocii;
	//public List<Sprite> emociiPlayer ;
	public Sprite[] emociiSpritefromServer;
	//public string[] emociinameRu;
	public string[] emociinameEn;

	public Sprite BGMaingarderob;
	public Sprite BGPanelVibor;
	public Sprite BtBodyOn;
	public Sprite BtBodyOff;
	public Sprite BtHairOn;
	public Sprite BtHairOff;
	public Sprite BtDressOn;
	public Sprite BtDressOff;
	public Sprite BtMackUpOn;
	public Sprite BtMackUpOff;
	public Sprite BtGotovo;
	public Sprite BtGotovoBuy;
	public Sprite BtStrelky;

	public Sprite plashkaNazvanieGarderob;


	//******************Для диалогов
	public Sprite plashkaWhoSayLeft;
	public Sprite plashkaWhoSayRight;
	public Sprite plashkaPodskazka;
	public Sprite plashkaWhoSay;
	public Sprite plashkaWhoSayNow;
	public float red;
	public float green;
	public float blue;
	public Color colorText;
	public Sprite ButtonOtvet;
	public Sprite ButtonOtvetForMoney;

	//****************Для настроек (Settings)
	public Sprite btnSettingsOn;
	public Sprite btnSettingsOff;

	public Sprite btnZvukOn;
	public Sprite btnZvukOff;
	public Sprite btnExit;

	public Sprite btnGarderobOn;
	public Sprite btnGarderobOff;

}
[System.Serializable]
public struct NumLevelEmocii
{
	public Sprite[] emociiSpritefromServer;
	//public string[] emociinameRu;
	//public string[] emociinameEn;
}