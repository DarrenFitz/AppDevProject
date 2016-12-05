# Mobile Applications Project
###### Darren Fitz
###### G00311853

## Introduction
For this Universal Windows Platform (UWP), I deceided to make a type of utility app that allowed you to make a To-Do list or schedule appointments into your calendar on your phone. This app include a login feature thatutilises a SQLite database engine, which stores the name and password of the user.

##Technologies Used
+ UWP (Universal Windows Platform)
+ SQLite database
+ Observable Collection
+ Data binding
+ Async - Await

##How I Set Up SQLite for UWP

To incorporate the SQLite database I installed the following packages using NuGet Package Manager:

    - SQLite.Net PCL
	
Then Went to Tools > Extensions and Updates

	- Ensured SQLite for Universal Windows Platfrom was installed 

Then Went Right-Click reference > Add reference > Universal Windows> Extensions
	
	- Checked [✓] - SQLite for Universal Windows Platfrom
	- Checked [✓] - c++ 2015 Runtime for Universal Windows platfrom app

    

##How to use the Application
The main login Page is where the app begins. It's where you have the option of signing in to the app if you already have an account made. If you dont have an account you can create one by imputting a Username, E-mail, and Password on the RegisterPage. When you have your account setup you Login. Login compares the login credentials with a corrisponding created acccount credentials in the SQLite databse. If they match Access is granted.

<img src="Screenshots/1.PNG" alt="home" width="200" height="400"/>
<img src="Screenshots/2.PNG" alt="home" width="200" height="400"/>

Then we navigate to a page which preset the option of a To-Do List or Appointment App. This button will direct you to the desired page. In the To-Do list you can add and delete tasks/choirs to a list, all while choosing an approproiate colour to match the chosen goal. Appointment app creates an appointment on the phone and adds it to your phone calendar for later use. CLicking the confirm button will create an appointment in your calendar.

<img src="Screenshots/5.PNG" alt="home" width="200" height="400"/>
<img src="Screenshots/3.PNG" alt="home" width="200" height="400"/>
<img src="Screenshots/4.PNG" alt="home" width="200" height="400"/>

##Difficulties with Application
For this app I couldn't get winUX imlemented. I wanted to use this to add the validation to my RegisterPage. It gave an error complaining that it couldnt find a validation control, so I left it out.

This proved troublesome because it meant that a user could enter no data and create a password/username that was empty. It really would have tied the app together more and allowed me to ensure email syntax was valid too. I had some of the code for validation left commented out in the resigration xaml page.


