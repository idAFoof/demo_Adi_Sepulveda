using TMPro;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public TextMeshProUGUI textbox; 

    public void OnClick()
    {
        textbox.text = "I have changed.";
    }

}