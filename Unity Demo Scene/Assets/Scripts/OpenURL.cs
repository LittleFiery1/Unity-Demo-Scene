using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void OpenWebPage(string URL)
    {
        Application.OpenURL(URL);
    }
}
