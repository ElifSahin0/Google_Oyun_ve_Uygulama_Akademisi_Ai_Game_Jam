using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton instance

    private int score = 0; // Oyuncunun puaný

    // Diðer script'lerin bu ScoreManager örneðine eriþebilmesi için Singleton yapýsý
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

    // Puan eklemek için kullanýlacak fonksiyon
    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        Debug.Log("Puan Eklendi! Toplam Puan: " + score);
    }

    // Puaný sýfýrlamak için kullanýlacak fonksiyon
    public void ResetScore()
    {
        score = 0;
        Debug.Log("Puan Sýfýrlandý!");
    }

    // Puaný almak için kullanýlacak fonksiyon
    public int GetScore()
    {
        return score;
    }
}
