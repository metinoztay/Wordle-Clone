
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContentController : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button temp;
    [SerializeField] private List<RowController> rows;

    private int _index;

    private void Start()
    {
        inputField.onValueChanged.AddListener(OnUpdateContent);
        inputField.onSubmit.AddListener(OnSubmit);
      
    }

    private void OnUpdateContent(string msg)
    {
        var row = rows[_index];
        row.UpdateText(msg);
    }

    private void OnSubmit(string msg)
    {
        temp.Select();
        inputField.Select();

        if (inputField.text.Length < rows[_index].cellAmount)
        {
            Debug.Log("Not Enough");
            return;
        }

        _index++;
        inputField.text = "";
        
    }
}
