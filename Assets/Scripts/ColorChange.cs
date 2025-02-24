using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(ChangeColor());
    }

    // Renk de�i�imi i�in Coroutine kullan�yoruz
    IEnumerator ChangeColor()
    {
        while (true)
        {
            // Yeni bir rastgele renk olu�tur
            Color newColor = new Color(Random.value, Random.value, Random.value);
            spriteRenderer.color = newColor;

            // Renk de�i�iminden sonra 1 saniye bekle
            yield return new WaitForSeconds(5f);
        }
    }
}
