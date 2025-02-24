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

    // Renk deðiþimi için Coroutine kullanýyoruz
    IEnumerator ChangeColor()
    {
        while (true)
        {
            // Yeni bir rastgele renk oluþtur
            Color newColor = new Color(Random.value, Random.value, Random.value);
            spriteRenderer.color = newColor;

            // Renk deðiþiminden sonra 1 saniye bekle
            yield return new WaitForSeconds(5f);
        }
    }
}
