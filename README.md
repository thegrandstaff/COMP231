# COMP231
HealthRecord

## Table of Contents
* [HealthRecord](#HealthRecord)
* [Technologies](#technologies)
* [Login](#login)
* [SignUp](#signup)
* [PatientList](#patientlist)
* [PrescriptionMaker](#prescriptionmaker)
* [BookAppointment](#bookappointment)
* [MedicationList](#medicationlist)

## HealthRecord
This is a college group project using WPF. It saves patient information, list of their prescription medication and books appointments.

## Technologies
Project is created with:
* Visual Studio 2019
* WPF Application (.Net Framework)

## Login - Done By Jasah
This is the login window.
The user will be able to login. If not sign up will be shown.Fixed Bugs in the Overall Document.

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

## PatientList
This is the patient list window. It uses a datagrid to dynamically display all the patients when the repository gets updated.

While each Patient object has a first name, last name, etc..., only the first name, last name, phone number and address will be displayed for each patient on the datagrid. 

Seed data is created for testing purposes to show that new Patient objects are being created and are then added to the ListOfPatients list. This new list will be used as the ItemSource for the datagrid.

Since it is a datagrid, patients can be organized on the datagrid by their property (e.g. first name or last name).

## PrescriptionMaker - Done By Jasah
This is the window where prescriptions can be added to patients. An ObservableCollection (for patients) is used to allow different data types to be used for each object (e.g. int for dosage amounts, Date for expiration dates, etc...).

## MedicationList
This is a window to display medication for a specific patient. Clicking patients on the datagrid can be used to open a new window. A unique ID for each patient can be used as a primary key to relate the data on the ListOfPatients with the information on the MedicationList or, for now, their phone numbers or email address.

## BookAppointment
This is the window where a patient can book an appointment for a specific time slot that is available for the day. There will be an option to select a preferred doctor if they're available for a specified day.
