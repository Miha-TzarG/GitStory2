using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class InventoryScrypt : MonoBehaviour
{
    public List<NumLVL> NumspisokLVL;


    public Sprite[] spriteAllDress;
    public int[] numberAllDress;
   // public List<Sprite> spisokNaryadov2222 = new List<Sprite>();

    //  public List<SpisokNaryadovVovremyIgry> spisokNaryadov;
    public List<Sprite> spisokNaryadov = new List<Sprite>(); //список нарядов. при выборе наряда добавляется в этот список наряд. При нажатии на кнопку гардероба во время игры. будут только наряды из этого списка
 
    public List<string> namespisokNaryadov = new List<string>();
   

    public List<NumNaryad> NumspisokNaryadov;

    public List<string> namespisokPrichesok = new List<string>();
    public List<NumHair> NumspisokHair;
    public List<Sprite> spisokPrichesok = new List<Sprite>();//список причесок. при выборе прически добавляется в этот список прическа. При нажатии на кнопку гардероба во время игры. будут только прически из этого списка

    public List<Sprite> spisokRoom = new List<Sprite>();
    public List<string> namespisokRoom = new List<string>();
    public List<NumRoom> NumspisokRoom;

    public int numFace;
    public Sprite[] spriteFace;
    public SpriteRenderer playerFace;
    //   public Text txtWhatFace;


    public Sprite[] Room;
    public SpriteRenderer spriteRoom;

    public int numHair;
    public Sprite[] Hair;
    public SpriteRenderer playerHair;

    public int numDress;
    public Sprite[] Dress;
    public SpriteRenderer playerDress;

   // public int numMackup;
  //  public Sprite[] Mackup;
 //   public SpriteRenderer playerMackup;


    public GameObject PanelChooseBody;
    public GameObject PanelChooseHair;
    public GameObject PanelChooseDress;
    public GameObject PanelChooseMackup;
    

    public string[] NameBody;
    public Text txtWhatFace;

    public string[] NameHair;
    public Text txtWhathair;
    public Text txtGarderobOnlyHair;

    public string[] NameDress;
    public Text txtWhatDress;
    public Text txtGarderobOnlyDress;

    public string[] NamemakeUp;
    public Text txtWhatmakeUp;
 

    public InkScript inkOldpricheska;
    public int prich;

    public int Briliant;
    public Text txtHowBriliant;
    public Text txtHowBriliantHair;

    public Text txtHowBriliantRoom;
    public int[] Kupleno;

    public InputField enterName;
    public GameObject personag;
    public int LVL;

    // Start is called before the first frame update
    void Start()
    {
        LVL = inkOldpricheska.LVL;
          // NumspisokNaryadov[proverka].Savenum();
          NumspisokNaryadov[proverka].LoadnumAll();
        NumspisokHair[proverka].LoadnumAll();
        txtHowBriliant.text = Briliant.ToString();
        txtHowBriliantHair.text = Briliant.ToString();
        /* numFace = PlayerPrefs.GetInt("NumFace");
         numHair = PlayerPrefs.GetInt("NumHair");
         numDress = PlayerPrefs.GetInt("NumDress");*/
        numFace = 0;
        numHair = 0;
        numDress = 0;
         oldnumHair = numHair;
    //    numMackup = PlayerPrefs.GetInt("NumMackup");
      
        //  playerMackup.GetComponent<SpriteRenderer>().sprite = Mackup[numMackup];
      //  txtWhathair.text = NameHair[numHair];
        //  txtGarderobOnlyHair.text = NameHair[numHair];
        txtWhathair.text = NumspisokHair[0].namehairRu[0];
        txtGarderobOnlyHair.text= NumspisokHair[0].namehairRu[0];
     //   Debug.Log(NameHair[numHair]);

        txtWhatDress.text = NameDress[numDress];
        txtGarderobOnlyDress.text = NameDress[numDress];

        //   NumspisokNaryadov[0].spisokNaryadov

        for (int i = 0; i <3; i++)
        {
            NumspisokNaryadov[0].spisokNaryadov[0] = Dress[0];
            NumspisokNaryadov[1].spisokNaryadov[i] = Dress[i];
            NumspisokNaryadov[2].spisokNaryadov[i] = Dress[i + 4];

         

           // NumspisokNaryadov[1].spisokNaryadov[i] = Dress[i + 7];
            // pool_size[i] = Instantiate(prefab, transform.position, transform.rotation, pool_parent);
            // pool_size[i].SetActive(false);

        }

        for(int j=0; j < NumspisokHair[0].spisokHair.Length; j++)
        {
            NumspisokHair[0].spisokHair[j] = Hair[j];
            spisokPrichesok.Add(NumspisokHair[0].spisokHair[j]);
            namespisokPrichesok.Add(NumspisokHair[0].namehairRu[j]);
        }
        playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numFace];
        playerHair.GetComponent<SpriteRenderer>().sprite = NumspisokHair[0].spisokHair[0];
        playerDress.GetComponent<SpriteRenderer>().sprite = NumspisokNaryadov[0].spisokNaryadov[0];

        for(int k=0; k< NumspisokRoom[0].spisokRoom.Length; k++)
        {
            NumspisokRoom[0].spisokRoom[k] = Room[k];
            spisokRoom.Add(NumspisokRoom[0].spisokRoom[k]);
            namespisokRoom.Add(NumspisokRoom[0].nameRoomRu[k]);

        }
        spriteRoom.GetComponent<SpriteRenderer>().sprite = NumspisokRoom[0].spisokRoom[0];
        NumspisokNaryadov[proverka].LoadnumAll();
        NumspisokNaryadov[proverka].Loadnum();
        NumspisokHair[proverka].LoadnumAll();
        NumspisokHair[proverka].Loadnum();

        NumspisokLVL[0].allDress[0].LoadAllDress();
       // LoadAllDress();
        zagruzkaNaraiadov();
        zagruzkaPrichesok();
    }



    //***********************************

        //*********************************
      
    public void zagruzkaNaraiadov()
    {
        for(int i=0; i < 7; i++)
        {
           // if (NumspisokNaryadov[1].numNaryadBuy[i] == 1)
           if(NumspisokLVL[0].allDress[0].buyedDress[i] == 1)
            {
                namespisokNaryadov.Add(NumspisokLVL[0].allDress[0].allNameDress[i]);
                spisokNaryadov.Add(NumspisokLVL[0].allDress[0].allDress[i]);
                //  spisokNaryadov.Add(NumspisokNaryadov[1].spisokNaryadov[i]);
                // namespisokNaryadov.Add(NumspisokNaryadov[1].namenaryadRu[i]);
            }
        }


    }
    public void zagruzkaPrichesok()
    {
        for (int i = 1; i < 3; i++)
        {
            if (NumspisokNaryadov[1].numNaryadBuy[i] == 1)
            {
                spisokPrichesok.Add(NumspisokHair[1].spisokHair[i]);
                namespisokPrichesok.Add(NumspisokHair[1].namehairRu[i]);
            }
        }
    }
        void Update()
    {
        
    }
    public Text txtWhatFaceGarderob;
    public string FaceNow;
    public void ChooseFace()
    {
    personag.GetComponent<Animator>().runtimeAnimatorController = null;


        StartCoroutine(startChoseFace());
         
        //  Savepersonazh();


    }

    IEnumerator startChoseFace()
    {
     
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(0.1f);
        if (numFace + 1 > spriteFace.Length - 1)
        {


            numFace = 0;
            txtWhatFace.text = NameBody[numFace];
            txtWhatFaceGarderob.text = NameBody[numFace];
            playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numFace];
        }
        else
        {
            numFace = numFace + 1;
            txtWhatFace.text = NameBody[numFace];
            txtWhatFaceGarderob.text = NameBody[numFace];


            playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numFace];
        }

        if (FaceNow == NameBody[numFace])
        {
            txtWhatFaceGarderob.text = "Текущий цвет кожи";
        }
       inkOldpricheska.numberFace = numFace;
    }
    public void PrevChooseFace()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(StartPrevChooseFace());
        // Savepersonazh();

    }
    IEnumerator StartPrevChooseFace()
    {
      
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers 1") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        if (numFace - 1 < 0)
        {



            numFace = spriteFace.Length - 1;
            txtWhatFace.text = NameBody[numFace];
            txtWhatFaceGarderob.text = NameBody[numFace];
            playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numFace];
        }
        else
        {
            numFace = numFace - 1;
            txtWhatFace.text = NameBody[numFace];
            txtWhatFaceGarderob.text = NameBody[numFace];
            playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numFace];
        }
        if (FaceNow == NameBody[numFace])
        {
            txtWhatFaceGarderob.text = "Текущий цвет кожи";
        }
        inkOldpricheska.numberFace = numFace;
    }

    public int oldnumHair;
    public string HairNow;
    public int newNumHair;
    public void ChooseNextHair()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(startChooseNextHair());
    }

    IEnumerator startChooseNextHair()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 1);
        proverka = int.Parse(inkOldpricheska.story.variablesState["nomerzapuskaGarderoba"].ToString());
        NumspisokHair[proverka].LoadnumAll();
        NumspisokHair[proverka].Loadnum();


        prich = inkOldpricheska.oldPricheska;

        if (numHair + 1 > NumspisokHair[proverka].spisokHair.Length - 1)
        {
            numHair = NumspisokHair[proverka].spisokHair.Length - 1;
            numHair = 0;


            txtWhathair.text = NumspisokHair[proverka].namehairRu[numHair];
            txtGarderobOnlyHair.text = NumspisokHair[proverka].namehairRu[numHair];
            playerHair.GetComponent<SpriteRenderer>().sprite = NumspisokHair[proverka].spisokHair[numHair];
            if (NumspisokHair[proverka].numHairBuy[numHair] == 0 && proverka != 0)
            {
                if (numHair == 0)
                {
                    textPriceHair.text = "0";
                    textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                }
                if (numHair == 1)
                {
                    textPriceHair.text = "100";
                }
                if (numHair == 2)
                {
                    textPriceHair.text = "150";
                }
            }
            else if (NumspisokHair[proverka].numHairBuy[numHair] == 1 && proverka != 0)
            {
                textPriceHair.text = "0";
                textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                // Debug.Log("Buyed Hair");
            }
            /*  Debug.Log(NumspisokHair[proverka].namehairRu[numHair]);

              if (HairNow == NumspisokHair[proverka].namehairRu[numHair])
              {
                  txtWhathair.text = "Текущая прическа";
                  txtGarderobOnlyHair.text = "Текущая прическа";
              }*/
        }
        else
        {
            numHair = numHair + 1;
            txtWhathair.text = NumspisokHair[proverka].namehairRu[numHair];
            txtGarderobOnlyHair.text = NumspisokHair[proverka].namehairRu[numHair];
            playerHair.GetComponent<SpriteRenderer>().sprite = NumspisokHair[proverka].spisokHair[numHair];

            if (NumspisokHair[proverka].numHairBuy[numHair] == 0 && proverka != 0)
            {

                if (numHair == 0)
                {
                    textPriceHair.text = "0";
                    textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                }
                if (numHair == 1)
                {
                    textPriceHair.text = "100";
                }
                if (numHair == 2)
                {
                    textPriceHair.text = "150";
                }
            }
            else if (NumspisokHair[proverka].numHairBuy[numHair] == 1 && proverka != 0)
            {
                textPriceHair.text = "0";
                textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                //  Debug.Log("Buyed");
            }
            /*  Debug.Log(NumspisokHair[proverka].namehairRu[numHair]);

              */
        }
        if (HairNow == NumspisokHair[proverka].namehairRu[numHair])
        {
            txtWhathair.text = "Текущая прическа";
            txtGarderobOnlyHair.text = "Текущая прическа";
        }

        if (oldnumHair == numHair)
        {
            inkOldpricheska.story.variablesState["pricheska"] = "0";

        }
        else inkOldpricheska.story.variablesState["pricheska"] = "1";

    }
    public Text textPriceHair;
    public void ChoosePreviousHair()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(startChoosePreviousHair());

      
    }

    IEnumerator startChoosePreviousHair()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers 1") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 1);

        proverka = int.Parse(inkOldpricheska.story.variablesState["nomerzapuskaGarderoba"].ToString());
        NumspisokHair[proverka].LoadnumAll();
        NumspisokHair[proverka].Loadnum();

        if (numHair - 1 < 0)
        {

            numHair = NumspisokHair[proverka].spisokHair.Length - 1;

            txtWhathair.text = NumspisokHair[proverka].namehairRu[numHair];
            txtGarderobOnlyHair.text = NumspisokHair[proverka].namehairRu[numHair];
            playerHair.GetComponent<SpriteRenderer>().sprite = NumspisokHair[proverka].spisokHair[numHair];
            if (NumspisokHair[proverka].numHairBuy[numHair] == 0 && proverka != 0)
            {
                if (numHair == 0)
                {
                    textPriceHair.text = "0";
                    textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                }
                if (numHair == 1)
                {
                    textPriceHair.text = "100";
                }
                if (numHair == 2)
                {
                    textPriceHair.text = "150";
                }
            }
            else if (NumspisokHair[proverka].numHairBuy[numHair] == 1 && proverka != 0)
            {
                textPriceHair.text = "0";
                textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                Debug.Log("Buyed Hair");
            }
        }
        else
        {
            numHair = numHair - 1;
            txtWhathair.text = NumspisokHair[proverka].namehairRu[numHair];
            txtGarderobOnlyHair.text = NumspisokHair[proverka].namehairRu[numHair];
            playerHair.GetComponent<SpriteRenderer>().sprite = NumspisokHair[proverka].spisokHair[numHair];
            if (NumspisokHair[proverka].numHairBuy[numHair] == 0 && proverka != 0)
            {

                if (numHair == 0)
                {
                    textPriceHair.text = "0";
                    textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                }
                if (numHair == 1)
                {
                    textPriceHair.text = "100";
                }
                if (numHair == 2)
                {
                    textPriceHair.text = "150";
                }
            }
            else if (NumspisokHair[proverka].numHairBuy[numHair] == 1 && proverka != 0)
            {
                textPriceHair.text = "0";
                textPriceHair.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                Debug.Log("Buyed");
            }
        }
        if (HairNow == NumspisokHair[proverka].namehairRu[numHair])
        {
            txtWhathair.text = "Текущая прическа";
            txtGarderobOnlyHair.text = "Текущая прическа";
        }

        if (oldnumHair == numHair)
        {
            inkOldpricheska.story.variablesState["pricheska"] = "0";

        }
        else inkOldpricheska.story.variablesState["pricheska"] = "1";

    }
    public int oldnumHairGameGarderob;
    public void ChooseNextHairGameGarderob()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(startChooseNextHairGameGarderob());

      
    }

    IEnumerator startChooseNextHairGameGarderob()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);

        prich = inkOldpricheska.oldPricheska;
        Debug.Log("Spisok prichesok: " + spisokPrichesok.Count);
        if (numHair + 1 > spisokPrichesok.Count - 1)
        {
            numHair = spisokPrichesok.Count - 1;
            numHair = 0;
            txtWhathair.text = namespisokPrichesok[numHair];
            txtGarderobOnlyHair.text = namespisokPrichesok[numHair];
            txtGarderobOnlyHairGarderob.text = namespisokPrichesok[numHair];
            playerHair.GetComponent<SpriteRenderer>().sprite = spisokPrichesok[numHair];
        }
        else
        {
            numHair = numHair + 1;
            txtWhathair.text = namespisokPrichesok[numHair];
            txtGarderobOnlyHair.text = namespisokPrichesok[numHair];
            txtGarderobOnlyHairGarderob.text = namespisokPrichesok[numHair];
            playerHair.GetComponent<SpriteRenderer>().sprite = spisokPrichesok[numHair];
        }

        Debug.Log(namespisokPrichesok[numHair]);
        if (HairNow == namespisokPrichesok[numHair])
        {
            txtWhathair.text = "Текущая прическа";
            txtGarderobOnlyHair.text = "Текущая прическа";
            txtGarderobOnlyHairGarderob.text = "Текущая прическа";
        }
        if (oldnumHairGameGarderob == numHair)
        {
            inkOldpricheska.story.variablesState["pricheska"] = "0";

        }
        else inkOldpricheska.story.variablesState["pricheska"] = "1";


    }
    public void ChoosePreviousHairGameGarderob()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(startChoosePreviousHairGameGarderob());

        
    }
    IEnumerator startChoosePreviousHairGameGarderob()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers 1") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        if (numHair - 1 < 0)
        {

            numHair = spisokPrichesok.Count - 1;

            txtWhathair.text = namespisokPrichesok[numHair];
            txtGarderobOnlyHair.text = namespisokPrichesok[numHair];
            txtGarderobOnlyHairGarderob.text = namespisokPrichesok[numHair];
            playerHair.GetComponent<SpriteRenderer>().sprite = spisokPrichesok[numHair];
        }
        else
        {
            numHair = numHair - 1;
            txtWhathair.text = namespisokPrichesok[numHair];
            txtGarderobOnlyHair.text = namespisokPrichesok[numHair];
            txtGarderobOnlyHairGarderob.text = namespisokPrichesok[numHair];
            playerHair.GetComponent<SpriteRenderer>().sprite = spisokPrichesok[numHair];
        }

        if (oldnumHairGameGarderob == numHair)
        {
            inkOldpricheska.story.variablesState["pricheska"] = "0";

        }
        else inkOldpricheska.story.variablesState["pricheska"] = "1";
        if (HairNow == namespisokPrichesok[numHair])
        {
            txtWhathair.text = "Текущая прическа";
            txtGarderobOnlyHair.text = "Текущая прическа";
            txtGarderobOnlyHairGarderob.text = "Текущая прическа";
        }
    }

   // NumspisokNaryadov[0].spisokNaryadov[0] = Dress[0];
   //    NumspisokNaryadov[1].spisokNaryadov[i] = Dress[i + 1];
   //   NumspisokNaryadov[2].spisokNaryadov[i] = Dress[i + 4];

    public int oldnumDress;

    public int proverka;
    public Text textPriceDress;
    public string DressNow;
    public void ChooseNextDress()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(startChooseNextDress());

       
    }

    IEnumerator startChooseNextDress()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(0.1f);
        textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 1);
        proverka = int.Parse(inkOldpricheska.story.variablesState["nomerzapuskaGarderoba"].ToString());
        NumspisokNaryadov[proverka].LoadnumAll();
        NumspisokNaryadov[proverka].Loadnum();

        /*  if (NumspisokNaryadov[proverka].numNaryadBuy[numDress] == 1 && proverka != 0)
          {
              textPriceDress.text = "0";
              Debug.Log("Buyed");
          }
        */
        if (inkOldpricheska.story.variablesState["nomerzapuskaGarderoba"].ToString() == "0")
        {

        }
        else
        {

            if (numDress + 1 > NumspisokNaryadov[proverka].spisokNaryadov.Length - 1)
            {

                numDress = NumspisokNaryadov[proverka].spisokNaryadov.Length - 1;
                numDress = 0;
                txtWhatDress.text = NameDress[numDress];
                txtGarderobOnlyDress.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];
                playerDress.GetComponent<SpriteRenderer>().sprite = NumspisokNaryadov[proverka].spisokNaryadov[numDress];
                Debug.Log(numDress);
                if (NumspisokNaryadov[proverka].numNaryadBuy[numDress] == 0 && proverka != 0)
                {

                    if (numDress == 0)
                    {
                        textPriceDress.text = "0";
                        textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                    }
                    if (numDress == 1)
                    {
                        textPriceDress.text = "100";
                    }
                    if (numDress == 2)
                    {
                        textPriceDress.text = "150";
                    }
                }
                else if (NumspisokNaryadov[proverka].numNaryadBuy[numDress] == 1 && proverka != 0)
                {
                    textPriceDress.text = "0";
                    textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                    Debug.Log("Buyed");
                }
                // textPriceDress.text = "0";
            }

            else
            {

                numDress = numDress + 1;
                txtWhatDress.text = NameDress[numDress];
                txtGarderobOnlyDress.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];
                playerDress.GetComponent<SpriteRenderer>().sprite = NumspisokNaryadov[proverka].spisokNaryadov[numDress];
                //    Debug.Log(numDress);
                if (NumspisokNaryadov[proverka].numNaryadBuy[numDress] == 0 && proverka != 0)
                {
                    if (numDress == 0)
                    {
                        textPriceDress.text = "0";
                        textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                    }
                    if (numDress == 1)
                    {
                        textPriceDress.text = "100";
                    }
                    if (numDress == 2)
                    {
                        textPriceDress.text = "150";
                    }
                }
                else if (NumspisokNaryadov[proverka].numNaryadBuy[numDress] == 1 && proverka != 0)
                {
                    textPriceDress.text = "0";
                    textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                    Debug.Log("Buyed");
                }
            }

            if (DressNow == NumspisokNaryadov[proverka].namenaryadRu[numDress])
            {
                txtWhatDress.text = "Текущий наряд";
                txtGarderobOnlyDress.text = "Текущий наряд";
            }
            if (oldnumDress == numDress)
            {
                inkOldpricheska.story.variablesState["platie"] = "0";

            }
            else inkOldpricheska.story.variablesState["platie"] = "1";
        }
    }


    public void ChoosePrevoiusDress()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(startChoosePrevoiusDress());


        
    }
    IEnumerator startChoosePrevoiusDress()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers 1") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(0.1f);
        textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 1);
        proverka = int.Parse(inkOldpricheska.story.variablesState["nomerzapuskaGarderoba"].ToString());
        NumspisokNaryadov[proverka].LoadnumAll();
        NumspisokNaryadov[proverka].Loadnum();


        if (inkOldpricheska.story.variablesState["nomerzapuskaGarderoba"].ToString() == "0")
        {

        }
        else
        {

            if (numDress - 1 < 0)
            {

                numDress = NumspisokNaryadov[proverka].spisokNaryadov.Length - 1;

                txtWhatDress.text = NameDress[numDress];
                txtGarderobOnlyDress.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];
                playerDress.GetComponent<SpriteRenderer>().sprite = NumspisokNaryadov[proverka].spisokNaryadov[numDress];
                // textPriceDress.text = "150";
                if (NumspisokNaryadov[proverka].numNaryadBuy[numDress] == 0 && proverka != 0)
                {
                    if (numDress == 0)
                    {
                        textPriceDress.text = "0";
                        textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                    }
                    if (numDress == 1)
                    {
                        textPriceDress.text = "100";
                    }
                    if (numDress == 2)
                    {
                        textPriceDress.text = "150";
                    }
                }
                else if (NumspisokNaryadov[proverka].numNaryadBuy[numDress] == 1 && proverka != 0)
                {
                    textPriceDress.text = "0";
                    textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                    Debug.Log("Buyed");
                }
            }
            else
            {
                numDress = numDress - 1;
                txtWhatDress.text = NameDress[numDress];
                txtGarderobOnlyDress.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];
                playerDress.GetComponent<SpriteRenderer>().sprite = NumspisokNaryadov[proverka].spisokNaryadov[numDress];
                Debug.Log(numDress);
                if (NumspisokNaryadov[proverka].numNaryadBuy[numDress] == 0 && proverka != 0)
                {

                    if (numDress == 0)
                    {
                        textPriceDress.text = "0";
                        textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                    }
                    if (numDress == 1)
                    {
                        textPriceDress.text = "100";
                    }
                    if (numDress == 2)
                    {
                        textPriceDress.text = "150";
                    }
                }
                else if (NumspisokNaryadov[proverka].numNaryadBuy[numDress] == 1 && proverka != 0)
                {
                    textPriceDress.text = "0";
                    textPriceDress.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0);
                    Debug.Log("Buyed");
                }

            }
            if (DressNow == NumspisokNaryadov[proverka].namenaryadRu[numDress])
            {
                txtWhatDress.text = "Текущий наряд";
                txtGarderobOnlyDress.text = "Текущий наряд";
            }
            if (oldnumDress == numDress)
            {
                inkOldpricheska.story.variablesState["platie"] = "0";

            }
            else inkOldpricheska.story.variablesState["platie"] = "1";
        }

    }


    public int oldnumDressGameGarderob;
    public Text txtWhatDressGarderob;
    public Text txtGarderobOnlyDressGarderob;

    public Text txtGarderobOnlyHairGarderob;
    public void ChooseNextDressGameGarderob()
    {

        personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(startChooseNextDressGameGarderob());

    }

    IEnumerator startChooseNextDressGameGarderob()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        if (numDress + 1 > spisokNaryadov.Count - 1)
        {

            numDress = spisokNaryadov.Count - 1;
            numDress = 0;
            txtWhatDress.text = namespisokNaryadov[numDress];
            txtGarderobOnlyDress.text = namespisokNaryadov[numDress];
            txtWhatDressGarderob.text = namespisokNaryadov[numDress];

            //  txtGarderobOnlyDressGarderob.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];

            playerDress.GetComponent<SpriteRenderer>().sprite = spisokNaryadov[numDress];

        }

        else
        {

            numDress = numDress + 1;
            txtWhatDress.text = namespisokNaryadov[numDress];
            txtGarderobOnlyDress.text = namespisokNaryadov[numDress];
            txtWhatDressGarderob.text = namespisokNaryadov[numDress];
            //   txtGarderobOnlyDressGarderob.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];
            playerDress.GetComponent<SpriteRenderer>().sprite = spisokNaryadov[numDress];

        }
        if (DressNow == namespisokNaryadov[numDress])
        {
            txtWhatDress.text = "Текущий наряд";
            txtGarderobOnlyDress.text = "Текущий наряд";
            txtWhatDressGarderob.text = "Текущий наряд";
        }
        if (oldnumDressGameGarderob == numDress)
        {
            inkOldpricheska.story.variablesState["platie"] = "0";

        }
        else inkOldpricheska.story.variablesState["platie"] = "1";

    }

    // spisokNaryadov.Add(Dress[numDress]); // добавляем в список нарядов выбранный наряд
    //   spisokPrichesok.Add(Hair[numHair]);
    public void ChoosePrevoiusDressGameGarderob()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(startChoosePrevoiusDressGameGarderob());

       
    }
    IEnumerator startChoosePrevoiusDressGameGarderob()
    {
        personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers 1") as RuntimeAnimatorController;
        personag.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        if (numDress - 1 < 0)
        {

            numDress = spisokNaryadov.Count - 1;

            txtWhatDress.text = namespisokNaryadov[numDress];
            txtGarderobOnlyDress.text = namespisokNaryadov[numDress];
            txtWhatDressGarderob.text = namespisokNaryadov[numDress];
            //  txtGarderobOnlyDressGarderob.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];
            playerDress.GetComponent<SpriteRenderer>().sprite = spisokNaryadov[numDress];

        }
        else
        {
            numDress = numDress - 1;
            txtWhatDress.text = namespisokNaryadov[numDress];
            txtGarderobOnlyDress.text = namespisokNaryadov[numDress];
            txtWhatDressGarderob.text = namespisokNaryadov[numDress];
            // txtGarderobOnlyDressGarderob.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];
            playerDress.GetComponent<SpriteRenderer>().sprite = spisokNaryadov[numDress];


        }

        if (oldnumDressGameGarderob == numDress)
        {
            inkOldpricheska.story.variablesState["platie"] = "0";

        }
        else inkOldpricheska.story.variablesState["platie"] = "1";
        if (DressNow == namespisokNaryadov[numDress])
        {
            txtWhatDress.text = "Текущий наряд";
            txtGarderobOnlyDress.text = "Текущий наряд";
            txtWhatDressGarderob.text = "Текущий наряд";
        }
    }
    public GameObject panelZatemnenie;
    public Canvas CanvasZatemnenit;
    public void ChooseNextRoom()
    {
       // personag.GetComponent<Animator>().runtimeAnimatorController = null;
        StartCoroutine(startChooseNextRoom());
    }

    public int numRoom;
    public Text txtWhatRoom;
    public int oldnumRoom;
    public string RoomNow;
    //spisokRoom = new List<Sprite>();
    //public List<string> namespisokRoom = new List<string>();
    // public List<NumHair> NumspisokRoom
    IEnumerator startChooseNextRoom()
    {
        panelZatemnenie.SetActive(true);
        CanvasZatemnenit.sortingOrder = 6;
  StartCoroutine(disactivPanelZatemnenie());
        // personag.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Garderob/Pers 1") as RuntimeAnimatorController;
        //personag.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.3f);


        textPriceRoom.GetComponent<Text>().color = new Color(255f, 255f, 255f, 1);
       
        if (numRoom + 1 > spisokRoom.Count - 1)
        {

            numRoom = spisokRoom.Count - 1;
            numRoom = 0;
        
            txtWhatRoom.text = namespisokRoom[numRoom];
            spriteRoom.GetComponent<SpriteRenderer>().sprite = NumspisokRoom[0].spisokRoom[numRoom];
          
        }
        else
        {
            numRoom = numRoom + 1;
            
            txtWhatRoom.text = namespisokRoom[numRoom];
            spriteRoom.GetComponent<SpriteRenderer>().sprite = NumspisokRoom[0].spisokRoom[numRoom];
          

        }

        if (numRoom == 0)
        {
            textPriceRoom.text = "0";
           
        }
        if (numRoom == 1)
        {
            textPriceRoom.text = "100";
          
        }
        if (numRoom == 2)
        {
            textPriceRoom.text = "150";
        
        }
        if (RoomNow == NumspisokRoom[0].nameRoomRu[numRoom])
        {
            txtWhatDress.text = "Текущий наряд";
            txtGarderobOnlyDress.text = "Текущий наряд";
        }
        txtWhatRoom.text = namespisokRoom[numRoom];
        spriteRoom.GetComponent<SpriteRenderer>().sprite = spisokRoom[numRoom];
       
        /*if (oldnumDress == numRoom)
        {
            inkOldpricheska.story.variablesState["platie"] = "0";

        }
        else inkOldpricheska.story.variablesState["platie"] = "1";*/
    }
    IEnumerator disactivPanelZatemnenie()
    {
        yield return new WaitForSeconds(0.3f);
        panelZatemnenie.SetActive(false);
        CanvasZatemnenit.sortingOrder = 3;
    }
    public void ChoosePreviousRoom()
    {
      
        StartCoroutine(startChoosePreviousRoom());
    }
    public Text textPriceRoom;
    IEnumerator startChoosePreviousRoom()
    {
        panelZatemnenie.SetActive(true);
        CanvasZatemnenit.sortingOrder = 6;
        StartCoroutine(disactivPanelZatemnenie());
        yield return new WaitForSeconds(0.3f);
        textPriceRoom.GetComponent<Text>().color = new Color(255f, 255f, 255f, 1);
      
      
            if (numRoom - 1 < 0)
            {

            numRoom = NumspisokRoom[0].spisokRoom.Length - 1;
            txtWhatRoom.text = namespisokRoom[numRoom];
            spriteRoom.GetComponent<SpriteRenderer>().sprite = NumspisokRoom[0].spisokRoom[numRoom];
           
            }
            else
            {
            numRoom = numRoom - 1;
         
            txtWhatRoom.text = namespisokRoom[numRoom];
            spriteRoom.GetComponent<SpriteRenderer>().sprite = NumspisokRoom[0].spisokRoom[numRoom];
           

        }

        if (numRoom == 0)
        {
            textPriceRoom.text = "0";
           
        }
        if (numRoom == 1)
        {
            textPriceRoom.text = "100";
          
        }
        if (numRoom == 2)
        {
            textPriceRoom.text = "150";
         
        }
        if (RoomNow == NumspisokRoom[0].nameRoomRu[numRoom])
            {
                txtWhatDress.text = "Текущий наряд";
                txtGarderobOnlyDress.text = "Текущий наряд";
            }
         txtWhatRoom.text = namespisokRoom[numRoom];
            spriteRoom.GetComponent<SpriteRenderer>().sprite = spisokRoom[numRoom];

        /*if (oldnumDress == numRoom)
        {
            inkOldpricheska.story.variablesState["numRoom"] = "0";
        numRoom
        }
        else inkOldpricheska.story.variablesState["platie"] = "1";*/
    }


    public void ChooseNextMackup()
    {
      /*  if (numMackup + 1 > Mackup.Length - 1)
        {
            numMackup = Dress.Length - 1;
        }
        else
        {
            numMackup = numMackup + 1;
            playerMackup.GetComponent<SpriteRenderer>().sprite = Mackup[numMackup];
        }
        Savepersonazh();*/
        //  playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
    }
    public void ChoosePreviousMackup()
    {
   /*     if (numMackup - 1 < 0)
        {
            numMackup = 0;
        }
        else
        {
            numMackup = numMackup - 1;
            playerMackup.GetComponent<SpriteRenderer>().sprite = Mackup[numMackup];
        }
        Savepersonazh();*/
        //playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
    }

  

    public GameObject[] panelWhatChoose;
    public Image[] btnImageActive;
    public Image[] btnImageNoActive;
    public Sprite[] GarderobBtnSpriteOn;
    public Sprite[] GarderobBtnSpriteOf;
    public void WhatChooseBody(int numpanel)
    {
        for(int i =0; i < panelWhatChoose.Length; i++)
        {
            if (i == numpanel)
            {
                panelWhatChoose[i].SetActive(true);
                btnImageActive[i].sprite = GarderobBtnSpriteOn[i];
            }
            else {
               
                btnImageActive[i].sprite = GarderobBtnSpriteOf[i];
                panelWhatChoose[i].SetActive(false);
            }
        }

     

    }


    public GameObject[] panelWhatChooseGarderobGame;
    public Image[] btnImageActiveGarderobGame;
    public Image[] btnImageNoActiveGarderobGame;
    public Sprite[] GarderobBtnSpriteOnGarderobGame;
    public Sprite[] GarderobBtnSpriteOfGarderobGame;

    public Text KolichestvoDressGarderob;
    public Text KolichestvoHairGarderob;
    public void WhatChooseBodyGarderobGame(int numpanel)
    {
        for (int i = 0; i < panelWhatChooseGarderobGame.Length; i++)
        {
            if (i == numpanel)
            {
                panelWhatChooseGarderobGame[i].SetActive(true);
                txtWhatDress.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];
                txtGarderobOnlyDress.text = NumspisokNaryadov[proverka].namenaryadRu[numDress];

                // txtWhathair.text = NumspisokHair[proverka].namehairRu[numHair];
                // txtGarderobOnlyHair.text = NumspisokHair[proverka].namehairRu[numHair];
              //  txtWhatDressGarderob.text = "Текущий наряд";
              //  txtGarderobOnlyHairGarderob.text = "Текущая прическа";
              //  txtWhatFaceGarderob.text = "Текущий цвет кожи";
                btnImageActiveGarderobGame[i].sprite = GarderobBtnSpriteOnGarderobGame[i];
            }
            else
            {

                btnImageActiveGarderobGame[i].sprite = GarderobBtnSpriteOfGarderobGame[i];
                panelWhatChooseGarderobGame[i].SetActive(false);
            }
        }



    }
    public HideGarferobShop hideGarderob;
    public HideGarferobShop showGarderob;
    public GameObject particle;
    public Canvas canvas;
    public void VihodGarderob() // это выход из гардероба, который в начале игры появляется
    {
        HairNow = NumspisokHair[0].namehairRu[numHair];
        DressNow = NumspisokNaryadov[0].namenaryadRu[numDress];
        FaceNow = NameBody[numFace];

        spisokNaryadov.Add(Dress[numDress]); // добавляем в список нарядов выбранный наряд
       // spisokPrichesok.Add(Hair[numHair]);
        namespisokNaryadov.Add(NumspisokNaryadov[0].namenaryadRu[0]);
       // namespisokPrichesok.Add(NumspisokHair[0].namehairRu[numHair]);

        NumspisokHair[1].spisokHair[0] = NumspisokHair[0].spisokHair[numHair];
        NumspisokHair[1].namehairRu[0] = NumspisokHair[0].namehairRu[numHair];
        NumspisokNaryadov[1].spisokNaryadov[0] = NumspisokNaryadov[0].spisokNaryadov[numDress];
        NumspisokNaryadov[1].namenaryadRu[0] = NumspisokNaryadov[0].namenaryadRu[numDress];

        txtWhathair.text = "Текущая прическа";
        txtGarderobOnlyHair.text = "Текущая прическа";
        txtWhatDress.text = "Текущий наряд";
        txtGarderobOnlyDress.text = "Текущий наряд";
        txtWhatFaceGarderob.text = "Текущий цвет кожи";
        txtWhatDressGarderob.text = "Текущий наряд";
        txtGarderobOnlyHairGarderob.text = "Текущая прическа";
        txtWhatFaceGarderob.text = "Текущий цвет кожи";


       numHair = 0;
       numDress = 0;
      //  numFace = 0;
        hideGarderob.hidePanel();
        //inkOldpricheska.panelZatemnenie.GetComponent<Animator>().enabled = false;
        inkOldpricheska.particlAfterGarderob.SetActive(true);
        canvas.sortingOrder = 5;
        StartCoroutine(HideParicle());
       // inkOldpricheska.Exitgarderob();
        Savepersonazh();
    }

    IEnumerator HideParicle()
    {
        yield return new WaitForSeconds(2f);
        inkOldpricheska.particlAfterGarderob.SetActive(false);
       // showGarderob.showPanel();
      //  showGarderobDress.showPanel();
      //  showGarderobHair.showPanel(); 
        inkOldpricheska.garderobMain();
    }

    IEnumerator HideParicle2()
    {
        yield return new WaitForSeconds(2f);
        inkOldpricheska.particlAfterGarderob.SetActive(false);
        // showGarderob.showPanel();
        //  showGarderobDress.showPanel();
        //  showGarderobHair.showPanel(); 
        inkOldpricheska.garderobMain2();
    }

    IEnumerator HideParicleDress()
    {
        yield return new WaitForSeconds(2.5f);
        inkOldpricheska.particlAfterGarderob.SetActive(false);
        // showGarderob.showPanel();
       // panelDress.transform.position = new Vector3(0, 130, 0);
       // showGarderobDress.showPanel();
        //showGarderobHair.showPanel();
        inkOldpricheska.garderobMain();
    }
    IEnumerator HideParicleHair()
    {
        yield return new WaitForSeconds(2.5f);
        inkOldpricheska.particlAfterGarderob.SetActive(false);
        //showGarderob.showPanel();
        //showGarderobDress.showPanel();
       // showGarderobHair.showPanel();
        inkOldpricheska.garderobMain();
    }

    public void VihodGarderobGame()
    {
        HairNow = namespisokPrichesok[numHair];
        DressNow = namespisokNaryadov[numDress];//NumspisokNaryadov[0].namenaryadRu[numDress];
        FaceNow = NameBody[numFace];
        inkOldpricheska.pers.GetComponent<Animator>().GetComponent<Animator>().runtimeAnimatorController = null;
        
        inkOldpricheska.gard();
        Savepersonazh();
    }

    public int proverkaNaryadov;
    public HideGarferobShop hideGarderobDress;
    public HideGarferobShop showGarderobDress;
    public GameObject panelDress;


    public HideGarferobShop hideGarderobRoom;
    public HideGarferobShop showGarderobRoom;
    public GameObject panelRoom;

    public void VihodRoom()
    {
        //NumspisokRoom[0].Savenum();
        inkOldpricheska.story.variablesState["numRoom"] = numRoom+1;
       hideGarderobRoom.hidePanel();

        //inkOldpricheska.spLocation.GetComponent<SpriteRenderer>().sprite = spisokRoom[numRoom];
        //inkOldpricheska.panelZatemnenie.GetComponent<Animator>().enabled = false;
        inkOldpricheska.particlAfterGarderob.SetActive(true);
        canvas.sortingOrder = 5;
         StartCoroutine(HideParicle2());
      //  inkOldpricheska.enableMousebtn = true;
      //  inkOldpricheska.Newtext();
       //  inkOldpricheska.Exitgarderob();
         // Savepersonazh();
    }
    public void VihodGarderobDress()
    {
        NumspisokNaryadov[proverka].Savenum();
      


        //spisokNaryadov.Add(Dress[numDress]); // добавляем в список нарядов выбранный наряд


        for (int i=0; i< namespisokNaryadov.Count; i++)
        {
            if(namespisokNaryadov[i] == NumspisokNaryadov[proverka].namenaryadRu[numDress])
            {
                proverkaNaryadov = proverkaNaryadov + 1;
            }

        }
        if(proverkaNaryadov == 0)
        {
            spisokNaryadov.Add(NumspisokNaryadov[proverka].spisokNaryadov[numDress]);
            namespisokNaryadov.Add(NumspisokNaryadov[proverka].namenaryadRu[numDress]);
        }
        // HairNow = NumspisokHair[0].namehairRu[numHair];
      //  DressNow = namespisokNaryadov[numDress];
        DressNow = NumspisokNaryadov[proverka].namenaryadRu[numDress];
       // HairNow =namespisokPrichesok[numHair];
       //HairNow = NumspisokHair[proverka].namehairRu[numHair];
       // FaceNow  = NameBody[numFace];
       // numHair = 0;
       // numDress = 0;

        txtWhatDress.text = "Текущий наряд";
        txtGarderobOnlyDress.text = "Текущий наряд";

       // hideGarderobDress.GetComponent<>
        hideGarderobDress.hidePanel();
        //inkOldpricheska.panelZatemnenie.GetComponent<Animator>().enabled = false;
        inkOldpricheska.particlAfterGarderob.SetActive(true);
        canvas.sortingOrder = 5;
        StartCoroutine(HideParicle());
       
        // inkOldpricheska.Exitgarderob();
        Savepersonazh();
        proverkaNaryadov = 0;
    }
    public HideGarferobShop hideGarderobHair;
    public HideGarferobShop showGarderobHair;
    public void VihodGarderobHair()
    {
        NumspisokHair[proverka].Savenum();

        for (int i = 0; i < namespisokPrichesok.Count; i++)
        {
            if (namespisokPrichesok[i] == NumspisokHair[proverka].namehairRu[numHair])
            {
                proverkaNaryadov = proverkaNaryadov + 1;
            }

        }
        if (proverkaNaryadov == 0)
        {
            spisokPrichesok.Add(NumspisokHair[proverka].spisokHair[numHair]); // добавляем в список причесок выбранную прическу
                                                                              //spisokNaryadov.Add(NumspisokNaryadov[proverka].spisokNaryadov[numDress]);
            namespisokPrichesok.Add(NumspisokHair[proverka].namehairRu[numHair]);
        }

         HairNow = NumspisokHair[proverka].namehairRu[numHair];
       // numHair = 0;
       // numDress = 0;
        // DressNow = NumspisokNaryadov[0].namenaryadRu[numDress];
        txtWhathair.text = "Текущая прическа";
        txtGarderobOnlyHair.text = "Текущая прическа";

        hideGarderobHair.hidePanel();
        //inkOldpricheska.panelZatemnenie.GetComponent<Animator>().enabled = false;
        inkOldpricheska.particlAfterGarderob.SetActive(true);
        canvas.sortingOrder = 5;
        StartCoroutine(HideParicle());
       // inkOldpricheska.Exitgarderob();
        Savepersonazh();
        proverkaNaryadov = 0;
    }
    
    public void OpenGarderob()
    {
      //  Debug.Log("openGarderobGame");
        numHair = 0;
        numDress = 0;
        //numFace = 0;
        canvas.sortingOrder = 5;
        txtWhatDressGarderob.text = "Текущий наряд";
        txtGarderobOnlyHairGarderob.text = "Текущая прическа";
        txtWhatFaceGarderob.text = "Текущий цвет кожи";
        inkOldpricheska.boolTimer = false;
        inkOldpricheska.palecTimer.SetActive(false);
        inkOldpricheska.Timer = 0;
        KolichestvoHairGarderob.text = spisokPrichesok.Count.ToString();
        KolichestvoDressGarderob.text = spisokNaryadov.Count.ToString();
        inkOldpricheska.ZatemneniePriGarderobe();
    }
    
    public void vvodImeni()
    {
        // panelZatemnenie.SetActive(false);
        canvas.sortingOrder = 4;
        inkOldpricheska.story.variablesState["Gven"] = enterName.text;
        inkOldpricheska.story.variablesState["showname"] = 0;
        inkOldpricheska.proverkaBackPers = 0;
          //  Debug.Log("vvod imeny: " + enterName.text);
        inkOldpricheska.panelInputname.SetActive(false);
        inkOldpricheska.enableMousebtn = true;
        inkOldpricheska.Newtext();
    }


    public void Savepersonazh()
    {
        oldnumHair = numHair;
        PlayerPrefs.SetInt("NumFace", numFace);
        PlayerPrefs.SetInt("NumHair", numHair);
        PlayerPrefs.SetInt("NumDress", numDress);
      //  PlayerPrefs.SetInt("NumMackup", numMackup);
        
        PlayerPrefs.Save();
    }
 
    
    
    
    public void GoToScene(int numScene)
    {


        SceneManager.LoadScene(numScene);
    }

 
}



[System.Serializable]
public struct NumNaryad
{
    //  public List<Sprite> spisok = new List<Sprite>();
    public Sprite[] spisokNaryadov;
    public int[] numNaryadBuy;
    public string[] namenaryadRu;
    public InventoryScrypt inbentScr;
    public string nameForSave;
    public void Savenum()
    {
     /* nameForSave = "Nomernaryada12";
         numNaryadBuy[0] = 0;
         numNaryadBuy[1] = 0;
         numNaryadBuy[2] = 0;
         PlayerPrefs.SetInt(nameForSave, numNaryadBuy[inbentScr.numDress]);
         PlayerPrefs.Save();
         */
       if (inbentScr.Briliant - int.Parse(inbentScr.textPriceDress.text) < 0)
            {
                Debug.Log("No maney");

            }
            else
            {
                inbentScr.Briliant = inbentScr.Briliant - int.Parse(inbentScr.textPriceDress.text);
                inbentScr.textPriceDress.text = "0";
                numNaryadBuy[inbentScr.numDress] = 1;

                nameForSave = "Nomernaryada" + inbentScr.proverka.ToString() + inbentScr.numDress.ToString();

                inbentScr.txtHowBriliant.text = inbentScr.Briliant.ToString();
            inbentScr.txtHowBriliantHair.text = inbentScr.Briliant.ToString();

            PlayerPrefs.SetInt(nameForSave, numNaryadBuy[inbentScr.numDress]);
                PlayerPrefs.Save();
            }
     
    }

    public void Loadnum()
    {
        nameForSave = "Nomernaryada" + inbentScr.proverka.ToString() + inbentScr.numDress.ToString();
       // Debug.Log(nameForSave);
        numNaryadBuy[inbentScr.numDress] = PlayerPrefs.GetInt(nameForSave);

        Debug.Log("load");
       // inbentScr.NumspisokNaryadov[1].numNaryadBuy[1] = PlayerPrefs.GetInt("Nomernaryada" + inbentScr.NumspisokNaryadov[1].numNaryadBuy[1].ToString());
    }
    public void LoadnumAll()
    {
        for (int i = 0; i < numNaryadBuy.Length; i++)
        {
            nameForSave = "Nomernaryada" + inbentScr.proverka.ToString() + i.ToString();
           // Debug.Log(nameForSave);
            numNaryadBuy[i] = PlayerPrefs.GetInt(nameForSave);

          //  Debug.Log("load");
        }
        // inbentScr.NumspisokNaryadov[1].numNaryadBuy[1] = PlayerPrefs.GetInt("Nomernaryada" + inbentScr.NumspisokNaryadov[1].numNaryadBuy[1].ToString());
    }

}
[System.Serializable]
public struct NumLVL
{
    public List<AllDress> allDress;
}
[System.Serializable]
public struct AllDress
{
    public Sprite[] allDress;
    public string[] allNameDress;
    public int[] buyedDress;
    public string nameForSaveAllDress;
    public InventoryScrypt inventoryScriptAllDress;


   public void SaveallDress()
    {
        for(int i=0; i< allNameDress.Length; i++)
        {
            if(allNameDress[i] == inventoryScriptAllDress.NumspisokNaryadov[inventoryScriptAllDress.proverka].namenaryadRu[inventoryScriptAllDress.numDress])
            {
                nameForSaveAllDress = "NomerAllDress" + inventoryScriptAllDress.LVL + i;
                PlayerPrefs.SetInt(nameForSaveAllDress, buyedDress[i]);
                PlayerPrefs.Save();
            }
        }
    }

    public void LoadAllDress()
    {
        for (int i = 0; i < allNameDress.Length; i++)
        {
            nameForSaveAllDress = "NomerAllDress" + inventoryScriptAllDress.LVL + i;
            buyedDress[i] = PlayerPrefs.GetInt(nameForSaveAllDress);
        }
    }
}

[System.Serializable]
public struct NumHair
{
    //  public List<Sprite> spisok = new List<Sprite>();
    public Sprite[] spisokHair;
    public int[] numHairBuy;
    public string[] namehairRu;
    public InventoryScrypt inventScr;
    public string nameForSaveHair;
    public void Savenum()
    {
        /* nameForSave = "Nomernaryada12";
            numNaryadBuy[0] = 0;
            numNaryadBuy[1] = 0;
            numNaryadBuy[2] = 0;
            PlayerPrefs.SetInt(nameForSave, numNaryadBuy[inbentScr.numDress]);
            PlayerPrefs.Save();
            */
        if (inventScr.Briliant - int.Parse(inventScr.textPriceHair.text) < 0)
        {
            Debug.Log("No maney Hair");

        }
        else
        {
            inventScr.Briliant = inventScr.Briliant - int.Parse(inventScr.textPriceHair.text);
            inventScr.textPriceHair.text = "0";
            numHairBuy[inventScr.numHair] = 1;

            nameForSaveHair = "Nomerhair" + inventScr.proverka.ToString() + inventScr.numHair.ToString();

            inventScr.txtHowBriliant.text = inventScr.Briliant.ToString();
            inventScr.txtHowBriliantHair.text = inventScr.Briliant.ToString();
            PlayerPrefs.SetInt(nameForSaveHair, numHairBuy[inventScr.numHair]);
            PlayerPrefs.Save();
        }

    }

    public void Loadnum()
    {
        nameForSaveHair = "Nomerhair" + inventScr.proverka.ToString() + inventScr.numHair.ToString();
      //  Debug.Log(nameForSaveHair);
        numHairBuy[inventScr.numHair] = PlayerPrefs.GetInt(nameForSaveHair);

       // Debug.Log("load Hair");
        // inbentScr.NumspisokNaryadov[1].numNaryadBuy[1] = PlayerPrefs.GetInt("Nomernaryada" + inbentScr.NumspisokNaryadov[1].numNaryadBuy[1].ToString());
    }
    public void LoadnumAll()
    {
        for (int i = 0; i < numHairBuy.Length; i++)
        {
            nameForSaveHair = "Nomerhair" + inventScr.proverka.ToString() + i.ToString();
           // Debug.Log(nameForSaveHair);
            numHairBuy[i] = PlayerPrefs.GetInt(nameForSaveHair);

           // Debug.Log("load");
        }
        // inbentScr.NumspisokNaryadov[1].numNaryadBuy[1] = PlayerPrefs.GetInt("Nomernaryada" + inbentScr.NumspisokNaryadov[1].numNaryadBuy[1].ToString());
    }

}

[System.Serializable]
public struct NumRoom
{
    public Sprite[] spisokRoom;
    public string[] nameRoomRu;
    public int[] numRoomBuy;
    public InventoryScrypt inventScr;
    public string nameForSaveRoom;

    public void Savenum()
    {
        /* nameForSave = "Nomernaryada12";
            numNaryadBuy[0] = 0;
            numNaryadBuy[1] = 0;
            numNaryadBuy[2] = 0;
            PlayerPrefs.SetInt(nameForSave, numNaryadBuy[inbentScr.numDress]);
            PlayerPrefs.Save();
            */
        if (inventScr.Briliant - int.Parse(inventScr.textPriceRoom.text) < 0)
        {
            Debug.Log("No maney Hair");

        }
        else
        {
            inventScr.Briliant = inventScr.Briliant - int.Parse(inventScr.textPriceRoom.text);
            inventScr.textPriceRoom.text = "0";
            numRoomBuy[inventScr.numRoom] = 1;

            nameForSaveRoom = "Nomerroom0"  + inventScr.numRoom.ToString();

            inventScr.txtHowBriliant.text = inventScr.Briliant.ToString();
            inventScr.txtHowBriliantRoom.text = inventScr.Briliant.ToString();
            PlayerPrefs.SetInt(nameForSaveRoom, numRoomBuy[inventScr.numRoom]);
            PlayerPrefs.Save();
        }

    }

}