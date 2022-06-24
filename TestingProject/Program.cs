﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;



namespace seleniumTest
{
    class working
    {
        
        static void Main(string[] args)
        {
            //change this var name
            var constructor = new generalHandlers();


            constructor.browserStart("https://brokerage.qc.suntecktts.com/agents/login");
            constructor.loginPage("-", "-");
            constructor.dropdownHandler("/html/body/header/nav/div/div/div[3]/ul/li[3]", "/html/body/header/nav/div/div/div[3]/ul/li[3]/ul/li[2]/a"); //navigation to the CreateTL form
            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[2]/div[2]/div/div[1]/div[1]/div/div/span/span[1]/span/span[2]", "/html/body/span[2]/span/span[2]/ul/li[2]");


            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[1]/div/span/span[1]/span/span[1]", "/html/body/span[2]/span/span[2]/ul/li"); //Fill the information manually using the textboxHandler - this is a "hacky" solution
            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[1]/div/span/span[1]/span/span[1]", "/html/body/span[2]/span/span[2]/ul/li"); //consignnee
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[13]/div[1]/div/input", "6/24/2022"); //this should ideally use a function of Time
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[13]/div[1]/div/input", "6/24/2022"); //this too

            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[2]/div/input", "1"); //quantity, should be random, from 1-10000
            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[3]/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[1]"); //UoM, should be randomized for what is available in the dropdown
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[4]/div/input", "1"); //Description, should fill with random garbage
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[5]/div/input", "1"); //Weight, should fill with a random value 1-150,000

            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[5]/div[2]/div/div[1]/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[1]"); //Equipment Type


            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[2]/div/select", "/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[2]/div/select/option[2]"); //Method


            constructor.buttonHandler("/html/body/div[2]/div[2]/form/div[9]/div/div/div[3]/button");

        }

    }
}