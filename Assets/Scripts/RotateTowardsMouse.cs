using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsMouse : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Farenin d�nya koordinatlar�n� al
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Z eksenini s�f�rlayarak sadece XY y�n�nde d�nmesini sa�la
        mousePos.z = 0;

        // Farenin bulundu�u yere do�ru d�nd�r
        transform.up = mousePos - transform.position;
    }
}
