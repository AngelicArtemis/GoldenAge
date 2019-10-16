using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.PostProcessing;

public class FocusChanging : MonoBehaviour
{

    public PostProcessingProfile ppProfile;


    IEnumerator changes()
    {
        for (int i = 1; i <= 21; i += 5)
        {
            yield return new WaitForSeconds(0.23f);
            ppProfile.depthOfField.enabled = true;
            DepthOfFieldModel.Settings newSettings = ppProfile.depthOfField.settings;
            newSettings.focusDistance = i;
            //Debug.Log("focus: " + i);
            ppProfile.depthOfField.settings = newSettings;
            if(i == 21)
            {
                ppProfile.depthOfField.enabled = false;
            }
        }
    }

    public void changeFocus()
    {
        StartCoroutine(changes());
    }


}
