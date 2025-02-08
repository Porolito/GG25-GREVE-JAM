using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private int m_Score;
    [SerializeField] private TMP_Text m_ScoreLabel;

    [SerializeField] private int m_ComboIndex = 0;

    private int[] m_ComboArray = new int[4]{1,2,4,8};

    public void AddScore(int number)
    {
        m_Score += number * m_ComboArray[m_ComboIndex];
        m_ScoreLabel.text = m_Score.ToString();
    }

    public void MinusScore(int number)
    {
        m_Score -= number;
        m_ScoreLabel.text = m_Score.ToString();
    }

    public void AddCombo()
    {
        if(m_ComboIndex < m_ComboArray.Length - 1)
        {
            m_ComboIndex++;
        }
    }

    public void BreakCombo()
    {
        m_ComboIndex = 0;
    }
}
