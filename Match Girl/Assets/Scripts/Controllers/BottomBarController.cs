using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BottomBarController : MonoBehaviour
{
    public TextMeshProUGUI barText;
    public TextMeshProUGUI personNameText;

    private int sentenceIndex = -1;
    public StoryScene currentScene;
    private State state = State.COMPLETE;

    private enum State
    {
        PLAYING, COMPLETE
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TypeText(currentScene.sentences[++sentenceIndex].text));
    }

    private IEnumerator TypeText(string text)
    {
        barText.text = "";
        state = State.PLAYING;
        int wordIndex = 0;

        while(state != State.COMPLETE)
        {
            // adding to text piece by piece, type effect
            barText.text += text[wordIndex];
            yield return new WaitForSeconds(0.05f); // speed adjust
            if(++wordIndex == text.Length)
            {
                state = State.COMPLETE;
                break;
            }
        }
    }
}
