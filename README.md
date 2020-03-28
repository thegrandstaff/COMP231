# COMP231
HealthRecord

## Table of Contents
* [HealthRecord](#HealthRecord)
* [Technologies](#technologies)
* [Login](#login)
* [SignUp](#sign-up)
* [PatientList](#patient-list)
* [PrescriptionMaker](#prescription-maker)
* [BookAppointment](#book-appointment)
* [MedicationList](#medication-list)

## HealthRecord
This is a college group project using WPF. It saves patient information, list of their prescription medication and books appointments.

## Technologies
Project is created with:
* Visual Studio 2019
* WPF Application (.Net Framework)

## Login
This is the login window.

## SignUp
This is the sign-up window for new patients.

The following information is needed to create the "Patient" object:
* First name
* Last name
* Email address
* Phone number
* Street address
* Password 

The application will automatically prompt you to enter the required fields using a message box. 

Regex expressions are used to validate whether or not email addresses or phone numbers are valid. For example, email addresses need to following the standard "example@emailservice.extension" in order to be accepted and all unaccepted email addresses will be followed up by a prompt. Phone numbers need to follow the typical "(Area code)-six numbers" example, but other variations are acceptable (e.g. "1-416-XXX-XXXX", "416XXXXXXX", etc...). As with email addresses, incorrect or invalid phone numbers will be followed by a prompt to change it.

Password needs to be at least 10 characters. A prompt to change it will appear when the password does not meet the condition. Confirm password input needs to match the password entered.

When all fields are correctly entered, a Patient object should be created with all the above information as properties.
