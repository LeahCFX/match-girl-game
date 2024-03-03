using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BottomBarController : MonoBehaviour
{
    public TextMeshProUGUI barText;
    public TextMeshProUGUI personNameText;

    private int sentenceIndex = -1;
    private StoryScene currentScene;
    private State state = State.COMPLETE;

    private enum State
    {
        PLAYING, COMPLETE
    }

    public void PlayScene(StoryScene scene)
    {
        currentScene = scene;
        sentenceIndex = -1;
        PlayNextSentence();
    }

    public void PlayNextSentence()
    {
        StartCoroutine(TypeText(currentScene.sentences[++sentenceIndex].text));
        personNameText.text = currentScene.sentences[sentenceIndex].character.characterName;
        personNameText.color = currentScene.sentences[sentenceIndex].character.textColor;
    }

    public bool IsCompleted()
    {
        return state == State.COMPLETE;
    }

    public bool IsLastSentence()
    {
        return sentenceIndex + 1 == currentScene.sentences.Count;
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
