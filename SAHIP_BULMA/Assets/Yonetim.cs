using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yonetim : MonoBehaviour
{
    int yerlesen_parca=0;
   public int toplam_parca = 20;
    int can;//3 yanl�� hakk�n var
    int sure = 60;// oyun s�resi

    // Start is called before the first frame update
    void Start()
    {
        can = 3;
        
    }
    public void sayi_artir() 
    {
        yerlesen_parca++;//t�m kutular yerle�tirildiyse
        if (yerlesen_parca==toplam_parca)
        {
            Debug.Log("sonraki sahneye ge� !!!");

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
    // Update is called once per frame
    void Update()
    {
        
    }
}
