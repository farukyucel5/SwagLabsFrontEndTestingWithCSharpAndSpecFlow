Feature: HomePagewithProblemUser

 Background: homepage common parts
  Given go to the "https://www.saucedemo.com"
  And  enter your username "problem_user"
  And enter the password "secret_sauce"
  Then click the "loginBtn"
  Then verify the step "loggedIn"
  And just wait a second

  Scenario: remove button test
   Then click the "addToCartBtn"
   And just wait a second
   Then click the "removeBtn"
   And just wait a second
   Then click the "cart"
   And verify that the product is not available in the cart

 Scenario Outline: ordering the prices by the dropdown menu
	And select an option of sorting product by "<value>"
	Then verify the step "<value>"
	Examples: 
	| value |
	| za    |
	| lohi  |
	| hilo  |

 Scenario: open menu about button functionality
	Then click the "openMenu"
	And just wait a second
	Then click the "aboutBtn"
	Then verify the step "about"
 
 Scenario: open munu log out button functuonality
	Then click the "openMenu"
	And just wait a second
	Then click the "logOutBtn"
	And just wait a second
	Then verify the step "loggedOut"
	And just wait a second








	



	



  
   
	
  
   
