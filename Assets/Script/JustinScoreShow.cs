using UnityEngine;
using System.Collections;

public class JustinScoreShow : MonoBehaviour {

    private CubeGestureListenerForJustin gestureListener;

    public GUIText scoreShow;
    public int score;
    public float waveWait;
    public int scoreValue;

	// Use this for initialization
	void Start () {
        score = 0;
        gestureListener = CubeGestureListenerForJustin.Instance;
        StartCoroutine(ScoreAnim());
	}
	
	// Update is called once per frame
	//void Update () {
        
	//}


    // Dance Action
    IEnumerator ScoreAnim()
    {
        yield return new WaitForSeconds(17);
        
        for (int i = 0; i < 4; i++)
        {
            if (gestureListener)
            {
                if (gestureListener.IsButtomRight())
                {
                    AddScore(scoreValue);
                    
                }
            }
            yield return new WaitForSeconds(waveWait);
        }

        for (int i = 0; i < 2; i++)
        {
            if (gestureListener)
            {
                if (gestureListener.IsDoubleHandRight())
                {
                    AddScore(scoreValue);
                }
                yield return new WaitForSeconds(waveWait);
                if (gestureListener.IsDoubleHandLeft())
                {
                    AddScore(scoreValue);
                }
            }
            yield return new WaitForSeconds(waveWait);
        }

        for(int i = 0; i < 4; i++)
        {
            if (gestureListener)
            {
                if(gestureListener.IsLeftHandDownRight())
                {
                    AddScore(scoreValue);
                }            
            }
            yield return new WaitForSeconds(waveWait);
        }
        yield return new WaitForSeconds(8.4f);

        for(int i = 0; i < 4; i++)
        {
            if (gestureListener)
            {
                if (gestureListener.IsDoubleHandPullBack())
                {
                    AddScore(scoreValue);
                }
            }
            yield return new WaitForSeconds(waveWait);
        }

    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreShow.text = "Score:" + score;
    }
}
