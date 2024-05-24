using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using TMPro;

public class PoseDetector : MonoBehaviour
{
    public List<ActiveStateSelector> poses;
    public TextMeshProUGUI infoText;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in poses)
        {
            item.WhenSelected += () => SetTextToPoseName(item.gameObject.name);
            item.WhenUnselected += () => SetTextToPoseName("");
        }
    }

    private void SetTextToPoseName(string newText)
    {
        infoText.text = newText;
    }

}