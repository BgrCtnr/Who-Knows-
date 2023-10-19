using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class anamenusc : MonoBehaviour
{


    [SerializeField]

    AudioSource audioSource;

    public AudioClip butonsesi;

    [SerializeField]

    private GameObject basla , cikis ;

    
    private void Awake() {
        
        audioSource=GetComponent<AudioSource>();

    
     }

    // Start is called before the first frame update
    void Start()
    {


        FadeOut();

    }
 
    void FadeOut()
    {

        basla.GetComponent<CanvasGroup>().DOFade(1, 1f);
        cikis.GetComponent<CanvasGroup>().DOFade(1, 1f);
    }    


  


    public void butonabasildi(){

    audioSource.PlayOneShot(butonsesi);

     }


    public void exitgame() {

        Application.Quit();

     }


    public void startgame()
    {

        
        SceneManager.LoadScene("ekran");


    }


}    