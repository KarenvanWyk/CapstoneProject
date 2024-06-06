# Capstone Project
This project presents the development of automation testing of the Demo Web Shop browser using predefined test cases.  

<a href="https://demowebshop.tricentis.com/">
    <img src="img/readme/TestingWebsite.png" align="center"/>
</a>


## Index
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



## Platform, language and tools 


Visual Studio: an integrated development environment developed by Microsoft. It is used to develop computer programs including websites, web apps, web services and mobile apps
C#: a general-purpose high-level programming language supporting multiple paradigms.
Selenium:  a suite of tools that are widely used in the testing community when it comes to cross browser testing
Sikuli: open-source GUI based test automation tool


## Dependencies 


Selenium.WebDriver
Selenium.Support
ExtentReports
SikuliSharp
InputSimulator


## Development 


Configuration: Create the configuration file to store login details which will be used across all test cases
OneTimeSetup: this function is called once at the start of each test case to create the session and driver 
Test Cases: execute seven (7) predefined test cases
OneTimeTearDown : this function is called once at the end of each test case to close the session and driver


## Test Cases

Below is a short description of each test case with execution conditions:

### Navigate to the Demo Web Shop Website
Using Selenium, open Chrome Browser and navigate to the “https://demowebshop.tricentis.com/" webpage,verify Page title

### Login
Using Selenium, login from the page header and complete a number of verification steps

### Select category
Using Selenium, select Jewelry under the categories section and verify that the url is correct

### Change display view
Using Selenium, select the List option under the View as dropdown

### Add product to the cart
Using Sikuli, select a specific Product, Material option, determine Length, Pendant option and increase the Quantity.  Add to the cart and navigate to the Shopping Cart link.

### Proceed to Checkout
Using Sikuli, select Country from the dropdown, capture ZipCode in the source field,, select the T&C’s checkbox and select the Checkout button.  Using Selenium verify the page header

### Return to home page & logout
Using Selenium, select the Demo WorkShop logo and select to Logout.  

## Reporting
Extent Reports. a customizable HTML report, which  integrates into Selenium WebDriver using the NUnit framework was used to generate test reports.





