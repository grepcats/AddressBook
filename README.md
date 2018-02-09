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
Form should only accept letters for name
Form should only accept 5 characters for zip (12345)

Program should recognize duplicate entries & tell user to enter a unique entry
Input: duplicate name
Output: "sorry, that person is already in the system."

Program should allow user to search for Contacts (v1 - name must be exact)
Input: contact name
Output: details for that contact or "no match found"
