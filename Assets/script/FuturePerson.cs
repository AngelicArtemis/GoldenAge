using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuturePerson : MonoBehaviour {
	public PlayerLook pLook;
	public Robot robot;
	public GameObject RobotDialogue;
    public Text RobotText;
    public int PageNum = 0;
    public string text1;
	public UnityStandardAssets.Characters.FirstPerson.FirstPersonController firstPersonController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Player clicked");

			if (firstPersonController.enabled == false) {
                if (PageNum == 0 && robot.gameObject.GetComponent<clickText>().mustClick == true) {
                    RobotText.text = robot.gameObject.GetComponent<clickText>().text2;
                    PageNum = PageNum + 1;}
                else if (PageNum == 1 && robot.gameObject.GetComponent<clickText>().mustClick == true)
                {
                    RobotText.text = robot.gameObject.GetComponent<clickText>().text3;
                    PageNum = PageNum + 1;
                }
                else if (PageNum == 2 && robot.gameObject.GetComponent<clickText>().mustClick == true)
                {
                    RobotText.text = robot.gameObject.GetComponent<clickText>().text4;
                    PageNum = PageNum + 1;
                }
                else if (PageNum == 3 && robot.gameObject.GetComponent<clickText>().mustClick == true)
                {
                    RobotText.text = robot.gameObject.GetComponent<clickText>().text5;
                    PageNum = PageNum + 1;
                }
                else if (PageNum == 4 && robot.gameObject.GetComponent<clickText>().mustClick == true)
                {
                    RobotText.text = robot.gameObject.GetComponent<clickText>().text6;
                    PageNum = PageNum + 1;
                }
                else if (PageNum == 5 && robot.gameObject.GetComponent<clickText>().mustClick == true)
                {
                    RobotText.text = robot.gameObject.GetComponent<clickText>().text7;
                    PageNum = PageNum + 1;
                }
                else if (PageNum == 6 && robot.gameObject.GetComponent<clickText>().mustClick == true)
                {
                    RobotText.text = robot.gameObject.GetComponent<clickText>().text8;
                    PageNum = PageNum + 1;
                }
                else
                {
                    Debug.Log("Hide Dialogue");

                    RobotDialogue.gameObject.SetActive(false);
                    firstPersonController.enabled = true;
                }
            } else if (pLook.lookingAtRobot == true && robot.playerClose == true)
            {
                PageNum = 0;
                RobotText.text = robot.gameObject.GetComponent<clickText>().text ;
                Debug.Log("Show Dialogue!");

                RobotDialogue.gameObject.SetActive(true);
                firstPersonController.enabled = false;
            }
		}
	}
}
