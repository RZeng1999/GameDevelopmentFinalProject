using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Policies : MonoBehaviour
{
    public static int sanitization = 40;
    public static int foodSupply = 35;
    public static int crimeRate = 25;
    public static Boolean policyPassed;
    public GameObject noGold;
    public GameObject alreadyPassed;


    /// <summary>
    /// The following methods all deal with the player attempting to pass all of the policies, 
    /// includes checks for if the player has already passed a policy that week and if they have 
    /// enough gold.
    /// </summary>
    

    public void taxIncreaseOne()
    {
        if(policyPassed != true)
        {
            GameManager.goldPerTurn += 100;
            GameManager.dissent += 5;
            policyPassed = true;
        } else
        {
            policyError();
        }
    }

    public void taxIncreaseTwo()
    {
        if (policyPassed != true)
        {
            GameManager.goldPerTurn += 250;
            GameManager.dissent += 15;
            policyPassed = true;
        } else
        {
            alreadyPassed.SetActive(true);
        }
    }

    public void taxIncreaseThree()
    {
        if (policyPassed != true)
        {
            GameManager.goldPerTurn += 350;
            GameManager.dissent += 25;
            policyPassed = true;
        } else
        {
            policyError();
        }
    }

    public void trainCraftsmen()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 250)
        {
            goldError();
        }
        else
        {
            GameManager.goldPerTurn += 50;
            GameManager.dissent -= 5;
            policyPassed = true;
        }
    }

    public void exportGoods()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 500)
        {
            goldError();
        }
        else
        {
            GameManager.goldPerTurn += 150;
            GameManager.dissent += 5;
            GameManager.gold -= 500;
            policyPassed = true;
        }
    }

    public void guardFundOne()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 250)
        {
            goldError();
        }
        else
        {
            crimeRate -= 4;
            GameManager.authority += 5;
            GameManager.gold -= 250;
            policyPassed = true;
        }
    }

    public void guardFundTwo()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 400)
        {
            goldError();
        }
        else
        {
            crimeRate -= 4;
            GameManager.authority += 10;
            GameManager.gold -= 400;
            policyPassed = true;
        }
    }

    public void guardFundThree()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 100000)
        {
            goldError();
        }
        else
        {
            crimeRate -= 4;
            GameManager.authority += 15;
            GameManager.gold -= 750;
            policyPassed = true;
        }
    }

    public void jailFund()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 300)
        {
            goldError();
        }
        else
        {
            crimeRate -= 4;
            GameManager.authority += 10;
            GameManager.gold -= 300;
            policyPassed = true;
        }
    }

    public void publicPunish()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 250)
        {
            goldError();
        }
        else
        {
            crimeRate -= 5;
            GameManager.authority += 10;
            GameManager.gold -= 250;
            policyPassed = true;
        }
    }

    public void jailDissent()
    {
        if (policyPassed == true)
        {
            policyError();
        } else
        {
            GameManager.authority += 20;
            policyPassed = true;
        }
    }

    public void wasteCollect()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 200)
        {
            goldError();
        }
        else
        {
            sanitization -= 7;
            GameManager.gold -= 200;
            GameManager.goldPerTurn -= 50;
            policyPassed = true;
        }
    }

    public void sanitizeWorkers()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 300)
        {
            goldError();
        }
        else
        {
            sanitization -= 10;
            GameManager.gold -= 300;
            GameManager.goldPerTurn -= 100;
            policyPassed = true;
        }
    }

    public void plumbing()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 1000)
        {
            goldError();
        }
        else
        {
            sanitization -= 15;
            GameManager.gold -= 1000;
            policyPassed = true;
        }
    }

    public void courtyards()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 600)
        {
            goldError();
        }
        else
        {
            GameManager.dissent -= 10;
            GameManager.gold -= 600;
            GameManager.goldPerTurn -= 75;
            policyPassed = true;
        }
    }

    public void gardens()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 600)
        {
            goldError();
        }
        else
        {
            GameManager.dissent -= 10;
            GameManager.gold -= 600;
            GameManager.goldPerTurn -= 75;
            policyPassed = true;
        }
    }

    public void fundArts()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 800)
        {
            goldError();
        }
        else
        {
            GameManager.dissent -= 10;
            GameManager.gold -= 800;
            policyPassed = true;
        }
    }

    public void threeCrop()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 500)
        {
            goldError();
        }
        else
        {
            foodSupply -= 10;
            GameManager.gold -= 500;
            policyPassed = true;
        }
    }

    public void farmAllotments()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 1000)
        {
            goldError();
        }
        else
        {
            foodSupply -= 10;
            GameManager.gold -= 1000;
            policyPassed = true;
        }
    }

    public void irrigation()
    {
        if (policyPassed == true)
        {
            policyError();
        }
        else if (GameManager.gold < 1200)
        {
            goldError();
        }
        else
        {
            foodSupply -= 15;
            GameManager.gold -= 1200;
            policyPassed = true;
        }
    }

    public void closeError() {
        noGold.SetActive(false);
        alreadyPassed.SetActive(false);
    }

    public void goldError()
    {
        noGold.SetActive(true);
        noGold.transform.SetAsLastSibling();
    }

    public void policyError()
    {
        alreadyPassed.SetActive(true);
        alreadyPassed.transform.SetAsLastSibling();
    }

}
