using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public AudioSource OyunSesi;
    public Top _Top;
    public Top _Top2;
    public int ToplamTopSayisi;
    public int DevrilmesiGerekenObjeSayisi;
    public AudioSource IpKesmeSesi;

    public GameObject[] IP_Merkezleri;

    private void Start()
    {
        OyunSesi.Play();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null) 
            {
                if (hit.collider.CompareTag("Merkez_1"))
                {
                    IpKesmeSesi.Play();
                    //*Destroy(hit.collider.gameObject);
                    //hit.collider.gameObject.SetActive(false);
                    //_Top.HingeKontrol["Merkez_1"].enabled = false;
                    foreach (var item in IP_Merkezleri)
                    {
                        if (item.GetComponent<Ip_Yonetimi>().HingeAdi == "Merkez_1")
                    {
                        foreach (var item2 in item.GetComponent<Ip_Yonetimi>().BaglantiHavuzu)
                    {
                        item2.SetActive(false);
                    }
                    }
                    //} ---> // kýsýmlar zincirlerin tamamýný kaldýrmamýzý saðlýyor.
                }}
                else if (hit.collider.CompareTag("Merkez_2"))
                {
                    IpKesmeSesi.Play();
                    //*Destroy(hit.collider.gameObject);
                    //hit.collider.gameObject.SetActive(false);
                    //_Top.HingeKontrol["Merkez_2"].enabled = false;
                    foreach (var item in IP_Merkezleri)
                    {
                        if (item.GetComponent<Ip_Yonetimi>().HingeAdi == "Merkez_2")
                    {
                        foreach (var item2 in item.GetComponent<Ip_Yonetimi>().BaglantiHavuzu)
                    {
                        item2.SetActive(false);
                    }
                    }
                    }
                }
                else if (hit.collider.CompareTag("Merkez_3"))
                {
                    IpKesmeSesi.Play();
                    hit.collider.gameObject.SetActive(false);
                   _Top2.HingeKontrol["Merkez_3"].enabled = false;
                }
                else if (hit.collider.CompareTag("Merkez_4"))
                {
                    IpKesmeSesi.Play();
                    hit.collider.gameObject.SetActive(false);
                    _Top2.HingeKontrol["Merkez_4"].enabled = false;
                }
                else if (hit.collider.CompareTag("Merkez_5"))
                {
                    IpKesmeSesi.Play();
                    hit.collider.gameObject.SetActive(false);
                    _Top2.HingeKontrol["Merkez_5"].enabled = false;
                }

            }       
    }
}

    public void TopDustu()
    {
        ToplamTopSayisi--;
        if (ToplamTopSayisi==0)
        {
            if (DevrilmesiGerekenObjeSayisi>0)
            {
                Debug.Log("Kaybettin");
            }
            else if (DevrilmesiGerekenObjeSayisi==0)
            {
                Debug.Log("Kazandýn");
            }
            else
            {
                if (DevrilmesiGerekenObjeSayisi == 0)
                {
                    Debug.Log("Kazandýn");
                }
            }
        }
    }
    public void HedefObjeDustu()
    {
        DevrilmesiGerekenObjeSayisi--;
        if (ToplamTopSayisi == 0 && DevrilmesiGerekenObjeSayisi==0)
        {
            Debug.Log("KAZANDIN");
        }
        else if (ToplamTopSayisi == 0 && DevrilmesiGerekenObjeSayisi > 0)
        {
            Debug.Log("KAYBETTÝN");
        }
    }
}
