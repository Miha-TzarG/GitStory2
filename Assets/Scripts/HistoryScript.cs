using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HistoryScript : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public int numFace;
    public SpriteRenderer personazh;
    public Sprite[] vidPersonazha;

    public int numHair;
    public Sprite[] Hair;
    public SpriteRenderer playerHair;

    public int numDress;
    public Sprite[] Dress;
    public SpriteRenderer playerDress;

    public AudioClip Music;
    public AudioSource audioSource;
    public int musicOffOnn;
    public bool vklPlashkaStat;
    public Text txtPlashkaStat;
    public Image imgBgPlashkaStat;
    public Image icoPlashkaStat;

    public Text txtVsplivausheeOkno;
    public Image imgBgVsplivausheeOkno;

    public Image IcoBgVsplivausheeOkno;

    public AudioClip vsplivaushieOknaClip;
    public AudioSource vsplivaushieOknaSource;

    public InkScript inkScript;

   // public AnimationClip[] animatPlameTXTBTN;
   // public Animation 
   public Animator panelka;

    public int Zapusk=0;
    // Start is called before the first frame update
    void Start()
    {
        LVL = inkScript.LVL;

    //    panelka.Play(animatPlameTXTBTN[0].name);
    //  panelka = GetComponent<Animator>();
    // panelka.runtimeAnimatorController = Resources.Load("Animator/PanelTXTBTN") as RuntimeAnimatorController;
    //  StartCoroutine(ShowPlashkaStat());
        musicOffOnn = PlayerPrefs.GetInt("Music");
        if (musicOffOnn == 0)
        {
            audioSource.enabled = false;
            // audioSource.PlayOneShot(Music);
        }
        else audioSource.enabled = false;
        StartCoroutine(pers());
   //     numFace = PlayerPrefs.GetInt("NumFace");

     //   numHair = PlayerPrefs.GetInt("NumHair");
       // numDress = PlayerPrefs.GetInt("NumDress");
        //   numMackup = PlayerPrefs.GetInt("NumMackup");

    }

    IEnumerator pers()
    {
        yield return new WaitForSeconds(0.01f);
        for (int i = 0; i < vidPersonazha.Length; i++)
        {

            if (i == numFace)
            {
                personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[i];

            }


            if (i == numHair)
            {
                playerHair.GetComponent<SpriteRenderer>().sprite = Hair[i];

            }

            if (i == numDress)
            {
                playerDress.GetComponent<SpriteRenderer>().sprite = Dress[i];

            }
        }
        //*************personazh Dress

        //*************personazh Makup
       // rt = GetComponent<RectTransform>();
    }


    // Update is called once per frame
    void Update()
    {
 
        /*  if (vklPlashkaStat)
          {
              StartCoroutine(ShowPlashkaStat());

          }*/

    }
    //  vklPlashkaStat
    // txtPlashkaStat
    // imgBgPlashkaStat
    //icoPlashkaStat

    public float izmenenieStatov;
    public void ZapuskPlashka()
    {
     
        StartCoroutine(ShowPlashkaStat());
    }
    IEnumerator ShowPlashkaStat()
    {
        yield return new WaitForSeconds(0.02f);
       // if (vklPlashkaStat)
       // {
            if (izmenenieStatov >= 0 && izmenenieStatov < 1)
            {

                //vklPlashkaStat
                txtPlashkaStat.GetComponent<Text>().color = new Color(255f, 255f, 255f, izmenenieStatov);
                imgBgPlashkaStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
                icoPlashkaStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
                // imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
                // statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
                // txtinImageinDialogStat.color = new Color(255f, 255f, 255f, izmenenieStatov);
                //imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
                //imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
                //txtinImageinDialogMisly.GetComponent<Text>().color = new Color(0f, 0f, 0f, izmenenieStatov);
                izmenenieStatov = izmenenieStatov + 0.02f;

                StartCoroutine(ShowPlashkaStat());
            }
            if (izmenenieStatov >= 1)
            {
                txtPlashkaStat.GetComponent<Text>().color = new Color(255f, 255f, 255f, 1f);
                imgBgPlashkaStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
                icoPlashkaStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);

                //imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
                //statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
                //txtinImageinDialogStat.color = new Color(255f, 255f, 255f, 1f);
                //imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
                //imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
                //txtinImageinDialogMisly.GetComponent<Text>().color = new Color(0f, 0f, 0f, 1f);
                // StartCoroutine(UschezanieStatov());
                StartCoroutine(ZhdatPlashkaStat());
                StopCoroutine(ShowPlashkaStat());


            }
       // }
    }

    IEnumerator ZhdatPlashkaStat()
    {
        yield return new WaitForSeconds(2f);
        StartCoroutine(HideplashkaStat());
    }
    IEnumerator HideplashkaStat()
    {
        yield return new WaitForSeconds(0.02f);
        if (izmenenieStatov > 0)
        {
            txtPlashkaStat.GetComponent<Text>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            imgBgPlashkaStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            icoPlashkaStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            izmenenieStatov = izmenenieStatov - 0.02f;
            StartCoroutine(HideplashkaStat());
        }

        if (izmenenieStatov <= 0)
        {
            txtPlashkaStat.GetComponent<Text>().color = new Color(255f, 255f, 255f, 0f);
            imgBgPlashkaStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            icoPlashkaStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            // izmenenieStatov = izmenenieStatov - 0.02f;
            vklPlashkaStat = false;
            izmenenieStatov = 0;
            StopCoroutine(HideplashkaStat());
        }


    }

   // txtVsplivausheeOkno
     //   imgBgVsplivausheeOkno
     //   IcoBgVsplivausheeOkno
         public void ZapuskVsplivausheeOkno()
    {
        vsplivaushieOknaSource.Play();



        StartCoroutine(ShowVsplivausheeOkno());
        /*  if (inkScript.vikluchitHistoryText)
          {
              StartCoroutine(ZhdatVsplivausheeOkno());
          }
          else
          {
              StartCoroutine(ShowVsplivausheeOkno());
          }
        */

    }
    public Text txtInsidevsplivOknoMain;
    public int LVL;
    IEnumerator ShowVsplivausheeOkno()
    {
        yield return new WaitForSeconds(0.02f);
        // if (vklPlashkaStat)
        // {
      //  inkScript.numberLevel[LVL].red
           
        if (izmenenieStatov >= 0 && izmenenieStatov < 1)
        {

            //vklPlashkaStat
            txtVsplivausheeOkno.GetComponent<Text>().color = new Color(inkScript.numberLevel[LVL].red, inkScript.numberLevel[LVL].green, inkScript.numberLevel[LVL].blue, izmenenieStatov);
           // txtInsidevsplivOkno.GetComponent<Text>().color = new Color(0f, 0f, 0f, izmenenieStatov);
            imgBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            IcoBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            // imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            // statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            // txtinImageinDialogStat.color = new Color(255f, 255f, 255f, izmenenieStatov);
            //imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            //imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            //txtinImageinDialogMisly.GetComponent<Text>().color = new Color(0f, 0f, 0f, izmenenieStatov);
            izmenenieStatov = izmenenieStatov + 0.04f;

           /* if (inkScript.vikluchitHistoryText)
            {
                izmenenieStatov = 0 - 0.04f;
                txtVsplivausheeOkno.GetComponent<Text>().color = new Color(0f, 0f, 0f, 0f);
                imgBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                IcoBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            }
            izmenenieStatov = izmenenieStatov + 0.04f;*/
            StartCoroutine(ShowVsplivausheeOkno());
        }
        if (izmenenieStatov >= 1)
        {
            txtVsplivausheeOkno.GetComponent<Text>().color = new Color(inkScript.numberLevel[LVL].red, inkScript.numberLevel[LVL].green, inkScript.numberLevel[LVL].blue, 1f);
            imgBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            IcoBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            //txtInsidevsplivOkno.GetComponent<Text>().color = new Color(0f, 0f, 0f, 1f);
            //imgStat.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            //statImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            //txtinImageinDialogStat.color = new Color(255f, 255f, 255f, 1f);
            //imgMisly.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            //imgMislyIconka.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
            //txtinImageinDialogMisly.GetComponent<Text>().color = new Color(0f, 0f, 0f, 1f);
            // StartCoroutine(UschezanieStatov());
            StartCoroutine(ZhdatVsplivausheeOkno());
            StopCoroutine(ShowVsplivausheeOkno());


        }
        // }
    }

    IEnumerator ZhdatVsplivausheeOkno()
    {
        yield return new WaitForSeconds(1f);
      
        StartCoroutine(HideVsplivausheeOkno());
    }
    IEnumerator HideVsplivausheeOkno()
    {
        StopCoroutine(ShowVsplivausheeOkno());
        yield return new WaitForSeconds(0.02f);
        if (izmenenieStatov > 0)
        {
            txtVsplivausheeOkno.GetComponent<Text>().color = new Color(inkScript.numberLevel[LVL].red, inkScript.numberLevel[LVL].green, inkScript.numberLevel[LVL].blue, izmenenieStatov);
            imgBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
            IcoBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmenenieStatov);
          //  txtInsidevsplivOkno.GetComponent<Text>().color = new Color(0f, 0f, 0f, izmenenieStatov);
            izmenenieStatov = izmenenieStatov - 0.02f;

          /*  if (inkScript.vikluchitHistoryText)
            {
                izmenenieStatov = 0 ;
                txtVsplivausheeOkno.GetComponent<Text>().color = new Color(0f, 0f, 0f, 0f);
                imgBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                IcoBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            }*/
            StartCoroutine(HideVsplivausheeOkno());
        }

        if (izmenenieStatov <= 0)
        {
            txtVsplivausheeOkno.GetComponent<Text>().color = new Color(inkScript.numberLevel[LVL].red, inkScript.numberLevel[LVL].green, inkScript.numberLevel[LVL].blue, 0f);
            imgBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            IcoBgVsplivausheeOkno.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
         //   txtInsidevsplivOkno.GetComponent<Text>().color = new Color(0f, 0f, 0f, 0f);

            // izmenenieStatov = izmenenieStatov - 0.02f;
            vklPlashkaStat = false;
            izmenenieStatov = 0;
            StopCoroutine(HideVsplivausheeOkno());
        }


    }
    public TextAndImageinInkText textImagetext;
    public GameObject goBtnBackMotanie;
    public Button btnBackMotanie;
    public int proverkamotaniya;

    public void BackMotanie()
    {
        proverkamotaniya = 1;
           textImagetext = GameObject.FindGameObjectWithTag("Maintext").GetComponent<TextAndImageinInkText>();
        textImagetext.revers = -1;
        textImagetext.Startmotanie();
        goBtnBackMotanie.SetActive(false);
        inkScript.enableMousebtn = false;
        inkScript.boolTimer = false;
        inkScript.palecTimer.SetActive(false);
    }
    public void ExitScene()
    {
        SceneManager.LoadScene(1);
    }

}
