# Address Book

#### _An app to store your contacts, 2/9/2018_

#### By **Kayla Ondracek**

## Description
This is a C#/ASP.NET app that can be used to store contact/address info locally as long as it is running. No database backend yet. Users may also search for, delete, and update contacts.

## Specs
Program should store a contact with name, phone number, and address
Input: name, phone number, address
Output: stored Contact

Program should display all Contacts
Input: (navigate to index page /)
Output: (view contacts)

Program should allow users to create a Contact
Input: click "Add new contact"
Output: (take user to page with contact form)

Program should take user-generated content for Contact
Input: form name, phone number, address
Output: (accept input and add to List of Contacts, return user to Index)

Program should allow users to clear all Contacts
Input: button that says "clear all"
Output: Contact list is cleared

Program should display details for a particular contact
Input: select contact name and provide ID
Output: Details view with more information about the contact

Program should allow removal of individual contacts
Input: select "delete contact"
Output: new list of contacts with deleted contact removed

Program should store the address in its own object, which should be stored in Contact
Input: street, city/state, zip
Output: address with more controlled fields

Program should be styled
Input: unstyled program
Output: styled program

Program should allow updates to objects
Input: select object and select "update"
Output: updated values for object

Form Controls:
Form should suggest format for phone number and throw error if wrong (123-456-7890)
Form should only accept letters, -, and ' for name
Form should only accept city, ST format for City/State (city, ST)
Form should only accept 5 characters for zip (12345)

Program should recognize duplicate entries & tell user to enter a unique entry
Input: duplicate name
Output: "sorry, that person is already in the system."

Program should allow user to search for Contacts (v1 - name must be exact)
Input: contact name
Output: details for that contact or "no match found"

Program should allow user more flexibilit in searching for Contacts (v2 - case insensitive, partial words accepted)
Input: coNtaCt Na
Output: Contact name

## Setup/Installation Instructions
In terminal,
* git clone https://github.com/grepcats/AddressBook to Desktop
* run "dotnet restore" in project folder
* run "dotnet build"
* run "dotnet run"
* open web browser and navigate to http://localhost:5000

Program will run as long as it is running in the terminal.

## Known Bugs
No known bugs at this time. Please report any bugs by opening a github issue.

## Support and Contact Details
If there are any issues or questions, please contact me at kayla.renee at gmail dot com or create an issue in GitHub.

## Technologies Used
C#/ASP.NET Core

## License
Copyright (c) 2018 **Kayla Ondracek**
