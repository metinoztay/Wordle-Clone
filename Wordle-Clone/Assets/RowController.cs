using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowController : MonoBehaviour
{
    [SerializeField] private List<CellController> cells;
    public int cellAmount => cells.Count;

    public void UpdateText(string msg)
    {
        var arrayChar = msg.ToCharArray();

        for (int i = 0; i < cells.Count; i++)
        {
            var cell = cells[i];

            bool isExist = i < arrayChar.Length;
            var content = isExist ? arrayChar[i] : ' ';
            cell.UpdateText(content);
        }

    }
}
