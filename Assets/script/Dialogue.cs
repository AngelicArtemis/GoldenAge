using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public string[] messages = new string[1];
    public GameObject dialogBox;
    public PlayerLook pLook;
    public Robot robot;
    bool talking = false;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController firstPersonController;

    private void Start()
    {
        robot = GameObject.Find("Robot").GetComponent<Robot>();
    }

    private void Update()
    {
        if (robot.playerClose && Input.GetMouseButtonDown(0))
        {
            if(talking)
            {
                dialogBox.gameObject.SetActive(false);
                talking = false;
                firstPersonController.enabled = true;
            }
            else if(!talking)
            {
                var randomMessage = messages[Random.Range(0, messages.Length)];
                dialogBox.transform.Find("Text").GetComponent<UnityEngine.UI.Text>().text = randomMessage;
                dialogBox.gameObject.SetActive(true);
                talking = true;
                firstPersonController.enabled = false;
            }
            
        }
    }
}