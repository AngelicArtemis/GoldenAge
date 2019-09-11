using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TaskListManager : MonoBehaviour
{



    public void taskChecker(TaskList taskList)
    {
        if(FindObjectOfType<ScreenCaptureManager>().taskListCheck(taskList.taskName))
        {
            taskList.taskCompletion = true;
        }


    }


}
