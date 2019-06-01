using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    [SerializeField]
    public Image midImg;
    [SerializeField]
    private Image topImg;

    public AnimationCurve curve;

    [SerializeField]
    private GameObject levelCompleteGO;

    [SerializeField]
    private GameObject hud;

    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    public void FadeTo(string scene)
    {
        StartCoroutine(FadeOutToNextScene(scene));
    }

    public void StartFadeOut()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeIn()
    {
        float t = 2f;

        while (t > 0f)
        {
            t -= Time.deltaTime;
            float a = curve.Evaluate(t);
            midImg.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }
    }

    //Borde endast användas vid byte från meny till annan scen.
    IEnumerator FadeOutToNextScene(string scene)
    {
        float t = 0f;

        while (t < 2f)
        {
            t += Time.deltaTime;
            float a = curve.Evaluate(t);
            topImg.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }

        SceneManager.LoadScene(scene);
    }

    IEnumerator FadeOut()
    {
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime;
            float a = curve.Evaluate(t);
            midImg.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }

        levelCompleteGO.SetActive(true);

        yield return new WaitForSeconds(3);

        hud.gameObject.SetActive(false);
    }
}