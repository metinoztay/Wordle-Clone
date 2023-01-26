using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CellController : MonoBehaviour
{
    [SerializeField] private Color colorCorrect;
    [SerializeField] private Color colorExist;
    [SerializeField] private Color colorFail;
    [SerializeField] private Color colorNone;


    [SerializeField] private Image background;
    [SerializeField] private TextMeshProUGUI text;

    public void UpdateText(char msg)
    {
        text.SetText(msg.ToString());
    }

    public void UpdateState(State state)
    {
        background.color = GetColor(state);
    }

    private Color GetColor(State state)
    {
        return state switch
        {
            State.None => colorNone,
            State.Exist => colorExist,
            State.Fail => colorFail,
            State.Correct => colorCorrect,
        };
    }

}

public enum State
{
    None,
    Exist,
    Correct,
    Fail
}
