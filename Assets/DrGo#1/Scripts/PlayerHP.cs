using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private Transform parentTransform;
    [SerializeField]
    private GameObject hudTextPrefab;

    private void OnEnable()
    {
        StartCoroutine("UpdateHPLoop");
    }
    private void OnDisable()
    {
        StopCoroutine("UpdateHPLoop");
    }
    private IEnumerator UpdateHPLoop()
    {
        while (true)
        {
            float time = Random.Range(0.1f, 1.0f);
            yield return new WaitForSeconds(time);
            int type = Random.Range(0, 2);
            string text = Random.Range(10, 1000).ToString();
            Color color = type == 0 ? Color.red : Color.green;
            SpawnHUDText(text, color);
        }
    }

    private void SpawnHUDText(string text, Color color)
    {
        GameObject clone = Instantiate(hudTextPrefab);
        clone.transform.SetParent(parentTransform);
        Bounds bounds = GetComponent<Collider2D>().bounds;
        clone.GetComponent<UIHUDText>().Play(text, color, bounds);
    }
}
