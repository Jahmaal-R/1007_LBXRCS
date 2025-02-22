using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jahmaal Rivers
//Student Number: 101593815

public class Test1 : MonoBehaviour
{
    private float weeklyPay = 200;
    private float grossSalesLow = 0.09f;
    private float grossSalesHigh = 0.15f;

    public float merchPrice = 0;

    public float weeklySaleLow = 0;
    public float weeklySaleHigh = 0;
    
    public float totalProfit;


    void Start()
    {
        MoneyCalculations();
    }

    void MoneyCalculations()
    {
        if (merchPrice <= 2000)
        {
            //Calculate price
            totalProfit = merchPrice * grossSalesLow;

            //Add weekly pay
            totalProfit += weeklyPay;
            
            //Display on console
            Debug.Log("Your weekly pay is " + totalProfit + " !");
        }    
        else if (merchPrice > 2000)
        {
            //Separate prices from higher and lower interest sales
            weeklySaleLow += 2000;
            merchPrice -= 2000;
            weeklySaleHigh = merchPrice;

            //Caluclate interest
            weeklySaleLow = weeklySaleLow * grossSalesLow;
            weeklySaleHigh = weeklySaleHigh * grossSalesHigh;

            //Calculate price
            totalProfit += weeklyPay + weeklySaleLow + weeklySaleHigh;

            //Display on console
            Debug.Log("Your weekly pay is " + totalProfit + " !");
        }

    }
}
