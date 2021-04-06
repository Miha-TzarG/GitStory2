using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public GameObject btnNarcis, btnMint,btnRomashka,btnRose, btnShalfey;
    public int btnNarcisActive, btnMintActive, btnRomashkaActive, btnRoseActive, btnShalfeyActive;

    public Sprite spritebtnNarcis, spritebtnMint, spritebtnRomashka, spritebtnRose, spritebtnShalfey;

    public string trueOtvet = "12345";
    public string otvet;
    public int colvoOtvetov;
    public int colvoSovpadenii;

    public InkScript inkScript;
    public GameObject Game0;
    public HistoryScript historyScript;

    public GameObject panelErrrorGame;

    public GameObject Panel;
    public Text txtinPanel;
    public Image ImageName;
    public Text txtNamePanel;
  
    // Start is called before the first frame update
    void Start()
    {
        historyScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<HistoryScript>();
        btnNarcis.GetComponent<Button>().OnButtonClick = delegate
        {

            ChooseNarcis();

        };

        btnMint.GetComponent<Button>().OnButtonClick = delegate
        {
            ChooseMint();

        };
        btnRomashka.GetComponent<Button>().OnButtonClick = delegate
        {
            ChooseRomashka();

        };
        btnRose.GetComponent<Button>().OnButtonClick = delegate
        {
            ChooseRose();

        };
        btnShalfey.GetComponent<Button>().OnButtonClick = delegate
        {
            ChooseShalfey();

        };
    }


    public void ChooseNarcis()
    {
        if (btnNarcisActive == 0)
        {
            btnNarcis.GetComponent<SpriteRenderer>().sprite = spritebtnNarcis;
               a = a + 1;
            //  b = 4;
            otvet = otvet + "4";
            colvoOtvetov = colvoOtvetov + 1;
            inkScript.story.variablesState["game0"] = "";
         //   inkScript.enableMousebtn = true;
            StartCoroutine(ProverkaOtveta());
            StartCoroutine(proverkaA());
            btnNarcisActive = 1;
        }

    }
    public void ChooseMint()
    {
        if (btnMintActive == 0)
        {
            btnMint.GetComponent<SpriteRenderer>().sprite = spritebtnMint;
            a = a + 1;
            // b = 5;
            otvet = otvet + "5";
            colvoOtvetov = colvoOtvetov + 1;
            inkScript.story.variablesState["game0"] = "";
          //  inkScript.enableMousebtn = true;
            StartCoroutine(ProverkaOtveta());
            StartCoroutine(proverkaA());
            btnMintActive = 1;
        }
        
    }
    public void ChooseRomashka()
    {
        if (btnRomashkaActive == 0)
        {
            btnRomashka.GetComponent<SpriteRenderer>().sprite = spritebtnRomashka;
            a = a + 1;
            // b = 1;
            otvet = otvet + "1";
            colvoOtvetov = colvoOtvetov + 1;
            inkScript.story.variablesState["game0"] = "";
           // inkScript.enableMousebtn = true;
            StartCoroutine(ProverkaOtveta());
            StartCoroutine(proverkaA());
            btnRomashkaActive = 1;
        }
        
    }
    public void ChooseRose()
    {

        if (btnRoseActive == 0)
        {
            btnRose.GetComponent<SpriteRenderer>().sprite = spritebtnRose;
            a = a + 1;
            //   b = 3;
            otvet = otvet + "3";
            colvoOtvetov = colvoOtvetov + 1;
            inkScript.story.variablesState["game0"] = "";
          //  inkScript.enableMousebtn = true;

            StartCoroutine(ProverkaOtveta());
            StartCoroutine(proverkaA());
            btnRoseActive = 1;
        }
        
    }
    public void ChooseShalfey()
    {
        if (btnShalfeyActive == 0)
        {
            btnShalfey.GetComponent<SpriteRenderer>().sprite = spritebtnShalfey;
            // b = 2;
            a = a + 1;
            otvet = otvet + "2";
            colvoOtvetov = colvoOtvetov + 1;
            inkScript.story.variablesState["game0"] = "";
          //  inkScript.enableMousebtn = true;
            StartCoroutine(ProverkaOtveta());
            StartCoroutine(proverkaA());
            btnShalfeyActive = 1;
        }

        
    }
    public int a;
    public float izmeneniya;
    //public int b;
    IEnumerator proverkaA()
    {
        yield return new WaitForSeconds(0.001f);
        if(a.ToString() != otvet[a-1].ToString())
        {
            if (izmeneniya < 1)
            {
                Panel.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmeneniya);
                txtinPanel.color = new Color(0f, 0f, 0f, izmeneniya);
                ImageName.color = new Color(255f, 255f, 255f, izmeneniya);
                txtNamePanel.color = new Color(255f, 255f, 255f, izmeneniya);
                izmeneniya = izmeneniya + 0.04f;
               
                StartCoroutine(proverkaA());
            }
            else if (izmeneniya >= 1)
            {
                Panel.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1f);
                txtinPanel.color = new Color(0f, 0f, 0f, 1f);
                ImageName.color = new Color(255f, 255f, 255f, 1f);
                txtNamePanel.color = new Color(255f, 255f, 255f, 1f);
                izmeneniya = 0;
                StartCoroutine(ZakritError());
                StopCoroutine(proverkaA());
            }

        }
       
    }
    
    IEnumerator ZakritError()
    {
        yield return new WaitForSeconds(1f);
        StartCoroutine(ZatuhanieError());
    }
    public float izmeneniya2;
    IEnumerator ZatuhanieError()
    {
        yield return new WaitForSeconds(0.001f);
        if (izmeneniya2 > 0.05)
        {
            Panel.GetComponent<Image>().color = new Color(255f, 255f, 255f, izmeneniya2);
            txtinPanel.color = new Color(0f, 0f, 0f, izmeneniya2);
            ImageName.color = new Color(255f, 255f, 255f, izmeneniya2);
            txtNamePanel.color = new Color(255f, 255f, 255f, izmeneniya2);
            izmeneniya2 = izmeneniya2 - 0.04f;
            StartCoroutine(ZatuhanieError());
        }
        else if (izmeneniya <= 0.05)
        {
            Panel.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
            txtinPanel.color = new Color(0f, 0f, 0f, 0f);
            ImageName.color = new Color(255f, 255f, 255f, 0f);
            txtNamePanel.color = new Color(255f, 255f, 255f, 0f);
            izmeneniya2 = 1;
            StopCoroutine(ZatuhanieError());
            //StartCoroutine(ZakritError());
        }
    }
    IEnumerator ProverkaOtveta()
    {
        yield return new WaitForSeconds(0.1f);
        {
            Debug.Log("Game-: " + inkScript.story.variablesState["gam0"]);
            if (colvoOtvetov == 5)
            {
               
                for(int i = 0; i < 5; i++)
                {
                    if(otvet[i] == trueOtvet[i])
                    {
                        colvoSovpadenii = colvoSovpadenii + 1;
                       
                    }
                  
                    
                  
                }
                OtpravkaOtveta();
            }

            inkScript.ViborGame();


        }
    }
    public void OtpravkaOtveta()
    {
      //  inkScript.enableMousebtn = true;
        if (colvoSovpadenii < 4)
        {
            inkScript.story.variablesState["gam0Otvet"] = "2";
            historyScript.ZapuskVsplivausheeOkno();
            historyScript.txtVsplivausheeOkno.text = "Вы плохо справились с заданием. Это огорчило Олимпию.";

        }
        if (colvoSovpadenii >= 4)
        {
            inkScript.story.variablesState["gam0Otvet"] = "1";
            historyScript.ZapuskVsplivausheeOkno();
            historyScript.txtVsplivausheeOkno.text = "Вы успешно справились с заданием! Олимпия гордится вами.";
        }
      //  Panel.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
       // txtinPanel.color = new Color(0f, 0f, 0f, 0f);
     //   ImageName.color = new Color(255f, 255f, 255f, 0f);
        //txtNamePanel.color = new Color(255f, 255f, 255f, 0f);
        Game0.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
