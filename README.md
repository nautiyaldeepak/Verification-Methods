# About
This C# code was developed on Viusal Studio 2017 platform. For test purpose outlook profile was used to send the otp. 
The smtp settings in this code are as for outlook. This C# program randomly generates a 6 digit code and sends it to the 
designated email.

# Before Executing The code
Enter the credentials i.e the account specifications from which the email will be sent.
Check the smtp settings. The smtp settings in the program are as per outlook.
For smtp settings check the resources section.
Your might have to add Net.Mail references. 

# Note A
The OTP which you will recieve in the email will of the format "XXX XXX". Eg: "123 456". But for verifivation you will have 
to type all the 6 digits together "XXXXXX". Eg "123456". 

# Note B (Only Gmail Users)
If you are using Gmail for sending the otp then there is 1 extra step.
You will first has reduce the security of the Gmail Account.
Check the Resources section of this Repo to reduce security OR go on the link: https://myaccount.google.com/lesssecureapps
The lessSecureAppUse Feature should be "ON".
