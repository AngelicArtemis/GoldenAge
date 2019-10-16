using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.PostProcessing;

public class FocusChanging : MonoBehaviour
{

    PostProcessingProfile ppProfile;
    // Start is called before the first frame update
    void Start()
    {
        ppProfile = gameObject.GetComponent<PostProcessingProfile>();
        Debug.Log(ppProfile);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("o"))
        {
            changeFocus();
            Debug.Log("pressed o");
        }
    }

    public void changeFocus()
    {
        ppProfile.depthOfField.enabled = true;
        DepthOfFieldModel.Settings newSettings = ppProfile.depthOfField.settings;
        newSettings.focusDistance = 1f;
        ppProfile.depthOfField.settings = newSettings;
    }


}
