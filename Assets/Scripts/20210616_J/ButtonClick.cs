using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Button[] buttons = new Button[6];

    private void Start()
    {
        for(int i = 0; i<buttons.Length;i++)
        {
            int a = i;
            buttons[i].onClick.AddListener(() =>
            {
                OnClick(a);
            });
        }
    }

    public void OnClick(int index)
    {
/*   ½ÂÈ¯ÄÚµå
 *   for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = true;
        }

        buttons[index].interactable = false;*/

        for (int i = 0; i< buttons.Length;i++)
        {
            buttons[i].interactable = (i != index);
        }
    }
}