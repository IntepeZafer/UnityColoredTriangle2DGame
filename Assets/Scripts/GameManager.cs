using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameObject;
    public float spawnInteral = 1f;
    public float spawnRangeX = 8f;
    public float spawnRangeY = 4f;

    private void Start()
    {
        StartCoroutine(SpawnTargets());
    }
    IEnumerator SpawnTargets()
    {
        while (true)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
            GameObject newTarget = Instantiate(gameObject, spawnPosition, Quaternion.identity);
            SpriteRenderer sr = newTarget.GetComponent<SpriteRenderer>();
            sr.color = new Color(Random.value, Random.value, Random.value);
            Destroy(newTarget, 5f);
            yield return new WaitForSeconds(spawnInteral);
        }
    }
}
