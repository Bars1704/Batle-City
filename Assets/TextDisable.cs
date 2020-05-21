using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisable : MonoBehaviour
{
    public float step;
    public float pause;
    Text text;
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        StartCoroutine(Pause(pause));   
    }
    IEnumerator Pause(float pause)
    {
        yield return new WaitForSeconds(pause);
    }
    private void Update()
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - step * Time.deltaTime);
        if (text.color.a <= 0)
        {
            Destroy(gameObject);
        }
    }
}
