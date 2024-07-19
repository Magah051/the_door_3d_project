using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGoOut : MonoBehaviour
{
    public GameObject key;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(DeactivateKeyAfterDelay(2f));
    }

    private IEnumerator DeactivateKeyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        key.SetActive(false);
    }
}
