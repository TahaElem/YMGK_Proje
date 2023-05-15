using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yonetim : MonoBehaviour
{
    int puan = 0;
    public int hedef_puan = 500;
    int saniye = 60;

    public AudioSource arkaplanses;
    public AudioSource puansesi;
    public AudioSource kritikzamansesi;
    public AudioSource kazandinses;
    public AudioSource kaybettinses;
    int yerlesen_parca=0;
    tasi tasima_obj = new tasi();
   public int toplam_parca = 20;
    public GameObject kaybet_pnl;
    public GameObject kazandin_pnl;
    public GameObject bilgi_pnl;
    public bool panel_acik = false;
    public TextMeshProUGUI saniye_txt;
    public TextMeshProUGUI puan_txt;
    public TextMeshProUGUI hedef_puan_txt;
    int can;//3 yanlýþ hakkýn var
    int sure = 60;// oyun süresi

    // Start is called before the first frame update
    void Start()
    {
        //hedef_puan = tasima_obj.toplam_parca;
        saniye_txt.text = saniye.ToString();
        puan_txt.text = puan.ToString();
        hedef_puan_txt.text = hedef_puan.ToString();

        InvokeRepeating("saniye_azalt", 0.0f, 1f);
        can = 3;
        
    }
    #region methotlar
    public void sayi_artir() 
    {
        yerlesen_parca++;//tüm kutular yerleþtirildiyse
        if (yerlesen_parca==toplam_parca)
        {
            Debug.Log("sonraki sahneye geç !!!");

        }    
    }

    
    public void Can_kontrol() 
    {
        
            can++;//can kontrol

        
        
        if (can==0)
        {
            Debug.Log(can+"kaybetttin pnl!!!");

        }
        else
        {
            Debug.Log(can + "kaybetttin pnl!!!");
        }
    
    }

    //saniye azaltma methodu
    void saniye_azalt()
    {
        if (!panel_acik)
        {
            saniye--;
            saniye_txt.text = saniye.ToString();

            if (saniye == 10)
            {
                kritikzamansesi.Play();
            }
            if (saniye <= 0)
            {
                kaybettin();

            }

        }
       
    }
    public void puan_artir(int deger) {
        puan+=deger;
        puan_txt.text = puan.ToString();
        puansesi.Play();

        
        if (puan>=hedef_puan)
        {
            arkaplanses.Stop();
            Time.timeScale = 1.0f;
            kazandin_pnl.SetActive(true);
            panel_acik = true;
            kazandinses.Play();
            Debug.Log("kazandın");
        }
    
    
    }

    void kaybettin() {
        arkaplanses.Stop();
        kaybet_pnl.SetActive(true);
        panel_acik = true;
        kaybettinses.Play();
        Time.timeScale = 1.0f;
    
    }
   public void tekrar_oyna()
    {
        
        Time.timeScale = 1.0f;//sahne zamanı durdur
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//aktif sahnenin indexini alır

    }

    public void sonraki_sahne()
    {

        Time.timeScale = 1.0f;//sahne zamanı durdur
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//aktif sahnenin indexini alır

    }
    public void ilk_sahne()
    {

        Time.timeScale = 1.0f;//sahne zamanı durdur
        SceneManager.LoadScene(0);//aktif sahnenin indexini alır

    }
    public void cikis()
    {
        Application.Quit();

    }

    public void devam_et()
    {
        Time.timeScale = 1.0f;
        kaybet_pnl.SetActive(false);//durdur paneli gizle
        panel_acik = false;
       

    }
    public void durdur_btn()
    {
        Time.timeScale = 0.0f;
        bilgi_pnl.SetActive(true);
        panel_acik = true;

    }
    public void bilgi_panel_gizle()
    {
        Time.timeScale = 1;//tüm hareketi aç

        bilgi_pnl.SetActive(false);
        panel_acik = false;
        if (saniye <= 10)
        {
            kritikzamansesi.Play();
        }
    }
    public void bilgi_panel_goster()
    {
        Time.timeScale = 1;//tüm hareketi baslat
        if (saniye <= 10)
        {
            kritikzamansesi.Pause();
        }
        bilgi_pnl.SetActive(true);
        panel_acik = true;
    }

    #endregion methotlar
    // Update is called once per frame
    void Update()
    {
        
    }
}
