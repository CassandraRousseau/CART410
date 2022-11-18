using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDialog : MonoBehaviour
{

    public GameObject uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText.SetActive(false);
    }

    // Update is called once per frame
    void onTriggerEnter(MeshRenderer areaMesh)
    {
        if (areaMesh.gameObject.tag == "Zone")
        {
            uiText.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec() {

        yield return new WaitForSeconds(5);
        Destroy(uiText);
        Destroy(gameObject);
    }
}
