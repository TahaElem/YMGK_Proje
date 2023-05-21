using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tasi : MonoBehaviour
{
    Camera kamera;
    Vector2 baslangic_pos;
    GameObject[] kutu_dizisi;
    Yonetim yonet;
    public int toplam_parca;

    private void OnMouseDrag() 
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    
    }
    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangic_pos = transform.position;
        kutu_dizisi = GameObject.FindGameObjectsWithTag("kutu");
        yonet = GameObject.Find("yonetim").GetComponent<Yonetim>();

        
        toplam_parca = kutu_dizisi.Length;
        yonet.hedef_puan= toplam_parca*100;
        yonet.hedef_puan_txt.text = (toplam_parca * 100).ToString();
        Debug.Log("toplam parça=="+toplam_parca);

    }

    // Update is called once per frame
    void Update ()
    {

        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject kutu in kutu_dizisi)
            {

                if (kutu.name==gameObject.name)
                {

                    float mesafe = Vector3.Distance(kutu.transform.position, transform.position);
                    if (mesafe<=1)
                    {
                        transform.position = kutu.transform.position;

                        yonet.puan_artir(100);
                        this.enabled = false;
                       
                      

                    }
                    else if(mesafe>1)
                    {
                        transform.position = baslangic_pos;
                        yonet.Can_kontrol();//düzenle
                    }

                }
            }

        }
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag(""))
    //    {

    //    }
    //}
}
