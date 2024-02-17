using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text textArea;
    private int timeCount;
    // Start is called before the first frame update
    void Start()
    {
        timeCount = 30;
        StartCoroutine(ChangingTextEverySecond());
    }

    IEnumerator ChangingTextEverySecond()
    {
        timeCount--;
        if (timeCount < 0)
        {
            Destroy(gameObject);
        }
        textArea.text = timeCount.ToString();
        yield return new WaitForSeconds(1);
        StartCoroutine(ChangingTextEverySecond());
    }
}
