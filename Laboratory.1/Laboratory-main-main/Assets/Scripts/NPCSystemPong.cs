using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class NPCSystemPong : MonoBehaviour
{
    public GameObject d_template;
    public GameObject d_template2;
    public GameObject canva;

    bool player_detection = false;

    void Update()
    {

        if (player_detection && !PlayerMove.dialogue)
        {
            PlayerMove.dialogue = true;
            NewDialogue("Hello");
            NewDialogue("If you want to play pong klick Y");
            canva.transform.GetChild(0).gameObject.SetActive(true);
            Invoke(nameof(SwitchText), 2f);
        }

        if(Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            int sceneBuildIndex = SceneManager.GetActiveScene().buildIndex - 1;
            SceneManager.LoadScene(sceneBuildIndex);
        }

    }

    void SwitchText()
    {
        canva.transform.GetChild(0).gameObject.SetActive(false);
        canva.transform.GetChild(1).gameObject.SetActive(true);
    }

    void NewDialogue(string text)
    {
        GameObject template_clone = Instantiate(d_template, canva.transform);
        template_clone.GetComponent<TextMeshProUGUI>().text = text;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player_detection = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
        PlayerMove.dialogue = false;
        for (int I = 0; I < canva.transform.childCount; I++)
        {
            Destroy(canva.transform.GetChild(I).gameObject);
        }
    }
}