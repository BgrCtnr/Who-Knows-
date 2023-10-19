using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;


public class ödüla : MonoBehaviour
{
    public sorular sorularb;

    private string[] ödül;


    private int[] dogru ;

    public int ödülsayisi, maxÖdül; 

    private Text ödül1; 





    void Start()
    {

        ödülsayisi = 1;
        maxÖdül = 15 ;
        
        ödül = new string[maxÖdül +1];


        dogru = new int[maxÖdül +1];


        ödül1 = gameObject.GetComponent<Text>();


        int a = 1 ;

        ödül[a]="500 TL KAZANDINIZ";

        a = 2 ;
        ödül[a]="750 TL KAZANDINIZ";

        a = 3 ;
        ödül[a]="1.500 TL KAZANDINIZ";

        a = 4 ;
        ödül[a]="3.000 TL KAZANDINIZ";

        a = 5 ;
        ödül[a]="5.000 TL KAZANDINIZ";

        a = 6 ;
        ödül[a]="7.500 TL KAZANDINIZ";

        a = 7 ;
        ödül[a]="15.000 TL KAZANDINIZ";

        a = 8 ;
        ödül[a]="30.000 TL KAZANDINIZ";

        a = 9 ;
        ödül[a]="50.000 TL KAZANDINIZ";

        a = 10 ;
        ödül[a]="100.000 TL KAZANDINIZ";

        a = 11 ;
        ödül[a]="250.000 TL KAZANDINIZ";

        a = 12 ;
        ödül[a]="500.000 TL KAZANDINIZ";

        a = 13 ;
        ödül[a]="750.000 TL KAZANDINIZ";

        a = 14 ;
        ödül[a]="1.000.000 TL KAZANDINIZ";

        a = 15 ;
        ödül[a]="5.000.000 TL KAZANDINIZ";



}


        void Update () 
        
        {


        ödül1.text = ödül[ödülsayisi];


            
        }




        public void dypress123 ()
        
        {
            if(ödülsayisi<maxÖdül)
            {


            ödülsayisi += 1;

            }
        
            else if(ödülsayisi==maxÖdül)
            {
                sorularb = GameObject.Find("dybutton").GetComponent<sorular>();

                sorularb.dybutton.SetActive(true);
                sorularb.dyText.text=("Oyun bitti");
                

            }

        
        }

}
