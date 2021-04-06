using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextAndImageinInkText : MonoBehaviour
{
    public GameObject CameraForDvizh;
    public Camera Camera;
    public string txtstr;
    public Transform maintxt;
    public Text txtDialogName;
    public TextMeshProUGUI meshtxtDialog;
    public Text txtinImageinDialog;
    public TextMeshProUGUI meshtxtinImageinDialog;
    public Text txtinImageinDialogNPC;
    public TextMeshProUGUI meshtxtinImageinDialogNPC;
    public Text txtinImageinDialogMisly;
    public Text txtinImageinDialogPodskazka;
    public TextMeshProUGUI meshtxtinImageinDialogPodskazka;
    public Text txtinImageinDialogStat;
    public Text txtWhoSay;
  //  public Image imgInDialog;
 //   public Vector2 imgWhosay;
    public GameObject imgPlayer;
    public GameObject imgNPC;
    public GameObject imgMisly;
    public GameObject imgMislyIconka;
    public GameObject imgPodskazka;
    public GameObject imgStat;
    public GameObject personaj;

  
    public Sprite[] Bg;

    public InkScript Inkscript;

    public GameObject cam;
    public GameObject left;
    public bool leftbool;
    public bool leftbool2;
    public GameObject right;
    public bool rightbool;
    public bool rightbool2;
    public GameObject center;
    public bool centerbool;
    public bool centerbool2;
    public float speed;

    public SpriteRenderer spriteNPC;
    public SpriteRenderer spritePlayer;
    public SpriteRenderer spritePlayerHair;
    public SpriteRenderer spritePlayerDress;
    public float prozrachnostPlayer;
    public float prozrachnostNPC;

    public Sprite[] spriteStat;
    public Image statImg;

    public int modestyValue;
    public int braveryValue;
    public int levkippaloveValue;
    public int levkippafriendValue;
    public int admetloveValue;
    public int creationValue;
    public int destructionValue;
    public string nameWindow;


  //  public int numpers;
    public string nm;


    public Image WhoSayLeft;
    public Image WhoSayRight;
    public Image WhoSayPodskazka;
    public Image WhoSay;


   
    // public int Zapusk;
    public HistoryScript historyScript;
    //   public InkScript inkScript;

    public Animator Animpers;
    public int LVL;
    public int howBackpersStart;

    // Start is called before the first frame update
    void Start()
    {

    
       
    //   StartCoroutine(StartAll());
    //}
    //IEnumerator StartAll()
    //void Start()
    //{
    // yield return new WaitForSeconds(0.00001f);
    // imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
    // statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
    // imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
    // txtinImageinDialogMisly.GetComponent<Text>().color = new Color(50f, 50f, 50f, 0f);
    //  spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
    //  spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
    // spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
    //  numpers= PlayerPrefs.GetInt("Numpers");
    //  modestyValue = PlayerPrefs.GetInt("Modesty");
    // braveryValue = PlayerPrefs.GetInt("Bravery");
    //levkippaloveValue = PlayerPrefs.GetInt("Levkippalove");
    //levkippafriendValue = PlayerPrefs.GetInt("Levkippafriend");
    //admetloveValue = PlayerPrefs.GetInt("Admetlove");
    //creationValue = PlayerPrefs.GetInt("Creation");
    //destructionValue = PlayerPrefs.GetInt("Destruction");
    //destructionValue = PlayerPrefs.GetInt("Modesty");
    Camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        cam = GameObject.FindGameObjectWithTag("Location");
        left= GameObject.FindGameObjectWithTag("Left");
        right = GameObject.FindGameObjectWithTag("Right");
        center = GameObject.FindGameObjectWithTag("Center");
        personaj = GameObject.FindGameObjectWithTag("Pers");
        spriteNPC = GameObject.FindGameObjectWithTag("NPC").GetComponent<SpriteRenderer>();
        spritePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        spritePlayerHair = GameObject.FindGameObjectWithTag("Hair").GetComponent<SpriteRenderer>();
        spritePlayerDress = GameObject.FindGameObjectWithTag("Dress").GetComponent<SpriteRenderer>();

        //   transform.position = new Vector2(transform.position.x + 0.15f, transform.position.y + 3.5f);
        Inkscript = GameObject.FindGameObjectWithTag("Ink").GetComponent<InkScript>();
        historyScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<HistoryScript>();
        CameraForDvizh = GameObject.FindGameObjectWithTag("Location");
        //CameraForDvizh.GetComponent<Animator>().runtimeAnimatorController = null;
        // Animpers = 
        txtDialogName.text = Inkscript.story.variablesState["name"].ToString();
        txtinImageinDialogNPC.text = Inkscript.story.variablesState["name"].ToString();
        txtinImageinDialogPodskazka.text = Inkscript.story.variablesState["name"].ToString();

        txtstr = Inkscript.names;
        LVL = Inkscript.LVL;
        // Zapusk = PlayerPrefs.GetInt("Zapusk");
        Debug.Log(Inkscript.story.variablesState["position"].ToString());
        //   Debug.Log("Motanie NoW: " + Inkscript.story.variablesState["motanieGolovoi"].ToString());
        // if(historyScript.Zapusk == 0)
        if (Inkscript.ZapuskNewlocation == 0)
            {
            v3Center.x = 0f;
            v3Center.y =0f;
            v3Center.z = 0f;


            v3Left.x = -0.8f;
            v3Left.y = 0f;
            v3Left.z = 0f;

            v3Right.x = 0.8f;
            v3Right.y = 0f;
            v3Right.z = 0f;
        }

        //  if (historyScript.Zapusk == 1)
        if (Inkscript.ZapuskNewlocation == 1)
        {
           v3Center.x = PlayerPrefs.GetFloat("V3CentrX");
            v3Center.y = PlayerPrefs.GetFloat("V3CentrY");
            v3Center.z = PlayerPrefs.GetFloat("V3CentrZ");


            v3Left.x = PlayerPrefs.GetFloat("v3LeftX");
            v3Left.y = PlayerPrefs.GetFloat("v3LeftY");
            v3Left.z = PlayerPrefs.GetFloat("v3LeftZ");

            v3Right.x = PlayerPrefs.GetFloat("V3v3RightX");
            v3Right.y = PlayerPrefs.GetFloat("V3v3RightY");
            v3Right.z = PlayerPrefs.GetFloat("V3v3RightZ");
        }


       // Inkscript.PanelTXTBTN.runtimeAnimatorController = null;
     //   Inkscript.PanelTXTBTN.enabled = false;
        //Cont(meshtxtDialog.text);

        //StartCoroutine(TextCoroutine());
        StartCoroutine(pechatanie());
        if (txtstr == Inkscript.story.variablesState["Gven"].ToString())
        {
          //  Debug.Log("Motanie: " + Inkscript.story.variablesState["motanieGolovoi"].ToString());
           
            // WhoSayLeft
            // WhoSayRight
            // WhoSayPodskazka
            //WhoSay


            imgMisly.SetActive(false);
            imgPodskazka.SetActive(false);
            imgStat.SetActive(false);
         
            centerbool = false;
        //   if (Inkscript.numtest == 0 && Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())
          if (Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())
            // {
            {
              //  personaj.SetActive(true);
              //  personaj.GetComponent<Animator>().runtimeAnimatorController = null;
             
                personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 2") as RuntimeAnimatorController;
                imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;
                
                //  imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                //  Debug.Log("Gven ne ravno");
                Inkscript.BackPers = 1;
                Inkscript.proverkaBackPers = 1;

                // personaj.GetComponent<Animator>().enabled = true;

                /*Vector3 point = Camera.ViewportToWorldPoint(new Vector3(-.5f, .3f, .5f));
           
                personaj.transform.position = point;

              
                personaj.transform.position = point;*/
                //   spriteNPC.transform.localScale = new Vector2(0.25f, 0.25f);
              //  spritePlayer.transform.localScale = new Vector2(1.4f, 1.4f);
                spritePlayer.transform.localScale = new Vector2(0.3f, 0.3f);


                 imgPlayer.SetActive(true);
                //imgPlayer.SetActive(false);
                //  WhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
                WhoSayLeft.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayLeft;
                //WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayNow;
                StartCoroutine(whoSayNaow());
                //   imgNPC.SetActive(true);

                //   rightbool = true;
                leftbool = true;
               // Inkscript.enableMousebtn = false;
                Inkscript.numtest = 1;


                //Inkscript.txt.text = Inkscript.story.variablesState["name"].ToString();
                //   Debug.Log("0:" + Inkscript.story.variablesState["name"].ToString());

                //PlayerPrefs.SetInt("Numpers", numpers);
                //  StartCoroutine(DvizheniePersonazha());
                // StartCoroutine(Dvizhenielocation());   if (Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString() && Inkscript.story.variablesState["motanieGolovoi"].ToString() != "0")
              


                    if (Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString() && Inkscript.story.variablesState["motanieGolovoi"].ToString() != "0")
                    {
                  
                   //    Debug.Log("mot");
                   // personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 3") as RuntimeAnimatorController;
                    imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                    //  imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                    // imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5) 1") as RuntimeAnimatorController;
                    //imgPlayer.SetActive(false);
                   personaj.GetComponent<Animator>().runtimeAnimatorController = null;
                    //imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                    // personaj.SetActive(false);
                    //Debug.Log("motanie");
                    transform.position = new Vector2(transform.position.x, transform.position.y);
                    /* imgMisly.SetActive(false);
                     imgPlayer.SetActive(false);
                     imgNPC.SetActive(false);
                     imgPodskazka.SetActive(true);
                     imgStat.SetActive(false);*/
                    leftbool = true;
                    leftbool2 = true;
                    rightbool = false;
                    centerbool = false;
                    rightbool2 = false;
                    centerbool2 = false;
                    Inkscript.numtest = 1;
                    Inkscript.enableMousebtn = false;
                    Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                    //txtstr = "Персефона";
                    // StartCoroutine(Dvizhenielocation());
                    Inkscript.boolTimer = false;
                    StartCoroutine(MotanieGolpvoi());
                 //   StartCoroutine(whoSayNaow());
                }
                 else
                {
                    Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                    //   Debug.Log("Motanie 0: " + Inkscript.story.variablesState["motanieGolovoi"].ToString());
                    StartCoroutine(Dvizhenielocation());
                    StartCoroutine(whoSayNaow());

                }
               // StartCoroutine(Dvizhenielocation());
               // StartCoroutine(whoSayNaow());
            }
            else if (Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString())
            {/*
                if (Inkscript.story.variablesState["name"].ToString() != Inkscript.story.variablesState["whonext"].ToString())
                {
                    Inkscript.BackPers = 1;
                    Inkscript.proverkaBackPers = 1;
                }
                else
                {
                    Inkscript.BackPers = 0;
                    // Inkscript.proverkaBackPers = 1;
                }*/
            //    Debug.Log("mot ne ravno");
                // personaj.SetActive(true);
                //  personaj.GetComponent<Animator>().runtimeAnimatorController = null;
                // personaj.GetComponent<Animator>().enabled = false;
                // Debug.Log("Gven ravno");
                personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 2") as RuntimeAnimatorController;
                //  imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;
                Inkscript.BackPers = 0;
                //Inkscript.proverkaBackPers = 0;
               // Inkscript.proverkaBackPers = 0;

                prozrachnostPlayer = 1f;
               // spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
                //spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
                //spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
                // personaj.transform.position = new Vector2(-3.4f, -1.4f);
                // spriteNPC.transform.localScale = new Vector2(-0.25f, 0.25f);

                //  spritePlayer.transform.localScale = new Vector2(1.6f, 1.6f);
                //  spritePlayerDress.transform.localScale = new Vector2(-0.25f, 0.25f);
                // spritePlayerHair.transform.localScale = new Vector2(-0.25f, 0.25f);*/

            
               // Inkscript.enableMousebtn = false;
               // Inkscript.numtest = 1;
                imgPlayer.SetActive(true);
                imgNPC.SetActive(false);

               // WhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
                WhoSayLeft.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayLeft;
                //WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayNow;
              //  StartCoroutine(whoSayNaow());

                leftbool = true;
                Inkscript.numtest = 1;

                if (Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString() && Inkscript.story.variablesState["motanieGolovoi"].ToString() != "0")
                {
                    Debug.Log("mot");
                  //  personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 3") as RuntimeAnimatorController;
                      imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                   // imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5) 1") as RuntimeAnimatorController;
                     personaj.GetComponent<Animator>().runtimeAnimatorController = null;
                    //imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                    // personaj.SetActive(false);
                    //Debug.Log("motanie");
                    transform.position = new Vector2(transform.position.x, transform.position.y);
                    /* imgMisly.SetActive(false);
                     imgPlayer.SetActive(false);
                     imgNPC.SetActive(false);
                     imgPodskazka.SetActive(true);
                     imgStat.SetActive(false);*/
                    leftbool = true;
                    leftbool2 = true;
                    rightbool = false;
                    centerbool = false;
                    rightbool2 = false;
                    centerbool2 = false;
                    Inkscript.numtest = 1;
                    Inkscript.enableMousebtn = false;
                    //txtstr = "Персефона";
                    // StartCoroutine(Dvizhenielocation());
                    Inkscript.boolTimer = false;
                    StartCoroutine(MotanieGolpvoi());
                    StartCoroutine(whoSayNaow());
                }
                 else
                  {
                      //   Debug.Log("Motanie 0: " + Inkscript.story.variablesState["motanieGolovoi"].ToString());
                      StartCoroutine(Dvizhenielocation());
                      StartCoroutine(whoSayNaow());

                  }
             //   StartCoroutine(Dvizhenielocation());
                //StartCoroutine(whoSayNaow());
                // StartCoroutine(zapuskText());
                // StartCoroutine(DvizheniePersonazha());
                //     StartCoroutine(Dvizhenielocation());
            }

       




            //  Inkscript.ZapuskTextFind();
            //  else
            //  {
            //     imgPlayer.SetActive(true);
            //     imgNPC.SetActive(false);
            //  }

            /*  if (Inkscript.numtest == 1 && Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())
              {

                  personaj.transform.position = new Vector2(-3.4f, -0.85f);
                 // spriteNPC.transform.localScale = new Vector2(-0.25f, 0.25f);

                spritePlayer.transform.localScale = new Vector2(1.6f, 1.6f);
                 // spritePlayerDress.transform.localScale = new Vector2(-0.25f, 0.25f);
                  //spritePlayerHair.transform.localScale = new Vector2(-0.25f, 0.25f);

                  imgPlayer.SetActive(true);
                  imgNPC.SetActive(false);

                  rightbool = false;
                  leftbool = true;
                  Inkscript.enableMousebtn = false;
                  Inkscript.numtest = 0;
                  Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
               //   Debug.Log("1:" + Inkscript.story.variablesState["name"].ToString());
                  // PlayerPrefs.SetInt("Numpers", numpers);
              }
              else if (Inkscript.numtest == 1 && Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString())
              {

               //   personaj.transform.position = new Vector2(3.4f, -1.4f);
                //  spriteNPC.transform.localScale = new Vector2(0.25f, 0.25f);

                  spritePlayer.transform.localScale = new Vector2(-1.6f, 1.6f);
                 // spritePlayerDress.transform.localScale = new Vector2(0.25f, 0.25f);
                //  spritePlayerHair.transform.localScale = new Vector2(0.25f, 0.25f);

                  imgPlayer.SetActive(false);
                  imgNPC.SetActive(true);
                  //   imgPlayer.SetActive(false);
                  //  imgNPC.SetActive(true);

              }*/
            //StartCoroutine(test());

        }

        // if (Inkscript.Inknm != "Персефона" && Inkscript.Inknm != "..." && Inkscript.Inknm != "Подсказка" && Inkscript.Inknm != "window" && Inkscript.Inknm != "")
        if (txtstr != Inkscript.story.variablesState["Gven"].ToString() && txtstr != "..." && txtstr != "Подсказка" && txtstr != "window" && txtstr != "")
        {
          /*  if (Inkscript.story.variablesState["name"].ToString() != Inkscript.story.variablesState["whonext"].ToString())
            {
                Inkscript.BackPers = 2;
                Inkscript.proverkaBackPers = 2;
            }
            else
            {
                Inkscript.BackPers = 0;
                // Inkscript.proverkaBackPers = 1;
            }*/
            if (Inkscript.numtest == 1 && Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())

            {

              /*  if (Inkscript.story.variablesState["name"].ToString() != Inkscript.story.variablesState["whonext"].ToString())
                {
                    Inkscript.BackPers = 2;
                    Inkscript.proverkaBackPers = 2;
                }
                else
                {
                    Inkscript.BackPers = 0;
                    // Inkscript.proverkaBackPers = 1;
                }*/


              //  Inkscript.proverkaBackPers = 2;
              //  Inkscript.BackPers = 2;
                personaj.GetComponent<Animator>().runtimeAnimatorController = null;
                if (Inkscript.story.variablesState["heightPers"].ToString() == "0")
                {

                    personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController;

                    imgNPC.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1)") as RuntimeAnimatorController;
                }
                if (Inkscript.story.variablesState["heightPers"].ToString() == "2")
                {

                    personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController;

                    imgNPC.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1) 2") as RuntimeAnimatorController;
                }
                spriteNPC.transform.localScale = new Vector2(0.3f, 0.3f);

                           


                imgPlayer.SetActive(false);
                imgNPC.SetActive(true);
                rightbool = true;
                leftbool = false;

               
                WhoSayRight.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayRight;
              


                Inkscript.numtest = 0;

            /*    if (Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString() && Inkscript.story.variablesState["motanieGolovoi"].ToString() != "0")
                {
                    Debug.Log("mot");
                    personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 3") as RuntimeAnimatorController;
                    //  imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                    imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5) 1") as RuntimeAnimatorController;
                    // personaj.GetComponent<Animator>().runtimeAnimatorController = null;
                    //imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                    // personaj.SetActive(false);
                    //Debug.Log("motanie");
                    transform.position = new Vector2(transform.position.x, transform.position.y);
                   
                    leftbool = true;
                    leftbool2 = true;
                    rightbool = false;
                    centerbool = false;
                    rightbool2 = false;
                    centerbool2 = false;
                    Inkscript.numtest = 1;
                    Inkscript.enableMousebtn = false;
                    Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                    //txtstr = "Персефона";
                    // StartCoroutine(Dvizhenielocation());
                    StartCoroutine(MotanieGolpvoi());
                    StartCoroutine(whoSayNaow());
                }
                else
                {
                    Debug.Log("Pers");
                    Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                    //   Debug.Log("Motanie 0: " + Inkscript.story.variablesState["motanieGolovoi"].ToString());
                    StartCoroutine(Dvizhenielocation());
                    StartCoroutine(whoSayNaow());

                }
                */

                Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();

                spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
                spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
                spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
                spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
                // Debug.Log("0:" + Inkscript.story.variablesState["name"].ToString());

                //PlayerPrefs.SetInt("Numpers", numpers);
            }
           else if (Inkscript.numtest == 1 && Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString())

            {
              /*  if (Inkscript.story.variablesState["name"].ToString() != Inkscript.story.variablesState["whonext"].ToString())
                {
                    Inkscript.BackPers = 2;
                    Inkscript.proverkaBackPers = 2;
                }
                else
                {
                    Inkscript.BackPers = 0;
                    // Inkscript.proverkaBackPers = 1;
                }*/
              //  Inkscript.BackPers = 0;
              
             
                spriteNPC.transform.localScale = new Vector2(0.3f, 0.3f);

            
              
                imgPlayer.SetActive(false);
                imgNPC.SetActive(true);
              
                WhoSayRight.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayRight;
               
                Inkscript.numtest = 0;

               
            }
         if (Inkscript.numtest == 0 &&   Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())

            {

                personaj.GetComponent<Animator>().runtimeAnimatorController = null;
             /*   if (Inkscript.story.variablesState["name"].ToString() != Inkscript.story.variablesState["whonext"].ToString())
                {
                    Inkscript.BackPers = 2;
                    Inkscript.proverkaBackPers = 2;
                }
                else
                {
                    Inkscript.BackPers = 0;
                    // Inkscript.proverkaBackPers = 0;
                }*/
                // imgNPC.GetComponent<Animator>().runtimeAnimatorController = null;
               // Inkscript.BackPers = 3;
                //Inkscript.proverkaBackPers = 3;

               // Debug.Log("3   BackPers: " + Inkscript.BackPers + ".proverkaBackPers:   " + Inkscript.proverkaBackPers);

                //  Debug.Log("personagest: " + Inkscript.story.variablesState["personagest"].ToString());//"numtest = 0  Ne ravno" + Inkscript.Inknm);
                if (Inkscript.story.variablesState["personagest"].ToString() == "0")
                {
                    // WhoSayLeft
                    // WhoSayRight
                    // WhoSayPodskazka
                    //WhoSay
                  //  Debug.Log("ravno 0 personages");
                    personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers") as RuntimeAnimatorController;
                    imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;

                    /* Vector3 point = Camera.ViewportToWorldPoint(new Vector3(-.5f, .3f, .5f)); //лево
                     //personaj.transform.position = new Vector2(-11.4f,-0.85f);
                     personaj.transform.position = point;

                    // Vector3 point = v3Left;
                   //  point.x = v3Left.x - 2.4f;
                     personaj.transform.position = point;*/

                    // personaj.transform.position = new Vector2(-11.4f, -0.85f);

                    spriteNPC.transform.localScale = new Vector2(-0.3f, 0.3f);
                    imgPlayer.SetActive(true);
                    imgNPC.SetActive(false);

                //    WhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
                    WhoSayLeft.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayLeft;
                    //  WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayNow;
                   // StartCoroutine(whoSayNaow());
                    rightbool = false;
                    leftbool = true;
                  //  Inkscript.enableMousebtn = false;
                    Inkscript.numtest = 1;

                    Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                    spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
                    spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
                }
                else if (Inkscript.story.variablesState["personagest"].ToString() == "1")
                {
                    // WhoSayLeft
                    // WhoSayRight
                    // WhoSayPodskazka
                    //WhoSay
                    Debug.Log("ravno 1 personages");
                    if (Inkscript.story.variablesState["heightPers"].ToString() == "0")
                    {

                        personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController;

                        imgNPC.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1)") as RuntimeAnimatorController;
                    }
                    if (Inkscript.story.variablesState["heightPers"].ToString() == "2")
                    {

                        personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController;

                        imgNPC.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1) 2") as RuntimeAnimatorController;
                    }
                 //   personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController;
                   // imgNPC.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1)") as RuntimeAnimatorController;
                    /* Vector3 point = Camera.ViewportToWorldPoint(new Vector3(1.5f, .3f, .5f));

                     personaj.transform.position = point;

                    // Vector3 point = v3Right;
                   //  point.x = v3Right.x + 2.4f;
                     personaj.transform.position = point;*/

                    // personaj.transform.position = new Vector2(11.4f, -0.85f);
                    spriteNPC.transform.localScale = new Vector2(0.3f, 0.3f);
                    imgPlayer.SetActive(false);
                    imgNPC.SetActive(true);

                    WhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
                    WhoSayRight.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayRight;
                    WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayNow;

                    rightbool = true;
                    leftbool = false;
                   // Inkscript.enableMousebtn = false;
                    Inkscript.numtest = 1;

                    Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                    spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
                    spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
                }

                // spriteNPC.transform.localScale = new Vector2(-0.34f, 0.34f);


                //  imgPlayer.SetActive(true);
                // imgNPC.SetActive(false);

                //  rightbool = false;
                //   leftbool = true;
                //  Inkscript.enableMousebtn = false;
                // Inkscript.numtest = 1;

                //   Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                // Debug.Log("1:" + Inkscript.story.variablesState["name"].ToString());
                // PlayerPrefs.SetInt("Numpers", numpers);
            }
            else if (Inkscript.numtest == 0 && Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString())

            {
                /* if (Inkscript.story.variablesState["name"].ToString() != Inkscript.story.variablesState["whonext"].ToString())
                  {
                      Inkscript.BackPers = 2;
                      Inkscript.proverkaBackPers = 2;
                  }
                  else
                  {
                      Inkscript.BackPers = 0;
                    // Inkscript.proverkaBackPers = 0;
                  }*/
                //  Inkscript.BackPers = 0;
                if (Inkscript.story.variablesState["heightPers"].ToString() == "0")
                {

                  //  personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController;

                    imgNPC.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1)") as RuntimeAnimatorController;
                }
                if (Inkscript.story.variablesState["heightPers"].ToString() == "2")
                {

                //    personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController;

                    imgNPC.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1) 2") as RuntimeAnimatorController;
                }
              //  imgNPC.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1)") as RuntimeAnimatorController;
                // rightbool = true;
              //  Debug.Log("4   BackPers: " + Inkscript.BackPers + ".proverkaBackPers:   " + Inkscript.proverkaBackPers);
                //  personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController;
              
                //  personaj.transform.position = new Vector2(3.4f, -1.4f);


                /*spritePlayer.transform.localScale = new Vector2(0.25f, 0.25f);
                spritePlayerDress.transform.localScale = new Vector2(0.25f, 0.25f);
                spritePlayerHair.transform.localScale = new Vector2(0.25f, 0.25f);*/

                if (personaj.transform.position.x == 1.35f)
                //if (personaj.transform.position == Camera.ViewportToWorldPoint(new Vector3(.8f, .4f, .5f)))
                {
                    // WhoSayLeft
                    // WhoSayRight
                    // WhoSayPodskazka
                    //WhoSay+
                    rightbool = true;
                  //  historyScript.panelka.runtimeAnimatorController = Resources.Load("Animator/Right") as RuntimeAnimatorController;
                    historyScript.panelka.enabled = true;
                    //  Debug.Log("imgNPC = true");
                    imgPlayer.SetActive(false);
                     imgNPC.SetActive(true);

                    WhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
                    WhoSayRight.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayRight;
                    WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayNow;

                    spriteNPC.transform.localScale = new Vector2(0.3f, 0.3f);
                    // imgPlayer.SetActive(true);
                    // imgNPC.SetActive(false);
                    Inkscript.numtest = 0;
                 //   StartCoroutine(zapuskText());
                    // Inkscript.ZapuskTextFind();
                }
                if (personaj.transform.position.x == -1.35f)
               // if (personaj.transform.position == Camera.ViewportToWorldPoint(new Vector3(.2f, .4f, .5f)))
                {// WhoSayLeft
                 // WhoSayRight
                 // WhoSayPodskazka
                 //WhoSay
                    leftbool = true;
                   // historyScript.panelka.runtimeAnimatorController = Resources.Load("Animator/Left") as RuntimeAnimatorController;
                    historyScript.panelka.enabled = true;
                //  Debug.Log("imgNPC = false");
                    imgPlayer.SetActive(true);
                     imgNPC.SetActive(false);

                    WhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
                    WhoSayLeft.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayLeft;
                    WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayNow;

                    spriteNPC.transform.localScale = new Vector2(-0.3f, 0.3f);
                    // imgPlayer.SetActive(false);
                    // imgNPC.SetActive(true);
                    Inkscript.numtest = 1;
                //   StartCoroutine(zapuskText());
                    //  Inkscript.ZapuskTextFind();
                }
                if (personaj.transform.position.x == 0)
             
               
                {
                   // Debug.Log("ravno v3Right");

                    //   leftbool = true;
                    imgPlayer.SetActive(false);
                    imgNPC.SetActive(true);
                   // personaj.transform.position = v3Right;
                  //  personaj.transform.position = Camera.ViewportToWorldPoint(new Vector3(.8f, .4f, .5f));
                
                    spriteNPC.transform.localScale = new Vector2(0.3f, 0.3f);
                   
                    Inkscript.numtest = 1;
                  //  StartCoroutine(zapuskText());
                    // Inkscript.ZapuskTextFind();
                }

           
            }
            //  StartCoroutine(Dvizhenielocation());
            // StartCoroutine(whoSayNaow());
            // StartCoroutine(DvizheniePersonazha());
            // Inkscript.ZapuskTextFind();
            // Debug.Log(StartCoroutine(Dvizhenielocation()));

            StartCoroutine(Dvizhenielocation());
            StartCoroutine(whoSayNaow());
        }
        //if(txtstr != "Персефона" && txtstr != "..." && txtstr != "Подсказка" && txtstr != "window" && txtstr == "")
        // if(Inkscript.namewindow != Inkscript.story.variablesState["namewindow"].ToString())
        if (txtstr == "")// || Inkscript.namewindow != Inkscript.story.variablesState["namewindow"].ToString()) //)
         {
            // WhoSayLeft
            // WhoSayRight
            // WhoSayPodskazka
            //WhoSay
            //WhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>();
            //WhoSayPodskazka.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaPodskazka;
           // WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSay;

            historyScript.ZapuskVsplivausheeOkno();
           // historyScript.txtVsplivausheeOkno.text = Inkscript.story.variablesState["namewindow"].ToString();
            Inkscript.namewindow = Inkscript.story.variablesState["namewindow"].ToString();
            /*  txtDialog.fontSize = 40;
              imgMisly.transform.position = new Vector2(imgMisly.transform.position.x + 0.15f, imgMisly.transform.position.y + 3.8f);
              txtinImageinDialogMisly.text = Inkscript.story.variablesState["namewindow"].ToString();
              imgMisly.SetActive(true);
              imgMislyIconka.SetActive(true);
              //imgPlayer.SetActive(false);
              //imgNPC.SetActive(true);
              imgPodskazka.SetActive(false);
              imgStat.SetActive(false);
              leftbool = false;
              rightbool = false;
            //  centerbool = true;
              Inkscript.enableMousebtn = false;
              // StartCoroutine(Dvizhenielocation());
               StartCoroutine(PoyavlenieStatov());
              Inkscript.namewindow = Inkscript.story.variablesState["namewindow"].ToString();*/
            // StartCoroutine(PoyavlenieWindow());
        }
       


        if ((txtstr == "Подсказка" || txtstr == "...") && Inkscript.story.variablesState["motanieGolovoi"].ToString() == "0" && txtstr != Inkscript.Inknm.ToString() )
        {
            //   personaj.GetComponent<Animator>().runtimeAnimatorController = null;
            //  Debug.Log("podskazka = Inkm  " + "Textr: " +txtstr+ "  inkname: " + Inkscript.Inknm.ToString());
            //  personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 3") as RuntimeAnimatorController;
            //   personaj.GetComponent<Animator>().enabled = true;
         //   Debug.Log("Podskazka");

          //  Inkscript.BackPers = Inkscript.proverkaBackPers ;
            //Inkscript.DostupKischeznoveniuPersa();
           // StartCoroutine(Inkscript.ischeznoveniePersa());
            
            // WhoSayLeft
            // WhoSayRight
            // WhoSayPodskazka
            //WhoSay

            //  WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSay;

            // txtDialog.fontSize = 40;
            //  personaj.transform.position = new Vector2(0f, -1.4f);
            //txtstr = "Подсказка";
            // transform.position = new Vector2(transform.position.x, transform.position.y);
            //   spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
            // spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
            // spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
            // spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
            // Inkscript.BackPers = 1;
            Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();

            imgMisly.SetActive(false);
            imgPlayer.SetActive(false);
            imgNPC.SetActive(false);
            imgStat.SetActive(false);
            imgPodskazka.SetActive(true);
            imgPodskazka.GetComponent<Animator>().runtimeAnimatorController = null;

            //   historyScript.panelkaA;
            // historyScript.panelka.runtimeAnimatorController = Resources.Load("Animator/PanelTXTBTN") as RuntimeAnimatorController;
            //historyScript.panelka.Play("Animator/PanelTXTBTN");
            leftbool = false;
              rightbool = false;
           centerbool = true;
            
            //     Inkscript.rectPanelWithText.pivot = new Vector2(1, 0.5f);

            // uitransform.anchorMin = new Vector2(1, 0.5f);
            //  uitransform.anchorMax = new Vector2(1, 0.5f);
            // uitransform.pivot = new Vector2(1, 0.5f);
            // centerbool = false;
            //  Inkscript.enableMousebtn = true;
           // Inkscript.ZapuskTextFind();
            StartCoroutine(Dvizhenielocation());
           
            WhoSayPodskazka.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaPodskazka; // назначаем спрайт диалоговому окну
          //  WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSay; // назначаем спрайт плашки с именем
           // Debug.Log(WhoSay);
            StartCoroutine(whoSay());
            // StartCoroutine(NothingDvizhenie());
        }

       
       else if ((txtstr == "Подсказка" || txtstr == "...") && Inkscript.story.variablesState["motanieGolovoi"].ToString() == "0" && txtstr == Inkscript.Inknm.ToString())
        {
        //    Debug.Log("podskazka !!!= Inkm  " + "Textr: " + txtstr + "  inkname: "  + Inkscript.Inknm.ToString());
            // WhoSayLeft
            // WhoSayRight
            // WhoSayPodskazka
            //WhoSay

            //  WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSay;

            // txtDialog.fontSize = 40;
            //  personaj.transform.position = new Vector2(0f, -1.4f);
            //txtstr = "Подсказка";
            // transform.position = new Vector2(transform.position.x, transform.position.y);
            //   spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
            // spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
            // spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
            // spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
            //Inkscript.BackPers = 0;
            Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();

            imgMisly.SetActive(false);
            imgPlayer.SetActive(false);
            imgNPC.SetActive(false);
            imgStat.SetActive(false);
            imgPodskazka.SetActive(true);


            //   historyScript.panelkaA;
            // historyScript.panelka.runtimeAnimatorController = Resources.Load("Animator/PanelTXTBTN") as RuntimeAnimatorController;
            //historyScript.panelka.Play("Animator/PanelTXTBTN");
            leftbool = false;
            rightbool = false;
            centerbool = true;
            imgPodskazka.GetComponent<Animator>().runtimeAnimatorController = null;
            //     Inkscript.rectPanelWithText.pivot = new Vector2(1, 0.5f);

            // uitransform.anchorMin = new Vector2(1, 0.5f);
            //  uitransform.anchorMax = new Vector2(1, 0.5f);
            // uitransform.pivot = new Vector2(1, 0.5f);
            // centerbool = false;
            //  Inkscript.enableMousebtn = true;
            //Inkscript.ZapuskTextFind();
            StartCoroutine(Dvizhenielocation());

            WhoSayPodskazka.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaPodskazka; // назначаем спрайт диалоговому окну
                                                                                                        //  WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSay; // назначаем спрайт плашки с именем
                                                                                                        // Debug.Log(WhoSay);
            StartCoroutine(whoSay());
            // StartCoroutine(NothingDvizhenie());
        }
        // if (txtstr == "motanie")
     /*   if (Inkscript.story.variablesState["motanieGolovoi"].ToString() != "0" && txtstr != Inkscript.story.variablesState["Gven"].ToString()&& txtstr != Inkscript.Inknm.ToString())
        {
            Debug.Log("motanie");
            if (personaj.GetComponent<Animator>().runtimeAnimatorController == Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController)
            {
                personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 4") as RuntimeAnimatorController;

            }
       //     transform.position = new Vector2(transform.position.x, transform.position.y);
           imgMisly.SetActive(false);
            imgPlayer.SetActive(false);
            imgNPC.SetActive(false);
            imgPodskazka.SetActive(true);
            imgStat.SetActive(false);
            leftbool2 = true;
             rightbool = false;
             centerbool = true;
            rightbool2 = false;
            centerbool2 = false;
           Inkscript.enableMousebtn = false;
            //txtstr = "Персефона";
            // StartCoroutine(Dvizhenielocation());
            StartCoroutine(MotanieGolpvoi());
        }*/
        if (Inkscript.story.variablesState["motanieGolovoi"].ToString() != "0" && txtstr != Inkscript.story.variablesState["Gven"].ToString())// && txtstr == Inkscript.Inknm.ToString())
        {
        //    Debug.Log("motanie");
            if (personaj.GetComponent<Animator>().runtimeAnimatorController == Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController)
            {
                personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 4") as RuntimeAnimatorController;

            }
            //     transform.position = new Vector2(transform.position.x, transform.position.y);
            imgMisly.SetActive(false);
            imgPlayer.SetActive(false);
            imgNPC.SetActive(false);
            // imgPodskazka.SetActive(true);
            imgPodskazka.SetActive(false);

            imgStat.SetActive(false);
            leftbool2 = true;
            rightbool = false;
            centerbool = true;
            rightbool2 = false;
            centerbool2 = false;
            Inkscript.enableMousebtn = false;
            //txtstr = "Персефона";
            // StartCoroutine(Dvizhenielocation());
            Inkscript.boolTimer = false;
            StartCoroutine(MotanieGolpvoi());
        }
        if (Inkscript.namewindow != Inkscript.story.variablesState["namewindow"].ToString())//txtstr.Contains("window"))
        {
            /*  Inkscript.vikluchitHistoryText = false;
              historyScript.ZapuskVsplivausheeOkno();
              historyScript.txtInsidevsplivOknoMain.text = Inkscript.story.variablesState["namewindow"].ToString();
              historyScript.txtVsplivausheeOkno.text = Inkscript.story.variablesState["namewindow"].ToString();
           Inkscript.namewindow = Inkscript.story.variablesState["namewindow"].ToString();*/
            //********************
            //   historyScript.txtPlashkaStat.text = "modesty + 1";
            //  ZapuskVsplivausheeOkno

            //   txtDialog.fontSize = 40;

          //  Debug.Log("namewindow");
             txtinImageinDialogMisly.text = Inkscript.story.variablesState["namewindow"].ToString(); 
           //   imgMisly.transform.position = new Vector2(imgMisly.transform.position.x + 0.5f, 300f);
        //    Debug.Log(imgMisly.transform.position);
              imgMisly.SetActive(true);
              imgMislyIconka.SetActive(true);

              Inkscript.namewindow = Inkscript.story.variablesState["namewindow"].ToString();
              
              StartCoroutine(PoyavlenieStatov());
        }


        
        
       
         //if (modestyValue != Inkscript.modesty)
        if (Inkscript.modesty != int.Parse(Inkscript.story.variablesState["modesty"].ToString()))
        {
            historyScript.ZapuskPlashka();
            historyScript.txtPlashkaStat.text = "Милосердие +1";//"modesty + 1";
            historyScript.icoPlashkaStat.GetComponent<Image>().sprite = spriteStat[0];
            Inkscript.modesty = int.Parse(Inkscript.story.variablesState["modesty"].ToString());
         

        }
        //  if (braveryValue != Inkscript.bravery)
        if (Inkscript.bravery != int.Parse(Inkscript.story.variablesState["bravery"].ToString()))
        {
            historyScript.ZapuskPlashka();
            historyScript.txtPlashkaStat.text = "Властность +1";//"bravery + 1";
            historyScript.icoPlashkaStat.GetComponent<Image>().sprite = spriteStat[1];
            Inkscript.bravery = int.Parse(Inkscript.story.variablesState["bravery"].ToString());


            /* txtDialog.fontSize = 21;
             txtinImageinDialogStat.text = "bravery + 1";
             imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
             imgStat.SetActive(true);
             statImg.GetComponent<Image>().sprite = spriteStat[1];
             //  braveryValue = Inkscript.bravery;
             Inkscript.bravery = int.Parse(Inkscript.story.variablesState["bravery"].ToString());
           //  PlayerPrefs.SetInt("Bravery", braveryValue);
             imgStat.GetComponent<Image>();
             StartCoroutine(PoyavlenieStatov());*/

        }

       
       
    
     

        //if (levkippaloveValue != Inkscript.levkippalove)
        if (Inkscript.levkippalove != int.Parse(Inkscript.story.variablesState["levkippalove"].ToString()))
        {
         /*   txtinImageinDialogStat.text = "levkippalove + 1";
            imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
            imgStat.SetActive(true);
            statImg.GetComponent<Image>().sprite = spriteStat[2];*/
            //  levkippaloveValue = Inkscript.levkippalove;
            Inkscript.levkippalove = int.Parse(Inkscript.story.variablesState["levkippalove"].ToString());
          //  PlayerPrefs.SetInt("Levkippalove", levkippaloveValue);
           // imgStat.GetComponent<Image>();
           // StartCoroutine(PoyavlenieStatov());

        }
        //if (levkippafriendValue != Inkscript.levkippafriend)
        if (Inkscript.levkippafriend != int.Parse(Inkscript.story.variablesState["levkippafriend"].ToString()))
        {
          /*  txtinImageinDialogStat.text = "levkippafriend + 1";
            imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
            imgStat.SetActive(true);
            statImg.GetComponent<Image>().sprite = spriteStat[3];
           // levkippafriendValue = Inkscript.levkippafriend;*/
            Inkscript.levkippafriend = int.Parse(Inkscript.story.variablesState["levkippafriend"].ToString());
         //   PlayerPrefs.SetInt("Levkippafriend", levkippafriendValue);
         //   imgStat.GetComponent<Image>();
            //StartCoroutine(PoyavlenieStatov());

        }
        // if (admetloveValue != Inkscript.admetlove)
        if (Inkscript.admetlove != int.Parse(Inkscript.story.variablesState["admetlove"].ToString()))
        {
            txtinImageinDialogStat.text = "admetlove + 1";
            imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
            imgStat.SetActive(true);
            statImg.GetComponent<Image>().sprite = spriteStat[0];
            //admetloveValue = Inkscript.admetlove;
            Inkscript.admetlove = int.Parse(Inkscript.story.variablesState["admetlove"].ToString());
           // PlayerPrefs.SetInt("Admetlove", admetloveValue);
            imgStat.GetComponent<Image>();
            StartCoroutine(PoyavlenieStatov());

        }

        // if (creationValue != Inkscript.creation)
        if (Inkscript.creation != int.Parse(Inkscript.story.variablesState["creation"].ToString()))
        {
            historyScript.ZapuskPlashka();
            historyScript.txtPlashkaStat.text = "Богиня Созидания + 1";
            historyScript.icoPlashkaStat.GetComponent<Image>().sprite = spriteStat[2];
            Inkscript.creation = int.Parse(Inkscript.story.variablesState["creation"].ToString());
            /*  txtDialog.fontSize = 21;
              txtinImageinDialogStat.text = "creation + 1";
              imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
              imgStat.SetActive(true);
              statImg.GetComponent<Image>().sprite = spriteStat[1];
              //creationValue = Inkscript.creation;
              Inkscript.creation = int.Parse(Inkscript.story.variablesState["creation"].ToString());
            //  PlayerPrefs.SetInt("Creation", creationValue);
              imgStat.GetComponent<Image>();
              StartCoroutine(PoyavlenieStatov());*/

        }

       

        //   if (destructionValue != Inkscript.destruction)
        if (Inkscript.destruction != int.Parse(Inkscript.story.variablesState["destruction"].ToString()))
        {
            historyScript.ZapuskPlashka();
            historyScript.txtPlashkaStat.text = "Богиня Разрушения + 1";
            historyScript.icoPlashkaStat.GetComponent<Image>().sprite = spriteStat[3];
            Inkscript.destruction = int.Parse(Inkscript.story.variablesState["destruction"].ToString());
            /*  txtDialog.fontSize = 21;
              txtinImageinDialogStat.text = "destruction + 1";
              imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
              imgStat.SetActive(true);
              statImg.GetComponent<Image>().sprite = spriteStat[1];
              // destructionValue = Inkscript.destruction;
              Inkscript.destruction = int.Parse(Inkscript.story.variablesState["destruction"].ToString());
             // PlayerPrefs.SetInt("Destruction", creationValue);
              imgStat.GetComponent<Image>();
              StartCoroutine(PoyavlenieStatov());*/

        }

        if (Inkscript.slava != int.Parse(Inkscript.story.variablesState["slava"].ToString()))
        {
            historyScript.ZapuskPlashka();
            historyScript.txtPlashkaStat.text = "+1 Слава";//"modesty + 1";
            historyScript.icoPlashkaStat.GetComponent<Image>().sprite = spriteStat[0];
            Inkscript.slava = int.Parse(Inkscript.story.variablesState["slava"].ToString());
   

        }
        if (Inkscript.voinstvennist != int.Parse(Inkscript.story.variablesState["voinstvennist"].ToString()))
        {
            historyScript.ZapuskPlashka();
            historyScript.txtPlashkaStat.text = "+1 Воинственность";//"modesty + 1";
            historyScript.icoPlashkaStat.GetComponent<Image>().sprite = spriteStat[1];
            Inkscript.voinstvennist = int.Parse(Inkscript.story.variablesState["voinstvennist"].ToString());


        }
        if (Inkscript.mudrost != int.Parse(Inkscript.story.variablesState["mudrost"].ToString()))
        {
            historyScript.ZapuskPlashka();
            historyScript.txtPlashkaStat.text = "+1 Мудрость";//"modesty + 1";
            historyScript.icoPlashkaStat.GetComponent<Image>().sprite = spriteStat[2];
            Inkscript.mudrost = int.Parse(Inkscript.story.variablesState["mudrost"].ToString());


        }
        //  Inkscript.ZapuskTextFind();

        StartCoroutine(Asd());
       
    }

   // WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSay; // назначаем спрайт плашки с именем
     IEnumerator whoSay()
    {
        yield return new WaitForSeconds(0.01f);
        WhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>(); // ищем плашку, где должно писаться имя
        WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSay; // назначаем спрайт плашки с именем
    }
    IEnumerator whoSayNaow()
    {
        yield return new WaitForSeconds(0.01f);
        WhoSay = GameObject.FindGameObjectWithTag("TagPlashkaWhoSay").GetComponent<Image>(); // ищем плашку, где должно писаться имя
        WhoSay.GetComponent<Image>().sprite = Inkscript.numberLevel[LVL].plashkaWhoSayNow; // назначаем спрайт плашки с именем
    }
    // StartCoroutine(Namelevkippa());


    /*  IEnumerator Namelevkippa()
 {
     yield return new WaitForSeconds(0.01f);
     txtWhoSay.text = "Левкиппа";
 }
 */
    public float izmenenieStatov;
    // txtinImageinDialogPodskazka.text = txtDialog.text;


 
    void Update()
    {
     

    }
    public int a;

    public void Cont(string text)
    {
        meshtxtinImageinDialog.text = meshtxtinImageinDialog.text + meshtxtDialog.text[a];
        meshtxtinImageinDialogNPC.text = meshtxtinImageinDialogNPC.text + meshtxtDialog.text[a];

        meshtxtinImageinDialogPodskazka.text = meshtxtinImageinDialogPodskazka.text + meshtxtDialog.text[a];




        //   public TextMesh meshtxtinImageinDialog;
        // public Text txtinImageinDialogNPC;
        //  public TextMesh meshtxtinImageinDialogNPC;
        // yield return new WaitForSeconds(0.000000000001f);
        if (a == meshtxtDialog.text.Length - 1)
        {
            if (Inkscript.story.variablesState["motanieGolovoi"].ToString() == "0" && !Inkscript.PanelWithText.transform.Find("Button(Clone)"))
            {

                Inkscript.enableMousebtn = true;
            }

           // StopCoroutine(TextCoroutine(text));
        }
        else if (a < meshtxtDialog.text.Length)
        {
            a = a + 1;
            Cont(text);
        }
        
    }
    public int b;
    public int c;
    public string pech;
    
    IEnumerator pechatanie()
    {
        yield return new WaitForSeconds(0.2f);

       
        StartCoroutine(TextCoroutine());

    }
    IEnumerator TextCoroutine()   // ******************это не нужно
    {

        pech = meshtxtDialog.text;
        string[] split = pech.Split(); // разделяем строку на слова и в массив каждое слово отправляем
        for (int i = 0; i < split.Length; i++)  // перебераем слова из массива и печптпем в плашке
        {

            meshtxtinImageinDialogPodskazka.text = meshtxtinImageinDialogPodskazka.text + split[i].ToString() + " " ;
            meshtxtinImageinDialogNPC.text = meshtxtinImageinDialogNPC.text + split[i].ToString() + " ";
            meshtxtinImageinDialog.text = meshtxtinImageinDialog.text + split[i].ToString() + " ";
            //  txtinImageinDialog.text = txtinImageinDialog.text + split[i].ToString();
            //txtinImageinDialogNPC.text = txtinImageinDialogNPC.text + split[i].ToString();
            //  Debug.Log(split[i]);
           // StartCoroutine(izmenitCvet());
            yield return new WaitForSeconds(0.03f);
        }
        if (Inkscript.story.variablesState["motanieGolovoi"].ToString() == "0" && !Inkscript.PanelWithText.transform.Find("Button(Clone)"))
        {
            // Debug.Log("Enable mouse");
            Inkscript.enableMousebtn = true;
        }
        pech = "";
     

     //   Debug.Log(Convert.ToInt32(meshtxtinImageinDialogPodskazka.Lines.Length));


    }
    public ArrayList arr;
    string testcolortext;
  
    IEnumerator PoyavlenieWindow()
    {
       
        yield return new WaitForSeconds(0.01f);
      //  Debug.Log("StartischznovenieWindow");
        if (izmenenieStatov >= 0 && izmenenieStatov < 1)
        {
         //   imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
           // imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(0f, 0f, 0f, izmenenieStatov);
            izmenenieStatov = izmenenieStatov + 0.02f;
            StartCoroutine(PoyavlenieWindow());
        }
        if (izmenenieStatov >= 1)
        {
          //  imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
          //  imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f,1f);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(0f, 0f, 0f, 1f);
        //    Debug.Log("StartischznovenieWindow");
            StartCoroutine(StartischznovenieWindow());
           StopCoroutine(PoyavlenieWindow());
        }


     }
    IEnumerator StartischznovenieWindow()
    {
        yield return new WaitForSeconds(2f);
        StartCoroutine(IscheznovenieWindow());
      
    }
    IEnumerator IscheznovenieWindow()
    {
        yield return new WaitForSeconds(0.01f);

        if (izmenenieStatov > 0 )
        {
            //imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
          //  imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(0f, 0f, 0f, izmenenieStatov);
            izmenenieStatov = izmenenieStatov - 0.02f;

            // prevnumLocation = numLocation;

            StartCoroutine(IscheznovenieWindow());
        }
        else
        {
           // imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
           // statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
           // imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            //imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f,0f);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(0f, 0f, 0f, 0f);
        }

    }


        IEnumerator PoyavlenieStatov()
    {
        yield return new WaitForSeconds(0.01f);
        if (izmenenieStatov >= 0 && izmenenieStatov < 1)
        {
            imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            txtinImageinDialogStat.color = new Color(255f, 255f, 255f, izmenenieStatov);
            imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            izmenenieStatov = izmenenieStatov + 0.02f;
        
        StartCoroutine(PoyavlenieStatov());
        }
		if (izmenenieStatov >= 1)
		{
            imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            txtinImageinDialogStat.color = new Color(255f, 255f, 255f, 1f);
            imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(255f, 255f, 255f, 1f);
            // StartCoroutine(UschezanieStatov());
            StartCoroutine(Asd());
            StopCoroutine(PoyavlenieStatov());


        }
    }
    IEnumerator UschezanieStatov()
    {
        yield return new WaitForSeconds(0.01f);

        if (izmenenieStatov > 0 && izmenenieStatov <= 1.25f)
        {

            imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            txtinImageinDialogStat.color = new Color(255f, 255f, 255f, izmenenieStatov);
             imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            izmenenieStatov = izmenenieStatov - 0.02f;

           // prevnumLocation = numLocation;

            StartCoroutine(UschezanieStatov());

        }
        else
        {
            imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
           txtinImageinDialogStat.color = new Color(255f, 255f, 255f, 255f);
          // txtinImageinDialogMisly.GetComponent<Text>().color = new Color(0f, 0f, 0f, 0f);
        }
      //  imgMisly.SetActive(false);
    }
    IEnumerator Asd()
    {
        yield return new WaitForSeconds(4f);
        StartCoroutine(UschezanieStatov());
    }

    IEnumerator NothingDvizhenie()
    {
        yield return new WaitForSeconds(0.001f);
        //  if (cam.transform.position != right.transform.position && prozrachnostPlayer != 1 || prozrachnostNPC != 0)
        //   {
        if (cam.transform.position == right.transform.position || cam.transform.position == left.transform.position || cam.transform.position == center.transform.position)
        {
            //  Inkscript.enableMousebtn = true;
            // Debug.Log(Inkscript.enableMousebtn);
            //}
            if (txtstr == Inkscript.story.variablesState["Gven"].ToString())
            {
                spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                prozrachnostPlayer = prozrachnostPlayer + 0.04f;

                spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                prozrachnostNPC = prozrachnostNPC + 0.04f;

                StartCoroutine(NothingDvizhenie());
            }
            else
            {
                spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                prozrachnostPlayer = prozrachnostPlayer - 0.04f;

                spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                prozrachnostNPC = prozrachnostNPC + 0.04f;

                StartCoroutine(NothingDvizhenie());

            }
        }


       // }
    }
    public Vector3 v3Left;
    public Vector3 v3Right;
    public Vector3 v3Center;

    IEnumerator Dvizhenielocation()
    {
      //  Debug.Log(float.Parse(Inkscript.story.variablesState["position"].ToString()));
        yield return new WaitForSeconds(0.001f);
        if (leftbool)
        {
            // Vector3 point = Camera.ScreenToViewportPoint(new Vector3(385f, .5f, .5f));
            // Vector3 point = Camera.ScreenToWorldPoint(new Vector3(.7f, .5f, .5f));

            //  Vector3 point = Camera.ViewportToWorldPoint(new Vector3(.7f, .5f, .5f));
            // cam.transform.position = Vector3.MoveTowards(cam.transform.position, point, speed * 3f * Time.deltaTime);
            // cam.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, speed * Time.deltaTime);
            // personaj.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, speed * Time.deltaTime);
            //  if (cam.transform.position != right.transform.position && prozrachnostPlayer != 1 || prozrachnostNPC != 0)
            // v3Left

            v3Right.x = float.Parse(Inkscript.story.variablesState["KoordinateX"].ToString()) + 0.8f;

          
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, v3Right, (speed-1f) * Time.deltaTime);
            //if (cam.transform.position != point && prozrachnostPlayer != 1 || prozrachnostNPC != 0)
            if (cam.transform.position != v3Right)// && prozrachnostPlayer != 1 || prozrachnostNPC != 0)
            {
                
                /*     if(txtstr == "Персефона")
                     {

                          spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                         spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                         spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                         prozrachnostPlayer = prozrachnostPlayer + 0.02f;



                         spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                         prozrachnostNPC = prozrachnostNPC - 0.02f;

                         StartCoroutine(Dvizhenielocation());
                     }
                     if (txtstr != "Персефона" && txtstr != "..." && txtstr != "Подсказка" && txtstr != "window" && txtstr != "")
                   //  else
                     {
                         spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                         spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                         spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                         prozrachnostPlayer = prozrachnostPlayer - 0.02f;

                         spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                         prozrachnostNPC = prozrachnostNPC + 0.02f;

                         StartCoroutine(Dvizhenielocation());

                     }
                */
                StartCoroutine(Dvizhenielocation());
            }

            else 
            {

           

            }
            //    if (cam.transform.position == right.transform.position)
            // if (cam.transform.position == point)
            if (cam.transform.position == v3Right) 
            {
         //  Debug.Log(v3Right);
                //Inkscript.enableMousebtn = true;
                StartCoroutine(StartdizheniePersonazha());
               // Debug.Log(cam.transform.position);
                StopCoroutine(Dvizhenielocation());
                // Debug.Log(Inkscript.enableMousebtn);
            }


        }
        if (rightbool)
        {
            v3Left.x = float.Parse(Inkscript.story.variablesState["KoordinateX"].ToString()) - 0.8f;
            //   Vector3 point = Camera.ScreenToViewportPoint(new Vector3(-385f, .5f, .5f));
            // Vector3 point = Camera.ScreenToWorldPoint(new Vector3(.3f, .5f, .5f));

            //   Vector3 point = Camera.ViewportToWorldPoint(new Vector3(.3f, .5f, .5f));
            //  cam.transform.position = Vector3.MoveTowards(cam.transform.position, point, speed * 3f * Time.deltaTime);
            // cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, speed * Time.deltaTime);
            // personaj.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, speed * Time.deltaTime);
            // if (cam.transform.position != left.transform.position && prozrachnostNPC != 1 || prozrachnostPlayer != 0)
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, v3Left, (speed - 1f) * Time.deltaTime);
            if (cam.transform.position != v3Left)// && prozrachnostNPC != 1 || prozrachnostPlayer != 0)
             //   if (cam.transform.position != point && prozrachnostNPC != 1 || prozrachnostPlayer != 0)
            {

                StartCoroutine(Dvizhenielocation());
            }
            else
            {

                // if (cam.transform.position == left.transform.position)
                //if (cam.transform.position == point)
                if (cam.transform.position == v3Left)
                {
                  //  Debug.Log(v3Left);
                    StartCoroutine(StartdizheniePersonazha());

                    StopCoroutine(Dvizhenielocation());

                }

            }
         


            //  else
            //  {
            //      StartCoroutine(StartdizheniePersonazha());


            // }

        }
        if (centerbool)
        { 
         // Debug.Log("vkluxhit center");
            StartCoroutine(StartdizheniePersonazha()); 
            StopCoroutine(Dvizhenielocation());

            /*  spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
              spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
              spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
              spriteNPC.color = (new Color(255f, 255f, 255f, 0f));

              StopCoroutine(Dvizhenielocation());*/

        }
    }
   

    IEnumerator StartdizheniePersonazha()
    {
        yield return new WaitForSeconds(0.00001f);
      //  Debug.Log("Zapusk Dvizhenie personazha");
        StartCoroutine(DvizheniePersonazha());
    }
    IEnumerator DvizheniePersonazha()
    {
        yield return new WaitForSeconds(0.1f);
       
        if (leftbool)
        {

            //Vector3 point = Camera.ViewportToWorldPoint(new Vector3(.2f, .4f, .5f));
            //  Vector3 point = v3Left;

            // point.x = v3Left.x -0.4f;
            // point.x = v3Left.x;
            // point.x = v3Left.x;
            //  Vector2 point = Camera.ViewportToWorldPoint(new Vector2(1f, 1f));
            //point.x = 0.2f;
            // point.y = -0.44f;
            //  Debug.Log("leftbool");
          /*  if(Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString()){
                Debug.Log("Gven ravno: " + Inkscript.story.variablesState["name"].ToString());
            }
            else
            {*/
                personaj.GetComponent<Animator>().enabled = true;
          //  }
           

          //  personaj.transform.position = Vector3.MoveTowards(personaj.transform.position, point, speed * 3f * Time.deltaTime);
       
             //   if (personaj.transform.position !=point)
              //  {
               /* if (txtstr == Inkscript.story.variablesState["Gven"].ToString())
                {

                    spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    prozrachnostPlayer = prozrachnostPlayer + 0.005f;



                    spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                    prozrachnostNPC = prozrachnostNPC - 0.005f;
                    StartCoroutine(DvizheniePersonazha());
                }*/
             //   if (txtstr != Inkscript.story.variablesState["Gven"].ToString() && txtstr != "..." && txtstr != "Подсказка" && txtstr != "window" && txtstr != "")
                //  else
             /*   {
                    spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    prozrachnostPlayer = prozrachnostPlayer - 0.005f;

                    spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                    prozrachnostNPC = prozrachnostNPC + 0.005f;

                    StartCoroutine(DvizheniePersonazha());

                }*/

              
           // }
          //  if (personaj.transform.position == left.transform.position)
              // if (personaj.transform.position == point)
          //  {
              /*  if (txtstr == Inkscript.story.variablesState["Gven"].ToString())
                {

                    Debug.Log("Gven left");
                    spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
                    spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
                  
                }
                if (txtstr != Inkscript.story.variablesState["Gven"].ToString() && txtstr != "..." && txtstr != "Подсказка" && txtstr != "window" && txtstr != "")
               
                {
                    spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
                    spriteNPC.color = (new Color(255f, 255f, 255f, 1f));
               

                }*/
                if (Inkscript.PanelWithText.transform.Find("Button(Clone)"))
                {
             //   historyScript.panelka.runtimeAnimatorController = Resources.Load("Animator/Left") as RuntimeAnimatorController;
              //  historyScript.panelka.enabled = true;
                //	Debug.Log(rectTxtInPlashka.sizeDelta);
                // rectTxtInPlashka.sizeDelta = new Vector2(rectTxtInPlashka.sizeDelta.x, 300);
           }
                else
               {
                // historyScript.panelka.runtimeAnimatorController = Resources.Load("Animator/Left") as RuntimeAnimatorController;
                //   historyScript.panelka.runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;
                // imgNPC;
               // imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;
                imgPlayer.GetComponent<Animator>().enabled = true;
               
                // Debug.Log("NPC  Left");
            }
            StartCoroutine(zapuskText());
           // StopCoroutine(DvizheniePersonazha());
            //     if(Inkscript.story.variablesState["motanieGolovoi"].ToString() != "0")
            //  {
            //     Inkscript.StartTextAfterMotanie(meshtxtDialog.text);
            // }
            // else {

            //}


            // Inkscript.ZapuskTextFind();
            //  StopCoroutine(DvizheniePersonazha());

            // }

        }
        if (rightbool)
        {
            //  Vector2 point = Camera.ViewportToWorldPoint(new Vector2(1f, 1f));
            //  point.x = 0.8f;
            //  point.y = -0.44f;
            personaj.GetComponent<Animator>().enabled = true;

           // Vector3 point = Camera.ViewportToWorldPoint(new Vector3(.8f, .4f, .5f));
           // Vector3 point = v3Right;
        //    point.x = v3Right.x + 0.4f;

            //   personaj.transform.position = Vector3.MoveTowards(personaj.transform.position, v3Right, speed*3f * Time.deltaTime);
            //if (personaj.transform.position != right.transform.position)
          //  personaj.transform.position = Vector3.MoveTowards(personaj.transform.position, point, speed * 3f * Time.deltaTime);
         //  if (personaj.transform.position != point)
          //  {
              /*  if (txtstr == Inkscript.story.variablesState["Gven"].ToString())
                {

                    spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    prozrachnostPlayer = prozrachnostPlayer + 0.005f;


                    spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                    prozrachnostNPC = prozrachnostNPC - 0.005f;
                    StartCoroutine(DvizheniePersonazha());
                    //StartCoroutine(Dvizhenielocation());
                }
                if (txtstr != Inkscript.story.variablesState["Gven"].ToString() && txtstr != "..." && txtstr != "Подсказка" && txtstr != "window" && txtstr != "")
                // else
                {
                    spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    prozrachnostPlayer = prozrachnostPlayer - 0.005f;


                    spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                    prozrachnostNPC = prozrachnostNPC + 0.005f;

                    //StartCoroutine(Dvizhenielocation());
                    StartCoroutine(DvizheniePersonazha());
                }*/
              //  StartCoroutine(DvizheniePersonazha());
           // }
           // if (personaj.transform.position == right.transform.position)
         //   if (personaj.transform.position == point)
            //{
              /*  if (txtstr == Inkscript.story.variablesState["Gven"].ToString())
                {

                    spritePlayer.color = (new Color(255f, 255f, 255f, 1f));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, 1f));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, 1f));
                    spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
 zapuskText()
                }
                if (txtstr != Inkscript.story.variablesState["Gven"].ToString() && txtstr != "..." && txtstr != "Подсказка" && txtstr != "window" && txtstr != "")

                {
                    spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
                    spriteNPC.color = (new Color(255f, 255f, 255f, 1f));


                }*/

               if (Inkscript.PanelWithText.transform.Find("Button(Clone)"))
                {

                    //	Debug.Log(rectTxtInPlashka.sizeDelta);
                    // rectTxtInPlashka.sizeDelta = new Vector2(rectTxtInPlashka.sizeDelta.x, 300);
                }
                else
            {
                //historyScript.panelka.runtimeAnimatorController = Resources.Load("Animator/Right") as RuntimeAnimatorController;
             //   imgNPC.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1)") as RuntimeAnimatorController;
                //  imgNPC.GetComponent<Animator>().runtimeAnimatorController =
                //    imgPlayer.GetComponent<Animator>().runtimeAnimatorController =
                imgNPC.GetComponent<Animator>().enabled = true;
                //  Debug.Log("NPC  Right");
            }
            // if (Inkscript.story.variablesState["motanieGolovoi"].ToString() != "0")
            // // {
            //    Inkscript.StartTextAfterMotanie(meshtxtDialog.text);
            //  }
            //  else { 
          //  Debug.Log("NPC  Right");
            StartCoroutine(zapuskText());
          //  StopCoroutine(DvizheniePersonazha());
            //}
            //  StartCoroutine(zapuskText());
            // Inkscript.ZapuskTextFind();
            // StopCoroutine(DvizheniePersonazha());

            // }
        }

        if (centerbool)
        {
            //  Debug.Log("podskazka");  imgPlayer;
           
            //imgPodskazka;
            imgPodskazka.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (3)") as RuntimeAnimatorController;
            imgPodskazka.GetComponent<Animator>().enabled = true;



            // spritePlayer.color = (new Color(255f, 255f, 255f, 0));
            //  spritePlayerHair.color = (new Color(255f, 255f, 255f, 0));
            // spritePlayerDress.color = (new Color(255f, 255f, 255f, 0));
            // spriteNPC.color = (new Color(255f, 255f, 255f, 0));
            //Inkscript.ZapuskTextFind();
          //  if (Inkscript.story.variablesState["motanieGolovoi"].ToString() != "0")
          //  {
          //      Inkscript.StartTextAfterMotanie(meshtxtDialog.text);
          //  }
          //  else { 
                
                StartCoroutine(zapuskText()); 
            
            //}
          //  StartCoroutine(zapuskText());
        //    StopCoroutine(DvizheniePersonazha());
        }
    }

    public Vector3 Motaniev3Left;
    public Vector3 Motaniev3Right;
    public Vector3 Motaniev3Center;

    IEnumerator zapuskText()
    {
        yield return new WaitForSeconds(0.01f);
        //Debug.Log("Zapusk");
        //  Debug.Log(zapuskText());
        //personaj.GetComponent<Animator>().enabled = true;
      //  Inkscript.BackPers = 0;
        Inkscript.ZapuskTextFind();
        //personaj.GetComponent<Animator>().enabled = false;
    }

    IEnumerator enableAnimator()
    {
        yield return new WaitForSeconds(0.5f);
        personaj.GetComponent<Animator>().runtimeAnimatorController = null;
    }
    public int revers;
    public void Startmotanie()
    {
    
        StartCoroutine(MotanieGolpvoi());
    }
    IEnumerator MotanieGolpvoi()
    {
       
        
        yield return new WaitForSeconds(0.001f);
      //  Debug.Log("Motanie back");
        if (Inkscript.story.variablesState["motanieGolovoi"].ToString() == "1")
        {
          //  Motaniev3Left.x = -float.Parse(Inkscript.story.variablesState["KoordinateX"].ToString());
            if (leftbool2)
            {
              //  Debug.Log("dsad");
                //  cam.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, (speed - 2.5f) * Time.deltaTime);
                cam.transform.position = Vector3.MoveTowards(cam.transform.position, Motaniev3Right, (speed - 8.5f) * Time.deltaTime);
                if (cam.transform.position != Motaniev3Right)
                {
                    StartCoroutine(MotanieGolpvoi());
                }
                else
                {
                    leftbool2 = false;
                    centerbool2 = false;
                    rightbool2 = true;
                    StartCoroutine(MotanieGolpvoi());
                }
            }
            if (rightbool2)
            {
                //    cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, (speed - 2.5f) * Time.deltaTime);
                cam.transform.position = Vector3.MoveTowards(cam.transform.position, Motaniev3Left, (speed - 8.5f) * Time.deltaTime);
                if (cam.transform.position != Motaniev3Left)
                {

                    StartCoroutine(MotanieGolpvoi());
                }
                else
                {
                    centerbool2 = true;
                    leftbool2 = false;
                    rightbool2 = false;
                    StartCoroutine(MotanieGolpvoi());
                }

            }
            if (centerbool2)
            {
                //  cam.transform.position = Vector3.MoveTowards(cam.transform.position, center.transform.position, (speed - 2.5f) * Time.deltaTime);
                cam.transform.position = Vector3.MoveTowards(cam.transform.position, Motaniev3Center, (speed - 8.5f) * Time.deltaTime);
                if (cam.transform.position != Motaniev3Center)
                {

                    StartCoroutine(MotanieGolpvoi());
                }
                else
                {
                    centerbool2 = false;
                    leftbool2 = false;
                    rightbool2 = false;
                    imgPodskazka.SetActive(true);
                   // 
                    StartCoroutine(DvizheniePersonazha());
                    Inkscript.enableMousebtn = true;
                    // Inkscript.ZapuskTextFind();
                    v3Center.x = Motaniev3Center.x;
                    v3Left.x = Motaniev3Center.x - 1.35f;
                    v3Right.x = Motaniev3Center.x + 1.35f;
                  //  historyScript.Zapusk = 1;
                    Inkscript.ZapuskNewlocation = 1;
                    PlayerPrefs.SetFloat("V3CentrX",v3Center.x);
                    PlayerPrefs.SetFloat("V3CentrY", v3Center.y);
                    PlayerPrefs.SetFloat("V3CentrZ", v3Center.z);

                    PlayerPrefs.SetFloat("v3LeftX", v3Left.x);
                    PlayerPrefs.SetFloat("v3LeftY", v3Left.y);
                    PlayerPrefs.SetFloat("v3LeftZ", v3Left.z);

                    PlayerPrefs.SetFloat("V3v3RightX", v3Right.x);
                    PlayerPrefs.SetFloat("V3v3RightY", v3Right.y);
                    PlayerPrefs.SetFloat("V3v3RightZ", v3Right.z);
                    PlayerPrefs.Save();
                    Inkscript.story.variablesState["motanieGolovoi"] = 0;
                    //  Inkscript.ZapuskTextFind();
                    StopCoroutine(MotanieGolpvoi());
                    //  imgPodskazka.SetActive(true);
                    //    Inkscript.StartTextAfterMotanie(meshtxtDialog.text);
                    //  Inkscript.enableMousebtn = true;

                }
            }
        }

         if (Inkscript.story.variablesState["motanieGolovoi"].ToString() == "2")
        {
            //Debug.Log("dsad");
            Motaniev3Left.x = float.Parse(Inkscript.story.variablesState["KoordinateX"].ToString());
             leftbool2 = false;
            centerbool2 = false;
             rightbool2 = true;
             if (rightbool2)
            {
             //   Debug.Log("Aloha" + Dvizhenielocation());
                //    cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, (speed - 2.5f) * Time.deltaTime);
                cam.transform.position = Vector3.MoveTowards(cam.transform.position, Motaniev3Left , (speed - 7.5f) * Time.deltaTime);
                 if (cam.transform.position != Motaniev3Left)
                 {

                     StartCoroutine(MotanieGolpvoi());
                 } 
                 else 
                 {
                     //StartCoroutine(Dvizhenielocation());
                     centerbool2 = false;
                     leftbool2 = false;
                     rightbool2 = false;
                    //imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5) 1") as RuntimeAnimatorController;
                    //imgPlayer.SetActive(true);
                    StartCoroutine(DvizheniePersonazha());
                    //   Debug.Log("Aloha" + Dvizhenielocation());
                    if (txtstr == Inkscript.story.variablesState["Gven"].ToString())
                    {
                        personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 2") as RuntimeAnimatorController;
                        //  imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                        imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;
                    }

                   if(txtstr != Inkscript.story.variablesState["Gven"].ToString() && (txtstr == "Подсказка" || txtstr == "..."))
                    {
                        imgPodskazka.SetActive(true);
                        personaj.GetComponent<Animator>().runtimeAnimatorController = null;
                        imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (3)") as RuntimeAnimatorController;
                    }


                   /* if (txtstr != Inkscript.story.variablesState["Gven"].ToString() && (Inkscript.story.variablesState["name"].ToString() != "Подсказка" || Inkscript.story.variablesState["name"].ToString() != "..."))
                    {
                        personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 1") as RuntimeAnimatorController;
                        //  imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                        imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (1)") as RuntimeAnimatorController;
                    }*/
                        //  Inkscript.ZapuskTextFind();
                        v3Center.x = Motaniev3Center.x;
                     v3Left.x = Motaniev3Left.x - 0.8f;
                     v3Right.x = Motaniev3Left.x + 0.8f;
                    // personaj.SetActive(true);
                    // personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 2") as RuntimeAnimatorController;
                     //imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;
                     Inkscript.enableMousebtn = true;

                     //historyScript.Zapusk = 1;
                     Inkscript.ZapuskNewlocation = 1;
                     PlayerPrefs.SetFloat("V3CentrX", v3Center.x);
                     PlayerPrefs.SetFloat("V3CentrY", v3Center.y);
                     PlayerPrefs.SetFloat("V3CentrZ", v3Center.z);

                     PlayerPrefs.SetFloat("v3LeftX", v3Left.x);
                     PlayerPrefs.SetFloat("v3LeftY", v3Left.y);
                     PlayerPrefs.SetFloat("v3LeftZ", v3Left.z);

                     PlayerPrefs.SetFloat("V3v3RightX", v3Right.x);
                     PlayerPrefs.SetFloat("V3v3RightY", v3Right.y);
                     PlayerPrefs.SetFloat("V3v3RightZ", v3Right.z);
                     PlayerPrefs.Save();

                   //  Inkscript.ZapuskTextFind();
                  Inkscript.story.variablesState["motanieGolovoi"] = 0;
                    // Inkscript.StartTextAfterMotanie(meshtxtDialog.text);
                     //  StartCoroutine(MotanieGolpvoi());
                     StopCoroutine(MotanieGolpvoi());
                 }

             }

         }
        if (historyScript.proverkamotaniya == 0)
        {
          
            if (Inkscript.story.variablesState["motanieGolovoi"].ToString() == "4")
            {
                Motaniev3Left.x = float.Parse(Inkscript.story.variablesState["KoordinateX"].ToString());
                leftbool2 = false;
                rightbool2 = true;
                if (rightbool2)
                {
                    //    cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, (speed - 2.5f) * Time.deltaTime);
                    cam.transform.position = Vector3.MoveTowards(cam.transform.position, Motaniev3Left, (speed - 7.5f) * Time.deltaTime);
                    if (cam.transform.position != Motaniev3Left)
                    {

                        StartCoroutine(MotanieGolpvoi());
                    }
                    else
                    {
                       // Debug.Log(float.Parse(Inkscript.story.variablesState["KoordinateX"].ToString()) + float.Parse(Inkscript.story.variablesState["position"].ToString()));
                        //StartCoroutine(Dvizhenielocation());
                        // historyScript.proverkamotaniya = 1;
                        historyScript.goBtnBackMotanie.SetActive(true);
                        Inkscript.palecTimer.SetActive(true);
                        Inkscript.boolTimer = false;
                        //centerbool2 = false;
                        //leftbool2 = false;
                        /// rightbool2 = false;
                        // StartCoroutine(DvizheniePersonazha());
                        // Debug.Log("Aloha" + Dvizhenielocation());
                        // personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 2") as RuntimeAnimatorController;
                        //  imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                        // imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;

                        //  Inkscript.ZapuskTextFind();
                        // v3Center.x = Motaniev3Center.x;
                        // v3Left.x = Motaniev3Left.x - 0.8f;
                        //v3Right.x = Motaniev3Left.x + 0.8f;
                        // personaj.SetActive(true);
                        // personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 2") as RuntimeAnimatorController;
                        //imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;
                        //  Inkscript.enableMousebtn = true;

                        //historyScript.Zapusk = 1;
                        //Inkscript.ZapuskNewlocation = 1;
                        // PlayerPrefs.SetFloat("V3CentrX", v3Center.x);
                        // PlayerPrefs.SetFloat("V3CentrY", v3Center.y);
                        // PlayerPrefs.SetFloat("V3CentrZ", v3Center.z);

                        //  PlayerPrefs.SetFloat("v3LeftX", v3Left.x);
                        //  PlayerPrefs.SetFloat("v3LeftY", v3Left.y);
                        //  PlayerPrefs.SetFloat("v3LeftZ", v3Left.z);

                        // PlayerPrefs.SetFloat("V3v3RightX", v3Right.x);
                        //  PlayerPrefs.SetFloat("V3v3RightY", v3Right.y);
                        // PlayerPrefs.SetFloat("V3v3RightZ", v3Right.z);
                        // PlayerPrefs.Save();

                        //  Inkscript.ZapuskTextFind();
                        //  Inkscript.story.variablesState["motanieGolovoi"] = 0;
                        // Inkscript.StartTextAfterMotanie(meshtxtDialog.text);
                        //  StartCoroutine(MotanieGolpvoi());
                        StopCoroutine(MotanieGolpvoi());
                    }

                }

            }
        }
        if (historyScript.proverkamotaniya == 1)
        {
        //    Debug.Log("Motanie back");
            if (Inkscript.story.variablesState["motanieGolovoi"].ToString() == "4")
            {
                //Motaniev3Left.x = float.Parse(Inkscript.story.variablesState["KoordinateX"].ToString());
                leftbool2 = false;
                rightbool2 = true;
                if (rightbool2)
                {
                    //    cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, (speed - 2.5f) * Time.deltaTime);
                    cam.transform.position = Vector3.MoveTowards(cam.transform.position, -Motaniev3Left, (speed - 7.5f) * Time.deltaTime);
                    if (cam.transform.position != -Motaniev3Left)
                    {

                        StartCoroutine(MotanieGolpvoi());
                    }
                    else
                    {
                        //StartCoroutine(Dvizhenielocation());
                        centerbool2 = false;
                        leftbool2 = false;
                        rightbool2 = false;
                        StartCoroutine(DvizheniePersonazha());
                      //   Debug.Log("Aloha");
                        personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 2") as RuntimeAnimatorController;
                        //  imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                        imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;

                        //  Inkscript.ZapuskTextFind();
                        v3Center.x = Motaniev3Center.x;
                        v3Left.x = Motaniev3Left.x;
                        v3Right.x = Motaniev3Left.x;
                        // personaj.SetActive(true);
                        // personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 2") as RuntimeAnimatorController;
                        //imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;
                        Inkscript.enableMousebtn = true;

                        //historyScript.Zapusk = 1;
                        Inkscript.ZapuskNewlocation = 1;
                        PlayerPrefs.SetFloat("V3CentrX", v3Center.x);
                        PlayerPrefs.SetFloat("V3CentrY", v3Center.y);
                        PlayerPrefs.SetFloat("V3CentrZ", v3Center.z);

                        PlayerPrefs.SetFloat("v3LeftX", v3Left.x);
                        PlayerPrefs.SetFloat("v3LeftY", v3Left.y);
                        PlayerPrefs.SetFloat("v3LeftZ", v3Left.z);

                        PlayerPrefs.SetFloat("V3v3RightX", v3Right.x);
                        PlayerPrefs.SetFloat("V3v3RightY", v3Right.y);
                        PlayerPrefs.SetFloat("V3v3RightZ", v3Right.z);
                        PlayerPrefs.Save();
                        historyScript.proverkamotaniya = 0;
                        historyScript.goBtnBackMotanie.SetActive(false);
                        //  Inkscript.ZapuskTextFind();
                        Inkscript.story.variablesState["motanieGolovoi"] = 0;
                        // Inkscript.StartTextAfterMotanie(meshtxtDialog.text);
                        //  StartCoroutine(MotanieGolpvoi());
                        StopCoroutine(MotanieGolpvoi());
                    }

                }

            }

        }

            if (Inkscript.story.variablesState["motanieGolovoi"].ToString() == "3")
        {
            Motaniev3Right.x = float.Parse(Inkscript.story.variablesState["KoordinateX"].ToString());
           // Debug.Log("Motenae lEFT" + Inkscript.story.variablesState["motanieGolovoi"].ToString());
            leftbool2 = true;
            rightbool2 = false;
            if (leftbool2)
            {
                //    cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, (speed - 2.5f) * Time.deltaTime);
                cam.transform.position = Vector3.MoveTowards(cam.transform.position, Motaniev3Right, (speed - 7.5f) * Time.deltaTime);
                if (cam.transform.position != Motaniev3Right)
                {

                    StartCoroutine(MotanieGolpvoi());
                }
                else
                {
                    Debug.Log("Mot 3");
                    centerbool2 = false;
                    leftbool2 = false;
                    rightbool2 = false;
                    StartCoroutine(DvizheniePersonazha());
                    // Debug.Log("Aloha" + Dvizhenielocation());
                    personaj.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Personag/Pers 2") as RuntimeAnimatorController;
                    //  imgPlayer.GetComponent<Animator>().runtimeAnimatorController = null;
                    imgPlayer.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animator/Fortext/Image (5)") as RuntimeAnimatorController;


                    //Inkscript.ZapuskTextFind();
                    v3Center.x = Motaniev3Center.x;
                    v3Left.x = Motaniev3Right.x;
                    v3Right.x = Motaniev3Right.x;
                    Inkscript.enableMousebtn = true;
                   // StartCoroutine(Dvizhenielocation());
                    //historyScript.Zapusk = 1;
                    Inkscript.ZapuskNewlocation = 1;
                    
                    PlayerPrefs.SetFloat("V3CentrX", v3Center.x);
                    PlayerPrefs.SetFloat("V3CentrY", v3Center.y);
                    PlayerPrefs.SetFloat("V3CentrZ", v3Center.z);

                    PlayerPrefs.SetFloat("v3LeftX", v3Left.x);
                    PlayerPrefs.SetFloat("v3LeftY", v3Left.y);
                    PlayerPrefs.SetFloat("v3LeftZ", v3Left.z);

                    PlayerPrefs.SetFloat("V3v3RightX", v3Right.x);
                    PlayerPrefs.SetFloat("V3v3RightY", v3Right.y);
                    PlayerPrefs.SetFloat("V3v3RightZ", v3Right.z);
                    PlayerPrefs.Save();

                  //  Inkscript.ZapuskTextFind();
                    Inkscript.story.variablesState["motanieGolovoi"] = 0;
                    StopCoroutine(MotanieGolpvoi());
                }

            }

        }


    }
  
}
