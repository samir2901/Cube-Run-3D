
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    private int x = 1;
    public Text ScoreText;
    void Update()
    {
        ScoreText.text = x.ToString();
        x += 1;
    }
}
