using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMenager : MonoBehaviour
{
    public GameObject CloseButton;
    public GameObject ExampleText;

    public void ClickPopupButton()
    {
        CloseButton.SetActive(true);
    }

    public void ClickTimeButton()
    {
        ExampleText.SetActive(true);
        StartCoroutine(ShowExampleText(3.0f));
    }

    public void ClickCloseButton()
    {
        CloseButton.SetActive(false);
    }

    IEnumerator ShowExampleText(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
        ExampleText.SetActive(false);
    }
}
