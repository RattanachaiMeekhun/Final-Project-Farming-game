using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInventoryTextBox : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textTop1 = null;
    [SerializeField] TextMeshProUGUI textTop2 = null;
    [SerializeField] TextMeshProUGUI textTop3 = null;
    [SerializeField] TextMeshProUGUI textBottom1 = null;
    [SerializeField] TextMeshProUGUI textBottom2 = null;
    [SerializeField] TextMeshProUGUI textBottom3 = null;


    public void SetTextboxText(string textTop1, string textTop2, string textTop3,string textBottom1, string textBottom2, string textBottom3)
    {
        textTop1 = textTop1;
        textTop2 = textTop2;
        textTop3 = textTop3;
        textBottom1 = textBottom1;
        textBottom2 = textBottom2;
        textBottom3 = textBottom3;
    }

}
