using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class counterScripts : MonoBehaviour
{
    public TextMeshProUGUI counterMessage;
    private string displayedMessage;
    private int counterAmount = 5;
    private float secs = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine("showMessage");
    }

   

    private IEnumerator showMessage()
    {
        while (counterAmount >= 0)
        {
            displayedMessage = counterAmount.ToString();
            counterMessage.text = displayedMessage;
            counterAmount--;
            yield return new WaitForSeconds(secs);
            
        }

        displayedMessage = "Se acabó!";
        counterMessage.text = displayedMessage;
    }
}
