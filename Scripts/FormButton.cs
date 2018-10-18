using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormButton : Button
{
    public InputField[] inputFields;
    
    public bool MissingInput()
    {
        foreach (InputField i in inputFields)
        {
            if (i == null)
            {
                Debug.LogWarning("Missing input!");

                return true;
            }
        }

        return false;
    }
}
