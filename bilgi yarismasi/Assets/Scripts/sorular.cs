using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using Random = UnityEngine.Random;
using TMPro;


public class sorular : MonoBehaviour
{
    
    
    private string[] soru, secenekA , secenekB , secenekC , secenekD ;

    private int[] dogru ;
  

    public AudioSource audiod,audioy,audioz;

    public AudioClip butonsesi1,butonsesi2,butonsesi3;


    public GameObject secenekdosya , dybutton , exit, soruarkaplan, canvastimer,ödülekrani, confeti1, sonrakisoru ,cikis123, c3, seceneka,secenekb ,secenekc,secenekd;


    

    public Text buttonTextA , buttonTextB , buttonTextC , buttonTextD , dyText ;


    [HideInInspector]

    public int soruSayisi, maxSoru; 

    private Text soruyazi; 



    void Start()
    {   
        
        soruSayisi = Random.Range(1,28);
    



        maxSoru = 30 ;

        soru = new string[maxSoru +1];


        secenekA = new string[maxSoru +1];

        secenekB = new string[maxSoru +1];

        secenekC = new string[maxSoru +1];

        secenekD = new string[maxSoru +1];

        dogru = new int[maxSoru +1];


        soruyazi = gameObject.GetComponent<Text>();
      
       
        int a = 1;
        
        soru[a]="Türkiye'nin başkenti hangisidir? ";
        secenekA[a] = "İstanbul"; 
        secenekB[a] = "İzmir"; 
        secenekC[a] = "Ankara"; 
        secenekD[a] = "Çanakkale"; 
        dogru[a] = 3 ;

        
        a = 2;

        soru[a]="Hangi yiyecek evde yapılırken üzerine havlu örtülür? "; 
        secenekA[a]= "Tarhana"; 
        secenekB[a]= "Reçel"; 
        secenekC[a]= "Turşu"; 
        secenekD[a]= "Yoğurt"; 
        dogru[a] = 4 ;


        a = 3;

        soru[a]="Türkiye'de kaç adet bölge bulunmaktadır? "; 
        secenekA[a] = "7";
        secenekB[a] = "9"; 
        secenekC[a] = "3"; 
        secenekD[a] = "5"; 
        dogru[a] = 1 ;


        a = 4;

        soru[a]="'Becerikli , zeki , güçlü' anlamında kullanılan kelime hangisidir? "; 
        secenekA[a] = "Temkinli"; 
        secenekB[a] = "Dirayetli";
        secenekC[a] = "Görgülü";
        secenekD[a] = "Kibirli";
        dogru[a] = 2 ;


        a = 5;

        soru[a]="Bir yazıyı veya kitabı 'çok kısa sürede okumak' hangi sözle ifade edilir? "; 
        secenekA[a] = "Bir dikişte";
        secenekB[a] = "Bir bakışta";
        secenekC[a] = "Bir koşu"; 
        secenekD[a] = "Bir solukta"; 
        dogru[a] = 4 ;


        a = 6;

        soru[a]="Atatürk tarafından 4 Eylül 1919 tarihinde Sivas Kongresi'nde kurulmuş olan gazetenin adını söyleyiniz? "; 
        secenekA[a] = "Peyam";
        secenekB[a] = "Tasvir-i Efkar";
        secenekC[a] = "İrâde-i Milliye"; 
        secenekD[a] = "Cumhuriyet"; 
        dogru[a] = 3 ;



        a = 7;

        soru[a]="Dinamiti icat eden ve her yıl adına çeşitli dallarda ödüller verilen ünlü bilim adamı kimdir? "; 
        secenekA[a] = "Alfred Nobel";
        secenekB[a] = "Thomas Edison";
        secenekC[a] = "Alexander Graham Bell"; 
        secenekD[a] = "Charles Darwin"; 
        dogru[a] = 1 ;



        a = 8;

        soru[a]="Everest Tepesine tırmanan ilk Türk dağcı kimdir? "; 
        secenekA[a] = "Ali Nasuh Mahruki";
        secenekB[a] = "Tunç Fındık";
        secenekC[a] = "Bozkurt Ergör"; 
        secenekD[a] = "Tanju Duru"; 
        dogru[a] = 1 ;


        a = 9;
        
        soru[a]="2007 yılında Avrupa Birliğine giren ülkeler hangileridir? "; 
        secenekA[a] = "Letonya, Estonya";
        secenekB[a] = "Slovenya, Slovakya";
        secenekC[a] = "Bulgaristan, Romanya"; 
        secenekD[a] = "Macaristan, Polonya"; 
        dogru[a] = 3 ;



        a = 10;

        soru[a]="Osmanlı Devleti'nde ilk nüfus sayımı hangi padişah zamanında yapılmıştır? "; 
        secenekA[a] = "I. Mehmet";
        secenekB[a] = "II. Murad";
        secenekC[a] = "II. Bayezid"; 
        secenekD[a] = "Fatih Sultan Mehmet"; 
        dogru[a] = 2 ;



        a = 11;

        soru[a]="Türkçe hangi dil grubuna girmektedir? "; 
        secenekA[a] = "Hami - Sami Dil Ailesi";
        secenekB[a] = "Bantu Dil Ailesi";
        secenekC[a] = "Çin - Tibet Dil Ailesi"; 
        secenekD[a] = "Ural - Altay Dil Ailesi"; 
        dogru[a] = 4 ;



        a = 12;

        soru[a]="Kadınlara seçme ve seçilme hakkı tanıyan ilk ülke hangisidir? "; 
        secenekA[a] = "Türkiye";
        secenekB[a] = "Almanya";
        secenekC[a] = "Fransa"; 
        secenekD[a] = "İngiltere"; 
        dogru[a] = 1 ;


        a = 13;

        soru[a]="İstiklal Marşımızın resmi olarak bestecisi kimdir? "; 
        secenekA[a] = "Ali Rıfat Çağatay";
        secenekB[a] = "Mehmet Akif Ersoy";
        secenekC[a] = "Osman Zeki Güngör"; 
        secenekD[a] = "Ekrem Zeki Ün"; 
        dogru[a] = 3 ;


        a = 14;

        soru[a]="Türkiye sınırları içindeki en uzun nehir hangisidir? "; 
        secenekA[a] = "Fırat Nehri";
        secenekB[a] = "Kızılırmak Nehri";
        secenekC[a] = "Dicle Nehri"; 
        secenekD[a] = "Aras Nehri"; 
        dogru[a] = 2 ;


        a = 15;

        soru[a]="Telgraf'da hangi alfabe kullanılır? "; 
        secenekA[a] = "Mors Alfabesi";
        secenekB[a] = "Latin Alfabesi";
        secenekC[a] = "Kiril Alfabesi"; 
        secenekD[a] = "Arap Alfabesi"; 
        dogru[a] = 1 ;
        

        a = 16;

        soru[a]="Pusulada ( N ) harfi hangi yönü ifade eder ?"; 
        secenekA[a] = "Kuzey";
        secenekB[a] = "Güney";
        secenekC[a] = "Doğu"; 
        secenekD[a] = "Batı"; 
        dogru[a] = 1 ;
        

        a = 17;

        soru[a]="Avrupa Birliğinin başkenti neresidir?"; 
        secenekA[a] = "Düsseldorf";
        secenekB[a] = "Londra";
        secenekC[a] = "Brüksel"; 
        secenekD[a] = "Liverpool"; 
        dogru[a] = 3 ;
        
        a = 18;

        soru[a]="En geniş ormanlık alana sahip bölgemiz hangisidir ?"; 
        secenekA[a] = "Marmara Bölgesi";
        secenekB[a] = "Karadeniz Bölgesi";
        secenekC[a] = "Doğu Anadolu Bölgesi"; 
        secenekD[a] = "Akdeniz Bölgesi"; 
        dogru[a] = 2 ;
        
        a = 19;

        soru[a]="Halk arasında kullanılan söze göre saç ile hangisi karışmaz ?"; 
        secenekA[a] = "Soğan";
        secenekB[a] = "Saban";
        secenekC[a] = "Saman"; 
        secenekD[a] = "Sapan"; 
        dogru[a] = 3 ;
        
        a = 20;

        soru[a]="'Sonsuza dek mutlu yaşadılar' hangisinin bitiş sözüdür ? "; 
        secenekA[a] = "Ninni";
        secenekB[a] = "Destan";
        secenekC[a] = "Bilgi yarışması"; 
        secenekD[a] = "Masal"; 
        dogru[a] = 4 ;
        
        a = 21;

        soru[a]="İğne atsan yere düşmez sözü hangisini anlatmak için kullanılır ?"; 
        secenekA[a] = "Sessiz";
        secenekB[a] = "Kalabalık";
        secenekC[a] = "Issız"; 
        secenekD[a] = "Sıcak"; 
        dogru[a] = 2 ;
        
        a = 22;

        soru[a]="Yılbaşında insanların birbirinden ayrılırken yaptıkları soğuk şaka hangisidir? "; 
        secenekA[a] = "Ne desem boş";
        secenekB[a] = "Gözün arkada kalmasın";
        secenekC[a] = "Seneye görüşürüz"; 
        secenekD[a] = "Zaman herşeyin ilacı"; 
        dogru[a] = 3 ;
        
        a = 23;

        soru[a]="Geleneklere göre nişanı kim yapar ?"; 
        secenekA[a] = "Kız Tarafı";
        secenekB[a] = "Arkadaşlar";
        secenekC[a] = "Komşular"; 
        secenekD[a] = "Erkek Tarafı"; 
        dogru[a] = 1 ;
        
        a = 24;

        soru[a]="'Neredeyse az daha' anlamında kullanılan söz hangisidir ?"; 
        secenekA[a] = "Aslan Payı";
        secenekB[a] = "Kıl Payı";
        secenekC[a] = "Sus Payı"; 
        secenekD[a] = "Kardeş Payı"; 
        dogru[a] = 2 ;
        
        a = 25;

        soru[a]="En çok bilinen sihirbazlık numarasında, şapkadan hangi hayvan çıkar?"; 
        secenekA[a] = "Tavşan";
        secenekB[a] = "Ördek";
        secenekC[a] = "Kurbağa"; 
        secenekD[a] = "Kuş"; 
        dogru[a] = 1 ;
        
        a = 26;

        soru[a]="Hangisi yeni evlenenlere söylenen , iyi dilek anlamında bir sözdür? "; 
        secenekA[a] = "Geçmiş olsun";
        secenekB[a] = "Allah kurtarsın";
        secenekC[a] = "Allah müstehakınızı versin"; 
        secenekD[a] = "Bir yastıkta kocayın"; 
        dogru[a] = 4 ;
        
        a = 27;

        soru[a]="Hangisi hafif nesneleri kaldırırken yapılan benzetmedir ? "; 
        secenekA[a] = "İnci gibi";
        secenekB[a] = "Tüy gibi";
        secenekC[a] = "Çiçek gibi"; 
        secenekD[a] = "Kuş gibi"; 
        dogru[a] = 2 ;
        
        a = 28;

        soru[a]="En arkadan en öne doğru para uzatılan ulaşım aracı hangisidir? "; 
        secenekA[a] = "Uçak";
        secenekB[a] = "Minibüs";
        secenekC[a] = "Otobüs"; 
        secenekD[a] = "Tren"; 
        dogru[a] = 2 ;
        
        a = 29;

        soru[a]="Halk masallarına başlarken kullanılan tekerleme hangisidir ?"; 
        secenekA[a] = "Onlar ermiş muradına";
        secenekB[a] = "Az gittim uz gittim";
        secenekC[a] = "Bir varmış bir yokmuş"; 
        secenekD[a] = "Gökten üç elma düşmüş"; 
        dogru[a] = 3 ;
        
        a = 30;

        soru[a]="Halk arasında yaygın olarak kullanılan sözde kime zeval olmayacağı söylenir? "; 
        secenekA[a] = "Elçiye";
        secenekB[a] = "Bekçiye";
        secenekC[a] = "Müdüre"; 
        secenekD[a] = "Sunucuya"; 
        dogru[a] = 1 ;
        



    




    }




    // Update is called once per frame
    void Update()
    {


        soruyazi.text = soru[soruSayisi];


        buttonTextA.text = secenekA[soruSayisi];

        buttonTextB.text = secenekB[soruSayisi];

        buttonTextC.text = secenekC[soruSayisi];

        buttonTextD.text = secenekD[soruSayisi];
        



    }


 
public void buttonsecenekA()
{
    StartCoroutine(BekleVeDevamEt1());
}

IEnumerator BekleVeDevamEt1()
{

    if (audioz != null && butonsesi3 != null)
    {
        audioz.PlayOneShot(butonsesi3);
    }
    yield return new WaitForSeconds(2f); 
    Color originalColor = seceneka.GetComponent<Image>().color;

    if (dogru[soruSayisi] == 1)
    {   
    
    if (audiod != null && butonsesi1 != null)
    {
        audiod.PlayOneShot(butonsesi1);
    }
        seceneka.GetComponent<Image>().color = Color.green;

        Debug.Log("Doğru Cevap");

        yield return new WaitForSeconds(2f);
        secenekdosya.SetActive(false);
        cikis123.SetActive(false);
        soruarkaplan.SetActive(false);
        canvastimer.SetActive(false);
        confeti1.SetActive(true);
        ödülekrani.SetActive(true);
        sonrakisoru.SetActive(true);
        seceneka.GetComponent<Image>().color = originalColor;

        

    }
     else
    { 

    if (audioy != null && butonsesi2 != null)
    {
        audioy.PlayOneShot(butonsesi2);
    }

        Debug.Log("Yanlış Cevap");
        
        seceneka.GetComponent<Image>().color = Color.red;

        yield return new WaitForSeconds(2f);
        secenekdosya.SetActive(false);
        cikis123.SetActive(false);
        soruarkaplan.SetActive(false);
        canvastimer.SetActive(false);
        dybutton.SetActive(true);
        dybutton.GetComponent<Image>().color =Color.red;
        dyText.text="Yanlış Cevap, Tekrar Oyna!";
       

    }
    


    canvastimer.SetActive(false);
}

    

     public void  buttonsecenekB ()
{

StartCoroutine(BekleVeDevamEt2());

}

IEnumerator BekleVeDevamEt2()
{
    if (audioz != null && butonsesi3 != null)
    {
        audioz.PlayOneShot(butonsesi3);
    }
    yield return new WaitForSeconds(2f); 
    Color originalColor = secenekb.GetComponent<Image>().color;


    if (dogru[soruSayisi] == 2)
    {   
    
    if (audiod != null && butonsesi1 != null)
    {
        audiod.PlayOneShot(butonsesi1);
    }
        secenekb.GetComponent<Image>().color = Color.green;

        Debug.Log("Doğru Cevap");

        yield return new WaitForSeconds(2f);
        secenekdosya.SetActive(false);
        cikis123.SetActive(false);
        soruarkaplan.SetActive(false);
        canvastimer.SetActive(false);
        confeti1.SetActive(true);
        ödülekrani.SetActive(true);
        sonrakisoru.SetActive(true);

        secenekb.GetComponent<Image>().color = originalColor;


        

    }
    
     else
    {   
    if (audioy != null && butonsesi2 != null)
    {
        audioy.PlayOneShot(butonsesi2);
    }

        Debug.Log("Yanlış Cevap");

        secenekb.GetComponent<Image>().color = Color.red;

        yield return new WaitForSeconds(2f);
        secenekdosya.SetActive(false);
        cikis123.SetActive(false);
        soruarkaplan.SetActive(false);
        canvastimer.SetActive(false);
        dybutton.SetActive(true);
        dybutton.GetComponent<Image>().color =Color.red;
        dyText.text="Yanlış Cevap, Tekrar Oyna!";
       

    }
    
    

    canvastimer.SetActive(false);

}

    

     public void  buttonsecenekC ()
{

StartCoroutine(BekleVeDevamEt3());

}

IEnumerator BekleVeDevamEt3()
{
    if (audioz != null && butonsesi3 != null)
    {
        audioz.PlayOneShot(butonsesi3);
    }
    yield return new WaitForSeconds(2f); 
    Color originalColor = secenekc.GetComponent<Image>().color;


    if (dogru[soruSayisi] == 3)
    {   
    
    if (audiod != null && butonsesi1 != null)
    {
        audiod.PlayOneShot(butonsesi1);
    }
        secenekc.GetComponent<Image>().color = Color.green;

        Debug.Log("Doğru Cevap");

        yield return new WaitForSeconds(2f);
        secenekdosya.SetActive(false);
        cikis123.SetActive(false);
        soruarkaplan.SetActive(false);
        canvastimer.SetActive(false);
        confeti1.SetActive(true);

        ödülekrani.SetActive(true);
        sonrakisoru.SetActive(true);

        secenekc.GetComponent<Image>().color = originalColor;

        

    }
    
     else
    {   
    if (audioy != null && butonsesi2 != null)
    {
        audioy.PlayOneShot(butonsesi2);
    }

        Debug.Log("Yanlış Cevap");

        secenekc.GetComponent<Image>().color = Color.red;

        yield return new WaitForSeconds(2f);
        secenekdosya.SetActive(false);
        cikis123.SetActive(false);
        soruarkaplan.SetActive(false);
        canvastimer.SetActive(false);
        dybutton.SetActive(true);
        dybutton.GetComponent<Image>().color =Color.red;
        dyText.text="Yanlış Cevap, Tekrar Oyna!";
       

    }
    

        canvastimer.SetActive(false);



}




        public void  buttonsecenekD ()
{

StartCoroutine(BekleVeDevamEt4());

}

IEnumerator BekleVeDevamEt4()
{
    if (audioz != null && butonsesi3 != null)
    {
        audioz.PlayOneShot(butonsesi3);
    }
    yield return new WaitForSeconds(2f); 
    Color originalColor = secenekd.GetComponent<Image>().color;



    if (dogru[soruSayisi] == 4)
    {   
    
    if (audiod != null && butonsesi1 != null)
    {
        audiod.PlayOneShot(butonsesi1);
    }
        secenekd.GetComponent<Image>().color = Color.green;

        Debug.Log("Doğru Cevap");

        yield return new WaitForSeconds(2f);
        secenekdosya.SetActive(false);
        cikis123.SetActive(false);
        soruarkaplan.SetActive(false);
        canvastimer.SetActive(false);
        confeti1.SetActive(true);

        ödülekrani.SetActive(true);
        sonrakisoru.SetActive(true);

        secenekd.GetComponent<Image>().color = originalColor;
        

    }
    
     else
    {   
    if (audioy != null && butonsesi2 != null)
    {
        audioy.PlayOneShot(butonsesi2);
    }

        Debug.Log("Yanlış Cevap");

        secenekd.GetComponent<Image>().color = Color.red;

        yield return new WaitForSeconds(2f);
        secenekdosya.SetActive(false);
        cikis123.SetActive(false);
        soruarkaplan.SetActive(false);
        canvastimer.SetActive(false);
        dybutton.SetActive(true);
        dybutton.GetComponent<Image>().color =Color.red;
        dyText.text="Yanlış Cevap, Tekrar Oyna!";
       

    }
    



    canvastimer.SetActive(false);

}


public void ctpress(){

    if(soruSayisi<maxSoru)

        confeti1.SetActive(false);
        ödülekrani.SetActive(false);
        sonrakisoru.SetActive(false);
        secenekdosya.SetActive(true);
        cikis123.SetActive(true);
        soruarkaplan.SetActive(true);
        canvastimer.SetActive(true);

        soruSayisi +=1;


}
  public void dypressbg () 
    {

        SceneManager.LoadScene("anaekran");



    }
    
    public void oyunbitti(){

        Debug.Log("OYUN BİTTİ");

    }

        public void exitgame() {

        Application.Quit();

}



}








