# Capstone Project
This project presents the development of automation testing of the Demo Web Shop browser using predefined test cases.  

![image](https://github.com/KarenvanWyk/CapstoneProject/assets/127295835/5e82f5c5-9342-4a5f-968a-e2ca1bf07c44)


## 1. Index
- [Platform, language and tools](#platform-language-and-tools)
- [Dependencies](#dependencies)
- [Development](#development)
- [Test Cases](#test-cases)
  - [Navigate to the Demo Web Shop Website](#navigate-to-the-demo-web-shop-website)
  - [Login](#login)
  - [Select category](#select-category)
  - [Change display view](#change-display-view)
  - [Add product to the cart](#add-product-to-the-cart)
  - [Proceed to Checkout](#proceed-to-checkout)
  - [Return to home page & logout](#return-to-home-page-and-logout)
- [Reporting](#reporting)
- [Improvements](#improvements)



## 2. Platform, language and tools 


    2.1  Visual Studio: an integrated development environment developed by Microsoft. It is used to develop computer programs including websites, web apps, web services and mobile apps
    2.2  C#: a general-purpose high-level programming language supporting multiple paradigms.
    2.3  Selenium:  a suite of tools that are widely used in the testing community when it comes to cross browser testing
    2.4  Sikuli: open-source GUI based test automation tool
    2.5  Extent Reports: A customizable logger-style reporting OSS API. ExtentReports has 12 repositories available


## 3. Dependencies 

    3.1  Selenium.WebDriver
    3.2  Selenium.Support
    3.3  ExtentReports
    3.4  SikuliSharp
    3.5  InputSimulator


## 4. Development 


    4.1  Configuration: Create the configuration file to store login details which will be used across all test cases
    4.2  OneTimeSetup: this function is called once at the start of each test case to create the session and driver 
    4.3  Test Cases: execute seven (7) predefined test cases.  Each test case run on it's own, the user can select to run LogOut in order to run all test cases consequetively
    4.4  OneTimeTearDown : this function is called once at the end of each test case to close the session and driver


## 5. Test Cases

Below is a short description of each test case with execution conditions:

    5.1  Navigate to the Demo Web Shop Website
         Using Selenium, open Chrome Browser and navigate to the “https://demowebshop.tricentis.com/" webpage,verify Page title

    5.2  Login
         Using Selenium, login from the page header and complete a number of verification steps

    5.3  Select category
         Using Selenium, select Jewelry under the categories section and verify that the url is correct

    5.4  Change display view
         Using Selenium, select the List option under the View as dropdown

    5.5  Add product to the cart
         Using Sikuli, select a specific Product, Material option, determine Length, Pendant option and increase the Quantity.  Add to the cart and navigate to the Shopping Cart link.

    5.6  Proceed to Checkout
         Using Sikuli, select Country from the dropdown, capture ZipCode in the source field,, select the T&C’s checkbox and select the Checkout button.  Using Selenium verify the page header

    5.7  Return to home page & logout
         Using Selenium, select the Demo WorkShop logo and select to Logout.  

## 6. Reporting
Extent Reports. a customizable HTML report, which  integrates into Selenium WebDriver using the NUnit framework was used to generate test reports.

![image](https://github.com/KarenvanWyk/CapstoneProject/assets/127295835/ee0dc786-a7ff-463c-a8e1-571e05085651)

## 7. Improvements

    7.1  Negative test cases can be added to the project
    7.2  Boolean exception handling is currently used with a descriptive message where verification was required (see examples below).  Improved exception handling can be added to the project in order to build a more robust test program
         
         
![image](https://github.com/KarenvanWyk/CapstoneProject/assets/127295835/67fb125a-6dc8-49b9-87c7-a0cf034625cb)

![image](https://github.com/KarenvanWyk/CapstoneProject/assets/127295835/0d42c783-5c35-406c-a647-cccaeb53e988)



