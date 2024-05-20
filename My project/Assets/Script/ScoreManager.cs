using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton instance

    private int score = 0; // Oyuncunun puan�

    // Di�er script'lerin bu ScoreManager �rne�ine eri�ebilmesi i�in Singleton yap�s�
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Puan eklemek i�in kullan�lacak fonksiyon
    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        Debug.Log("Puan Eklendi! Toplam Puan: " + score);
    }

    // Puan� s�f�rlamak i�in kullan�lacak fonksiyon
    public void ResetScore()
    {
        score = 0;
        Debug.Log("Puan S�f�rland�!");
    }

    // Puan� almak i�in kullan�lacak fonksiyon
    public int GetScore()
    {
        return score;
    }
}
