using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRate : MonoBehaviour
{

    public float alphaLevel = 0.2f;
  
    bool changeBool = true;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        if (changeBool == true) {
            StartCoroutine(HeartRateChange());
            float change = Random.Range(-0.0002f, 0.002f);
            Debug.Log(alphaLevel);
            alphaLevel = alphaLevel + change;

            GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, alphaLevel);
        }
    }

    IEnumerator HeartRateChange()
    {
        changeBool = false;
        yield return new WaitForSeconds(0.01f);
        changeBool = true;

    }

}
