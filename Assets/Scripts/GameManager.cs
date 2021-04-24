using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static int week = 0;
    public static int population = 100000;
    public static int dead;
    public static int gold = 1000;
    public static int goldPerTurn = 100;
    public static int dissent = 50;
    public static int authority = 50;
    public Text weekCount;
    public Text popCount;
    public Text deadCount;
    public Text goldCount;
    public Text dissentCount;
    public Text authorityCount;
    public Text goldPerTurnCount;
    public GameObject revEnd;
    public GameObject deadEnd;
    public GameObject livedEnd;
    public GameObject nextButton;
    public GameObject policyButton;


    // Start is called before the first frame update
    void Start()
    {
        loadValues();
    }

    // Update is called once per frame
    void Update()
    {
        weekCount.text = week.ToString();
        popCount.text = population.ToString();
        deadCount.text = dead.ToString();
        goldCount.text = gold.ToString();
        goldPerTurnCount.text = goldPerTurn.ToString();
        dissentCount.text = dissent.ToString();
        authorityCount.text = authority.ToString();
    }

    // Saves values when scene is changed
    private void OnDestroy()
    {
        saveValues();
    }

    //Method to save values on screen
    private void saveValues()
    {
        PlayerPrefs.SetInt("week", week);
        PlayerPrefs.SetInt("population", population);
        PlayerPrefs.SetInt("dead", dead);
        PlayerPrefs.SetInt("gold", gold);
        PlayerPrefs.SetInt("goldPerTurn", goldPerTurn);
    }

    //Method to load values on screen
    private void loadValues()
    {
        PlayerPrefs.GetInt("week", week);
        PlayerPrefs.GetInt("population", population);
        PlayerPrefs.GetInt("dead", dead);
        PlayerPrefs.GetInt("gold", gold);
        PlayerPrefs.GetInt("goldPerTurn", goldPerTurn);
    }

    // Button for next week
    public void NextWeek()
    {
        week++;
        int newDead = Mathf.RoundToInt(((float)population * calculateDeathRate()));
        population -= newDead;
        dead += newDead;
        gold += goldPerTurn;
        Policies.policyPassed = false;

        saveValues();

        if (dead > 50000)
        {
            deathEnd();
        } else if (dissent >= authority+20)
        {
            revolutionEnd();
        } else if (week >= 50)
        {
            yearEnd();
        }
    }

    /// <summary>
    /// Calculates the percentage of people 
    /// </summary>
    /// <returns></returns>
    public static float calculateDeathRate()
    {
        return (float)(Policies.sanitization + Policies.foodSupply + Policies.crimeRate) * Random.Range(.00025f, .00035f);
    }

    public void deathEnd()
    {
        deadEnd.SetActive(true);
        nextButton.SetActive(false);
        policyButton.SetActive(false);
    }

    public void revolutionEnd()
    {
        revEnd.SetActive(true);
        nextButton.SetActive(false);
        policyButton.SetActive(false);
    }

    public void yearEnd()
    {
        livedEnd.SetActive(true);
        nextButton.SetActive(false);
        policyButton.SetActive(false);
    }

    public void Reset()
    {
        week = 0;
        population = 100000;
        dead = 0;
        gold = 1000;
        goldPerTurn = 100;
        dissent = 50;
        authority = 50;
        Policies.policyPassed = false;
        Policies.sanitization = 40;
        Policies.foodSupply = 35;
        Policies.crimeRate = 25;
        SceneManager.LoadScene(1);
    }
}
