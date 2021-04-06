using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HideGarferobShop : MonoBehaviour
{
    public Animator Hide;
    public GameObject ShowBtnDown;
    public GameObject ShowBtnUp;
    // public AnimationClip hideClip;
    //  public AnimationClip ShowClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hidePanel()
    {
         Hide.runtimeAnimatorController = Resources.Load("Animator/panelMain/PanelGarderob") as RuntimeAnimatorController;
        Hide.enabled = true;
        // ShowBtnUp.SetActive(true);
        ShowBtnDown.GetComponent<Image>().color = new Color(255f,255f,255f,0);
        StartCoroutine(startShowBtnUp()) ;
       
    }

    IEnumerator startShowBtnUp()
    {

        yield return new WaitForSeconds(1f);
      

        ShowBtnDown.SetActive(false);
        ShowBtnUp.SetActive(true);
        ShowBtnUp.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1);
        // ShowBtnDown.SetActive(false);
    }
    public void showPanel()
    {
       Hide.runtimeAnimatorController = Resources.Load("Animator/panelMain/PanelGarderob 1") as RuntimeAnimatorController;
       Hide.enabled = true;
        ShowBtnUp.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0);
        StartCoroutine(startShowBtnDown());
      
        // ShowBtnDown.SetActive(true);
    }
    IEnumerator startShowBtnDown()
    {
        yield return new WaitForSeconds(1f);
        ShowBtnUp.SetActive(false);
        ShowBtnDown.SetActive(true);
        ShowBtnDown.GetComponent<Image>().color = new Color(255f, 255f, 255f, 1);
    }
}
