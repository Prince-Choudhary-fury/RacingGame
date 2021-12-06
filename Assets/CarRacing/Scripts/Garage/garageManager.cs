using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class garageManager : MonoBehaviour
{

    public GameObject colorPanal;
    public GameObject tierPanal;
    public GameObject particalSmoke;
    public Transform spawnParent;

    public Button nextButton;
    public Button previousButton;

    public MeshRenderer bodyMat;

    public List<Color32> topColors = new List<Color32>();
    public static Color32 currentColor;
    private int currntTopColor;

    private void Start()
    {
        currentColor = bodyMat.material.color;
    }

    public void OnDropdownChange(int index)
    {
        if (index == 0)
        {
            tierPanal.SetActive(false);
            colorPanal.SetActive(true);
        }
        else if (index == 1)
        {
            colorPanal.SetActive(false);
            tierPanal.SetActive(true);
        }
    }

    public void Next()
    {
        nextButton.interactable = false;
        if (currntTopColor >= (topColors.Count - 1))
        {
            currntTopColor = 0;
        }
        else
        {
            currntTopColor += 1;
        }
        StartCoroutine(AddColour(nextButton));
    }

    public void Previous()
    {
        previousButton.interactable = false;
        if (currntTopColor <= 0)
        {
            currntTopColor = topColors.Count - 1;
        }
        else
        {
            currntTopColor -= 1;
        }
        StartCoroutine(AddColour(previousButton));
    }


    IEnumerator AddColour(Button button)
    {
        var inst = Instantiate(particalSmoke, spawnParent.position, spawnParent.rotation, spawnParent);
        inst.GetComponent<ParticleSystem>().startColor = topColors[currntTopColor];
        yield return new WaitForSeconds(1f);
        bodyMat.material.color = topColors[currntTopColor];
        currentColor = topColors[currntTopColor];
        yield return new WaitForSeconds(1f);
        button.interactable = true;
        Destroy(inst);

    }

    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
