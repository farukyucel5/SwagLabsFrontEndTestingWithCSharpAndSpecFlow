Feature: Login Functionality

A short summary of the feature
 Background: Common parts
  Given go to the "https://www.saucedemo.com"


 Scenario Outline: login functionality for the correct data 
   And  enter your username "<username>"
   And enter the password "<password>"
   Then click the "loginBtn"
   Then verify the step "loggedIn"
   Examples: 
   | username                | password     | system   |
   | standard_user           | secret_sauce | swaglabs |
   | locked_out_user         | secret_sauce | swaglabs |
   | problem_user            | secret_sauce | swaglabs |
   | performance_glitch_user | secret_sauce | swaglabs |





 Scenario Outline: login functionality with the wrong data
   And  enter your username "<username>"
   And enter the password "<password>"
   Then click the "loginBtn"
   Then verify that the user is not able to log in the "<system>"
   Examples: 
   | username        | password     | system     |
   | standard_user   | 123          | swaglabs   |
   # correct username and wrong password for the standard_user
   | faruk           | secret_sauce | swaglabs   |
   # wrong username and correct password for the standard_user
   |                 | secret_sauce | swaglabs   |
   # What if the username was not passed in?
   | standard_user   |              | swaglabs   |
   # What if the password was not passed in?
   #---------------------------------------------#
   | locked_out_user | 123          | swaglabs   |
   # correct username and wrong password for the locked_out_user
   | standard        |secret_sauce  | swaglabs   |
   # wrong username and correct password for the locked_out_user
   |                 |secret_sauce  | swaglabs   |
   # What if the username was not passed in?
   |locked_out_user  |              | swaglabs   |
    # What if the password was not passed in?
   #---------------------------------------------#
   | problem_user    | 123          | swaglabs   |
   # correct username and wrong password for the problem_user 
   | standard        |secret_sauce  | swaglabs   |
   # wrong username and correct password for the problem_user 
   |                 |secret_sauce  | swaglabs   |
   # What if the username was not passed in?
   |problem_user     |              | swaglabs   |
    # What if the password was not passed in?
   #---------------------------------------------#
   | performance_glitch_user    | 123          | swaglabs   |
   # correct username and wrong password for the problem_user 
   | standard                   |secret_sauce  | swaglabs   |
   # wrong username and correct password for the problem_user 
   |                            |secret_sauce  | swaglabs   |
   # What if the username was not passed in?
   |performance_glitch_user     |              | swaglabs   |
    # What if the password was not passed in?

 



   
   


     
