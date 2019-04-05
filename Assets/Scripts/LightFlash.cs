using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlash : MonoBehaviour
{
    [SerializeField] private float delay = 1.0f;
    public GameObject[] lights;

    private void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("Light");
        while (true)
            StartCoroutine(Flash());
    }
    
    IEnumerator Flash()
    {
        yield return new WaitForSeconds(delay);

        foreach (GameObject light in lights)
        {
            light.SetActive(!light.activeSelf);
            light.SetActive(!light.activeSelf);
        }

    }
}
