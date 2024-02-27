Feature: ChangePassword
         User Wants to change Password with valid data, invalid data and checks for max charcter length 
  
Background: 
Given User is logged in to the mars portal 
And User navigates to the Change password page 

Scenario Outline: Add Change Password with valid data
 When User enters valid change password details "<ChangePasswordwithValidDatafilePath>"
 Then user can successfully change the current password 
 Examples:
      | ChangePasswordwithValidDatafilePath     |
      | A:\Industry Connect\AdvancedSprint2\AdvancedTaskSpecflow\AdvancedTaskSpecflow\JsonTestData\ChangePasswordwithValidData.json|

Scenario Outline:Check for minimum length required 
When User enters less than 6 characters in the change password details "<CheckPasswordMinimumLengthFilePath>"
Then user gets an error message 
Examples: 
| CheckPasswordMinimumLengthFilePath |
|  A:\Industry Connect\AdvancedSprint2\AdvancedTaskSpecflow\AdvancedTaskSpecflow\JsonTestData\CheckPasswordMinimumLength.json |

