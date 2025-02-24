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
        // Farenin dünya koordinatlarýný al
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Z eksenini sýfýrlayarak sadece XY yönünde dönmesini saðla
        mousePos.z = 0;

        // Farenin bulunduðu yere doðru döndür
        transform.up = mousePos - transform.position;
    }
}
