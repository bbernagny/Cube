using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score1 : MonoBehaviour
{
    private int score = 0;
    private bool isHit = false;

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private MeshRenderer cube;

    public void ButtonClick()
    {
        float currentDegree = Mathf.Abs(Cube1.Instance.transform.eulerAngles.x) % 90;
        if (!isHit && (currentDegree <= 10f || (90 - currentDegree) <= 10f))
        {
            StartCoroutine(AddScore());
        }
    }

    private IEnumerator AddScore()
    {
        isHit = true;
        score++;
        text.text = score.ToString();
        yield return new WaitForSeconds(0.5f);
        isHit = false;
    }
}
