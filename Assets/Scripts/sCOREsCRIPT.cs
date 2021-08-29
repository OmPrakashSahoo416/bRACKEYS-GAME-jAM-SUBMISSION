using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sCOREsCRIPT : MonoBehaviour
{
    public Text score;
    public float scorevalue;

    private void Update()
    {
        scorevalue += Time.deltaTime;
        score.text = scorevalue.ToString("0"); 
    }

}
