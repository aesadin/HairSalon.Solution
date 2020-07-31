# Eau Claire's Salon

#### _An online system for organizing salon staff and clientele_	

#### By _**Allison Sadin**_
#### Date 07/31/2020

<br>

## **DESCRIPTION**

This application will allow the user to add Stylist information as well as Client information. The user must add Clients to a specific Stylist, they cannot only add Clients.

<br>

 ## **SPECIFICATIONS**

1. **Behavior:** The user is welcomed with a splash page and given the option to view Stylists or view Clients.
* **Input Example:** "View Stylists" or "Add a new Stylist"
* **Output Example:** /Stylists or /Clients 

2. **Behavior:** When the user navigates to "View Stylists" a list of all Stylists will be displayed, if there are no Stylists the message "There are currently no Stylists listed" and given the option to "Add a Stylist".
* **Input Example:** "Add a Stylist"
* **Output Example:** /Stylists/Create

3. **Behavior:** If the user navigates to "Add a Stylist" the program will allow the user to add a new Stylist and then be directed to Stylists.
* **Input Example:** "Add new Stylist"
* **Output Example:** /Stylists

4. **Behavior:** The program will allow the user to click on a Stylist.
* **Input Example:** "Italian"
* **Output Example:** /Stylists/Details/{StylistsId}

5. **Behavior:** The program will allow the user to view all Clients.
* **Input Example:** "View Clients"
* **Output Example:** /Clients

6. **Behavior:** The program will allow the user to add a new Client to a specific Stylist.
* **Input Example:** "Add a Resturant"
* **Output Example:** /Clients/Create

7. **Behavior:** The program will allow the user to view Client details.
* **Input Example:** "Johnnys Subs"
* **Output Example:** /Clients/Details/{ClientsId}

8. **Behavior:** The program will allow the user to edit Client details.
* **Input Example:** "Edit This Client"
* **Output Example:** /Clients/Edit/{ClientsId}

9. **Behavior:** The program will allow the user to edit Stylist details.
* **Input Example:** "Edit This Stylist"
* **Output Example:** /Stylists/Edit/{StylistsId}

10. **Behavior:** The program will allow the user to delete Stylist details.
* **Input Example:** "Delete This Stylist"
* **Output Example:** /Stylists/Delete/{StylistsId}

10. **Behavior:** The program will allow the user to delete Client details.
* **Input Example:** "Delete This Client"
* **Output Example:** /Clients/Delete/{ClientsId}




<br>

## **SETUP & INSTALL**

* _This program utilizes .NET version 2.2, and is a required instal for this program to function. Ensure .NET version 2.2 is installed before progressing._

*  _Recommended browser for everything in life. [Google Chrome](https://www.google.com/chrome/)_.

*  _Github [repository](https://github.com/aesadin/Pierre_Bakery.Solution.git)_



*  **Windows/Mac Users:** If modifying for personal use, dl Git [here](https://git-scm.com/downloads/) (v2.62.2)

* Download [Visual Studio Code](https://code.visualstudio.com/) (v1.45)

* Download ZIP [here](https://github.com/aesadin/Pierre_Bakery.Solution.git) OR if you are comfortable cloning a repo, copy the link as shown below.

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone.gif "How to clone repo")

* this image shows you where to paste your copied link into VSCode

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif "Cloning from Github within VSCode")

* Once cloned, navigate to the {yourProgramName}.Tests file using $ cd {yourProgramName}.Tests and use $ dotnet restore to create bin and obj directories. Make sure to hide those files in your .gitignore.

* Once the program has been built, navigate to your root directory using $ cd .. and type in command $ dotnet run

<br>

## **PROTECTING YOUR DATA**

* Step 1: create a .gitignore file in the top level of your project directory. populate the file as shown in step 1 of the image below.

* Step 2: commit that .gitignore file (this prevents your sensitive information being shown to others). **DO NOT PROCEED TO UNTIL YOU DO THIS!**

* Step 3: ignore step 3 for this project, as it does not utilize an API Key.

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/readme-image.jpg "Set up instructions")


<br>

## **Known Bugs**

 _No Known Bugs 7/31/2020_

<br>

## **Support and contact details**

_Questions, comments and concerns can be directed to the author(s) [Allison Sadin](aesadin@gmail.com)_

<br>

## **Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Image work:** [Adobe Photoshop](https://www.adobe.com/products/photoshop.html/)_

_C#_ 

_.NET version 2.2_

_MSTest_


<br>

## **License**
![alt text][logo]

[logo]: https://img.shields.io/bower/l/bootstrap "MIT License"

Copyright (c) 2020 **_[Allison Sadin](aesadin@gmail.com)_