using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpnDown : MonoBehaviour
{
    public float kecepatan;
    public GameObject batasAtas;
    public GameObject batasBawah;


    private bool naik;

    // Start is called before the first frame update
    void Start()
    {
        naik = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (naik)
        {
            float batasy = batasAtas.transform.position.y;
            Vector3 posisiakhir = new Vector3();
            posisiakhir.x = transform.position.x;
            posisiakhir.y = transform.position.y + kecepatan;
            posisiakhir.z = transform.position.z;
            transform.position = posisiakhir;
            if(posisiakhir.y > batasy)
            {
                naik = false;
            }
        }
        else
        {
            float batasy = batasBawah.transform.position.y;
            Vector3 posisiakhir = new Vector3();
            posisiakhir.x = transform.position.x;
            posisiakhir.y = transform.position.y - kecepatan;
            posisiakhir.z = transform.position.z;
            transform.position = posisiakhir;
            if (posisiakhir.y < batasy)
            {
                naik = true;
            }
        }
    }
}   
