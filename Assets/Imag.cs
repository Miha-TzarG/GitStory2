using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imag : MonoBehaviour
{
    public string txtstr;
    public Text txtDialog;
    public Text txtinImageinDialog;
    public Text txtinImageinDialogNPC;
    public Text txtinImageinDialogMisly;
    public Text txtinImageinDialogPodskazka;
    public Text txtinImageinDialogStat;
    public Text txtWhoSay;
    //  public Image imgInDialog;
    //   public Vector2 imgWhosay;
    public GameObject imgPlayer;
    public GameObject imgNPC;
    public GameObject imgMisly;
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

        cam = GameObject.FindGameObjectWithTag("Location");
        left = GameObject.FindGameObjectWithTag("Left");
        right = GameObject.FindGameObjectWithTag("Right");
        center = GameObject.FindGameObjectWithTag("Center");
        personaj = GameObject.FindGameObjectWithTag("Pers");
        spriteNPC = GameObject.FindGameObjectWithTag("NPC").GetComponent<SpriteRenderer>();
        spritePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        spritePlayerHair = GameObject.FindGameObjectWithTag("Hair").GetComponent<SpriteRenderer>();
        spritePlayerDress = GameObject.FindGameObjectWithTag("Dress").GetComponent<SpriteRenderer>();

        //   transform.position = new Vector2(transform.position.x + 0.15f, transform.position.y + 3.5f);
        Inkscript = GameObject.FindGameObjectWithTag("Ink").GetComponent<InkScript>();

        txtstr = Inkscript.names;
        txtinImageinDialog.text = txtDialog.text;
        txtinImageinDialogNPC.text = txtDialog.text;
        txtinImageinDialogMisly.text = txtDialog.text;
        txtinImageinDialogPodskazka.text = txtDialog.text;
        txtinImageinDialogStat.text = txtDialog.text;

        if (txtstr.Contains("Персефона"))
        {
            // spritePlayer.color = (new Color(255f, 255f, 255f, 0f));
            // spritePlayerHair.color = (new Color(255f, 255f, 255f, 0f));
            // spritePlayerDress.color = (new Color(255f, 255f, 255f, 0f));
            //Debug.Log("gven");
            //  imgPlayer.SetActive(true);
            //imgNPC.SetActive(false);
            imgMisly.SetActive(false);
            imgPodskazka.SetActive(false);
            imgStat.SetActive(false);
            //  leftbool = true;
            // rightbool = false;
            centerbool = false;
            if (Inkscript.numtest == 0 && Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())
            //  if (Inkscript.numtest == 0 && Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())
           // {
                {
                    personaj.transform.position = new Vector2(3.4f, -0.85f);

                    //   spriteNPC.transform.localScale = new Vector2(0.25f, 0.25f);

                    spritePlayer.transform.localScale = new Vector2(-1.6f, 1.6f);
                    //spritePlayerDress.transform.localScale = new Vector2(0.25f, 0.25f);
                    // spritePlayerHair.transform.localScale = new Vector2(0.25f, 0.25f);

                    imgPlayer.SetActive(false);
                    imgNPC.SetActive(true);

                    rightbool = true;
                    leftbool = false;
                    Inkscript.enableMousebtn = false;
                    Inkscript.numtest = 1;
                    Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                    //   Debug.Log("0:" + Inkscript.story.variablesState["name"].ToString());

                    //PlayerPrefs.SetInt("Numpers", numpers);
                }
            else if (Inkscript.numtest == 0 && Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString())
                {
                    // personaj.transform.position = new Vector2(-3.4f, -1.4f);
                    // spriteNPC.transform.localScale = new Vector2(-0.25f, 0.25f);

                    spritePlayer.transform.localScale = new Vector2(1.6f, 1.6f);
                    //  spritePlayerDress.transform.localScale = new Vector2(-0.25f, 0.25f);
                    // spritePlayerHair.transform.localScale = new Vector2(-0.25f, 0.25f);*/

                    imgPlayer.SetActive(true);
                    imgNPC.SetActive(false);
                }
                //  else
                //  {
                //     imgPlayer.SetActive(true);
                //     imgNPC.SetActive(false);
                //  }

                if (Inkscript.numtest == 1 && Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())
                {

                    personaj.transform.position = new Vector2(-3.4f, -0.85f);
                    // spriteNPC.transform.localScale = new Vector2(-0.25f, 0.25f);

                    spritePlayer.transform.localScale = new Vector2(1.6f, 1.6f);
                    // spritePlayerDress.transform.localScale = new Vector2(-0.25f, 0.25f);
                    //spritePlayerHair.transform.localScale = new Vector2(-0.25f, 0.25f);*/

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

                }
                //StartCoroutine(test());
                StartCoroutine(DvizheniePersonazha());
                StartCoroutine(Dvizhenielocation());
            }
            else
            {
                //  personaj.transform.position = new Vector2(0f, -1.4f);
                // spriteNPC.color = (new Color(255f, 255f, 255f, 0f));
                //   imgPlayer.SetActive(false);
                //imgNPC.SetActive(true);
                imgMisly.SetActive(false);
                imgPodskazka.SetActive(false);
                imgStat.SetActive(false);


                centerbool = false;

                if (Inkscript.numtest == 0 && Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())
                {
                    personaj.transform.position = new Vector2(3.4f, -0.85f);
                    spriteNPC.transform.localScale = new Vector2(0.3f, 0.3f);

                    /* spritePlayer.transform.localScale = new Vector2(0.25f, 0.25f);
                     spritePlayerDress.transform.localScale = new Vector2(0.25f, 0.25f);
                     spritePlayerHair.transform.localScale = new Vector2(0.25f, 0.25f);*/


                    imgPlayer.SetActive(false);
                    imgNPC.SetActive(true);
                    rightbool = true;
                    leftbool = false;
                    Inkscript.enableMousebtn = false;
                    Inkscript.numtest = 1;
                    Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                    // Debug.Log("0:" + Inkscript.story.variablesState["name"].ToString());

                    //PlayerPrefs.SetInt("Numpers", numpers);
                }
                else if (Inkscript.numtest == 0 && Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString())
                {
                    //  personaj.transform.position = new Vector2(-3.4f, -1.4f);
                    spriteNPC.transform.localScale = new Vector2(-0.3f, 0.3f);

                    // spritePlayer.transform.localScale = new Vector2(-1.25f, 1.25f);
                    //   spritePlayerDress.transform.localScale = new Vector2(-0.25f, 0.25f);
                    // spritePlayerHair.transform.localScale = new Vector2(-0.25f, 0.25f);*/

                    imgPlayer.SetActive(true);
                    imgNPC.SetActive(false);
                }
                if (Inkscript.numtest == 1 && Inkscript.Inknm != Inkscript.story.variablesState["name"].ToString())
                {
                    personaj.transform.position = new Vector2(-3.4f, -0.85f);

                    spriteNPC.transform.localScale = new Vector2(-0.3f, 0.3f);


                    // spritePlayer.transform.localScale = new Vector2(-1.25f, 1.25f);
                    // spritePlayerDress.transform.localScale = new Vector2(-0.25f, 0.25f);
                    //spritePlayerHair.transform.localScale = new Vector2(-0.25f, 0.25f);


                    imgPlayer.SetActive(true);
                    imgNPC.SetActive(false);

                    rightbool = false;
                    leftbool = true;
                    Inkscript.enableMousebtn = false;
                    Inkscript.numtest = 0;
                    Inkscript.Inknm = Inkscript.story.variablesState["name"].ToString();
                    // Debug.Log("1:" + Inkscript.story.variablesState["name"].ToString());
                    // PlayerPrefs.SetInt("Numpers", numpers);
                }
                else if (Inkscript.numtest == 1 && Inkscript.Inknm == Inkscript.story.variablesState["name"].ToString())
                {
                    //  personaj.transform.position = new Vector2(3.4f, -1.4f);
                    spriteNPC.transform.localScale = new Vector2(0.3f, 0.3f);

                    /*spritePlayer.transform.localScale = new Vector2(0.25f, 0.25f);
                    spritePlayerDress.transform.localScale = new Vector2(0.25f, 0.25f);
                    spritePlayerHair.transform.localScale = new Vector2(0.25f, 0.25f);*/

                    imgPlayer.SetActive(false);
                    imgNPC.SetActive(true);
                    //   imgPlayer.SetActive(false);
                    //  imgNPC.SetActive(true);

                }
                StartCoroutine(DvizheniePersonazha());
                StartCoroutine(Dvizhenielocation());

            }

            if (txtstr == "") //|| txtstr.Contains("window - "))
            {
                imgMisly.transform.position = new Vector2(imgMisly.transform.position.x + 0.15f, imgMisly.transform.position.y + 3.8f);
                imgMisly.SetActive(true);
                imgPlayer.SetActive(false);
                imgNPC.SetActive(true);
                imgPodskazka.SetActive(false);
                imgStat.SetActive(false);
                leftbool = false;
                rightbool = false;
                centerbool = true;
                Inkscript.enableMousebtn = false;
                StartCoroutine(Dvizhenielocation());
            }



            if (txtstr == "Подсказка" || txtstr == "...")
            {
                //  personaj.transform.position = new Vector2(0f, -1.4f);
                //txtstr = "Подсказка";
                // transform.position = new Vector2(transform.position.x, transform.position.y);
                imgMisly.SetActive(false);
                imgPlayer.SetActive(false);
                imgNPC.SetActive(false);
                imgStat.SetActive(false);
                imgPodskazka.SetActive(true);
                leftbool = false;
                rightbool = false;
                // centerbool = true;
                centerbool = false;
                Inkscript.enableMousebtn = true;
                //    StartCoroutine(Dvizhenielocation());
                // StartCoroutine(NothingDvizhenie());
            }

            if (txtstr == "motanie")
            {
                //Debug.Log("motanie");
                transform.position = new Vector2(transform.position.x, transform.position.y);
                imgMisly.SetActive(false);
                imgPlayer.SetActive(false);
                imgNPC.SetActive(false);
                imgPodskazka.SetActive(false);
                imgStat.SetActive(false);
                leftbool2 = true;
                rightbool = false;
                centerbool = false;
                rightbool2 = false;
                centerbool2 = false;
                Inkscript.enableMousebtn = false;
                //txtstr = "Персефона";
                // StartCoroutine(Dvizhenielocation());
                StartCoroutine(MotanieGolpvoi());
            }

            if (Inkscript.namewindow != Inkscript.story.variablesState["namewindow"].ToString())//txtstr.Contains("window"))
            {
                txtinImageinDialogMisly.text = Inkscript.story.variablesState["namewindow"].ToString();
                imgMisly.transform.position = new Vector2(imgMisly.transform.position.x + 0.15f, imgMisly.transform.position.y + 3.8f);
                imgMisly.SetActive(true);
                Inkscript.namewindow = Inkscript.story.variablesState["namewindow"].ToString();
                // imgPlayer.SetActive(false);
                // imgNPC.SetActive(false);
                // imgPodskazka.SetActive(false);
                //  imgStat.SetActive(false);
                //  leftbool = false;
                //rightbool = false;
                //  centerbool = true;
                // StartCoroutine(Dvizhenielocation());
                StartCoroutine(PoyavlenieStatov());
            }





            //if (modestyValue != Inkscript.modesty)
            if (Inkscript.modesty != int.Parse(Inkscript.story.variablesState["modesty"].ToString()))
            {

                txtinImageinDialogStat.text = "modesty + 1";
                imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
                imgStat.SetActive(true);
                statImg.GetComponent<Image>().sprite = spriteStat[0];
                // modestyValue = Inkscript.modesty;
                Inkscript.modesty = int.Parse(Inkscript.story.variablesState["modesty"].ToString());
                //  PlayerPrefs.SetInt("Modesty", modestyValue);
                imgStat.GetComponent<Image>();
                StartCoroutine(PoyavlenieStatov());

            }
            //  if (braveryValue != Inkscript.bravery)
            if (Inkscript.bravery != int.Parse(Inkscript.story.variablesState["bravery"].ToString()))
            {
                txtinImageinDialogStat.text = "bravery + 1";
                imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
                imgStat.SetActive(true);
                statImg.GetComponent<Image>().sprite = spriteStat[1];
                //  braveryValue = Inkscript.bravery;
                Inkscript.bravery = int.Parse(Inkscript.story.variablesState["bravery"].ToString());
                //  PlayerPrefs.SetInt("Bravery", braveryValue);
                imgStat.GetComponent<Image>();
                StartCoroutine(PoyavlenieStatov());

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
                txtinImageinDialogStat.text = "creation + 1";
                imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
                imgStat.SetActive(true);
                statImg.GetComponent<Image>().sprite = spriteStat[1];
                //creationValue = Inkscript.creation;
                Inkscript.creation = int.Parse(Inkscript.story.variablesState["creation"].ToString());
                //  PlayerPrefs.SetInt("Creation", creationValue);
                imgStat.GetComponent<Image>();
                StartCoroutine(PoyavlenieStatov());

            }



            //   if (destructionValue != Inkscript.destruction)
            if (Inkscript.destruction != int.Parse(Inkscript.story.variablesState["destruction"].ToString()))
            {
                txtinImageinDialogStat.text = "destruction + 1";
                imgStat.transform.position = new Vector2(imgStat.transform.position.x + 0.15f, imgStat.transform.position.y + 3.8f);
                imgStat.SetActive(true);
                statImg.GetComponent<Image>().sprite = spriteStat[1];
                // destructionValue = Inkscript.destruction;
                Inkscript.destruction = int.Parse(Inkscript.story.variablesState["destruction"].ToString());
                // PlayerPrefs.SetInt("Destruction", creationValue);
                imgStat.GetComponent<Image>();
                StartCoroutine(PoyavlenieStatov());

            }


            StartCoroutine(Asd());

        }
    public float izmenenieStatov;

    IEnumerator PoyavlenieStatov()
    {
        yield return new WaitForSeconds(0.01f);
        if (izmenenieStatov >= 0 && izmenenieStatov < 1)
        {
            imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(50f, 50f, 50f, izmenenieStatov);
            izmenenieStatov = izmenenieStatov + 0.02f;

            StartCoroutine(PoyavlenieStatov());
        }
        if (izmenenieStatov >= 1)
        {
            imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(50f, 50f, 50f, 1f);
            //StartCoroutine(UschezanieStatov());
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
            imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(50f, 50f, 50f, izmenenieStatov);
            izmenenieStatov = izmenenieStatov - 0.02f;

            // prevnumLocation = numLocation;

            StartCoroutine(UschezanieStatov());

        }
        else
        {
            imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            txtinImageinDialogMisly.GetComponent<Text>().color = new Color(50f, 50f, 50f, 0f);
        }
        //  imgMisly.SetActive(false);
    }
    IEnumerator Asd()
    {
        yield return new WaitForSeconds(2f);
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
            if (txtstr == "Персефона")
            {
                spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                prozrachnostPlayer = prozrachnostPlayer + 0.03f;

                spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                prozrachnostNPC = prozrachnostNPC + 0.03f;

                StartCoroutine(NothingDvizhenie());
            }
            else
            {
                spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                prozrachnostPlayer = prozrachnostPlayer - 0.03f;

                spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                prozrachnostNPC = prozrachnostNPC + 0.03f;

                StartCoroutine(NothingDvizhenie());

            }
        }


        // }
    }


    IEnumerator Dvizhenielocation()
    {
        yield return new WaitForSeconds(0.001f);
        if (leftbool)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, speed * Time.deltaTime);
            // personaj.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, speed * Time.deltaTime);
            if (cam.transform.position != right.transform.position && prozrachnostPlayer != 1 || prozrachnostNPC != 0)
            {

                if (txtstr == "Персефона")
                {

                    spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    prozrachnostPlayer = prozrachnostPlayer + 0.02f;



                    spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                    prozrachnostNPC = prozrachnostNPC - 0.02f;

                    StartCoroutine(Dvizhenielocation());
                }

                else
                {
                    spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    prozrachnostPlayer = prozrachnostPlayer - 0.02f;

                    spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                    prozrachnostNPC = prozrachnostNPC + 0.02f;

                    StartCoroutine(Dvizhenielocation());

                }


            }

            else
            {

                if (Inkscript.numtest == 1)
                {
                    Inkscript.numtest = 0;
                }
                else if (Inkscript.numtest == 0)
                {
                    Inkscript.numtest = 1;
                }

            }
            if (cam.transform.position == right.transform.position)
            {
                Inkscript.enableMousebtn = true;
                // Debug.Log(Inkscript.enableMousebtn);
            }


        }
        if (rightbool)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, speed * Time.deltaTime);
            // personaj.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, speed * Time.deltaTime);
            if (cam.transform.position != left.transform.position && prozrachnostNPC != 1 || prozrachnostPlayer != 0)
            {
                if (txtstr == "Персефона")
                {

                    spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    prozrachnostPlayer = prozrachnostPlayer + 0.02f;


                    spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                    prozrachnostNPC = prozrachnostNPC - 0.02f;

                    StartCoroutine(Dvizhenielocation());
                }
                else
                {
                    spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                    prozrachnostPlayer = prozrachnostPlayer - 0.02f;


                    spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                    prozrachnostNPC = prozrachnostNPC + 0.02f;

                    StartCoroutine(Dvizhenielocation());

                }

            }
            else
            {
                if (Inkscript.numtest == 1)
                {
                    Inkscript.numtest = 0;
                }
                else if (Inkscript.numtest == 0)
                {
                    Inkscript.numtest = 1;
                }
                Inkscript.enableMousebtn = true;
            }
            if (cam.transform.position == left.transform.position)
            {
                Inkscript.enableMousebtn = true;
                //  Debug.Log(Inkscript.enableMousebtn);
            }

        }
        if (centerbool)
        {
            Debug.Log(txtstr);
            // cam.transform.position = Vector3.MoveTowards(cam.transform.position, center.transform.position, speed * Time.deltaTime);

            // personaj.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, speed * Time.deltaTime);
            //  if (cam.transform.position != center.transform.position || prozrachnostNPC != 0 || prozrachnostPlayer != 0)
            //if(txtstr == "Подсказка" || txtstr == "..." || prozrachnostNPC != 0 || prozrachnostPlayer != 0)
            // {
            spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
            spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
            spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
            //   if (prozrachnostPlayer > 250)
            //  {
            prozrachnostPlayer = prozrachnostPlayer - 0.02f;
            //  }
            // else
            // {
            //     prozrachnostPlayer = 0;
            //}
            spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));

            prozrachnostNPC = prozrachnostNPC - 0.02f;

            StartCoroutine(Dvizhenielocation());
            //  }
            //  else
            //  {

            //}
            // if (cam.transform.position == center.transform.position)
            //  {
            //   Inkscript.enableMousebtn = true;
            //
            //}
        }

        else
        {
            if (Inkscript.numtest == 1)
            {
                Inkscript.numtest = 0;
            }
            else if (Inkscript.numtest == 0)
            {
                Inkscript.numtest = 1;
            }
            Inkscript.enableMousebtn = true;
            StopCoroutine(Dvizhenielocation());
        }
        /*  if (numpers == 0)
          {
              numpers = 1;
              PlayerPrefs.SetInt("Numpers", numpers);
          }
          else if (numpers == 1)
          {
              numpers = 0;
              PlayerPrefs.SetInt("Numpers", numpers);
          }*/

    }
    public Vector3 v3Left;
    public Vector3 v3Right;
    public Vector3 v3Center;
    IEnumerator DvizheniePersonazha()
    {
        yield return new WaitForSeconds(0.001f);
        if (leftbool)
        {

            personaj.transform.position = Vector3.MoveTowards(personaj.transform.position, v3Left, speed * 4f * Time.deltaTime);
            if (personaj.transform.position != left.transform.position)
            {
                StartCoroutine(DvizheniePersonazha());
            }

        }
        if (rightbool)
        {

            personaj.transform.position = Vector3.MoveTowards(personaj.transform.position, v3Right, speed * 4f * Time.deltaTime);
            if (personaj.transform.position != right.transform.position)
            {
                StartCoroutine(DvizheniePersonazha());
            }

        }
        if (centerbool)
        {

            personaj.transform.position = Vector3.MoveTowards(personaj.transform.position, v3Center, speed * 4f * Time.deltaTime);
            if (personaj.transform.position != center.transform.position)
            {
                StartCoroutine(DvizheniePersonazha());
            }
        }
    }
    IEnumerator MotanieGolpvoi()
    {
        yield return new WaitForSeconds(0.001f);
        if (leftbool2)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, (speed - 2.5f) * Time.deltaTime);
            if (cam.transform.position != right.transform.position)
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
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, (speed - 2.5f) * Time.deltaTime);
            if (cam.transform.position != left.transform.position)
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
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, center.transform.position, (speed - 2.5f) * Time.deltaTime);
            if (cam.transform.position != center.transform.position)
            {

                StartCoroutine(MotanieGolpvoi());
            }
            else
            {
                centerbool2 = false;
                leftbool2 = false;
                rightbool2 = false;
                Inkscript.enableMousebtn = true;

            }
        }
    }
    void Update()
    {

    }
}
