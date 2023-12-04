using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactable : MonoBehaviour
{
    public GameObject textPanel;

    public void OnInteraction()
    {
        textPanel.SetActive(true);
    }
}
